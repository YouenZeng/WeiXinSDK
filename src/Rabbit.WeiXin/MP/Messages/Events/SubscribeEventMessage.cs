namespace Rabbit.WeiXin.MP.Messages.Events
{
    /// <summary>
    /// 订阅事件消息。
    /// </summary>
    public sealed class SubscribeEventMessage : EventMessageBase
    {
        
        /// <summary>
        /// 事件类型。
        /// </summary>
        public override EventType EventType
        {
            get { return EventType.Subscribe; }
        }

            }
}