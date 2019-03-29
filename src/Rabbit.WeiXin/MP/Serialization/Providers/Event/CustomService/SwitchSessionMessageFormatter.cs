using Rabbit.WeiXin.MP.Messages.Events.CustomService;
using System;
using System.Xml.Linq;

namespace Rabbit.WeiXin.MP.Serialization.Providers.Event.CustomService
{
    internal sealed class SwitchSessionMessageFormatter : XmlMessageFormatterBase<SwitchSessionMessage>
    {
        
        public override SwitchSessionMessage Deserialize(XContainer container)
        {
            return SetBaseInfo(container, new SwitchSessionMessage
            {
                FromAccount = GetValue(container, "FromKfAccount"),
                ToAccount = GetValue(container, "ToKfAccount"),
            });
        }

        public override string Serialize(SwitchSessionMessage graph)
        {
            throw new NotImplementedException();
        }

            }
}