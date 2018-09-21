namespace QQ.Framework.Packets.Receive.Message
{
    /// <summary>
    ///     发送消息应答
    /// </summary>
    public class Receive_0x0002 : ReceivePacket
    {
        /// <summary>
        /// </summary>
        public Receive_0x0002(byte[] byteBuffer, QQUser User)
            : base(byteBuffer, User, User.TXProtocol.SessionKey)
        {
        }

        protected override void ParseBody()
        {
            Decrypt(user.TXProtocol.SessionKey);
            reader.ReadBytes(4);
        }
    }
}