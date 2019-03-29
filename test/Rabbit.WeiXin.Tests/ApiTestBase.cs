using Rabbit.WeiXin.MP.Api;

namespace Rabbit.WeiXin.Tests
{
    public class ApiTestBase
    {
        
        //请自行配置。
        private const string AppId = "xxxxxxxx";

        //请自行配置。
        private const string AppSecret = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

        //请自行配置。
        protected const string OpenId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

        protected readonly ICommonService CommonService;

        protected AccountModel AccountModel;

        
        
        public ApiTestBase()
        {
            AccountModel = new AccountModel
            {
                AppId = AppId,
                AppSecret = AppSecret,
                GetAccessToken = GetAccessToken
            };
            CommonService = new CommonService(AccountModel);
        }

        
        
        protected string GetAccessToken()
        {
            return CommonService.GetAccessToken().AccessToken;
        }

            }
}