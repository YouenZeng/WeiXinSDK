using Rabbit.WeiXin.MP.Messages.Events.CustomMenu;
using System;
using System.Xml.Linq;

namespace Rabbit.WeiXin.MP.Serialization.Providers.Event.CustomMenu
{
    internal sealed class LocationSelectMessageFormatter : XmlMessageFormatterBase<LocationSelectMessage>
    {
        
        public override LocationSelectMessage Deserialize(XContainer container)
        {
            var info = container.Element("SendLocationInfo");
            return SetBaseInfo(container, new LocationSelectMessage
            {
                EventKey = GetValue(container, "EventKey"),
                X = GetDouble(info, "Location_X"),
                Y = GetDouble(info, "Location_Y"),
                Scale = GetUInt(info, "Scale"),
                Label = GetValue(info, "Label"),
                Poiname = GetValue(info, "Poiname")
            });
        }

        public override string Serialize(LocationSelectMessage graph)
        {
            throw new NotImplementedException();
        }

            }
}