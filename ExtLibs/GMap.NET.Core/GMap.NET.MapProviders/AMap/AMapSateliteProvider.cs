namespace GMap.NET.MapProviders
{
    using GMap.NET;
    using System;

    public class AMapSateliteProvider : AMapProviderBase
    {
        private readonly Guid id = new Guid("ae3c1ec5-70ff-41c3-a022-a48a662b2f9a");
        public static readonly AMapSateliteProvider Instance = new AMapSateliteProvider();
        private readonly string name = Core.Resources.Strings.AMapSatellite;
        private static readonly string UrlFormat = "http://webst04.is.autonavi.com/appmaptile?x={0}&y={1}&z={2}&lang=zh_cn&size=1&scale=1&style=6&key=f0adb61d94ae8c1be05535cb1c64462f";

        public override PureImage GetTileImage(GPoint pos, int zoom)
        {
            string url = this.MakeTileImageUrl(pos, zoom, GMapProvider.LanguageStr);
            return base.GetTileImageUsingHttp(url);
        }

        private string MakeTileImageUrl(GPoint pos, int zoom, string language)
        {
            string str = string.Format(UrlFormat, pos.X, pos.Y, zoom);
            Console.WriteLine("url:" + str);
            return str;
        }

        public override Guid Id
        {
            get
            {
                return this.id;
            }
        }

        public override string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}

