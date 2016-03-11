/************************************************************************/
/*  功能：①引入C++动态链接库的函数；②声明C++动态链接库中的数据类型。
 *  需要添加的名字空间：using System.Runtime.InteropServices;
 *  各个函数详细功能及参数说明请参照文档《二次开发接口使用手册V1.3.pdf》
 *  公司：深圳市大族激光科技股份有限公司
 *  部门：软件中心—标准软件部
 *  作者：易勇军
 *  时间：2012-4-20
/************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TestLaser
{
    static public class CSharpInterface
    {
        /************************************************************************/
        /*  ①引入C++动态链接库的函数
        /************************************************************************/
        public static string g_strPathName = "";
        [DllImport(@"E:\VSProject\extDll\HansAdvInterface.dll", EntryPoint = "HS_GetDllVersion",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetDllVersion(ref ushort pMainVerr, ref ushort pDllVer);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_CloseMachine",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_CloseMachine();

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_SetDevCfg",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_SetDevCfg();

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_InitialMachine",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_InitialMachine(string pszPath);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetMarkRange",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetMarkRange(ref double pX, ref double pY);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetLastError",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetLastError(ref int pError, StringBuilder lpszMsg, int nSize);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_FreeStrokeList",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_FreeStrokeList(CInterStroke[] m_listCustom);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_IGotoXYZ",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_IGotoXYZ(int nType, double dbX, double dbY, double dbZ);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ILaserOn",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_ILaserOn(double dbQFrq, double dbQRls, double dbCurrentA, double
dbPower);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ILaserOff",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_ILaserOff();

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_CheckTouch",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_CheckTouch(IntPtr hWnd, bool bActive);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_Mark",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_Mark(int nType, bool bWaitTouch, bool bWaitEnd, int nOverTime, bool bMarkAll);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_IsMarkEnd",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_IsMarkEnd(ref int pFlag);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetMarkTime",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetMarkTime(ref int nTime);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_MarkPause",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_MarkPause();

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_Remark",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_Remark();

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_MarkStop",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_MarkStop();

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_PreviewGraph",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_PreviewGraph(IntPtr hWnd, double dbCenterX, double dbCenterY, double dbScale);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_SelectObjects",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_SelectObjects(string lpszObjName, bool bSelected);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_AddDotMatrix",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_AddDotMatrix(double[,] ptBuf, int nPtNum, int nLayer, string lpszObjName);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ReadPort",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_ReadPort(ref int InPort);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_WritePort",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_WritePort(int dwValue, int dwMask);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_IsTouch",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_IsTouch(ref int pTouchFlag);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_MoveMotorV",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_MoveMotorV(int nAxisNo, double dbMoveValue, int nMoveModel, int nMoveType);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_SetAsSoftHome",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_SetAsSoftHome(int nAxisNo);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_HomeMoveV",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_HomeMoveV(int nAxisNo, bool bSoftHome);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetFontPara",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetFontPara(ref FONTPARA fontPara);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetHatchPara",
               CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetHatchPara(ref HATCHPARA m_hatchPara);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_SetHatchPara",
                        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_SetHatchPara(ref HATCHPARA m_hatchPara);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetLayerPara",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetLayerPara(int nLayer, ref LAYERPARA pPara);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_SetLayerPara",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_SetLayerPara(int nLayer, ref LAYERPARA pPara);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_SetFontPara",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_SetFontPara(ref FONTPARA pPara);

        [DllImport("HansAdvInterface2.dll", EntryPoint = "HS_SetFontPara2",
CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_SetFontPara2(int type, byte charset, string name, string cn, string en, string num);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ClearObjects",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_ClearObjects();

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetObjList",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetObjList(byte[,] szObjList, ref int pCount);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_AddText2",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_AddText2(string lpszStr, double dbHeight, double dbWidthRatio,
            bool bModel, string pszName, double dbPosX, double dbPosY, int nAlign, double dbAngle,
            int nLayer, bool bHatch, int nHatchLayer, double dbCharSpace, double dbLineSpace, string lpszObjName);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetObjProperty",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetObjProperty(ref double pLeft, ref double pTop, ref double pRight, ref double pBottom);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_AddBarcode",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_AddBarcode(string lpszStr, int nBarType, double dbHeight, double dbPosX, double dbPosY,
            double dbAngle, int nAlign, int nLayerNo, double dbBarRatio, double dbLineDist, double dbShrink, bool bReverse,
            double dbRevWidth, double dbRevHeight, bool bModel, string lpszTextName, string lpszObjName);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_AddCurve",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_AddCurve(double[,] ptBuf, int nPtNum, int nLayer, bool bHatch, int nHatchLayer, string lpszObjName);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ImportVectorFile",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_ImportVectorFile(string lpszFileName, double dbPosX, double dbPosY, double dbWidth,
            double dbHeight, double dbRotate, bool bHatch, int nHatchLayer, string lpszObjName);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ImportImageFile",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_ImportImageFile(string lpszFileName, double dbPosX, double dbPosY, double dbWidth,
            double dbHeight, double dbRotate, int nMarkType, double dbDotDistX, double dbDotDistY, int nAccDot, bool bReciprocate,
            int nRepairDot, string lpszObjName);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetStrokeList",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetStrokeList(string lpszObjName, CInterStroke[] pList);// IntPtr pList);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ MarkStorkeList",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_MarkStorkeList(int nType, CInterStroke[] pList);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_Move",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_Move(double dbMoveX, double dbMoveY);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_Rotate",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_Rotate(double x, double y, double dbRotate);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_Shear",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_Shear(double dbBaseX, double dbBaseY, double dbAngleX, double dbAngleY);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_Scale",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_Scale(double x, double y, double dbScaleX, double dbScaleY);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ChangeTextByName",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_ChangeTextByName(string lpszTextName, string lpszText);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetTextByName",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetTextByName(string lpszTextName, StringBuilder lpszText, ref int pMaxCount);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetVarTextList",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetVarTextList(StringBuilder szObjList, ref int pCount);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_ChangeTextByNameW",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_ChangeTextByNameW(string lpszName, byte[] lpszTextValue);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_GetTextByNameW",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_GetTextByNameW(string lpszName, byte[] lpszText, ref int pMaxCount);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_LoadMarkFile",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_LoadMarkFile(string pszFileName);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_SaveMarkFile",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_SaveMarkFile(string lpszFile);

        [DllImport("HansAdvInterface.dll", EntryPoint = "HS_CloseMarkFile",
     CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HS_CloseMarkFile(string lpszFile, bool bSave);
        //获取错误信息
        public static string GetError()
        {
            int nErr = 0;
            StringBuilder szBuff = new StringBuilder(200);
            HS_GetLastError(ref nErr, szBuff, 200);
            return szBuff.ToString();
        }
        public static string ShowLastError()
        {
            int nErr = 0;
            StringBuilder szBuff = new StringBuilder(200);
            CSharpInterface.HS_GetLastError(ref nErr, szBuff, 200);
            return szBuff.ToString();
        }
       

        //将一个包含ASCII编码字符的Byte数组转化为一个完整的String
        public static string FromASCIIByteArray(byte[] characters)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            string constructedString = encoding.GetString(characters);
            return (constructedString);
        }
        //将一个包含Unicode编码字符的Byte数组转化为一个完整的String
        public static string FromUnicodeByteArray(byte[] characters)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            string constructedString = encoding.GetString(characters);
            return (constructedString);
        }
    }

    /************************************************************************/
    /*  ②声明C++动态链接库中的数据类型
    /************************************************************************/

    [StructLayout(LayoutKind.Sequential)]
    public struct BaseHatch
    {
        [MarshalAs(UnmanagedType.Bool)]
        public bool bEnable;		//填充使能
        [MarshalAs(UnmanagedType.Bool)]
        public bool bEquaDist;		//等间距使能
        [MarshalAs(UnmanagedType.Bool)]
        public bool bKeepAngle;		//填充线绕轮廓旋转
        [MarshalAs(UnmanagedType.U4)]
        public int nFillStyle;		//填充类型
        [MarshalAs(UnmanagedType.R8)]
        public double dbSpace;		//填充间距
        [MarshalAs(UnmanagedType.R8)]
        public double dbAngle;		//填充角度
        [MarshalAs(UnmanagedType.R8)]
        public double dbBeamComp;		//光栅大小
        [MarshalAs(UnmanagedType.R8)]
        public double dbLineReduce;   //线缩进量
        [MarshalAs(UnmanagedType.R8)]
        public double dbStartOffset;  //起始缩进量
        [MarshalAs(UnmanagedType.R8)]
        public double dbEndOffset;    //末尾缩进量
        [MarshalAs(UnmanagedType.R8)]
        public double dbMinJump;      //最小跳转间距
        [MarshalAs(UnmanagedType.Bool)]
        public bool bLoop;			//缩扩使能
        [MarshalAs(UnmanagedType.U4)]
        public int nLoopNum;		//缩扩圈数
        [MarshalAs(UnmanagedType.R8)]
        public double dbLoopDist;		//缩扩间距
        [MarshalAs(UnmanagedType.Bool)]
        public bool bRemoveLine;	//缩扩后去掉填充线
        [MarshalAs(UnmanagedType.Bool)]
        public bool bRemoveOrg;		//缩扩后去掉原始轮廓
        [MarshalAs(UnmanagedType.U4)]
        public int nFillNum;		//填充次数
        [MarshalAs(UnmanagedType.R8)]
        public double ProAngle;		//累进角度
        [MarshalAs(UnmanagedType.R8)]
        public double AddDis;			//累进间距
        [MarshalAs(UnmanagedType.Bool)]
        public bool bSaveCountour;	//填充后保留外框
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct HATCHPARA
    {
        [MarshalAs(UnmanagedType.Struct)]
        public BaseHatch newFileData1;
        [MarshalAs(UnmanagedType.Struct)]
        public BaseHatch newFileData2;
        [MarshalAs(UnmanagedType.Bool)]
        public bool bFillFirst;
    };


    //字体参数结构体定义
    [StructLayout(LayoutKind.Sequential)]
    public struct FONTPARA
    {
        [MarshalAs(UnmanagedType.U4)]
        public int naFontType;			            //字体类型 0-TTF，1-SHX，2-HANS，3-DOT
        [MarshalAs(UnmanagedType.U1)]
        public Byte nCharSet;			//字符集,Unicode编码时用
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public char[] szFontName;              //TTF、HANS字体用
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public char[] szShxCN;                   //SHX、DOT字中文字体用
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public char[] szShxEN;                   // SHX、DOT字英文字体用
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public char[] szShxNum;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LOGFONT
    {
        [MarshalAs(UnmanagedType.U4)]
        public int lfHeight;
        [MarshalAs(UnmanagedType.U4)]
        public int llfWidth;
        [MarshalAs(UnmanagedType.U4)]
        public int llfEscapement;
        [MarshalAs(UnmanagedType.U4)]
        public int llfOrientation;
        [MarshalAs(UnmanagedType.U4)]
        public int llfWeight;
        [MarshalAs(UnmanagedType.U1)]
        public System.Byte lfItalic;
        [MarshalAs(UnmanagedType.U1)]
        public System.Byte lfUnderline;
        [MarshalAs(UnmanagedType.U1)]
        public System.Byte lfStrikeOut;
        [MarshalAs(UnmanagedType.U1)]
        public System.Byte lfCharSet;
        [MarshalAs(UnmanagedType.U1)]
        public System.Byte lfOutPrecision;
        [MarshalAs(UnmanagedType.U1)]
        public System.Byte lfClipPrecision;
        [MarshalAs(UnmanagedType.U1)]
        public System.Byte lfQuality;
        [MarshalAs(UnmanagedType.U1)]
        public System.Byte lfPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] lfFaceName;
    };

    //层参数结构体定义
    [StructLayout(LayoutKind.Sequential)]
    public struct LAYERPARA
    {
        [MarshalAs(UnmanagedType.U4)]
        public int nCount;		    //打标次数
        [MarshalAs(UnmanagedType.R8)]
        public double dbMarkV;		//矢量打标速度(mm/s)
        [MarshalAs(UnmanagedType.R8)]
        public double dbJumpV;		//矢量空跳速度(mm/s)
        [MarshalAs(UnmanagedType.R8)]
        public double dbQFre;			//Q频(KHz)
        [MarshalAs(UnmanagedType.R8)]
        public double dbQRls;			//Q释放(us)
        [MarshalAs(UnmanagedType.R8)]
        public double dbCurrent;		//电流(A)
        [MarshalAs(UnmanagedType.U4)]
        public int nFpkTime;		//首脉冲抑制时间	
        [MarshalAs(UnmanagedType.R8)]
        public double dbFPKInitRate;	//首点比例(0.0~1.0)	
        [MarshalAs(UnmanagedType.R8)]
        public double dbFPKLenRate;	//抑制长度系数(0.0~0.999)
        [MarshalAs(UnmanagedType.R8)]
        public double dbFPKMaxPRate;	//峰值能量比例(0.0~1.0)
        [MarshalAs(UnmanagedType.R8)]
        public double dbFPKCurRate;	//首脉冲电流系数(0.0~1.0)
        [MarshalAs(UnmanagedType.U4)]
        public int nQuality;		//打标质量系数
        [MarshalAs(UnmanagedType.U4)]
        public int nLayerDelay;	//层延时
        [MarshalAs(UnmanagedType.U4)]
        public int nLaserOnDelay;	//激光开延时(us)
        [MarshalAs(UnmanagedType.U4)]
        public int nLaserOffDelay;	//激光关延时(us)
        [MarshalAs(UnmanagedType.U4)]
        public int nMoveLineDelay;	//走笔延时(us)
        [MarshalAs(UnmanagedType.U4)]
        public int nJumpDelay;		//跳转延时(us)
        [MarshalAs(UnmanagedType.U4)]
        public int nRoundDelay;	//拐弯延时(us)
        [MarshalAs(UnmanagedType.R8)]
        public double dbCurrentR;		//电流(%)
        [MarshalAs(UnmanagedType.R8)]
        public double dbSimmerCur;	//维持电流(%)
        [MarshalAs(UnmanagedType.U4)]
        public int nWaveForm;		//波形
        [MarshalAs(UnmanagedType.R8)]
        public double dbPowerR;		//功率(%)
    };

    //电机运动参数结构体定义
    [StructLayout(LayoutKind.Sequential)]
    public struct MOTORPARA
    {
        [MarshalAs(UnmanagedType.U2)]
        public ushort nVer;			//版本号,预留0
        [MarshalAs(UnmanagedType.U2)]
        public ushort nAxis;			//轴号
        [MarshalAs(UnmanagedType.U2)]
        public ushort nMoveMode;		//运动模式:0-绝对运动,1-相对运动
        [MarshalAs(UnmanagedType.U4)]
        public int nMovePos;		//运动量或位置
        [MarshalAs(UnmanagedType.U4)]
        public System.UInt32 nMoveSpeed;		//运动速度(脉冲/秒)
        [MarshalAs(UnmanagedType.U4)]
        public System.UInt32 nMoveAcc;		//加速度(递增脉冲/秒)
        [MarshalAs(UnmanagedType.U4)]
        public System.UInt32 nDelay;			//运动后延时
    };

    //对外接口点数据结构
    [StructLayout(LayoutKind.Sequential)]
    public struct CInterDot
    {
        [MarshalAs(UnmanagedType.R8)]
        public double x;	//x
        [MarshalAs(UnmanagedType.R8)]
        public double y;	//y
        [MarshalAs(UnmanagedType.R8)]
        public double z;	//z (3D预留)
    };

    //对外接口线条数据类
    [StructLayout(LayoutKind.Sequential)]
    public struct CInterStroke
    {
        [MarshalAs(UnmanagedType.ByValArray)]
        public CInterDot[] m_dotArray;
        [MarshalAs(UnmanagedType.U4)]
        public int m_nLayer;
    };
}
