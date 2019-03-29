﻿using System;

namespace Rabbit.WeiXin.MP.Messages.Events.WiFi
{
    /// <summary>
    /// WiFi连接成功时的事件消息。
    /// </summary>
    public class ConnectedMessage : EventMessageBase
    {
        
        /// <summary>
        /// 事件类型。
        /// </summary>
        public override EventType EventType { get { return EventType.WifiConnected; } }

        
        /// <summary>
        /// 连网时间。
        /// </summary>
        public DateTime ConnectTime { get; set; }

        /// <summary>
        /// 连网的门店id。
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        /// 连网的设备无线mac地址，对应bssid。
        /// </summary>
        public string DeviceNo { get; set; }
    }
}