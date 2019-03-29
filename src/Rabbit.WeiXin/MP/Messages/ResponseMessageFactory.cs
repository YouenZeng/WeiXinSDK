using Rabbit.WeiXin.MP.Messages.Response;
using Rabbit.WeiXin.MP.Serialization;

namespace Rabbit.WeiXin.MP.Messages
{
    /// <summary>
    /// 一个抽象的响应消息工厂。
    /// </summary>
    public interface IResponseMessageFactory
    {
        /// <summary>
        /// 根据相应消息得到xml内容。
        /// </summary>
        /// <param name="responseMessage">响应消息实例。</param>
        /// <returns>xml内容。</returns>
        string GetXmlByReponseMessage(IResponseMessage responseMessage);
    }

    /// <summary>
    /// 响应消息工厂实现。
    /// </summary>
    internal sealed class ResponseMessageFactory : IResponseMessageFactory
    {
        
        private readonly IMessageFormatterFactory _messageFormatterFactory;

        
        
        public ResponseMessageFactory(IMessageFormatterFactory messageFormatterFactory)
        {
            _messageFormatterFactory = messageFormatterFactory;
        }

        
        
        /// <summary>
        /// 根据相应消息得到xml内容。
        /// </summary>
        /// <param name="responseMessage">响应消息实例。</param>
        /// <returns>xml内容。</returns>
        public string GetXmlByReponseMessage(IResponseMessage responseMessage)
        {
            return _messageFormatterFactory.GetFormatter(responseMessage.MessageType).Serialize(responseMessage);
        }

            }
}