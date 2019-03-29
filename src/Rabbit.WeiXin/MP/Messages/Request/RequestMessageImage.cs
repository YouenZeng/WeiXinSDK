using System;

namespace Rabbit.WeiXin.MP.Messages.Request
{
    /// <summary>
    /// 图片请求消息。
    /// </summary>
    public class RequestMessageImage : RequestMessageBase, IMediaMessage
    {
        /// <summary>
        /// 图片链接
        /// </summary>
        public Uri PicUrl { get; set; }

        
        /// <summary>
        /// 消息类型。
        /// </summary>
        public override RequestMessageType MessageType
        {
            get { return RequestMessageType.Image; }
        }

        
        
        /// <summary>
        /// 媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string MediaId { get; set; }

            }
}