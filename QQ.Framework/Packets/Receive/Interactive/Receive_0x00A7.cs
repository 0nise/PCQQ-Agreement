namespace QQ.Framework.Packets.Receive.Interactive
{
    public class Receive_0x00A7 : ReceivePacket
    {
        /// <summary>
        ///     
        /// </summary>
        public Receive_0x00A7(byte[] byteBuffer, QQUser User)
            : base(byteBuffer, User, User.QQ_SessionKey)
        {
        }
        public byte resultCode { get; set; }
        protected override void ParseBody()
        {
            Decrypt(user.QQ_SessionKey);
            //��Ӧ��00��������֤��Ϣ��01����Ҫ��֤��Ϣ��99���Է��Ѿ�����ĺ��ѣ�03��04�����ʧ�ܣ�
            resultCode = (byte)reader.Read();
        }
    }
}