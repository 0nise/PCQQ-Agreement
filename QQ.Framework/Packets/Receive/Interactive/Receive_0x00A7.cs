namespace QQ.Framework.Packets.Receive.Interactive
{
    public class Receive_0X00A7 : ReceivePacket
    {
        /// <summary>
        /// </summary>
        public Receive_0X00A7(byte[] byteBuffer, QQUser user)
            : base(byteBuffer, user, user.TXProtocol.SessionKey)
        {
        }

        public byte ResultCode { get; set; }

        protected override void ParseBody()
        {
            Decrypt(User.TXProtocol.SessionKey);
            //��Ӧ��00��������֤��Ϣ��01����Ҫ��֤��Ϣ��99���Է��Ѿ�����ĺ��ѣ�03��04�����ʧ�ܣ�
            ResultCode = (byte) Reader.Read();
        }
    }
}