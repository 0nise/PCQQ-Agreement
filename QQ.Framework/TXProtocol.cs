using System;
using System.Collections.Generic;
using System.Net;
using QQ.Framework.Utils;

namespace QQ.Framework
{
    public class TXProtocol
    {
        public byte[] bufTGTGTKey { get; set; } = Util.RandomKey();
        public byte[] bufTGTGT { get; set; }
        public byte[] bufTGT { get; set; }
        //public byte[] bufComputerIDEx { get; set; } = Util.RandomKey();
        public byte[] bufComputerID { get; set; } = { 0x43, 0x04, 0x21, 0x7D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        //public byte[] bufComputerID { get; set; } = Util.RandomKey();
        public byte[]  bufComputerIDEx{ get; set; } = { 0x77, 0x98, 0x00, 0x0B, 0xAB, 0x5D, 0x4F, 0x3D, 0x30, 0x50, 0x65, 0x2C, 0x4A, 0x2A, 0xF8, 0x65 };
        public byte[] bufDeviceID { get; set; } = { 0x0f, 0xab, 0xbe, 0x21, 0x04, 0xa7, 0x2a, 0xf1, 0xe1, 0x9d, 0xa1, 0x95, 0x6a, 0x36, 0x3d, 0xf0, 0x7b, 0x22, 0xff, 0x2e, 0xc2, 0xca, 0xc9, 0x2b, 0xa8, 0xd6, 0xda, 0x45, 0x9d, 0x31, 0xa9, 0x60 };
        public byte[] bufSigPic { get; set; }
        public byte[] PngToken { get; set; }
        public byte[] PngKey { get; set; }
        public byte[] bufTGT_GTKey { get; set; }
        public byte[] buf16bytesGTKey_ST { get; set; }
        public byte[] bufServiceTicket { get; set; }
        public byte[] buf16bytesGTKey_STHttp { get; set; }
        public byte[] bufServiceTicketHttp { get; set; }
        public byte[] bufGTKey_TGTPwd { get; set; }
        public byte[] bufSessionKey { get; set; }
        public byte[] bufSigSession { get; set; }
        public byte[] bufPwdForConn { get; set; }
        public byte[] SessionKey { get; set; }
        public byte[] ClientKey { get; set; }
        public byte[] bufSigClientAddr { get; set; }
        public byte[] bufDHPublicKey { get; set; } =
        {
            0x02,0x78,0x28,0x16,0x7C,0x9E,0xF3,0xB7,0x5A,0x7B,0x5A,0xEF,0xA2,0x30,0x10,0xEC,0x0C,0x46,0x87,0x70,0x76,0x31,0xA7,0x88,0xEA
        };
        public byte[] bufDHShareKey { get; set; } =
        {
            0x60,0x42,0x3B,0x51,0xC3,0xB1,0xF6,0x0F,0x67,0xE8,0x9C,0x00,0xF0,0xA7,0xBD,0xA3
        };
        public byte[] bufMachineInfoGuid { get; set; }
        //public byte[] bufMacGuid { get; set; } = Util.RandomKey();
        public byte[] bufMacGuid { get; set; } = { 0x21, 0x4B, 0x1A, 0x04, 0x09, 0xED, 0x19, 0x70, 0x98, 0x75, 0x51, 0xBB, 0x2D, 0x3A, 0x7E, 0x0A };

        #region �û����
        /// <summary>
        ///     ��ס����
        /// </summary>
        public byte bRememberPwdLogin { get; set; } = 0x00;
        public byte cPingType { get; set; } = 0x01;
        /// <summary>
        /// �ض���IP��¼
        /// </summary>
        public List<byte[]> RedirectIP { get; set; } = new List<byte[]>();
        /// <summary>
        /// �������
        /// </summary>
        public string bufComputerName { get; set; } = Dns.GetHostName();

        /// <summary>
        /// SSO���汾��
        /// </summary>
        public byte cMainVer = 0x37;
        /// <summary>
        /// SSO�ΰ汾��
        /// </summary>
        public byte cSubVer = 0x09;
        /// <summary>
        /// Array
        /// </summary>
        public byte[] xxoo_a = new byte[] { 0x03, 0x00, 0x00 };
        public byte[] xxoo_d = new byte[] { 0x30, 0x00, 0x00, 0x00 };
        public byte xxoo_b = 0x01;
        /// <summary>
        /// �ͻ�������
        /// </summary>
        public byte[] dwClientType = new byte[] { 0x00, 0x01, 0x01, 0x01 };
        /// <summary>
        /// ���а汾��
        /// </summary>
        public byte[] dwPubNo = new byte[] { 0x00, 0x00, 0x68, 0x1C };
        #region QdData ��ز���
        public ushort cQdProtocolVer = 0x0063;
        public long dwQdVerion= 0x02040404;
        public ushort wQdCsCmdNo = 0x0004;
        public byte cQdCcSubNo = 0x00;
        /// <summary>
        /// ϵͳ����
        /// </summary>
        internal byte cOsType = 0x03;
        /// <summary>
        /// �Ƿ�x64
        /// </summary>
        internal byte bIsWOW64 = 0x01;
        public long dwDrvVersionInfo = 0x01020000;
        /// <summary>
        /// TSSafeEdit.dat��"�ļ��汾"
        /// </summary>
        public byte[] bufVersion_TSSafeEdit_dat = { 0x07, 0xdf, 0x00, 0x0a, 0x00, 0x0c, 0x00, 0x01 };
        /// <summary>
        /// QScanEngine.dll��"�ļ��汾"
        /// </summary>
        public byte[] bufVersion_QScanEngine_dll = { 0x00, 0x04, 0x00, 0x03, 0x00, 0x04, 0x20, 0x5c };
        public byte[] QdSufFix = { 0x68 };
        public byte[] QdPreFix = { 0x3E };
        /// <summary>
        /// wE7^3img#i)%h12]
        /// </summary>
        public byte[] bufQdKey = { 0x77, 0x45, 0x37, 0x5e, 0x33, 0x69, 0x6d, 0x67, 0x23, 0x69, 0x29, 0x25, 0x68, 0x31, 0x32, 0x5d };
        #endregion
        #endregion

        #region ȫ��
        /// <summary>
        /// ���汾��
        /// </summary>
        public uint dwSSOVersion { get; set; } = 0x00000453;
        public uint dwServiceId { get; set; } = 0x00000001;
        /// <summary>
        /// �ͻ��˰汾
        /// </summary>
        public uint dwClientVer { get; set; } = 0x00001585;
        public uint dwISP { get; set; }
        public uint dwIDC { get; set; }
        public long time_difference { get; set; }
        public byte[] bufSID { get; set; } = { 0x1E, 0xC1, 0x25, 0x71, 0xB2, 0x4C, 0xEA, 0x91, 0x9A, 0x6E, 0x8D, 0xE6, 0x95, 0x4E, 0xCE, 0x06 };
        //public byte[] bufSID { get; set; } = Util.RandomKey();
        public byte[] QQEXE_MD5 { get; set; }
        #endregion

        #region �ͻ���
        public ushort wClientPort { get; set; }
        public string dwClientIP { get; set; }
        public DateTime dwServerTime { get; set; }
        /// <summary>
        /// �ض������
        /// </summary>
        public ushort wRedirectCount { get; set; }
        public string dwServerIP { get; set; } = "61.151.226.190";
        public string dwRedirectIP { get; set; }
        public ushort wRedirectPort { get; set; }
        public ushort wServerPort { get; set; } = 8000;
        public ushort SubVer { get;  set; } = 0x0001 ;
        public ushort EcdhVer { get;  set; } = 0x0102 ;
        public byte[] QdData { get; set; }
        #endregion

    }
}