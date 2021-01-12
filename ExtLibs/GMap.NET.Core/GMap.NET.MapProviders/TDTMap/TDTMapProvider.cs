namespace GMap.NET.MapProviders
{
    using GMap.NET;
    using GMap.NET.Projections;
    using System;

    public abstract class TDTMapProviderBase : GMapProvider
    {
        private GMapProvider[] overlays;

        public TDTMapProviderBase()
        {
            this.MaxZoom = null;
            base.RefererUrl = "https://map.tianditu.gov.cn/";
            base.Copyright = string.Format("GS({0})1719号 - 甲测资字1100471", DateTime.Today.Year);
        }

        public override GMapProvider[] Overlays
        {
            get
            {
                if (this.overlays == null)
                {
                    this.overlays = new GMapProvider[] { this };
                }
                return this.overlays;
            }
        }

        public override PureProjection Projection
        {
            get
            {
                return MercatorProjectionGCJ.Instance;
            }
        }
    }

    public class TDTMapProvider : TDTMapProviderBase
    {
        private readonly Guid id = new Guid("EF3DD303-3F74-4938-BF40-232D0595EE8A");
        public static readonly TDTMapProvider Instance = new TDTMapProvider();
        private readonly string name = GMap.NET.Core.Resources.Strings.TDTMap;
        private static readonly string UrlFormat = "https://t6.tianditu.gov.cn/DataServer?T=img_w&x={0}&y={1}&l={2}&tk=ef6151d9f0386f3b2a2fdf1d58fe9b32";

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

