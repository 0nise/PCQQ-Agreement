namespace QQ.Framework.Packets.Receive.Interactive
{
    public class Receive_0x00A7 : ReceivePacket
    {
        /// <summary>
        ///     �ı�����״̬
        /// </summary>
        public Receive_0x00A7(byte[] byteBuffer, QQUser User)
            : base(byteBuffer, User, User.QQ_SessionKey)
        {
        }

        protected override void ParseBody()
        {
            Decrypt(user.QQ_SessionKey);
        }
    }
}