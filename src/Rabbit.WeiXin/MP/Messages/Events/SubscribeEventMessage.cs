namespace Rabbit.WeiXin.MP.Messages.Events
{
    /// <summary>
    /// �����¼���Ϣ��
    /// </summary>
    public sealed class SubscribeEventMessage : EventMessageBase
    {
        
        /// <summary>
        /// �¼����͡�
        /// </summary>
        public override EventType EventType
        {
            get { return EventType.Subscribe; }
        }

            }
}