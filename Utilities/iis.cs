using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.DirectoryServices;  //获取目录实体类
using Microsoft.Web.Administration; //ServerManger类所属命名空间using IISOle;                      //IIS管理添加mime类型
using System.Security.AccessControl; //设置文件安全权限类所属命名空间
using System.IO;                    //文件路径类所属命名空间
using System.ServiceProcess;        //上一节中所用的系统服务对象所属命名空间


namespace MissionPlanner.Utilities
{
    //站点身份验证模式
    public enum autherRight { asp_net模拟, Form身份验证, Windows身份验证, 基本身份验证, 匿名身份验证, 摘要式身份验证 };
    /// <summary>
    /// 站点类
    /// </summary>
    public class newWebSiteInfo
    {
        //站点设置参数
        public string hostIp { get; set; }  //主机ip
        public string porNum { get; set; }  //端口号
        public string hostName { get; set; } //主机名
        public string webName{ get; set; }  //网站名
        public string appName { get; set; } //应用程序池
        public string webPath { get; set; } //物理路径
        public string visualPath { get; set; }//虚拟目录
        public Dictionary<string, string> newMimeType { get; set; }//需要新添加mime类型
        public autherRight autherRight { get; set; }//身份验证模式
        public string defoultPage { get; set; }//默认文档

        //public newWebSiteInfo(string hostip, string portnum, string hostname, string webname, string appName, string webpath, string visualPath, Dictionary<string, string> newMimeType, autherRight autherRight, string defoultPage)
        //{
        //    this.hostIp = hostip;
        //    this.porNum = portnum;
        //    this.hostName = hostname;
        //    this.webName = webname;
        //    this.appName = appName;
        //    this.webPath = webpath;
        //    this.visualPath = visualPath;
        //    this.newMimeType = newMimeType;
        //    this.autherRight = autherRight;
        //    this.defoultPage = defoultPage;
        //}
        /// <summary>
        /// 返回站点绑定信息
        /// </summary>
        /// <returns></returns>
        public string bindString()
        {
            return String.IsNullOrEmpty(hostName) ? String.Format("http://{0}:{1}", hostIp, porNum) : String.Format("http://{0}:{1}", hostName, porNum);
        }
    }
    //托管模式
    public enum modelType { 集成, 经典 };
    //net版本
    public enum netVersion { v2_0, v4_0 };
    /// <summary>
    /// IIS操作类
    /// </summary>
    public class myIIS
    {
        /// <summary>
        /// IIS版本属性
        /// </summary>
        public String IISVersion
        {

            get { return IISVersion; }

            set
            {
                DirectoryEntry IISService = new DirectoryEntry("IIS://localhost/W3SVC/INFO");
                IISVersion = "v" + IISService.Properties["MajorIISVersionNumber"].Value.ToString();
            }

        }

        /// <summary>
        /// 检测客户端或服务器是否安装IIS服务
        /// </summary>
        /// <returns>true OR false</returns>
        public Boolean checkIIS()
        {
            Boolean retMsg = false;
            try
            {
                DirectoryEntry IISService = new DirectoryEntry("IIS://localhost/W3SVC");
                if (IISService.GetType().ToString().Equals("DirectoryEntry"))
                {
                    if (checkServiceIsRunning("IIS Admin Service"))
                        retMsg = true;
                }
            }
            catch (Exception e)
            {

            }
            return retMsg;
        }

        /// <summary>
        /// 检测服务是否开启
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public Boolean checkServiceIsRunning(string serviceName)
        {
            ServiceController[] allServices = System.ServiceProcess.ServiceController.GetServices();
            Boolean runing = false;
            foreach (ServiceController sc in allServices)
            {
                if (sc.DisplayName.Trim() == serviceName.Trim())
                {
                    if (sc.Status.ToString() == "Running")
                    {
                        runing = true;
                    }
                }
            }
            return runing;
        }
        /// <summary>
        /// 获取本机IIS版本
        /// </summary>
        /// <returns></returns>
        public String getIISVersion()
        {
            String retStr = "";
            if (checkIIS())
            {
                DirectoryEntry IISService = new DirectoryEntry("IIS://localhost/W3SVC/INFO");
                retStr = "v" + IISService.Properties["MajorIISVersionNumber"].Value.ToString();
            }
            return retStr;
        }

