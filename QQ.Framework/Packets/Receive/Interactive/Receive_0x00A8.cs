namespace QQ.Framework.Packets.Receive.Interactive
{
    public class Receive_0x00A8 : ReceivePacket
    {
        /// <summary>
        ///     
        /// </summary>
        public Receive_0x00A8(byte[] byteBuffer, QQUser User)
            : base(byteBuffer, User, User.QQ_SessionKey)
        {
        }
        public byte resultCode { get; set; }
        protected override void ParseBody()
        {
            Decrypt(user.QQ_SessionKey);
            if (GetPacketLength() == 159)
            {
                user.MessageLog("��Ǹ���������������Ƶ�����˻����ڲ���ȫ���أ���Ӻ��ѹ����ݱ�ֹͣʹ�ã����Ժ�����");
            }
        }
    }
}