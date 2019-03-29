using Rabbit.WeiXin.DependencyInjection;
using Rabbit.WeiXin.MP.Messages;
using System.Threading.Tasks;
using Tencent;

namespace Rabbit.WeiXin.Handlers.Impl
{
    /// <summary>
    /// ����������Ϣģ���м���������Ϣ���������Ƚ��н��ܲ�������
    /// </summary>
    public sealed class CreateRequestMessageHandlerMiddleware : HandlerMiddleware
    {
        /// <summary>
        /// ��ʼ��һ���µĴ����м����
        /// </summary>
        /// <param name="next">��һ�������м����</param>
        public CreateRequestMessageHandlerMiddleware(HandlerMiddleware next)
            : base(next)
        {
        }

        
        /// <summary>
        /// ���á�
        /// </summary>
        /// <param name="context">���������ġ�</param>
        /// <returns>����</returns>
        public override Task Invoke(IHandlerContext context)
        {
            var dependencyResolver = context.GetDependencyResolver();
            var requestMessageFactory = dependencyResolver.GetService<IRequestMessageFactory>();

            var content = context.Content;
            var parameters = context.GetRequestParameters();

            
            if (parameters.ContainsKey("encrypt_type"))
            {
                var nonce = parameters["nonce"];
                var signature = parameters["msg_signature"];
                var timestamp = parameters["timestamp"];

                var baseInfo = context.GetMessageHandlerBaseInfo();
                var appId = baseInfo.AppId;
                var encodingAesKey = baseInfo.EncodingAesKey;
                var token = baseInfo.Token;

                var wxBizMsgCrypt = new WXBizMsgCrypt(token, encodingAesKey, appId);
                wxBizMsgCrypt.DecryptMsg(signature, timestamp, nonce, content, ref content);
            }

            
            context.SetRequestMessage(requestMessageFactory.CreateRequestMessage(content));

            return Next.Invoke(context);
        }

            }
}