        /// <summary>
        /// 判断程序池是否存在
        /// </summary>
        /// <param name="AppPoolName">程序池名称</param>
        /// <returns>true存在 false不存在</returns>
        private bool isAppPoolExist(string AppPoolName)
        {
            bool result = false;
            DirectoryEntry appPools = new DirectoryEntry("IIS://localhost/W3SVC/AppPools");
            foreach (DirectoryEntry appPool in appPools.Children)
            {
                if (appPool.Name.Equals(AppPoolName))
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// 创建应用程序池
        /// </summary>
        /// <param name="appName">自定义引用程序池名</param>
        /// <param name="type">托管类型</param>
        /// <param name="netV">.net版本</param>
        /// <returns></returns>
        public DirectoryEntry creatAppPool(string appName, modelType type, netVersion netV)
        {

            if (!isAppPoolExist(appName))
            {
                DirectoryEntry newpool;
                DirectoryEntry appPools = new DirectoryEntry("IIS://localhost/W3SVC/AppPools");
                newpool = appPools.Children.Add(appName, "IIsApplicationPool");
                //修改应用程序池配置
                setModalAndNetVersionOfappPool(appName, type, netV);
                newpool.CommitChanges();
                return newpool;
            }
            else return null;

        }

        /// <summary>
        /// 删除指定程序池
        /// </summary>
        /// <param name="AppPoolName">程序池名称</param>
        /// <returns>true删除成功 false删除失败</returns>
        private bool deleteAppPool(string AppPoolName)
        {
            bool result = false;
            if (isAppPoolExist(AppPoolName)) return result;
            DirectoryEntry appPools = new DirectoryEntry("IIS://localhost/W3SVC/AppPools");
            foreach (DirectoryEntry appPool in appPools.Children)
            {
                if (appPool.Name.Equals(AppPoolName))
                {
                    try
                    {
                        appPool.DeleteTree();
                        result = true;
                    }
                    catch
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 设置应用程序池的托管模式和.net版本
        /// </summary>
        /// <param name="appPoolName"></param>
        /// <param name="modelType"></param>
        /// <param name="netVersion"></param>
        public void setModalAndNetVersionOfappPool(string appPoolName, modelType mt, netVersion nv)
        {
            if (String.IsNullOrEmpty(appPoolName)) return;
            if (isAppPoolExist(appPoolName)) return;
            if (nv == null) return;
            if (mt == null) return;
            ServerManager sm = new ServerManager();
            if (nv == netVersion.v2_0)
            {
                sm.ApplicationPools[appPoolName].ManagedRuntimeVersion = "v2.0";
            }
            else if (nv == netVersion.v4_0)
            {

                sm.ApplicationPools[appPoolName].ManagedRuntimeVersion = "v4.0";
            }

            if (mt == modelType.集成)
            {
                sm.ApplicationPools[appPoolName].ManagedPipelineMode = ManagedPipelineMode.Integrated;
            }
            else if (mt == modelType.经典)
            {
                sm.ApplicationPools[appPoolName].ManagedPipelineMode = ManagedPipelineMode.Classic; //托管模式Integrated为集成 Classic为经典
            }
            sm.CommitChanges();

        }

        /// <summary>
        ///检测网站名是否可用
        /// </summary>
        /// <param name="siteInfo"></param>
        /// <returns>true 可用，false 不可用过</returns>
        public bool checkWebNameIsAvailble(string webComment)
        {
            //检测网站名是否可用
            bool isAvalable = true;
            DirectoryEntry serviceEntry = new DirectoryEntry("IIS://localhost/W3SVC");
            foreach (DirectoryEntry entry in serviceEntry.Children)
            {
                if (entry.SchemaClassName == "IIsWebServer")
                {
                    string webName = entry.Properties["ServerComment"].Value.ToString();

                    if (webName == webComment)
                    {
                        isAvalable = false;
                        break;
                    }
                }
            }
            return isAvalable;
        }

        /// <summary>
        /// 检测端口号是否已被占用
        /// 注意：端口号输入有限制，在调用该方法前，需要做端口号合理性校验
        /// </summary>
        /// <param name="portNum"></param>
        /// <returns></returns>
        public bool checkPortIsVailble(string portNum)
        {
            bool isVailble = true;
            DirectoryEntry serviceEntry = new DirectoryEntry("IIS://localhost/W3SVC");
            foreach (DirectoryEntry entry in serviceEntry.Children)
            {
                if (entry.SchemaClassName == "IIsWebServer")
                {
                    if (entry.Properties["ServerBindings"].Value != null)
                    {
                        string Binding = entry.Properties["ServerBindings"].Value.ToString().Trim();
                        string[] Info = Binding.Split(':');
                        if (Info[1].Trim() == portNum)
                        {
                            isVailble = false;
                            break;
                        }
                    }
                }

            }
            return isVailble;
        }

        /// <summary>
        /// 创建网站
        /// </summary>
        /// <param name="siteInfo"></param>
        public DirectoryEntry creatNewWeb(newWebSiteInfo siteInfo, modelType type, netVersion netV)
        {

            DirectoryEntry Services = new DirectoryEntry("IIS://localhost/W3SVC");
            int webID = 0;
            foreach (DirectoryEntry server in Services.Children)
            {
                if (server.SchemaClassName == "IIsWebServer")
                {
                    if (Convert.ToInt32(server.Name) > webID)
                    {
                        webID = Convert.ToInt32(server.Name);
                    }
                }
            }
            webID++;

            //创建站点
            DirectoryEntry mySitServer = Services.Children.Add(webID.ToString(), "IIsWebServer");
            mySitServer.Properties["ServerComment"].Clear();
            mySitServer.Properties["ServerComment"].Add(siteInfo.webName);
            mySitServer.Properties["Serverbindings"].Clear();
            mySitServer.Properties["Serverbindings"].Add(":" + siteInfo.porNum + ":");
            mySitServer.Properties["Path"].Clear();//注意该path为站点的路径,新增站点时，两者目录一致
            mySitServer.Properties["path"].Add(siteInfo.webPath);
            mySitServer.Properties["DefaultDoc"].Add(siteInfo.defoultPage);//设置默认文档

            //创建虚拟目录
            DirectoryEntry root = mySitServer.Children.Add("Root", "IIsWebVirtualDir");
            root.Properties["path"].Clear();//该路劲属性是站点下虚拟路径的路径，类似于站点的子路径
            root.Properties["path"].Add(siteInfo.visualPath);


            if (string.IsNullOrEmpty(siteInfo.appName))
            {
                root.Invoke("appCreate", 0);
            }
            else
            {

                //创建引用程序池
                string appPoolName = siteInfo.appName;
                if (!isAppPoolExist(appPoolName))
                {
                    DirectoryEntry newpool;
                    DirectoryEntry appPools = new DirectoryEntry("IIS://localhost/W3SVC/AppPools");
                    newpool = appPools.Children.Add(appPoolName, "IIsApplicationPool");
                    newpool.CommitChanges();

                }
                //修改应用程序池配置
                setModalAndNetVersionOfappPool(appPoolName, type, netV);
                root.Invoke("appCreate3", 0, appPoolName, true);
            }

            root.Properties["AppFriendlyName"].Clear();
            root.Properties["AppIsolated"].Clear();
            root.Properties["AccessFlags"].Clear();
            root.Properties["FrontPageWeb"].Clear();
            root.Properties["AppFriendlyName"].Add(root.Name);
            root.Properties["AppIsolated"].Add(2);
            root.Properties["AccessFlags"].Add(513);
            root.Properties["FrontPageWeb"].Add(1);

            root.CommitChanges();
            mySitServer.CommitChanges();

            return mySitServer;

        }
        /// <summary>
        /// 设置站点新增自定义mime类型,一次添加一个类型
        /// </summary>
        /// <param name="siteInfo"></param>
        /// <param name="mysiteServer"></param>
        public void addMIMEtype(newWebSiteInfo siteInfo, DirectoryEntry mysiteServer)
        {
            //需要添加新的mime类型
            if (siteInfo.newMimeType.Count > 0)
            {
                IISOle.MimeMapClass NewMime = new IISOle.MimeMapClass();
                NewMime.Extension = siteInfo.newMimeType.Keys.ToString(); NewMime.MimeType = siteInfo.newMimeType.Values.ToString();
                IISOle.MimeMapClass TwoMime = new IISOle.MimeMapClass();
                mysiteServer.Properties["MimeMap"].Add(NewMime);
                mysiteServer.CommitChanges();
            }

        }

        /// <summary>
        /// 设置文件夹权限 处理给EVERONE赋予所有权限
        /// </summary>
        /// <param name="FileAdd">文件夹路径</param>
        public void SetFileRole(newWebSiteInfo siteInfo)
        {
            DirectoryInfo dir_info = new DirectoryInfo(siteInfo.webPath);
            DirectorySecurity dir_security = new DirectorySecurity();
            dir_security.AddAccessRule(new FileSystemAccessRule("Everyone ", FileSystemRights.WriteData, AccessControlType.Allow));
            dir_info.SetAccessControl(dir_security);
        }

        /// <summary>
        /// 删除网站
        /// </summary>
        /// <param name="webName"></param>
        public void deletWeb(string webName)
        {
            DirectoryEntry Services = new DirectoryEntry("IIS://localhost/W3SVC");
            foreach (DirectoryEntry server in Services.Children)
            {
                if (server.SchemaClassName == "IIsWebServer")
                {
                    if (server.Properties["ServerComment"].Value == webName || server.Name == webName)
                    {
                        server.DeleteTree();
                        break;
                    }
                }
            }

            Services.CommitChanges();
        }
    }
}