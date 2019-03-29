using Rabbit.WeiXin.MP.Messages.Events.CustomService;
using System;
using System.Xml.Linq;

namespace Rabbit.WeiXin.MP.Serialization.Providers.Event.CustomService
{
    internal sealed class CreateSessionMessageFormatter : XmlMessageFormatterBase<CreateSessionMessage>
    {
        
        public override CreateSessionMessage Deserialize(XContainer container)
        {
            return SetBaseInfo(container, new CreateSessionMessage
            {
                Account = GetValue(container, "KfAccount")
            });
        }

        public override string Serialize(CreateSessionMessage graph)
        {
            throw new NotImplementedException();
        }

            }
}