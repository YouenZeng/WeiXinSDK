using Rabbit.WeiXin.MP.Messages.Events.CustomMenu;
using System;
using System.Xml.Linq;

namespace Rabbit.WeiXin.MP.Serialization.Providers.Event.CustomMenu
{
    internal sealed class ClickMessageFormatter : XmlMessageFormatterBase<ClickMessage>
    {
        
        public override ClickMessage Deserialize(XContainer container)
        {
            return SetBaseInfo(container, new ClickMessage
            {
                EventKey = GetValue(container, "EventKey")
            });
        }

        public override string Serialize(ClickMessage graph)
        {
            throw new NotImplementedException();
        }

            }
}