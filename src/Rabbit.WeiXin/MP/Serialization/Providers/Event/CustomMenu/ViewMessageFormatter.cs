using Rabbit.WeiXin.MP.Messages.Events.CustomMenu;
using System;
using System.Xml.Linq;

namespace Rabbit.WeiXin.MP.Serialization.Providers.Event.CustomMenu
{
    internal sealed class ViewMessageFormatter : XmlMessageFormatterBase<ViewMessage>
    {
        
        public override ViewMessage Deserialize(XContainer container)
        {
            return SetBaseInfo(container, new ViewMessage
            {
                EventKey = GetValue(container, "EventKey")
            });
        }

        public override string Serialize(ViewMessage graph)
        {
            throw new NotImplementedException();
        }

            }
}