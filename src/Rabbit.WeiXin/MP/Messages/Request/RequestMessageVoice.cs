namespace Rabbit.WeiXin.MP.Messages.Request
{
    /// <summary>
    /// 语音请求消息。
    /// </summary>
    public class RequestMessageVoice : RequestMessageBase, IMediaMessage
    {
        /// <summary>
        /// 语音格式，如amr，speex等
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// 语音识别结果，UTF8编码
        /// </summary>
        public string Recognition { get; set; }

        
        /// <summary>
        /// 消息类型。
        /// </summary>
        public override RequestMessageType MessageType
        {
            get { return RequestMessageType.Voice; }
        }

        
        
        /// <summary>
        /// 媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string MediaId { get; set; }

            }
}