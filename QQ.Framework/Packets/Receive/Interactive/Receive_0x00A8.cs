namespace QQ.Framework.Packets.Receive.Interactive
{
    public class Receive_0X00A8 : ReceivePacket
    {
        /// <summary>
        /// </summary>
        public Receive_0X00A8(byte[] byteBuffer, QQUser user)
            : base(byteBuffer, user, user.TXProtocol.SessionKey)
        {
        }

        public byte ResultCode { get; set; }

        protected override void ParseBody()
        {
            Decrypt(User.TXProtocol.SessionKey);
            if (GetPacketLength() == 159)
            {
                User.MessageLog("��Ǹ���������������Ƶ�����˻����ڲ���ȫ���أ���Ӻ��ѹ����ݱ�ֹͣʹ�ã����Ժ�����");
            }
        }
    }
}