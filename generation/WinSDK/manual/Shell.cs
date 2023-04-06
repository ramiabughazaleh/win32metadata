using System;
using Windows.Win32.Foundation.Metadata;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation.Metadata;
using static Windows.Win32.Foundation.Apis;
using static Windows.Win32.System.SystemServices.Apis;

namespace Windows.Win32.UI.Shell
{

    public static unsafe partial class Apis
    {
        [NativeTypeName("HRESULT")]
        public const int HLINK_E_FIRST = OLE_E_LAST + 1;

        [NativeTypeName("HRESULT")]
        public const int HLINK_S_FIRST = OLE_S_LAST + 1;

        [DllImport("SHELL32.dll", EntryPoint = "#660", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern BOOL FileIconInit([In]BOOL fRestoreCache)
    }

    [Flags]
    public enum SHGFI_FLAGS
    {
        SHGFI_ADDOVERLAYS = 0x000000020,
        SHGFI_ATTR_SPECIFIED = 0x000020000,
        SHGFI_ATTRIBUTES = 0x000000800,
        SHGFI_DISPLAYNAME = 0x000000200,
        SHGFI_EXETYPE = 0x000002000,
        SHGFI_ICON = 0x000000100,
        SHGFI_ICONLOCATION = 0x000001000,
        SHGFI_LARGEICON = 0x000000000,
        SHGFI_LINKOVERLAY = 0x000008000,
        SHGFI_OPENICON = 0x000000002,
        SHGFI_OVERLAYINDEX = 0x000000040,
        SHGFI_PIDL = 0x000000008,
        SHGFI_SELECTED = 0x000010000,
        SHGFI_SHELLICONSIZE = 0x000000004,
        SHGFI_SMALLICON = 0x000000001,
        SHGFI_SYSICONINDEX = 0x000004000,
        SHGFI_TYPENAME = 0x000000400,
        SHGFI_USEFILEATTRIBUTES = 0x000000010,
    }

    [Flags]
    public enum SHCNE_ID : uint
    {
        SHCNE_RENAMEITEM = 0x00000001,
        SHCNE_CREATE = 0x00000002,
        SHCNE_DELETE = 0x00000004,
        SHCNE_MKDIR = 0x00000008,
        SHCNE_RMDIR = 0x00000010,
        SHCNE_MEDIAINSERTED = 0x00000020,
        SHCNE_MEDIAREMOVED = 0x00000040,
        SHCNE_DRIVEREMOVED = 0x00000080,
        SHCNE_DRIVEADD = 0x00000100,
        SHCNE_NETSHARE = 0x00000200,
        SHCNE_NETUNSHARE = 0x00000400,
        SHCNE_ATTRIBUTES = 0x00000800,
        SHCNE_UPDATEDIR = 0x00001000,
        SHCNE_UPDATEITEM = 0x00002000,
        SHCNE_SERVERDISCONNECT = 0x00004000,
        SHCNE_UPDATEIMAGE = 0x00008000,
        SHCNE_DRIVEADDGUI = 0x00010000,
        SHCNE_RENAMEFOLDER = 0x00020000,
        SHCNE_FREESPACE = 0x00040000,
        SHCNE_EXTENDED_EVENT = 0x04000000,
        SHCNE_ASSOCCHANGED = 0x08000000,
        SHCNE_DISKEVENTS = 0x0002381F,
        SHCNE_GLOBALEVENTS = 0x0C0581E0,
        SHCNE_ALLEVENTS = 0x7FFFFFFF,
        SHCNE_INTERRUPT = 0x80000000,
    }

    [Flags]
    public enum SHCNRF_SOURCE
    {
        SHCNRF_InterruptLevel = 0x0001,
        SHCNRF_ShellLevel = 0x0002,
        SHCNRF_RecursiveInterrupt = 0x1000,
        SHCNRF_NewDelivery = 0x8000
    }

    [Flags]
    public enum SHCNF_FLAGS : uint
    {
        SHCNF_IDLIST = 0x0000,
        SHCNF_PATHA = 0x0001,
        SHCNF_PRINTERA = 0x0002,
        SHCNF_DWORD = 0x0003,
        SHCNF_PATHW = 0x0005,
        SHCNF_PRINTERW = 0x0006,
        SHCNF_TYPE = 0x00FF,
        SHCNF_FLUSH = 0x1000,
        SHCNF_FLUSHNOWAIT = 0x3000,
        SHCNF_NOTIFYRECURSIVE = 0x10000,
        SHCNF_PATH = SHCNF_PATHW,
        SHCNF_PRINTER = SHCNF_PRINTERW,
    }

    [Flags]
    public enum QITIPF_FLAGS
    {
        QITIPF_DEFAULT = 0x00000000,
        QITIPF_USENAME = 0x00000001,
        QITIPF_LINKNOTARGET = 0x00000002,
        QITIPF_LINKUSETARGET = 0x00000004,
        QITIPF_USESLOWTIP = 0x00000008,
        QITIPF_SINGLELINE = 0x00000010,
        QIF_CACHED = 0x00000001,
        QIF_DONTEXPANDFOLDER = 0x00000002,
    }

    public enum SHDID_ID
    {
        SHDID_ROOT_REGITEM = 1,
        SHDID_FS_FILE = 2,
        SHDID_FS_DIRECTORY = 3,
        SHDID_FS_OTHER = 4,
        SHDID_COMPUTER_DRIVE35 = 5,
        SHDID_COMPUTER_DRIVE525 = 6,
        SHDID_COMPUTER_REMOVABLE = 7,
        SHDID_COMPUTER_FIXED = 8,
        SHDID_COMPUTER_NETDRIVE = 9,
        SHDID_COMPUTER_CDROM = 10,
        SHDID_COMPUTER_RAMDISK = 11,
        SHDID_COMPUTER_OTHER = 12,
        SHDID_NET_DOMAIN = 13,
        SHDID_NET_SERVER = 14,
        SHDID_NET_SHARE = 15,
        SHDID_NET_RESTOFNET = 16,
        SHDID_NET_OTHER = 17,
        SHDID_COMPUTER_IMAGING = 18,
        SHDID_COMPUTER_AUDIO = 19,
        SHDID_COMPUTER_SHAREDDOCS = 20,
        SHDID_MOBILE_DEVICE = 21,
        SHDID_REMOTE_DESKTOP_DRIVE = 22,
    }

    public enum SHGDFIL_FORMAT
    {
        SHGDFIL_FINDDATA = 1,
        SHGDFIL_NETRESOURCE = 2,
        SHGDFIL_DESCRIPTIONID = 3
    }

    [Flags]
    public enum PRF_FLAGS
    {
        PRF_VERIFYEXISTS = 0x0001,
        PRF_TRYPROGRAMEXTENSIONS = (0x0002 | PRF_VERIFYEXISTS),
        PRF_FIRSTDIRDEF = 0x0004,
        PRF_DONTFINDLNK = 0x0008,
        PRF_REQUIREABSOLUTE = 0x0010,
    }

    [Flags]
    public enum PCS_RET : uint
    {
        PCS_FATAL = 0x80000000,
        PCS_REPLACEDCHAR = 0x00000001,
        PCS_REMOVEDCHAR = 0x00000002,
        PCS_TRUNCATED = 0x00000004,
        PCS_PATHTOOLONG = 0x00000008
    }

    [Flags]
    public enum MM_FLAGS : uint
    {
        MM_ADDSEPARATOR = 0x00000001,
        MM_SUBMENUSHAVEIDS = 0x00000002,
        MM_DONTREMOVESEPS = 0x00000004
    }

    [Flags]
    public enum SHOP_TYPE
    {
        SHOP_PRINTERNAME = 0x00000001  // pszObjectName points to a printer friendly name,
        SHOP_FILEPATH = 0x00000002  // pszObjectName points to a fully qualified path+file name,
        SHOP_VOLUMEGUID = 0x00000004  // pszObjectName points to a Volume GUID
    }

    public enum SHFMT_ID : uint
    {
        SHFMT_ID_DEFAULT = 0xFFFF
    }

    [Flags]
    public enum SHFMT_OPT
    {
        SHFMT_OPT_NONE = 0
        SHFMT_OPT_FULL = 0x0001,
        SHFMT_OPT_SYSONLY = 0x0002
    }

    public enum SHFMT_RET : uint
    {
        SHFMT_ERROR = 0xFFFFFFFF,
        SHFMT_CANCEL = 0xFFFFFFFE,
        SHFMT_NOFORMAT = 0xFFFFFFFD
    }

    [Flags]
    public enum VALIDATEUNC_OPTION
    {
        VALIDATEUNC_CONNECT = 0x0001,
        VALIDATEUNC_NOUI = 0x0002,
        VALIDATEUNC_PRINT = 0x0004,
        VALIDATEUNC_PERSIST = 0x0008,
        VALIDATEUNC_VALID = 0x000F
    }

    public enum SFVM_MESSAGE_ID
    {
        SFVM_MERGEMENU = 1,
        SFVM_INVOKECOMMAND = 2,
        SFVM_GETHELPTEXT = 3,
        SFVM_GETTOOLTIPTEXT = 4,
        SFVM_GETBUTTONINFO = 5,
        SFVM_GETBUTTONS = 6,
        SFVM_INITMENUPOPUP = 7,
        SFVM_FSNOTIFY = 14,
        SFVM_WINDOWCREATED = 15,
        SFVM_GETDETAILSOF = 23,
        SFVM_COLUMNCLICK = 24,
        SFVM_QUERYFSNOTIFY = 25,
        SFVM_DEFITEMCOUNT = 26,
        SFVM_DEFVIEWMODE = 27,
        SFVM_UNMERGEMENU = 28,
        SFVM_UPDATESTATUSBAR = 31,
        SFVM_BACKGROUNDENUM = 32,
        SFVM_DIDDRAGDROP = 36,
        SFVM_SETISFV = 39,
        SFVM_THISIDLIST = 41,
        SFVM_ADDPROPERTYPAGES = 47,
        SFVM_BACKGROUNDENUMDONE = 48,
        SFVM_GETNOTIFY = 49,
        SFVM_GETSORTDEFAULTS = 53,
        SFVM_SIZE = 57,
        SFVM_GETZONE = 58,
        SFVM_GETPANE = 59,
        SFVM_GETHELPTOPIC = 63,
        SFVM_GETANIMATION = 68
    }

    public enum SFVS_SELECT
    {
        SFVS_SELECT_NONE = 0x0,
        SFVS_SELECT_ALLITEMS = 0x1,
        SFVS_SELECT_INVERT = 0x2
    }

    public enum DFM_MESSAGE_ID
    {
        DFM_MERGECONTEXTMENU = 1,
        DFM_INVOKECOMMAND = 2,
        DFM_GETHELPTEXT = 5,
        DFM_WM_MEASUREITEM = 6,
        DFM_WM_DRAWITEM = 7,
        DFM_WM_INITMENUPOPUP = 8,
        DFM_VALIDATECMD = 9,
        DFM_MERGECONTEXTMENU_TOP = 10,
        DFM_GETHELPTEXTW = 11,
        DFM_INVOKECOMMANDEX = 12,
        DFM_MAPCOMMANDNAME = 13,
        DFM_GETDEFSTATICID = 14,
        DFM_GETVERBW = 15,
        DFM_GETVERBA = 16,
        DFM_MERGECONTEXTMENU_BOTTOM = 17,
        DFM_MODIFYQCMFLAGS = 18
    }

    public enum DFM_CMD
    {
        DFM_CMD_DELETE = -1,
        DFM_CMD_MOVE = -2,
        DFM_CMD_COPY = -3,
        DFM_CMD_LINK = -4,
        DFM_CMD_PROPERTIES = -5,
        DFM_CMD_NEWFOLDER = -6,
        DFM_CMD_PASTE = -7,
        DFM_CMD_VIEWLIST = -8,
        DFM_CMD_VIEWDETAILS = -9,
        DFM_CMD_PASTELINK = -10,
        DFM_CMD_PASTESPECIAL = -11,
        DFM_CMD_MODALPROP = -12,
        DFM_CMD_RENAME = -13
    }

    public enum PID_IS
    {
        PID_IS_URL = 2,
        PID_IS_NAME = 4,
        PID_IS_WORKINGDIR = 5,
        PID_IS_HOTKEY = 6,
        PID_IS_SHOWCMD = 7,
        PID_IS_ICONINDEX = 8,
        PID_IS_ICONFILE = 9,
        PID_IS_WHATSNEW = 10,
        PID_IS_AUTHOR = 11,
        PID_IS_DESCRIPTION = 12,
        PID_IS_COMMENT = 13,
        PID_IS_ROAMED = 15
    }

    public enum PID_INTSITE
    {
        PID_INTSITE_WHATSNEW = 2,
        PID_INTSITE_AUTHOR = 3,
        PID_INTSITE_LASTVISIT = 4,
        PID_INTSITE_LASTMOD = 5,
        PID_INTSITE_VISITCOUNT = 6,
        PID_INTSITE_DESCRIPTION = 7,
        PID_INTSITE_COMMENT = 8,
        PID_INTSITE_FLAGS = 9,
        PID_INTSITE_CONTENTLEN = 10,
        PID_INTSITE_CONTENTCODE = 11,
        PID_INTSITE_RECURSE = 12,
        PID_INTSITE_WATCH = 13,
        PID_INTSITE_SUBSCRIPTION = 14,
        PID_INTSITE_URL = 15,
        PID_INTSITE_TITLE = 16,
        PID_INTSITE_CODEPAGE = 18,
        PID_INTSITE_TRACKING = 19,
        PID_INTSITE_ICONINDEX = 20,
        PID_INTSITE_ICONFILE = 21,
        PID_INTSITE_ROAMED = 34
    }

    [Flags]
    public enum PIDISF_FLAGS
    {
        PIDISF_RECENTLYCHANGED = 0x00000001,
        PIDISF_CACHEDSTICKY = 0x00000002,
        PIDISF_CACHEIMAGES = 0x00000010,
        PIDISF_FOLLOWALLLINKS = 0x00000020
    }

    public enum PIDISM_OPTIONS
    {
        PIDISM_GLOBAL = 0,
        PIDISM_WATCH = 1,
        PIDISM_DONTWATCH = 2
    }

    public enum PIDISR_INFO
    {
        PIDISR_UP_TO_DATE = 0,
        PIDISR_NEEDS_ADD = 1,
        PIDISR_NEEDS_UPDATE = 2,
        PIDISR_NEEDS_DELETE = 3
    }

    [Flags]
    public enum SSF_MASK : uint
    {
        SSF_SHOWALLOBJECTS = 0x00000001,
        SSF_SHOWEXTENSIONS = 0x00000002,
        SSF_HIDDENFILEEXTS = 0x00000004,
        SSF_SERVERADMINUI = 0x00000004,
        SSF_SHOWCOMPCOLOR = 0x00000008,
        SSF_SORTCOLUMNS = 0x00000010,
        SSF_SHOWSYSFILES = 0x00000020,
        SSF_DOUBLECLICKINWEBVIEW = 0x00000080,
        SSF_SHOWATTRIBCOL = 0x00000100,
        SSF_DESKTOPHTML = 0x00000200,
        SSF_WIN95CLASSIC = 0x00000400,
        SSF_DONTPRETTYPATH = 0x00000800,
        SSF_SHOWINFOTIP = 0x00002000,
        SSF_MAPNETDRVBUTTON = 0x00001000,
        SSF_NOCONFIRMRECYCLE = 0x00008000,
        SSF_HIDEICONS = 0x00004000,
        SSF_FILTER = 0x00010000,
        SSF_WEBVIEW = 0x00020000,
        SSF_SHOWSUPERHIDDEN = 0x00040000,
        SSF_SEPPROCESS = 0x00080000,
        SSF_NONETCRAWLING = 0x00100000,
        SSF_STARTPANELON = 0x00200000,
        SSF_SHOWSTARTPAGE = 0x00400000,
        SSF_AUTOCHECKSELECT = 0x00800000,
        SSF_ICONSONLY = 0x01000000,
        SSF_SHOWTYPEOVERLAY = 0x02000000,
        SSF_SHOWSTATUSBAR = 0x04000000,
    }

    [Flags]
    public enum ASSOCF : uint
    {
        ASSOCF_NONE = 0x00000000,
        ASSOCF_INIT_NOREMAPCLSID = 0x00000001,
        ASSOCF_INIT_BYEXENAME = 0x00000002,
        ASSOCF_OPEN_BYEXENAME = 0x00000002,
        ASSOCF_INIT_DEFAULTTOSTAR = 0x00000004,
        ASSOCF_INIT_DEFAULTTOFOLDER = 0x00000008,
        ASSOCF_NOUSERSETTINGS = 0x00000010,
        ASSOCF_NOTRUNCATE = 0x00000020,
        ASSOCF_VERIFY = 0x00000040,
        ASSOCF_REMAPRUNDLL = 0x00000080,
        ASSOCF_NOFIXUPS = 0x00000100,
        ASSOCF_IGNOREBASECLASS = 0x00000200,
        ASSOCF_INIT_IGNOREUNKNOWN = 0x00000400,
        ASSOCF_INIT_FIXED_PROGID = 0x00000800,
        ASSOCF_IS_PROTOCOL = 0x00001000,
        ASSOCF_INIT_FOR_FILE = 0x00002000,
        ASSOCF_IS_FULL_URI = 0x00004000,
        ASSOCF_PER_MACHINE_ONLY = 0x00008000,
        ASSOCF_APP_TO_APP = 0x00010000,
    }
}
