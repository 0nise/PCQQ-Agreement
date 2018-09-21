namespace QQ.Framework.Packets.Receive.Interactive
{
    public class Receive_0x0115 : ReceivePacket
    {
        /// <summary>
        ///     ������Ӻ�����Ϣ��ִ
        /// </summary>
        public Receive_0x0115(byte[] byteBuffer, QQUser User)
            : base(byteBuffer, User, User.TXProtocol.SessionKey)
        {
        }

        public AddFriendType addFriendType { get; set; }

        protected override void ParseBody()
        {
            Decrypt(user.TXProtocol.SessionKey);
            reader.ReadBytes(28);
            user.AddFriend_0018Value = reader.ReadBytes(24);
        }
    }
}