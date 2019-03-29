using Rabbit.WeiXin.MP.Messages.Request;
using System;
using System.Xml.Linq;

namespace Rabbit.WeiXin.MP.Serialization.Providers.Request
{
    internal sealed class TextMessageFormatter : XmlMessageFormatterBase<RequestMessageText>
    {
        
        public override RequestMessageText Deserialize(XContainer container)
        {
            return SetBaseInfo(container, new RequestMessageText
            {
                Content = GetValue(container, "Content")
            });
        }

        public override string Serialize(RequestMessageText graph)
        {
            throw new NotImplementedException();
        }

            }
}