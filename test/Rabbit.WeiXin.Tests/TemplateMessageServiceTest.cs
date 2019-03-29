using Xunit;
using Rabbit.WeiXin.MP.Api.TemplateMessage;

namespace Rabbit.WeiXin.Tests
{
    
    public class TemplateMessageServiceTest : ApiTestBase
    {
        
        private readonly ITemplateMessageService _templateMessageService;

        
        
        public TemplateMessageServiceTest()
        {
            _templateMessageService = new TemplateMessageService(AccountModel);
        }

        
        
        [Fact]
        public void SendTest()
        {
            _templateMessageService.Send(OpenId, "4Hdi5ry8Hxb6HtEHTTrEd7yLgAIrRLG4-6t55ammLS0", "http://cn.bing.com", "#FF0000", new
            {
                first = new TemplateMessageFieldDataItem("您好，您对微信影城影票的抢购未成功，已退款。", "#173177"),
                reason = new TemplateMessageFieldDataItem("未抢购成功"),
                refund = new TemplateMessageFieldDataItem("70元"),
                remark = new TemplateMessageFieldDataItem("如有疑问，请致电13912345678联系我们，或回复M来了解详情。")
            });
        }

            }
}