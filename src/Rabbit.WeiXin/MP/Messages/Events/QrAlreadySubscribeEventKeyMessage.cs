﻿namespace Rabbit.WeiXin.MP.Messages.Events
{
    /// <summary>
    /// 已经订阅事件消息。
    /// </summary>
    public sealed class QrAlreadySubscribeEventKeyMessage : QrEventKeyMessageBase
    {
        
        /// <summary>
        /// 事件类型。
        /// </summary>
        public override EventType EventType
        {
            get { return EventType.Scan; }
        }

            }
}