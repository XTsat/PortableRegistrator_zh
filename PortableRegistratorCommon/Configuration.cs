using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableRegistratorCommon
{
    public class Configuration
    {
        private const string _configFile = "PortableRegistrator.conf";
        public string ConfigFile { get { return _configFile; } }

        // STATICS
        internal static Configuration CreateDefault()
        {
            var config = new Configuration();

            // Defaults
            // ----------------
            // Contributors:
            //   - Holgi (Deskmodder: https://www.deskmodder.de/phpBB3/viewtopic.php?t=27857)
            //   - psorincatalin

            var mediaplayer = new AppType("视频播放器")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                    ".3g2", ".3gp", ".3gp2", ".3gpp", ".amv", ".asf", ".asx", ".avi", ".bdmv", ".dav",
                    ".divx", ".drc", ".dv", ".evo", ".f4a", ".f4b", ".f4p", ".f4v", ".flv", ".gifv",
                    ".hdmov", ".ifo", ".m1v", ".m2p", ".m2t", ".m2ts", ".m2v", ".m3u", ".m3u8", ".m4p",
                    ".m4v", ".mk3d", ".mkv", ".mng", ".mov", ".mp2", ".mp2v", ".mp4", ".mp4v", ".mpcpl",
                    ".mpe", ".mpeg", ".mpg", ".mpls", ".mpv", ".mpv2", ".mpv4", ".mts", ".mxf", ".nsv",
                    ".ogm", ".ogv", ".pva", ".qt", ".rec", ".rm", ".rmvb", ".roq", ".ssif", ".svi",
                    ".tp", ".trp", ".ts", ".viv", ".vob", ".webm", ".wm", ".wmp", ".wmv", ".yuv", },
            };
            config.AppTypes.Add(mediaplayer);

            var browser = new AppType("浏览器")
            {
                //PropertiesParameter = "-preferences",
                OpenParameters = "-url \"%1\"",
                FileAssociations = new List<string>() { ".htm", ".html", ".shtml", ".xht", ".xhtml", },
                URLAssociations = new List<string>() { "http", "https", "ftp", }
            };
            config.AppTypes.Add(browser);

            var mail = new AppType("邮件管理")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".xpi", ".eml", ".msg", ".ics", ".mbox" },
                URLAssociations = new List<string>() { "mailto", }
            };
            config.AppTypes.Add(mail);

            var vlcPlayer = new AppType("VLC-Player")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                    ".3ga",".669",".a52",".aac",".ac3",".adt",".adts",".aif",".aifc",".aiff",".au",".amr",".aob",
                    ".ape",".caf",".cda",".dts",".flac",".it",".m4a",".m4p",".mid",".mka",".mlp",".mod",".mp1",
                    ".mp2",".mp3",".mpc",".mpga",".oga",".oma",".opus",".qcp",".ra",".rmi",".snd",".s3m",".spx",
                    ".tta",".voc",".vqf",".w64",".wav",".wma",".wv",".xa",".xm",".3g2",".3gp",".3gp2",".3gpp",
                    ".amv",".asf",".avi",".bik",".divx",".drc",".dv",".f4v",".flv",".gvi",".gxf",".m1v",".m2t",
                    ".m2v",".m2ts",".m4v",".mkv",".mov",".mp2v",".mp4",".mp4v",".mpa",".mpe",".mpeg",".mpeg1",
                    ".mpeg2",".mpeg4",".mpg",".mpv2",".mts",".mtv",".mxf",".nsv",".nuv",".ogg",".ogm",".ogx",
                    ".ogv",".rec",".rm",".rmvb",".rpl",".thp",".tod",".ts",".tts",".vob",".vro",".webm",".wmv",
                    ".xesc",".asx",".b4s",".cue",".ifo",".m3u",".m3u8",".pls",".ram",".sdp",".vlc",".wvx",".xspf"}
            };
            config.AppTypes.Add(vlcPlayer);

            var excel = new AppType("Office - Excel")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".ods", ".xltm", ".xltx", ".xlt", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(excel);

            var word = new AppType("Office - Word")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".doc", ".docx", ".dot", ".dotx", ".dotm", ".odt", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(word);

            var powerpoint = new AppType("Office - Powerpoint")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".odp", ".otp", ".pot", ".potm", ".potx", ".pps", ".ppsx", ".ppt", ".pptm", ".pptx", ".odp", ".otp", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(powerpoint);

            var imageViewer = new AppType("图片预览")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".jpg", ".gif", ".bmp", ".png", ".ico", ".jpeg", ".tif", ".tiff", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(imageViewer);

            var imageViewerpp = new AppType("图片预览-高级")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                ".jpg",".gif",".bmp",".png",".ico",".jpeg",".tif",".tiff",".3fr",
                ".acr",".ani",".arw",".avif",".b3d",".cam",".cdr",".cgm",".cin",
                ".clp",".cmx",".cr2",".cr3",".crw",".cur",".dcm",".dcr",".dcx",
                ".dds",".dib",".djvu",".dng",".dpx",".dwg",".dxf",".ecw",".emf",
                ".erf",".exr",".fits",".flif",".fpx",".g3",".hdp",".heic",".icl",
                ".ics",".ids",".iff",".img",".iw44",".j2k",".jfif",".jls",".jng",
                ".jp2",".jpc",".jpe",".jpf",".jpm",".jxl",".jxr",".lbm",".mng",
                ".mos",".mpo",".mrw",".nef",".nrw",".orf",".pbm",".pcd",".pcx",
                ".pdn",".pef",".pgm",".plt",".ppm",".psb",".psd",".psp",".qoi",
                ".raf",".ras",".raw",".rgb",".rle",".rw2",".rwl",".sff",".sfw",
                ".sgi",".sid",".srf",".srw",".sun",".svg",".tga",".wad",".wbc",
                ".wbmp",".wbz",".wdp",".webp",".wmf",".wsq",".x3f",".xbm",".xcf",".xpm"},
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(imageViewerpp);

            var notepad = new AppType("文本")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".txt", ".conf", ".reg", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(notepad);

            var notepadpp = new AppType("文本-高级")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                ".txt",".md",".ahk",".application",".cfg",".conf",".css",".csv",
                    ".err",".inf",".ini",".js",".json",".log",".lua",".manifest",
                    ".nfo",".properties",".ps1",".ps1xml",".readme",".reg",".scp",
                    ".sh",".srt",".sub",".wtx",".xml",".xul",},
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(notepadpp);

            var pdf = new AppType("通用PDF")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                 ".pdf",".epub",".azw",".mobi",".fb2",".fb2z",".zfb2",".pdb",".tcr",
                 ".cbz",".cbr",".cbt",".cb7",".djv",".djvu",".chm",".xps",".oxps",".xod",},
            };
            config.AppTypes.Add(pdf);

            var music = new AppType("音频播放器")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                ".3ga",".aac",".ac3",".aif",".aifc",".aiff",".alac",".amr",".aob",
                ".ape",".apl",".au",".caf",".cda",".dsf",".dts",".dtshd",".dtsma",
                ".eac3",".flac",".m1a",".m2a",".m4a",".m4b",".m4r",".mid",".midi",
                ".mka",".mlp",".mp2",".mp3",".mpa",".mpc",".mpl",".ofr",".ofs",
                ".oga",".ogg",".opus",".ra",".rmi",".snd",".spx",".tak",".thd",
                ".tta",".wav",".weba",".wma",".wv",},
            };
            config.AppTypes.Add(music);
            
            var zip = new AppType("压缩软件")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                ".7z",".7zip",".zip",".rar",".gz",".cab",".tar",},
            };
            config.AppTypes.Add(zip);

            var zippp = new AppType("压缩软件-高级")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                ".7z",".7zip",".zip",".zipx",".rar",".gz",".gzip",".cab",".001",
                ".tar",".bz2",".bzip2",".tbz",".vhd",".vhdx",".iso",".esd",".wim",".dmg",".zst",},
            };
            config.AppTypes.Add(zippp);

            return config;
        }

        // PROPERTIES
        public List<AppType> AppTypes { get; set; }

        // CONSTRUCTOR
        public Configuration()
        {
            AppTypes = new List<AppType>();
        }

        public static Configuration Load()
        {
            try
            {
                if (!File.Exists(_configFile))
                {
                    var config = Configuration.CreateDefault();
                    config.Save();
                    return config;
                }
                else
                {
                    return Helper.XMLSerializer.Deserialize<Configuration>(_configFile);
                }
            }
            catch (Exception ex)
            {
                SimpleLogger.Instance.Error(ex);
                throw ex;
            }
        }

        public void Save()
        {
            Helper.XMLSerializer.Serialize(this, _configFile);
        }
    }
}
