namespace Rabbit.WeiXin.MP.Messages.Request
{
    /// <summary>
    /// 短视频请求消息。
    /// </summary>
    public class RequestMessageShortVideo : RequestMessageBase, IMediaMessage
    {
        /// <summary>
        /// 视频消息缩略图的媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string ThumbMediaId { get; set; }

        
        /// <summary>
        /// 消息类型。
        /// </summary>
        public override RequestMessageType MessageType
        {
            get { return RequestMessageType.ShortVideo; }
        }

        
        
        /// <summary>
        /// 媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string MediaId { get; set; }

            }
}