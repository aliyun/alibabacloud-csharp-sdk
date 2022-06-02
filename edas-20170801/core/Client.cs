// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Edas20170801.Models;

namespace AlibabaCloud.SDK.Edas20170801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "edas.ap-northeast-1.aliyuncs.com"},
                {"ap-south-1", "edas.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-3", "edas.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-5", "edas.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "edas.aliyuncs.com"},
                {"cn-beijing-finance-pop", "edas.aliyuncs.com"},
                {"cn-beijing-gov-1", "edas.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "edas.aliyuncs.com"},
                {"cn-chengdu", "edas.aliyuncs.com"},
                {"cn-edge-1", "edas.aliyuncs.com"},
                {"cn-fujian", "edas.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "edas.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "edas.aliyuncs.com"},
                {"cn-hangzhou-finance", "edas.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "edas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "edas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "edas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "edas.aliyuncs.com"},
                {"cn-hangzhou-test-306", "edas.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "edas.aliyuncs.com"},
                {"cn-huhehaote", "edas.aliyuncs.com"},
                {"cn-qingdao-nebula", "edas.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "edas.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "edas.aliyuncs.com"},
                {"cn-shanghai-finance-1", "edas.aliyuncs.com"},
                {"cn-shanghai-inner", "edas.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "edas.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "edas.aliyuncs.com"},
                {"cn-shenzhen-inner", "edas.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "edas.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "edas.aliyuncs.com"},
                {"cn-wuhan", "edas.aliyuncs.com"},
                {"cn-yushanfang", "edas.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "edas.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "edas.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "edas.aliyuncs.com"},
                {"eu-west-1", "edas.ap-northeast-1.aliyuncs.com"},
                {"eu-west-1-oxs", "edas.ap-northeast-1.aliyuncs.com"},
                {"me-east-1", "edas.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "edas.ap-northeast-1.aliyuncs.com"},
                {"us-west-1", "edas.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("edas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        public AbortAndRollbackChangeOrderResponse AbortAndRollbackChangeOrder(AbortAndRollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortAndRollbackChangeOrderWithOptions(request, headers, runtime);
        }

        public async Task<AbortAndRollbackChangeOrderResponse> AbortAndRollbackChangeOrderAsync(AbortAndRollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortAndRollbackChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        public AbortAndRollbackChangeOrderResponse AbortAndRollbackChangeOrderWithOptions(AbortAndRollbackChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortAndRollbackChangeOrder",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/change_order_abort_and_rollback",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortAndRollbackChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AbortAndRollbackChangeOrderResponse> AbortAndRollbackChangeOrderWithOptionsAsync(AbortAndRollbackChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortAndRollbackChangeOrder",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/change_order_abort_and_rollback",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortAndRollbackChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AbortChangeOrderResponse AbortChangeOrder(AbortChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortChangeOrderWithOptions(request, headers, runtime);
        }

        public async Task<AbortChangeOrderResponse> AbortChangeOrderAsync(AbortChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        public AbortChangeOrderResponse AbortChangeOrderWithOptions(AbortChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortChangeOrder",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/change_order_abort",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AbortChangeOrderResponse> AbortChangeOrderWithOptionsAsync(AbortChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortChangeOrder",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/change_order_abort",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddLogPathResponse AddLogPath(AddLogPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddLogPathWithOptions(request, headers, runtime);
        }

        public async Task<AddLogPathResponse> AddLogPathAsync(AddLogPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddLogPathWithOptionsAsync(request, headers, runtime);
        }

        public AddLogPathResponse AddLogPathWithOptions(AddLogPathRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLogPath",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/log/popListLogDirs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLogPathResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddLogPathResponse> AddLogPathWithOptionsAsync(AddLogPathRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLogPath",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/log/popListLogDirs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLogPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddMockRuleResponse AddMockRule(AddMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddMockRuleWithOptions(request, headers, runtime);
        }

        public async Task<AddMockRuleResponse> AddMockRuleAsync(AddMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddMockRuleWithOptionsAsync(request, headers, runtime);
        }

        public AddMockRuleResponse AddMockRuleWithOptions(AddMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppsJson))
            {
                query["ConsumerAppsJson"] = request.ConsumerAppsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboMockItemJson))
            {
                query["DubboMockItemJson"] = request.DubboMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraJson))
            {
                query["ExtraJson"] = request.ExtraJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MockType))
            {
                query["MockType"] = request.MockType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppId))
            {
                query["ProviderAppId"] = request.ProviderAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppName))
            {
                query["ProviderAppName"] = request.ProviderAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScMockItemJson))
            {
                query["ScMockItemJson"] = request.ScMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/addMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMockRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddMockRuleResponse> AddMockRuleWithOptionsAsync(AddMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppsJson))
            {
                query["ConsumerAppsJson"] = request.ConsumerAppsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboMockItemJson))
            {
                query["DubboMockItemJson"] = request.DubboMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraJson))
            {
                query["ExtraJson"] = request.ExtraJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MockType))
            {
                query["MockType"] = request.MockType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppId))
            {
                query["ProviderAppId"] = request.ProviderAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppName))
            {
                query["ProviderAppName"] = request.ProviderAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScMockItemJson))
            {
                query["ScMockItemJson"] = request.ScMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/addMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMockRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AuthorizeApplicationResponse AuthorizeApplication(AuthorizeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AuthorizeApplicationWithOptions(request, headers, runtime);
        }

        public async Task<AuthorizeApplicationResponse> AuthorizeApplicationAsync(AuthorizeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AuthorizeApplicationWithOptionsAsync(request, headers, runtime);
        }

        public AuthorizeApplicationResponse AuthorizeApplicationWithOptions(AuthorizeApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/authorize_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AuthorizeApplicationResponse> AuthorizeApplicationWithOptionsAsync(AuthorizeApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/authorize_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AuthorizeResourceGroupResponse AuthorizeResourceGroup(AuthorizeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AuthorizeResourceGroupWithOptions(request, headers, runtime);
        }

        public async Task<AuthorizeResourceGroupResponse> AuthorizeResourceGroupAsync(AuthorizeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AuthorizeResourceGroupWithOptionsAsync(request, headers, runtime);
        }

        public AuthorizeResourceGroupResponse AuthorizeResourceGroupWithOptions(AuthorizeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeResourceGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/authorize_res_group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AuthorizeResourceGroupResponse> AuthorizeResourceGroupWithOptionsAsync(AuthorizeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeResourceGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/authorize_res_group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AuthorizeRoleResponse AuthorizeRole(AuthorizeRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AuthorizeRoleWithOptions(request, headers, runtime);
        }

        public async Task<AuthorizeRoleResponse> AuthorizeRoleAsync(AuthorizeRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AuthorizeRoleWithOptionsAsync(request, headers, runtime);
        }

        public AuthorizeRoleResponse AuthorizeRoleWithOptions(AuthorizeRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                query["RoleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/authorize_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AuthorizeRoleResponse> AuthorizeRoleWithOptionsAsync(AuthorizeRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                query["RoleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/authorize_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindEcsSlbResponse BindEcsSlb(BindEcsSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BindEcsSlbWithOptions(request, headers, runtime);
        }

        public async Task<BindEcsSlbResponse> BindEcsSlbAsync(BindEcsSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BindEcsSlbWithOptionsAsync(request, headers, runtime);
        }

        public BindEcsSlbResponse BindEcsSlbWithOptions(BindEcsSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployGroupId))
            {
                query["DeployGroupId"] = request.DeployGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerHealthCheckUrl))
            {
                query["ListenerHealthCheckUrl"] = request.ListenerHealthCheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VForwardingUrlRule))
            {
                query["VForwardingUrlRule"] = request.VForwardingUrlRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupName))
            {
                query["VServerGroupName"] = request.VServerGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEcsSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/slb/bind_slb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEcsSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindEcsSlbResponse> BindEcsSlbWithOptionsAsync(BindEcsSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployGroupId))
            {
                query["DeployGroupId"] = request.DeployGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerHealthCheckUrl))
            {
                query["ListenerHealthCheckUrl"] = request.ListenerHealthCheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VForwardingUrlRule))
            {
                query["VForwardingUrlRule"] = request.VForwardingUrlRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupName))
            {
                query["VServerGroupName"] = request.VServerGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEcsSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/slb/bind_slb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEcsSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindK8sSlbResponse BindK8sSlb(BindK8sSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BindK8sSlbWithOptions(request, headers, runtime);
        }

        public async Task<BindK8sSlbResponse> BindK8sSlbAsync(BindK8sSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BindK8sSlbWithOptionsAsync(request, headers, runtime);
        }

        public BindK8sSlbResponse BindK8sSlbWithOptions(BindK8sSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePortInfos))
            {
                query["ServicePortInfos"] = request.ServicePortInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbProtocol))
            {
                query["SlbProtocol"] = request.SlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindK8sSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_slb_binding",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindK8sSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindK8sSlbResponse> BindK8sSlbWithOptionsAsync(BindK8sSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePortInfos))
            {
                query["ServicePortInfos"] = request.ServicePortInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbProtocol))
            {
                query["SlbProtocol"] = request.SlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindK8sSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_slb_binding",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindK8sSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindSlbResponse BindSlb(BindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BindSlbWithOptions(request, headers, runtime);
        }

        public async Task<BindSlbResponse> BindSlbAsync(BindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BindSlbWithOptionsAsync(request, headers, runtime);
        }

        public BindSlbResponse BindSlbWithOptions(BindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbIp))
            {
                query["SlbIp"] = request.SlbIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/app/bind_slb_json",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindSlbResponse> BindSlbWithOptionsAsync(BindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbIp))
            {
                query["SlbIp"] = request.SlbIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/app/bind_slb_json",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeDeployGroupResponse ChangeDeployGroup(ChangeDeployGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeDeployGroupWithOptions(request, headers, runtime);
        }

        public async Task<ChangeDeployGroupResponse> ChangeDeployGroupAsync(ChangeDeployGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeDeployGroupWithOptionsAsync(request, headers, runtime);
        }

        public ChangeDeployGroupResponse ChangeDeployGroupWithOptions(ChangeDeployGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStatus))
            {
                query["ForceStatus"] = request.ForceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDeployGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_change_group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDeployGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeDeployGroupResponse> ChangeDeployGroupWithOptionsAsync(ChangeDeployGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStatus))
            {
                query["ForceStatus"] = request.ForceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDeployGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_change_group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDeployGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ContinuePipelineResponse ContinuePipeline(ContinuePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ContinuePipelineWithOptions(request, headers, runtime);
        }

        public async Task<ContinuePipelineResponse> ContinuePipelineAsync(ContinuePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ContinuePipelineWithOptionsAsync(request, headers, runtime);
        }

        public ContinuePipelineResponse ContinuePipelineWithOptions(ContinuePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Confirm))
            {
                query["Confirm"] = request.Confirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinuePipeline",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/pipeline_batch_confirm",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinuePipelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ContinuePipelineResponse> ContinuePipelineWithOptionsAsync(ContinuePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Confirm))
            {
                query["Confirm"] = request.Confirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinuePipeline",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/pipeline_batch_confirm",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinuePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConvertK8sResourceResponse ConvertK8sResource(ConvertK8sResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConvertK8sResourceWithOptions(request, headers, runtime);
        }

        public async Task<ConvertK8sResourceResponse> ConvertK8sResourceAsync(ConvertK8sResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConvertK8sResourceWithOptionsAsync(request, headers, runtime);
        }

        public ConvertK8sResourceResponse ConvertK8sResourceWithOptions(ConvertK8sResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertK8sResource",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/k8s_resource_convert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertK8sResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConvertK8sResourceResponse> ConvertK8sResourceWithOptionsAsync(ConvertK8sResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertK8sResource",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/k8s_resource_convert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertK8sResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateApplicationScalingRuleResponse CreateApplicationScalingRule(CreateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<CreateApplicationScalingRuleResponse> CreateApplicationScalingRuleAsync(CreateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public CreateApplicationScalingRuleResponse CreateApplicationScalingRuleWithOptions(CreateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleEnable))
            {
                query["ScalingRuleEnable"] = request.ScalingRuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTrigger))
            {
                query["ScalingRuleTrigger"] = request.ScalingRuleTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/application_scaling_rule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateApplicationScalingRuleResponse> CreateApplicationScalingRuleWithOptionsAsync(CreateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleEnable))
            {
                query["ScalingRuleEnable"] = request.ScalingRuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTrigger))
            {
                query["ScalingRuleTrigger"] = request.ScalingRuleTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/application_scaling_rule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateConfigTemplateResponse CreateConfigTemplate(CreateConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigTemplateWithOptions(request, headers, runtime);
        }

        public async Task<CreateConfigTemplateResponse> CreateConfigTemplateAsync(CreateConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigTemplateWithOptionsAsync(request, headers, runtime);
        }

        public CreateConfigTemplateResponse CreateConfigTemplateWithOptions(CreateConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigTemplate",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/config_template",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateConfigTemplateResponse> CreateConfigTemplateWithOptionsAsync(CreateConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigTemplate",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/config_template",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIDCImportCommandResponse CreateIDCImportCommand(CreateIDCImportCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIDCImportCommandWithOptions(request, headers, runtime);
        }

        public async Task<CreateIDCImportCommandResponse> CreateIDCImportCommandAsync(CreateIDCImportCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIDCImportCommandWithOptionsAsync(request, headers, runtime);
        }

        public CreateIDCImportCommandResponse CreateIDCImportCommandWithOptions(CreateIDCImportCommandRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIDCImportCommand",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/create_idc_import_command",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIDCImportCommandResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIDCImportCommandResponse> CreateIDCImportCommandWithOptionsAsync(CreateIDCImportCommandRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIDCImportCommand",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/create_idc_import_command",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIDCImportCommandResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateK8sConfigMapResponse CreateK8sConfigMap(CreateK8sConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateK8sConfigMapWithOptions(request, headers, runtime);
        }

        public async Task<CreateK8sConfigMapResponse> CreateK8sConfigMapAsync(CreateK8sConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateK8sConfigMapWithOptionsAsync(request, headers, runtime);
        }

        public CreateK8sConfigMapResponse CreateK8sConfigMapWithOptions(CreateK8sConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateK8sConfigMap",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_config_map",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateK8sConfigMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateK8sConfigMapResponse> CreateK8sConfigMapWithOptionsAsync(CreateK8sConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateK8sConfigMap",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_config_map",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateK8sConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateK8sIngressRuleResponse CreateK8sIngressRule(CreateK8sIngressRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateK8sIngressRuleWithOptions(request, headers, runtime);
        }

        public async Task<CreateK8sIngressRuleResponse> CreateK8sIngressRuleAsync(CreateK8sIngressRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateK8sIngressRuleWithOptionsAsync(request, headers, runtime);
        }

        public CreateK8sIngressRuleResponse CreateK8sIngressRuleWithOptions(CreateK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConf))
            {
                query["IngressConf"] = request.IngressConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateK8sIngressRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_ingress",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateK8sIngressRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateK8sIngressRuleResponse> CreateK8sIngressRuleWithOptionsAsync(CreateK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConf))
            {
                query["IngressConf"] = request.IngressConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateK8sIngressRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_ingress",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateK8sIngressRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateK8sSecretResponse CreateK8sSecret(CreateK8sSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateK8sSecretWithOptions(request, headers, runtime);
        }

        public async Task<CreateK8sSecretResponse> CreateK8sSecretAsync(CreateK8sSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateK8sSecretWithOptionsAsync(request, headers, runtime);
        }

        public CreateK8sSecretResponse CreateK8sSecretWithOptions(CreateK8sSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Base64Encoded))
            {
                body["Base64Encoded"] = request.Base64Encoded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                body["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRegionId))
            {
                body["CertRegionId"] = request.CertRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateK8sSecret",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_secret",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateK8sSecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateK8sSecretResponse> CreateK8sSecretWithOptionsAsync(CreateK8sSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Base64Encoded))
            {
                body["Base64Encoded"] = request.Base64Encoded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                body["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRegionId))
            {
                body["CertRegionId"] = request.CertRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateK8sSecret",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_secret",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateK8sSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateK8sServiceResponse CreateK8sService(CreateK8sServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateK8sServiceWithOptions(request, headers, runtime);
        }

        public async Task<CreateK8sServiceResponse> CreateK8sServiceAsync(CreateK8sServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateK8sServiceWithOptionsAsync(request, headers, runtime);
        }

        public CreateK8sServiceResponse CreateK8sServiceWithOptions(CreateK8sServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePorts))
            {
                query["ServicePorts"] = request.ServicePorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateK8sService",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_service",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateK8sServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateK8sServiceResponse> CreateK8sServiceWithOptionsAsync(CreateK8sServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePorts))
            {
                query["ServicePorts"] = request.ServicePorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateK8sService",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_service",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateK8sServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationWithOptions(request, headers, runtime);
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationWithOptionsAsync(request, headers, runtime);
        }

        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_delete_app",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_delete_app",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteApplicationScalingRuleResponse DeleteApplicationScalingRule(DeleteApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteApplicationScalingRuleResponse> DeleteApplicationScalingRuleAsync(DeleteApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteApplicationScalingRuleResponse DeleteApplicationScalingRuleWithOptions(DeleteApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/application_scaling_rule",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteApplicationScalingRuleResponse> DeleteApplicationScalingRuleWithOptionsAsync(DeleteApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/application_scaling_rule",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteClusterWithOptions(request, headers, runtime);
        }

        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteClusterWithOptionsAsync(request, headers, runtime);
        }

        public DeleteClusterResponse DeleteClusterWithOptions(DeleteClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(DeleteClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteClusterMemberResponse DeleteClusterMember(DeleteClusterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteClusterMemberWithOptions(request, headers, runtime);
        }

        public async Task<DeleteClusterMemberResponse> DeleteClusterMemberAsync(DeleteClusterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteClusterMemberWithOptionsAsync(request, headers, runtime);
        }

        public DeleteClusterMemberResponse DeleteClusterMemberWithOptions(DeleteClusterMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterMemberId))
            {
                query["ClusterMemberId"] = request.ClusterMemberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterMember",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster_member",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteClusterMemberResponse> DeleteClusterMemberWithOptionsAsync(DeleteClusterMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterMemberId))
            {
                query["ClusterMemberId"] = request.ClusterMemberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterMember",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster_member",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteConfigTemplateResponse DeleteConfigTemplate(DeleteConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigTemplateWithOptions(request, headers, runtime);
        }

        public async Task<DeleteConfigTemplateResponse> DeleteConfigTemplateAsync(DeleteConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigTemplateWithOptionsAsync(request, headers, runtime);
        }

        public DeleteConfigTemplateResponse DeleteConfigTemplateWithOptions(DeleteConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigTemplate",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/config_template",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteConfigTemplateResponse> DeleteConfigTemplateWithOptionsAsync(DeleteConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigTemplate",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/config_template",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDeployGroupResponse DeleteDeployGroup(DeleteDeployGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDeployGroupWithOptions(request, headers, runtime);
        }

        public async Task<DeleteDeployGroupResponse> DeleteDeployGroupAsync(DeleteDeployGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDeployGroupWithOptionsAsync(request, headers, runtime);
        }

        public DeleteDeployGroupResponse DeleteDeployGroupWithOptions(DeleteDeployGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeployGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/deploy_group",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeployGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDeployGroupResponse> DeleteDeployGroupWithOptionsAsync(DeleteDeployGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeployGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/deploy_group",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeployGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEcuResponse DeleteEcu(DeleteEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEcuWithOptions(request, headers, runtime);
        }

        public async Task<DeleteEcuResponse> DeleteEcuAsync(DeleteEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEcuWithOptionsAsync(request, headers, runtime);
        }

        public DeleteEcuResponse DeleteEcuWithOptions(DeleteEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuId))
            {
                query["EcuId"] = request.EcuId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/delete_ecu",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEcuResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEcuResponse> DeleteEcuWithOptionsAsync(DeleteEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuId))
            {
                query["EcuId"] = request.EcuId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/delete_ecu",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEcuResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteK8sApplicationResponse DeleteK8sApplication(DeleteK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteK8sApplicationWithOptions(request, headers, runtime);
        }

        public async Task<DeleteK8sApplicationResponse> DeleteK8sApplicationAsync(DeleteK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteK8sApplicationWithOptionsAsync(request, headers, runtime);
        }

        public DeleteK8sApplicationResponse DeleteK8sApplicationWithOptions(DeleteK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_apps",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteK8sApplicationResponse> DeleteK8sApplicationWithOptionsAsync(DeleteK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_apps",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteK8sConfigMapResponse DeleteK8sConfigMap(DeleteK8sConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteK8sConfigMapWithOptions(request, headers, runtime);
        }

        public async Task<DeleteK8sConfigMapResponse> DeleteK8sConfigMapAsync(DeleteK8sConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteK8sConfigMapWithOptionsAsync(request, headers, runtime);
        }

        public DeleteK8sConfigMapResponse DeleteK8sConfigMapWithOptions(DeleteK8sConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sConfigMap",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_config_map",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sConfigMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteK8sConfigMapResponse> DeleteK8sConfigMapWithOptionsAsync(DeleteK8sConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sConfigMap",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_config_map",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteK8sIngressRuleResponse DeleteK8sIngressRule(DeleteK8sIngressRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteK8sIngressRuleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteK8sIngressRuleResponse> DeleteK8sIngressRuleAsync(DeleteK8sIngressRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteK8sIngressRuleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteK8sIngressRuleResponse DeleteK8sIngressRuleWithOptions(DeleteK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sIngressRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_ingress",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sIngressRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteK8sIngressRuleResponse> DeleteK8sIngressRuleWithOptionsAsync(DeleteK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sIngressRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_ingress",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sIngressRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteK8sSecretResponse DeleteK8sSecret(DeleteK8sSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteK8sSecretWithOptions(request, headers, runtime);
        }

        public async Task<DeleteK8sSecretResponse> DeleteK8sSecretAsync(DeleteK8sSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteK8sSecretWithOptionsAsync(request, headers, runtime);
        }

        public DeleteK8sSecretResponse DeleteK8sSecretWithOptions(DeleteK8sSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sSecret",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_secret",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sSecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteK8sSecretResponse> DeleteK8sSecretWithOptionsAsync(DeleteK8sSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sSecret",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_secret",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteK8sServiceResponse DeleteK8sService(DeleteK8sServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteK8sServiceWithOptions(request, headers, runtime);
        }

        public async Task<DeleteK8sServiceResponse> DeleteK8sServiceAsync(DeleteK8sServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteK8sServiceWithOptionsAsync(request, headers, runtime);
        }

        public DeleteK8sServiceResponse DeleteK8sServiceWithOptions(DeleteK8sServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sService",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_service",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteK8sServiceResponse> DeleteK8sServiceWithOptionsAsync(DeleteK8sServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteK8sService",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_service",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteK8sServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteLogPathResponse DeleteLogPath(DeleteLogPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLogPathWithOptions(request, headers, runtime);
        }

        public async Task<DeleteLogPathResponse> DeleteLogPathAsync(DeleteLogPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLogPathWithOptionsAsync(request, headers, runtime);
        }

        public DeleteLogPathResponse DeleteLogPathWithOptions(DeleteLogPathRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogPath",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/log/popListLogDirs",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLogPathResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteLogPathResponse> DeleteLogPathWithOptionsAsync(DeleteLogPathRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogPath",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/log/popListLogDirs",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLogPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRoleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRoleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteRoleResponse DeleteRoleWithOptions(DeleteRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/delete_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRoleResponse> DeleteRoleWithOptionsAsync(DeleteRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/delete_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceGroupResponse DeleteServiceGroup(DeleteServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<DeleteServiceGroupResponse> DeleteServiceGroupAsync(DeleteServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public DeleteServiceGroupResponse DeleteServiceGroupWithOptions(DeleteServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/serviceGroups",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceGroupResponse> DeleteServiceGroupWithOptionsAsync(DeleteServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/serviceGroups",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteUserDefineRegionResponse DeleteUserDefineRegion(DeleteUserDefineRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUserDefineRegionWithOptions(request, headers, runtime);
        }

        public async Task<DeleteUserDefineRegionResponse> DeleteUserDefineRegionAsync(DeleteUserDefineRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUserDefineRegionWithOptionsAsync(request, headers, runtime);
        }

        public DeleteUserDefineRegionResponse DeleteUserDefineRegionWithOptions(DeleteUserDefineRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserDefineRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/user_region_def",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserDefineRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteUserDefineRegionResponse> DeleteUserDefineRegionWithOptionsAsync(DeleteUserDefineRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserDefineRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/user_region_def",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserDefineRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeployApplicationResponse DeployApplication(DeployApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployApplicationWithOptions(request, headers, runtime);
        }

        public async Task<DeployApplicationResponse> DeployApplicationAsync(DeployApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployApplicationWithOptionsAsync(request, headers, runtime);
        }

        public DeployApplicationResponse DeployApplicationWithOptions(DeployApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppEnv))
            {
                query["AppEnv"] = request.AppEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Batch))
            {
                query["Batch"] = request.Batch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["ComponentIds"] = request.ComponentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gray))
            {
                query["Gray"] = request.Gray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseType))
            {
                query["ReleaseType"] = request.ReleaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlStrategy))
            {
                query["TrafficControlStrategy"] = request.TrafficControlStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarUrl))
            {
                query["WarUrl"] = request.WarUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeployApplicationResponse> DeployApplicationWithOptionsAsync(DeployApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppEnv))
            {
                query["AppEnv"] = request.AppEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Batch))
            {
                query["Batch"] = request.Batch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["ComponentIds"] = request.ComponentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gray))
            {
                query["Gray"] = request.Gray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseType))
            {
                query["ReleaseType"] = request.ReleaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlStrategy))
            {
                query["TrafficControlStrategy"] = request.TrafficControlStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarUrl))
            {
                query["WarUrl"] = request.WarUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeployK8sApplicationResponse DeployK8sApplication(DeployK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployK8sApplicationWithOptions(request, headers, runtime);
        }

        public async Task<DeployK8sApplicationResponse> DeployK8sApplicationAsync(DeployK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployK8sApplicationWithOptionsAsync(request, headers, runtime);
        }

        public DeployK8sApplicationResponse DeployK8sApplicationWithOptions(DeployK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                query["Annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                query["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTimeout))
            {
                query["BatchTimeout"] = request.BatchTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderDesc))
            {
                query["ChangeOrderDesc"] = request.ChangeOrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMountDescs))
            {
                query["ConfigMountDescs"] = request.ConfigMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                query["CpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuRequest))
            {
                query["CpuRequest"] = request.CpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAffinity))
            {
                query["CustomAffinity"] = request.CustomAffinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTolerations))
            {
                query["CustomTolerations"] = request.CustomTolerations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossNodes))
            {
                query["DeployAcrossNodes"] = request.DeployAcrossNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossZones))
            {
                query["DeployAcrossZones"] = request.DeployAcrossZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmptyDirs))
            {
                query["EmptyDirs"] = request.EmptyDirs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEmptyPushReject))
            {
                query["EnableEmptyPushReject"] = request.EnableEmptyPushReject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLosslessRule))
            {
                query["EnableLosslessRule"] = request.EnableLosslessRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvFroms))
            {
                query["EnvFroms"] = request.EnvFroms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTag))
            {
                query["ImageTag"] = request.ImageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JDK))
            {
                query["JDK"] = request.JDK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaStartUpConfig))
            {
                query["JavaStartUpConfig"] = request.JavaStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVolume))
            {
                query["LocalVolume"] = request.LocalVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleAligned))
            {
                query["LosslessRuleAligned"] = request.LosslessRuleAligned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleDelayTime))
            {
                query["LosslessRuleDelayTime"] = request.LosslessRuleDelayTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleFuncType))
            {
                query["LosslessRuleFuncType"] = request.LosslessRuleFuncType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleRelated))
            {
                query["LosslessRuleRelated"] = request.LosslessRuleRelated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleWarmupTime))
            {
                query["LosslessRuleWarmupTime"] = request.LosslessRuleWarmupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuLimit))
            {
                query["McpuLimit"] = request.McpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuRequest))
            {
                query["McpuRequest"] = request.McpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                query["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryRequest))
            {
                query["MemoryRequest"] = request.MemoryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDescs))
            {
                query["MountDescs"] = request.MountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersionId))
            {
                query["PackageVersionId"] = request.PackageVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvcMountDescs))
            {
                query["PvcMountDescs"] = request.PvcMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeClassName))
            {
                query["RuntimeClassName"] = request.RuntimeClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlStrategy))
            {
                query["TrafficControlStrategy"] = request.TrafficControlStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UriEncoding))
            {
                query["UriEncoding"] = request.UriEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumesStr))
            {
                query["VolumesStr"] = request.VolumesStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainerConfig))
            {
                query["WebContainerConfig"] = request.WebContainerConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_apps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployK8sApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeployK8sApplicationResponse> DeployK8sApplicationWithOptionsAsync(DeployK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                query["Annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                query["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTimeout))
            {
                query["BatchTimeout"] = request.BatchTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderDesc))
            {
                query["ChangeOrderDesc"] = request.ChangeOrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMountDescs))
            {
                query["ConfigMountDescs"] = request.ConfigMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                query["CpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuRequest))
            {
                query["CpuRequest"] = request.CpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAffinity))
            {
                query["CustomAffinity"] = request.CustomAffinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTolerations))
            {
                query["CustomTolerations"] = request.CustomTolerations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossNodes))
            {
                query["DeployAcrossNodes"] = request.DeployAcrossNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossZones))
            {
                query["DeployAcrossZones"] = request.DeployAcrossZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmptyDirs))
            {
                query["EmptyDirs"] = request.EmptyDirs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEmptyPushReject))
            {
                query["EnableEmptyPushReject"] = request.EnableEmptyPushReject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLosslessRule))
            {
                query["EnableLosslessRule"] = request.EnableLosslessRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvFroms))
            {
                query["EnvFroms"] = request.EnvFroms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTag))
            {
                query["ImageTag"] = request.ImageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JDK))
            {
                query["JDK"] = request.JDK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaStartUpConfig))
            {
                query["JavaStartUpConfig"] = request.JavaStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVolume))
            {
                query["LocalVolume"] = request.LocalVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleAligned))
            {
                query["LosslessRuleAligned"] = request.LosslessRuleAligned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleDelayTime))
            {
                query["LosslessRuleDelayTime"] = request.LosslessRuleDelayTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleFuncType))
            {
                query["LosslessRuleFuncType"] = request.LosslessRuleFuncType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleRelated))
            {
                query["LosslessRuleRelated"] = request.LosslessRuleRelated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleWarmupTime))
            {
                query["LosslessRuleWarmupTime"] = request.LosslessRuleWarmupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuLimit))
            {
                query["McpuLimit"] = request.McpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuRequest))
            {
                query["McpuRequest"] = request.McpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                query["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryRequest))
            {
                query["MemoryRequest"] = request.MemoryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDescs))
            {
                query["MountDescs"] = request.MountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersionId))
            {
                query["PackageVersionId"] = request.PackageVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvcMountDescs))
            {
                query["PvcMountDescs"] = request.PvcMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeClassName))
            {
                query["RuntimeClassName"] = request.RuntimeClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlStrategy))
            {
                query["TrafficControlStrategy"] = request.TrafficControlStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UriEncoding))
            {
                query["UriEncoding"] = request.UriEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumesStr))
            {
                query["VolumesStr"] = request.VolumesStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainerConfig))
            {
                query["WebContainerConfig"] = request.WebContainerConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_apps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployK8sApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppInstanceListResponse DescribeAppInstanceList(DescribeAppInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppInstanceListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppInstanceListResponse> DescribeAppInstanceListAsync(DescribeAppInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppInstanceListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppInstanceListResponse DescribeAppInstanceListWithOptions(DescribeAppInstanceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithNodeInfo))
            {
                query["WithNodeInfo"] = request.WithNodeInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppInstanceList",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/app_instance_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppInstanceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppInstanceListResponse> DescribeAppInstanceListWithOptionsAsync(DescribeAppInstanceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithNodeInfo))
            {
                query["WithNodeInfo"] = request.WithNodeInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppInstanceList",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/app_instance_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationScalingRulesResponse DescribeApplicationScalingRules(DescribeApplicationScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationScalingRulesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationScalingRulesResponse> DescribeApplicationScalingRulesAsync(DescribeApplicationScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationScalingRulesWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationScalingRulesResponse DescribeApplicationScalingRulesWithOptions(DescribeApplicationScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRules",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/application_scaling_rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationScalingRulesResponse> DescribeApplicationScalingRulesWithOptionsAsync(DescribeApplicationScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRules",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/application_scaling_rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableApplicationScalingRuleResponse DisableApplicationScalingRule(DisableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<DisableApplicationScalingRuleResponse> DisableApplicationScalingRuleAsync(DisableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public DisableApplicationScalingRuleResponse DisableApplicationScalingRuleWithOptions(DisableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/disable_application_scaling_rule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableApplicationScalingRuleResponse> DisableApplicationScalingRuleWithOptionsAsync(DisableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/disable_application_scaling_rule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableMockRuleResponse DisableMockRule(DisableMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableMockRuleWithOptions(request, headers, runtime);
        }

        public async Task<DisableMockRuleResponse> DisableMockRuleAsync(DisableMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableMockRuleWithOptionsAsync(request, headers, runtime);
        }

        public DisableMockRuleResponse DisableMockRuleWithOptions(DisableMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/disableMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableMockRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableMockRuleResponse> DisableMockRuleWithOptionsAsync(DisableMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/disableMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableMockRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableApplicationScalingRuleResponse EnableApplicationScalingRule(EnableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<EnableApplicationScalingRuleResponse> EnableApplicationScalingRuleAsync(EnableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public EnableApplicationScalingRuleResponse EnableApplicationScalingRuleWithOptions(EnableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/enable_application_scaling_rule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableApplicationScalingRuleResponse> EnableApplicationScalingRuleWithOptionsAsync(EnableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/enable_application_scaling_rule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableMockRuleResponse EnableMockRule(EnableMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableMockRuleWithOptions(request, headers, runtime);
        }

        public async Task<EnableMockRuleResponse> EnableMockRuleAsync(EnableMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableMockRuleWithOptionsAsync(request, headers, runtime);
        }

        public EnableMockRuleResponse EnableMockRuleWithOptions(EnableMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/enableMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableMockRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableMockRuleResponse> EnableMockRuleWithOptionsAsync(EnableMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/enableMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableMockRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAccountMockRuleResponse GetAccountMockRule(GetAccountMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAccountMockRuleWithOptions(request, headers, runtime);
        }

        public async Task<GetAccountMockRuleResponse> GetAccountMockRuleAsync(GetAccountMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAccountMockRuleWithOptionsAsync(request, headers, runtime);
        }

        public GetAccountMockRuleResponse GetAccountMockRuleWithOptions(GetAccountMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppName))
            {
                query["ConsumerAppName"] = request.ConsumerAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MockType))
            {
                query["MockType"] = request.MockType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppName))
            {
                query["ProviderAppName"] = request.ProviderAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/getAccountMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountMockRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAccountMockRuleResponse> GetAccountMockRuleWithOptionsAsync(GetAccountMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppName))
            {
                query["ConsumerAppName"] = request.ConsumerAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MockType))
            {
                query["MockType"] = request.MockType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppName))
            {
                query["ProviderAppName"] = request.ProviderAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/getAccountMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountMockRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAppDeploymentResponse GetAppDeployment(GetAppDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppDeploymentWithOptions(request, headers, runtime);
        }

        public async Task<GetAppDeploymentResponse> GetAppDeploymentAsync(GetAppDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppDeploymentWithOptionsAsync(request, headers, runtime);
        }

        public GetAppDeploymentResponse GetAppDeploymentWithOptions(GetAppDeploymentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppDeployment",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/app_deployment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppDeploymentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAppDeploymentResponse> GetAppDeploymentWithOptionsAsync(GetAppDeploymentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppDeployment",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/app_deployment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetApplicationWithOptions(request, headers, runtime);
        }

        public async Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetApplicationWithOptionsAsync(request, headers, runtime);
        }

        public GetApplicationResponse GetApplicationWithOptions(GetApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetApplicationResponse> GetApplicationWithOptionsAsync(GetApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetChangeOrderInfoResponse GetChangeOrderInfo(GetChangeOrderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetChangeOrderInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetChangeOrderInfoResponse> GetChangeOrderInfoAsync(GetChangeOrderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetChangeOrderInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetChangeOrderInfoResponse GetChangeOrderInfoWithOptions(GetChangeOrderInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChangeOrderInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/change_order_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeOrderInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetChangeOrderInfoResponse> GetChangeOrderInfoWithOptionsAsync(GetChangeOrderInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChangeOrderInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/change_order_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeOrderInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetClusterResponse GetCluster(GetClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterWithOptions(request, headers, runtime);
        }

        public async Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterWithOptionsAsync(request, headers, runtime);
        }

        public GetClusterResponse GetClusterWithOptions(GetClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetClusterResponse> GetClusterWithOptionsAsync(GetClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetContainerConfigurationResponse GetContainerConfiguration(GetContainerConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetContainerConfigurationWithOptions(request, headers, runtime);
        }

        public async Task<GetContainerConfigurationResponse> GetContainerConfigurationAsync(GetContainerConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetContainerConfigurationWithOptionsAsync(request, headers, runtime);
        }

        public GetContainerConfigurationResponse GetContainerConfigurationWithOptions(GetContainerConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContainerConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/container_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContainerConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetContainerConfigurationResponse> GetContainerConfigurationWithOptionsAsync(GetContainerConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContainerConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/container_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContainerConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJavaStartUpConfigResponse GetJavaStartUpConfig(GetJavaStartUpConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJavaStartUpConfigWithOptions(request, headers, runtime);
        }

        public async Task<GetJavaStartUpConfigResponse> GetJavaStartUpConfigAsync(GetJavaStartUpConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJavaStartUpConfigWithOptionsAsync(request, headers, runtime);
        }

        public GetJavaStartUpConfigResponse GetJavaStartUpConfigWithOptions(GetJavaStartUpConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJavaStartUpConfig",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/java_start_up_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJavaStartUpConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJavaStartUpConfigResponse> GetJavaStartUpConfigWithOptionsAsync(GetJavaStartUpConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJavaStartUpConfig",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/java_start_up_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJavaStartUpConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJvmConfigurationResponse GetJvmConfiguration(GetJvmConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJvmConfigurationWithOptions(request, headers, runtime);
        }

        public async Task<GetJvmConfigurationResponse> GetJvmConfigurationAsync(GetJvmConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJvmConfigurationWithOptionsAsync(request, headers, runtime);
        }

        public GetJvmConfigurationResponse GetJvmConfigurationWithOptions(GetJvmConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJvmConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_jvm_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJvmConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJvmConfigurationResponse> GetJvmConfigurationWithOptionsAsync(GetJvmConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJvmConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_jvm_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJvmConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetK8sApplicationResponse GetK8sApplication(GetK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetK8sApplicationWithOptions(request, headers, runtime);
        }

        public async Task<GetK8sApplicationResponse> GetK8sApplicationAsync(GetK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetK8sApplicationWithOptionsAsync(request, headers, runtime);
        }

        public GetK8sApplicationResponse GetK8sApplicationWithOptions(GetK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_application",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetK8sApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetK8sApplicationResponse> GetK8sApplicationWithOptionsAsync(GetK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_application",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetK8sApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetK8sClusterResponse GetK8sCluster(GetK8sClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetK8sClusterWithOptions(request, headers, runtime);
        }

        public async Task<GetK8sClusterResponse> GetK8sClusterAsync(GetK8sClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetK8sClusterWithOptionsAsync(request, headers, runtime);
        }

        public GetK8sClusterResponse GetK8sClusterWithOptions(GetK8sClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetK8sCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s_clusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetK8sClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetK8sClusterResponse> GetK8sClusterWithOptionsAsync(GetK8sClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetK8sCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s_clusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetK8sClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetK8sServicesResponse GetK8sServices(GetK8sServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetK8sServicesWithOptions(request, headers, runtime);
        }

        public async Task<GetK8sServicesResponse> GetK8sServicesAsync(GetK8sServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetK8sServicesWithOptionsAsync(request, headers, runtime);
        }

        public GetK8sServicesResponse GetK8sServicesWithOptions(GetK8sServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetK8sServices",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_service",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetK8sServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetK8sServicesResponse> GetK8sServicesWithOptionsAsync(GetK8sServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetK8sServices",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_service",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetK8sServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMockRuleByConsumerAppIdResponse GetMockRuleByConsumerAppId(GetMockRuleByConsumerAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMockRuleByConsumerAppIdWithOptions(request, headers, runtime);
        }

        public async Task<GetMockRuleByConsumerAppIdResponse> GetMockRuleByConsumerAppIdAsync(GetMockRuleByConsumerAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMockRuleByConsumerAppIdWithOptionsAsync(request, headers, runtime);
        }

        public GetMockRuleByConsumerAppIdResponse GetMockRuleByConsumerAppIdWithOptions(GetMockRuleByConsumerAppIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMockRuleByConsumerAppId",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/getMockRuleByConsumerAppId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMockRuleByConsumerAppIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMockRuleByConsumerAppIdResponse> GetMockRuleByConsumerAppIdWithOptionsAsync(GetMockRuleByConsumerAppIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMockRuleByConsumerAppId",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/getMockRuleByConsumerAppId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMockRuleByConsumerAppIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMockRuleByProviderAppIdResponse GetMockRuleByProviderAppId(GetMockRuleByProviderAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMockRuleByProviderAppIdWithOptions(request, headers, runtime);
        }

        public async Task<GetMockRuleByProviderAppIdResponse> GetMockRuleByProviderAppIdAsync(GetMockRuleByProviderAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMockRuleByProviderAppIdWithOptionsAsync(request, headers, runtime);
        }

        public GetMockRuleByProviderAppIdResponse GetMockRuleByProviderAppIdWithOptions(GetMockRuleByProviderAppIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppId))
            {
                query["ProviderAppId"] = request.ProviderAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMockRuleByProviderAppId",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/getMockRuleByProviderAppId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMockRuleByProviderAppIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMockRuleByProviderAppIdResponse> GetMockRuleByProviderAppIdWithOptionsAsync(GetMockRuleByProviderAppIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppId))
            {
                query["ProviderAppId"] = request.ProviderAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMockRuleByProviderAppId",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/getMockRuleByProviderAppId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMockRuleByProviderAppIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPackageStorageCredentialResponse GetPackageStorageCredential()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPackageStorageCredentialWithOptions(headers, runtime);
        }

        public async Task<GetPackageStorageCredentialResponse> GetPackageStorageCredentialAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPackageStorageCredentialWithOptionsAsync(headers, runtime);
        }

        public GetPackageStorageCredentialResponse GetPackageStorageCredentialWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPackageStorageCredential",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/package_storage_credential",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPackageStorageCredentialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPackageStorageCredentialResponse> GetPackageStorageCredentialWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPackageStorageCredential",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/package_storage_credential",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPackageStorageCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetScalingRulesResponse GetScalingRules(GetScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScalingRulesWithOptions(request, headers, runtime);
        }

        public async Task<GetScalingRulesResponse> GetScalingRulesAsync(GetScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScalingRulesWithOptionsAsync(request, headers, runtime);
        }

        public GetScalingRulesResponse GetScalingRulesWithOptions(GetScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScalingRules",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/scalingRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScalingRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetScalingRulesResponse> GetScalingRulesWithOptionsAsync(GetScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScalingRules",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/scalingRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScalingRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSecureTokenResponse GetSecureToken(GetSecureTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSecureTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetSecureTokenResponse> GetSecureTokenAsync(GetSecureTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSecureTokenWithOptionsAsync(request, headers, runtime);
        }

        public GetSecureTokenResponse GetSecureTokenWithOptions(GetSecureTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecureToken",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/secure_token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecureTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSecureTokenResponse> GetSecureTokenWithOptionsAsync(GetSecureTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecureToken",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/secure_token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecureTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetServiceConsumersPageResponse GetServiceConsumersPage(GetServiceConsumersPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceConsumersPageWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceConsumersPageResponse> GetServiceConsumersPageAsync(GetServiceConsumersPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceConsumersPageWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceConsumersPageResponse GetServiceConsumersPageWithOptions(GetServiceConsumersPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceConsumersPage",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceConsumersPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceConsumersPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceConsumersPageResponse> GetServiceConsumersPageWithOptionsAsync(GetServiceConsumersPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceConsumersPage",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceConsumersPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceConsumersPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetServiceDetailResponse GetServiceDetail(GetServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceDetailResponse> GetServiceDetailAsync(GetServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceDetailWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceDetailResponse GetServiceDetailWithOptions(GetServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceDetail",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceDetailResponse> GetServiceDetailWithOptionsAsync(GetServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceDetail",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetServiceListPageResponse GetServiceListPage(GetServiceListPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceListPageWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceListPageResponse> GetServiceListPageAsync(GetServiceListPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceListPageWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceListPageResponse GetServiceListPageWithOptions(GetServiceListPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["searchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                query["side"] = request.Side;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceListPage",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceListPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceListPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceListPageResponse> GetServiceListPageWithOptionsAsync(GetServiceListPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["searchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                query["side"] = request.Side;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceListPage",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceListPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceListPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetServiceMethodPageResponse GetServiceMethodPage(GetServiceMethodPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceMethodPageWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceMethodPageResponse> GetServiceMethodPageAsync(GetServiceMethodPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceMethodPageWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceMethodPageResponse GetServiceMethodPageWithOptions(GetServiceMethodPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodController))
            {
                query["methodController"] = request.MethodController;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceMethodPage",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceMethodPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceMethodPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceMethodPageResponse> GetServiceMethodPageWithOptionsAsync(GetServiceMethodPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodController))
            {
                query["methodController"] = request.MethodController;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceMethodPage",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceMethodPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceMethodPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetServiceProvidersPageResponse GetServiceProvidersPage(GetServiceProvidersPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceProvidersPageWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceProvidersPageResponse> GetServiceProvidersPageAsync(GetServiceProvidersPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceProvidersPageWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceProvidersPageResponse GetServiceProvidersPageWithOptions(GetServiceProvidersPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceProvidersPage",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceProvidersPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceProvidersPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceProvidersPageResponse> GetServiceProvidersPageWithOptionsAsync(GetServiceProvidersPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceProvidersPage",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mseForOam/getServiceProvidersPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceProvidersPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWebContainerConfigResponse GetWebContainerConfig(GetWebContainerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWebContainerConfigWithOptions(request, headers, runtime);
        }

        public async Task<GetWebContainerConfigResponse> GetWebContainerConfigAsync(GetWebContainerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWebContainerConfigWithOptionsAsync(request, headers, runtime);
        }

        public GetWebContainerConfigResponse GetWebContainerConfigWithOptions(GetWebContainerConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebContainerConfig",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/web_container_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebContainerConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWebContainerConfigResponse> GetWebContainerConfigWithOptionsAsync(GetWebContainerConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebContainerConfig",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/web_container_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebContainerConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ImportK8sClusterResponse ImportK8sCluster(ImportK8sClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImportK8sClusterWithOptions(request, headers, runtime);
        }

        public async Task<ImportK8sClusterResponse> ImportK8sClusterAsync(ImportK8sClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImportK8sClusterWithOptionsAsync(request, headers, runtime);
        }

        public ImportK8sClusterResponse ImportK8sClusterWithOptions(ImportK8sClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAsm))
            {
                query["EnableAsm"] = request.EnableAsm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportK8sCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/import_k8s_cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportK8sClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ImportK8sClusterResponse> ImportK8sClusterWithOptionsAsync(ImportK8sClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAsm))
            {
                query["EnableAsm"] = request.EnableAsm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportK8sCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/import_k8s_cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportK8sClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertApplicationResponse InsertApplication(InsertApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertApplicationWithOptions(request, headers, runtime);
        }

        public async Task<InsertApplicationResponse> InsertApplicationAsync(InsertApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertApplicationWithOptionsAsync(request, headers, runtime);
        }

        public InsertApplicationResponse InsertApplicationWithOptions(InsertApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["ComponentIds"] = request.ComponentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuInfo))
            {
                query["EcuInfo"] = request.EcuInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePortCheck))
            {
                query["EnablePortCheck"] = request.EnablePortCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUrlCheck))
            {
                query["EnableUrlCheck"] = request.EnableUrlCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURL))
            {
                query["HealthCheckURL"] = request.HealthCheckURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckUrl))
            {
                query["HealthCheckUrl"] = request.HealthCheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hooks))
            {
                query["Hooks"] = request.Hooks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JvmOptions))
            {
                query["JvmOptions"] = request.JvmOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeapSize))
            {
                query["MaxHeapSize"] = request.MaxHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPermSize))
            {
                query["MaxPermSize"] = request.MaxPermSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mem))
            {
                query["Mem"] = request.Mem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeapSize))
            {
                query["MinHeapSize"] = request.MinHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPortStr))
            {
                query["ReservedPortStr"] = request.ReservedPortStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_create_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertApplicationResponse> InsertApplicationWithOptionsAsync(InsertApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["ComponentIds"] = request.ComponentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuInfo))
            {
                query["EcuInfo"] = request.EcuInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePortCheck))
            {
                query["EnablePortCheck"] = request.EnablePortCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUrlCheck))
            {
                query["EnableUrlCheck"] = request.EnableUrlCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURL))
            {
                query["HealthCheckURL"] = request.HealthCheckURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckUrl))
            {
                query["HealthCheckUrl"] = request.HealthCheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hooks))
            {
                query["Hooks"] = request.Hooks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JvmOptions))
            {
                query["JvmOptions"] = request.JvmOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeapSize))
            {
                query["MaxHeapSize"] = request.MaxHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPermSize))
            {
                query["MaxPermSize"] = request.MaxPermSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mem))
            {
                query["Mem"] = request.Mem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeapSize))
            {
                query["MinHeapSize"] = request.MinHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPortStr))
            {
                query["ReservedPortStr"] = request.ReservedPortStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_create_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertClusterResponse InsertCluster(InsertClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertClusterWithOptions(request, headers, runtime);
        }

        public async Task<InsertClusterResponse> InsertClusterAsync(InsertClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertClusterWithOptionsAsync(request, headers, runtime);
        }

        public InsertClusterResponse InsertClusterWithOptions(InsertClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IaasProvider))
            {
                query["IaasProvider"] = request.IaasProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkMode))
            {
                query["NetworkMode"] = request.NetworkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversoldFactor))
            {
                query["OversoldFactor"] = request.OversoldFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertClusterResponse> InsertClusterWithOptionsAsync(InsertClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IaasProvider))
            {
                query["IaasProvider"] = request.IaasProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkMode))
            {
                query["NetworkMode"] = request.NetworkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversoldFactor))
            {
                query["OversoldFactor"] = request.OversoldFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertClusterMemberResponse InsertClusterMember(InsertClusterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertClusterMemberWithOptions(request, headers, runtime);
        }

        public async Task<InsertClusterMemberResponse> InsertClusterMemberAsync(InsertClusterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertClusterMemberWithOptionsAsync(request, headers, runtime);
        }

        public InsertClusterMemberResponse InsertClusterMemberWithOptions(InsertClusterMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertClusterMember",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertClusterMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertClusterMemberResponse> InsertClusterMemberWithOptionsAsync(InsertClusterMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertClusterMember",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertClusterMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertDeployGroupResponse InsertDeployGroup(InsertDeployGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertDeployGroupWithOptions(request, headers, runtime);
        }

        public async Task<InsertDeployGroupResponse> InsertDeployGroupAsync(InsertDeployGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertDeployGroupWithOptionsAsync(request, headers, runtime);
        }

        public InsertDeployGroupResponse InsertDeployGroupWithOptions(InsertDeployGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitPackageVersionId))
            {
                query["InitPackageVersionId"] = request.InitPackageVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertDeployGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/deploy_group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertDeployGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertDeployGroupResponse> InsertDeployGroupWithOptionsAsync(InsertDeployGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitPackageVersionId))
            {
                query["InitPackageVersionId"] = request.InitPackageVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertDeployGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/deploy_group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertDeployGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertK8sApplicationResponse InsertK8sApplication(InsertK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertK8sApplicationWithOptions(request, headers, runtime);
        }

        public async Task<InsertK8sApplicationResponse> InsertK8sApplicationAsync(InsertK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertK8sApplicationWithOptionsAsync(request, headers, runtime);
        }

        public InsertK8sApplicationResponse InsertK8sApplicationWithOptions(InsertK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                query["Annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationDescription))
            {
                query["ApplicationDescription"] = request.ApplicationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMountDescs))
            {
                query["ConfigMountDescs"] = request.ConfigMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsClusterId))
            {
                query["CsClusterId"] = request.CsClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAffinity))
            {
                query["CustomAffinity"] = request.CustomAffinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTolerations))
            {
                query["CustomTolerations"] = request.CustomTolerations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossNodes))
            {
                query["DeployAcrossNodes"] = request.DeployAcrossNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossZones))
            {
                query["DeployAcrossZones"] = request.DeployAcrossZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmptyDirs))
            {
                query["EmptyDirs"] = request.EmptyDirs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAsm))
            {
                query["EnableAsm"] = request.EnableAsm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEmptyPushReject))
            {
                query["EnableEmptyPushReject"] = request.EnableEmptyPushReject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLosslessRule))
            {
                query["EnableLosslessRule"] = request.EnableLosslessRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvFroms))
            {
                query["EnvFroms"] = request.EnvFroms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbId))
            {
                query["InternetSlbId"] = request.InternetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbPort))
            {
                query["InternetSlbPort"] = request.InternetSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbProtocol))
            {
                query["InternetSlbProtocol"] = request.InternetSlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetTargetPort))
            {
                query["InternetTargetPort"] = request.InternetTargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbId))
            {
                query["IntranetSlbId"] = request.IntranetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbPort))
            {
                query["IntranetSlbPort"] = request.IntranetSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbProtocol))
            {
                query["IntranetSlbProtocol"] = request.IntranetSlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetTargetPort))
            {
                query["IntranetTargetPort"] = request.IntranetTargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMultilingualApp))
            {
                query["IsMultilingualApp"] = request.IsMultilingualApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JDK))
            {
                query["JDK"] = request.JDK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaStartUpConfig))
            {
                query["JavaStartUpConfig"] = request.JavaStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitCpu))
            {
                query["LimitCpu"] = request.LimitCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitMem))
            {
                query["LimitMem"] = request.LimitMem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitmCpu))
            {
                query["LimitmCpu"] = request.LimitmCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVolume))
            {
                query["LocalVolume"] = request.LocalVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleAligned))
            {
                query["LosslessRuleAligned"] = request.LosslessRuleAligned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleDelayTime))
            {
                query["LosslessRuleDelayTime"] = request.LosslessRuleDelayTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleFuncType))
            {
                query["LosslessRuleFuncType"] = request.LosslessRuleFuncType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleRelated))
            {
                query["LosslessRuleRelated"] = request.LosslessRuleRelated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleWarmupTime))
            {
                query["LosslessRuleWarmupTime"] = request.LosslessRuleWarmupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDescs))
            {
                query["MountDescs"] = request.MountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvcMountDescs))
            {
                query["PvcMountDescs"] = request.PvcMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsCpu))
            {
                query["RequestsCpu"] = request.RequestsCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsMem))
            {
                query["RequestsMem"] = request.RequestsMem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsmCpu))
            {
                query["RequestsmCpu"] = request.RequestsmCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeClassName))
            {
                query["RuntimeClassName"] = request.RuntimeClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UriEncoding))
            {
                query["UriEncoding"] = request.UriEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainerConfig))
            {
                query["WebContainerConfig"] = request.WebContainerConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/create_k8s_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertK8sApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertK8sApplicationResponse> InsertK8sApplicationWithOptionsAsync(InsertK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                query["Annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationDescription))
            {
                query["ApplicationDescription"] = request.ApplicationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMountDescs))
            {
                query["ConfigMountDescs"] = request.ConfigMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsClusterId))
            {
                query["CsClusterId"] = request.CsClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAffinity))
            {
                query["CustomAffinity"] = request.CustomAffinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTolerations))
            {
                query["CustomTolerations"] = request.CustomTolerations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossNodes))
            {
                query["DeployAcrossNodes"] = request.DeployAcrossNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossZones))
            {
                query["DeployAcrossZones"] = request.DeployAcrossZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmptyDirs))
            {
                query["EmptyDirs"] = request.EmptyDirs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAsm))
            {
                query["EnableAsm"] = request.EnableAsm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEmptyPushReject))
            {
                query["EnableEmptyPushReject"] = request.EnableEmptyPushReject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLosslessRule))
            {
                query["EnableLosslessRule"] = request.EnableLosslessRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvFroms))
            {
                query["EnvFroms"] = request.EnvFroms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbId))
            {
                query["InternetSlbId"] = request.InternetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbPort))
            {
                query["InternetSlbPort"] = request.InternetSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbProtocol))
            {
                query["InternetSlbProtocol"] = request.InternetSlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetTargetPort))
            {
                query["InternetTargetPort"] = request.InternetTargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbId))
            {
                query["IntranetSlbId"] = request.IntranetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbPort))
            {
                query["IntranetSlbPort"] = request.IntranetSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbProtocol))
            {
                query["IntranetSlbProtocol"] = request.IntranetSlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetTargetPort))
            {
                query["IntranetTargetPort"] = request.IntranetTargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMultilingualApp))
            {
                query["IsMultilingualApp"] = request.IsMultilingualApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JDK))
            {
                query["JDK"] = request.JDK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaStartUpConfig))
            {
                query["JavaStartUpConfig"] = request.JavaStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitCpu))
            {
                query["LimitCpu"] = request.LimitCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitMem))
            {
                query["LimitMem"] = request.LimitMem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitmCpu))
            {
                query["LimitmCpu"] = request.LimitmCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVolume))
            {
                query["LocalVolume"] = request.LocalVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleAligned))
            {
                query["LosslessRuleAligned"] = request.LosslessRuleAligned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleDelayTime))
            {
                query["LosslessRuleDelayTime"] = request.LosslessRuleDelayTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleFuncType))
            {
                query["LosslessRuleFuncType"] = request.LosslessRuleFuncType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleRelated))
            {
                query["LosslessRuleRelated"] = request.LosslessRuleRelated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LosslessRuleWarmupTime))
            {
                query["LosslessRuleWarmupTime"] = request.LosslessRuleWarmupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDescs))
            {
                query["MountDescs"] = request.MountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvcMountDescs))
            {
                query["PvcMountDescs"] = request.PvcMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsCpu))
            {
                query["RequestsCpu"] = request.RequestsCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsMem))
            {
                query["RequestsMem"] = request.RequestsMem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsmCpu))
            {
                query["RequestsmCpu"] = request.RequestsmCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeClassName))
            {
                query["RuntimeClassName"] = request.RuntimeClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UriEncoding))
            {
                query["UriEncoding"] = request.UriEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainerConfig))
            {
                query["WebContainerConfig"] = request.WebContainerConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/create_k8s_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertK8sApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertOrUpdateRegionResponse InsertOrUpdateRegion(InsertOrUpdateRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertOrUpdateRegionWithOptions(request, headers, runtime);
        }

        public async Task<InsertOrUpdateRegionResponse> InsertOrUpdateRegionAsync(InsertOrUpdateRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertOrUpdateRegionWithOptionsAsync(request, headers, runtime);
        }

        public InsertOrUpdateRegionResponse InsertOrUpdateRegionWithOptions(InsertOrUpdateRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugEnable))
            {
                query["DebugEnable"] = request.DebugEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionName))
            {
                query["RegionName"] = request.RegionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertOrUpdateRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/user_region_def",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertOrUpdateRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertOrUpdateRegionResponse> InsertOrUpdateRegionWithOptionsAsync(InsertOrUpdateRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugEnable))
            {
                query["DebugEnable"] = request.DebugEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionName))
            {
                query["RegionName"] = request.RegionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertOrUpdateRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/user_region_def",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertOrUpdateRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertRoleResponse InsertRole(InsertRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertRoleWithOptions(request, headers, runtime);
        }

        public async Task<InsertRoleResponse> InsertRoleAsync(InsertRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertRoleWithOptionsAsync(request, headers, runtime);
        }

        public InsertRoleResponse InsertRoleWithOptions(InsertRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionData))
            {
                query["ActionData"] = request.ActionData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/create_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertRoleResponse> InsertRoleWithOptionsAsync(InsertRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionData))
            {
                query["ActionData"] = request.ActionData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/create_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertServiceGroupResponse InsertServiceGroup(InsertServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<InsertServiceGroupResponse> InsertServiceGroupAsync(InsertServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public InsertServiceGroupResponse InsertServiceGroupWithOptions(InsertServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertServiceGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/serviceGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertServiceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertServiceGroupResponse> InsertServiceGroupWithOptionsAsync(InsertServiceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertServiceGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/serviceGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertServiceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InstallAgentResponse InstallAgent(InstallAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallAgentWithOptions(request, headers, runtime);
        }

        public async Task<InstallAgentResponse> InstallAgentAsync(InstallAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallAgentWithOptionsAsync(request, headers, runtime);
        }

        public InstallAgentResponse InstallAgentWithOptions(InstallAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DoAsync))
            {
                query["DoAsync"] = request.DoAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAgent",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/ecss/install_agent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAgentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InstallAgentResponse> InstallAgentWithOptionsAsync(InstallAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DoAsync))
            {
                query["DoAsync"] = request.DoAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAgent",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/ecss/install_agent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAliyunRegionResponse ListAliyunRegion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAliyunRegionWithOptions(headers, runtime);
        }

        public async Task<ListAliyunRegionResponse> ListAliyunRegionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAliyunRegionWithOptionsAsync(headers, runtime);
        }

        public ListAliyunRegionResponse ListAliyunRegionWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliyunRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/region_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliyunRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAliyunRegionResponse> ListAliyunRegionWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliyunRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/region_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliyunRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListApplicationResponse ListApplication(ListApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApplicationWithOptions(request, headers, runtime);
        }

        public async Task<ListApplicationResponse> ListApplicationAsync(ListApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApplicationWithOptionsAsync(request, headers, runtime);
        }

        public ListApplicationResponse ListApplicationWithOptions(ListApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionIdFilter))
            {
                query["LogicalRegionIdFilter"] = request.LogicalRegionIdFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListApplicationResponse> ListApplicationWithOptionsAsync(ListApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionIdFilter))
            {
                query["LogicalRegionIdFilter"] = request.LogicalRegionIdFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListApplicationEcuResponse ListApplicationEcu(ListApplicationEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApplicationEcuWithOptions(request, headers, runtime);
        }

        public async Task<ListApplicationEcuResponse> ListApplicationEcuAsync(ListApplicationEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApplicationEcuWithOptionsAsync(request, headers, runtime);
        }

        public ListApplicationEcuResponse ListApplicationEcuWithOptions(ListApplicationEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/ecu_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationEcuResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListApplicationEcuResponse> ListApplicationEcuWithOptionsAsync(ListApplicationEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/ecu_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationEcuResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAuthorityResponse ListAuthority()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAuthorityWithOptions(headers, runtime);
        }

        public async Task<ListAuthorityResponse> ListAuthorityAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAuthorityWithOptionsAsync(headers, runtime);
        }

        public ListAuthorityResponse ListAuthorityWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthority",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/authority_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAuthorityResponse> ListAuthorityWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthority",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/authority_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBuildPackResponse ListBuildPack()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBuildPackWithOptions(headers, runtime);
        }

        public async Task<ListBuildPackResponse> ListBuildPackAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBuildPackWithOptionsAsync(headers, runtime);
        }

        public ListBuildPackResponse ListBuildPackWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBuildPack",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/build_pack_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBuildPackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBuildPackResponse> ListBuildPackWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBuildPack",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/build_pack_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBuildPackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterResponse ListCluster(ListClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterWithOptions(request, headers, runtime);
        }

        public async Task<ListClusterResponse> ListClusterAsync(ListClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterWithOptionsAsync(request, headers, runtime);
        }

        public ListClusterResponse ListClusterWithOptions(ListClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterResponse> ListClusterWithOptionsAsync(ListClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterMembersResponse ListClusterMembers(ListClusterMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterMembersWithOptions(request, headers, runtime);
        }

        public async Task<ListClusterMembersResponse> ListClusterMembersAsync(ListClusterMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterMembersWithOptionsAsync(request, headers, runtime);
        }

        public ListClusterMembersResponse ListClusterMembersWithOptions(ListClusterMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsList))
            {
                query["EcsList"] = request.EcsList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterMembers",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster_member_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterMembersResponse> ListClusterMembersWithOptionsAsync(ListClusterMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsList))
            {
                query["EcsList"] = request.EcsList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterMembers",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/cluster_member_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListComponentsResponse ListComponents()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListComponentsWithOptions(headers, runtime);
        }

        public async Task<ListComponentsResponse> ListComponentsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListComponentsWithOptionsAsync(headers, runtime);
        }

        public ListComponentsResponse ListComponentsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponents",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListComponentsResponse> ListComponentsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponents",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConfigTemplatesResponse ListConfigTemplates(ListConfigTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigTemplatesWithOptions(request, headers, runtime);
        }

        public async Task<ListConfigTemplatesResponse> ListConfigTemplatesAsync(ListConfigTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigTemplatesWithOptionsAsync(request, headers, runtime);
        }

        public ListConfigTemplatesResponse ListConfigTemplatesWithOptions(ListConfigTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigTemplates",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/config_template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigTemplatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConfigTemplatesResponse> ListConfigTemplatesWithOptionsAsync(ListConfigTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigTemplates",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/config_template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConsumedServicesResponse ListConsumedServices(ListConsumedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumedServicesWithOptions(request, headers, runtime);
        }

        public async Task<ListConsumedServicesResponse> ListConsumedServicesAsync(ListConsumedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumedServicesWithOptionsAsync(request, headers, runtime);
        }

        public ListConsumedServicesResponse ListConsumedServicesWithOptions(ListConsumedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumedServices",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/listConsumedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumedServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConsumedServicesResponse> ListConsumedServicesWithOptionsAsync(ListConsumedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumedServices",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/listConsumedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumedServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConvertableEcuResponse ListConvertableEcu(ListConvertableEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConvertableEcuWithOptions(request, headers, runtime);
        }

        public async Task<ListConvertableEcuResponse> ListConvertableEcuAsync(ListConvertableEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConvertableEcuWithOptionsAsync(request, headers, runtime);
        }

        public ListConvertableEcuResponse ListConvertableEcuWithOptions(ListConvertableEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["clusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConvertableEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/convertable_ecu_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConvertableEcuResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConvertableEcuResponse> ListConvertableEcuWithOptionsAsync(ListConvertableEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["clusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConvertableEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/convertable_ecu_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConvertableEcuResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDeployGroupResponse ListDeployGroup(ListDeployGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDeployGroupWithOptions(request, headers, runtime);
        }

        public async Task<ListDeployGroupResponse> ListDeployGroupAsync(ListDeployGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDeployGroupWithOptionsAsync(request, headers, runtime);
        }

        public ListDeployGroupResponse ListDeployGroupWithOptions(ListDeployGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/deploy_group_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeployGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDeployGroupResponse> ListDeployGroupWithOptionsAsync(ListDeployGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/deploy_group_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeployGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEcsNotInClusterResponse ListEcsNotInCluster(ListEcsNotInClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEcsNotInClusterWithOptions(request, headers, runtime);
        }

        public async Task<ListEcsNotInClusterResponse> ListEcsNotInClusterAsync(ListEcsNotInClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEcsNotInClusterWithOptionsAsync(request, headers, runtime);
        }

        public ListEcsNotInClusterResponse ListEcsNotInClusterWithOptions(ListEcsNotInClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkMode))
            {
                query["NetworkMode"] = request.NetworkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEcsNotInCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/ecs_not_in_cluster",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsNotInClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEcsNotInClusterResponse> ListEcsNotInClusterWithOptionsAsync(ListEcsNotInClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkMode))
            {
                query["NetworkMode"] = request.NetworkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEcsNotInCluster",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/ecs_not_in_cluster",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsNotInClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEcuByRegionResponse ListEcuByRegion(ListEcuByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEcuByRegionWithOptions(request, headers, runtime);
        }

        public async Task<ListEcuByRegionResponse> ListEcuByRegionAsync(ListEcuByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEcuByRegionWithOptionsAsync(request, headers, runtime);
        }

        public ListEcuByRegionResponse ListEcuByRegionWithOptions(ListEcuByRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                query["Act"] = request.Act;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEcuByRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/ecu_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcuByRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEcuByRegionResponse> ListEcuByRegionWithOptionsAsync(ListEcuByRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                query["Act"] = request.Act;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEcuByRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/ecu_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcuByRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHistoryDeployVersionResponse ListHistoryDeployVersion(ListHistoryDeployVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHistoryDeployVersionWithOptions(request, headers, runtime);
        }

        public async Task<ListHistoryDeployVersionResponse> ListHistoryDeployVersionAsync(ListHistoryDeployVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHistoryDeployVersionWithOptionsAsync(request, headers, runtime);
        }

        public ListHistoryDeployVersionResponse ListHistoryDeployVersionWithOptions(ListHistoryDeployVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHistoryDeployVersion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/deploy_history_version_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHistoryDeployVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHistoryDeployVersionResponse> ListHistoryDeployVersionWithOptionsAsync(ListHistoryDeployVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHistoryDeployVersion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/deploy_history_version_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHistoryDeployVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListK8sConfigMapsResponse ListK8sConfigMaps(ListK8sConfigMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListK8sConfigMapsWithOptions(request, headers, runtime);
        }

        public async Task<ListK8sConfigMapsResponse> ListK8sConfigMapsAsync(ListK8sConfigMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListK8sConfigMapsWithOptionsAsync(request, headers, runtime);
        }

        public ListK8sConfigMapsResponse ListK8sConfigMapsWithOptions(ListK8sConfigMapsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowRelatedApps))
            {
                query["ShowRelatedApps"] = request.ShowRelatedApps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListK8sConfigMaps",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_config_map",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListK8sConfigMapsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListK8sConfigMapsResponse> ListK8sConfigMapsWithOptionsAsync(ListK8sConfigMapsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowRelatedApps))
            {
                query["ShowRelatedApps"] = request.ShowRelatedApps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListK8sConfigMaps",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_config_map",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListK8sConfigMapsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListK8sIngressRulesResponse ListK8sIngressRules(ListK8sIngressRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListK8sIngressRulesWithOptions(request, headers, runtime);
        }

        public async Task<ListK8sIngressRulesResponse> ListK8sIngressRulesAsync(ListK8sIngressRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListK8sIngressRulesWithOptionsAsync(request, headers, runtime);
        }

        public ListK8sIngressRulesResponse ListK8sIngressRulesWithOptions(ListK8sIngressRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListK8sIngressRules",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_ingress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListK8sIngressRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListK8sIngressRulesResponse> ListK8sIngressRulesWithOptionsAsync(ListK8sIngressRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListK8sIngressRules",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_ingress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListK8sIngressRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListK8sNamespacesResponse ListK8sNamespaces(ListK8sNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListK8sNamespacesWithOptions(request, headers, runtime);
        }

        public async Task<ListK8sNamespacesResponse> ListK8sNamespacesAsync(ListK8sNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListK8sNamespacesWithOptionsAsync(request, headers, runtime);
        }

        public ListK8sNamespacesResponse ListK8sNamespacesWithOptions(ListK8sNamespacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListK8sNamespaces",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListK8sNamespacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListK8sNamespacesResponse> ListK8sNamespacesWithOptionsAsync(ListK8sNamespacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListK8sNamespaces",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListK8sNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListK8sSecretsResponse ListK8sSecrets(ListK8sSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListK8sSecretsWithOptions(request, headers, runtime);
        }

        public async Task<ListK8sSecretsResponse> ListK8sSecretsAsync(ListK8sSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListK8sSecretsWithOptionsAsync(request, headers, runtime);
        }

        public ListK8sSecretsResponse ListK8sSecretsWithOptions(ListK8sSecretsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowRelatedApps))
            {
                query["ShowRelatedApps"] = request.ShowRelatedApps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListK8sSecrets",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_secret",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListK8sSecretsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListK8sSecretsResponse> ListK8sSecretsWithOptionsAsync(ListK8sSecretsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowRelatedApps))
            {
                query["ShowRelatedApps"] = request.ShowRelatedApps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListK8sSecrets",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_secret",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListK8sSecretsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMethodsResponse ListMethods(ListMethodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMethodsWithOptions(request, headers, runtime);
        }

        public async Task<ListMethodsResponse> ListMethodsAsync(ListMethodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMethodsWithOptionsAsync(request, headers, runtime);
        }

        public ListMethodsResponse ListMethodsWithOptions(ListMethodsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMethods",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/list_methods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMethodsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMethodsResponse> ListMethodsWithOptionsAsync(ListMethodsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMethods",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/list_methods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMethodsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPublishedServicesResponse ListPublishedServices(ListPublishedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPublishedServicesWithOptions(request, headers, runtime);
        }

        public async Task<ListPublishedServicesResponse> ListPublishedServicesAsync(ListPublishedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPublishedServicesWithOptionsAsync(request, headers, runtime);
        }

        public ListPublishedServicesResponse ListPublishedServicesWithOptions(ListPublishedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedServices",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/listPublishedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPublishedServicesResponse> ListPublishedServicesWithOptionsAsync(ListPublishedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedServices",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/listPublishedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRecentChangeOrderResponse ListRecentChangeOrder(ListRecentChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRecentChangeOrderWithOptions(request, headers, runtime);
        }

        public async Task<ListRecentChangeOrderResponse> ListRecentChangeOrderAsync(ListRecentChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRecentChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        public ListRecentChangeOrderResponse ListRecentChangeOrderWithOptions(ListRecentChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentChangeOrder",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/change_order_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRecentChangeOrderResponse> ListRecentChangeOrderWithOptionsAsync(ListRecentChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentChangeOrder",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/change_order_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceGroupResponse ListResourceGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceGroupWithOptions(headers, runtime);
        }

        public async Task<ListResourceGroupResponse> ListResourceGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceGroupWithOptionsAsync(headers, runtime);
        }

        public ListResourceGroupResponse ListResourceGroupWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/reg_group_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceGroupResponse> ListResourceGroupWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceGroup",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/reg_group_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRoleResponse ListRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRoleWithOptions(headers, runtime);
        }

        public async Task<ListRoleResponse> ListRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRoleWithOptionsAsync(headers, runtime);
        }

        public ListRoleResponse ListRoleWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/role_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRoleResponse> ListRoleWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/role_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRootStacksResponse ListRootStacks(ListRootStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRootStacksWithOptions(request, headers, runtime);
        }

        public async Task<ListRootStacksResponse> ListRootStacksAsync(ListRootStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRootStacksWithOptionsAsync(request, headers, runtime);
        }

        public ListRootStacksResponse ListRootStacksWithOptions(ListRootStacksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRootStacks",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/s2i/list_root_stack",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRootStacksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRootStacksResponse> ListRootStacksWithOptionsAsync(ListRootStacksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRootStacks",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/s2i/list_root_stack",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRootStacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListScaleOutEcuResponse ListScaleOutEcu(ListScaleOutEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScaleOutEcuWithOptions(request, headers, runtime);
        }

        public async Task<ListScaleOutEcuResponse> ListScaleOutEcuAsync(ListScaleOutEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScaleOutEcuWithOptionsAsync(request, headers, runtime);
        }

        public ListScaleOutEcuResponse ListScaleOutEcuWithOptions(ListScaleOutEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNum))
            {
                query["InstanceNum"] = request.InstanceNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mem))
            {
                query["Mem"] = request.Mem;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScaleOutEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/scale_out_ecu_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScaleOutEcuResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListScaleOutEcuResponse> ListScaleOutEcuWithOptionsAsync(ListScaleOutEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNum))
            {
                query["InstanceNum"] = request.InstanceNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mem))
            {
                query["Mem"] = request.Mem;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScaleOutEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/scale_out_ecu_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScaleOutEcuResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceGroupsResponse ListServiceGroups()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceGroupsWithOptions(headers, runtime);
        }

        public async Task<ListServiceGroupsResponse> ListServiceGroupsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceGroupsWithOptionsAsync(headers, runtime);
        }

        public ListServiceGroupsResponse ListServiceGroupsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceGroups",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/serviceGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceGroupsResponse> ListServiceGroupsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceGroups",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/service/serviceGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSlbResponse ListSlb()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSlbWithOptions(headers, runtime);
        }

        public async Task<ListSlbResponse> ListSlbAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSlbWithOptionsAsync(headers, runtime);
        }

        public ListSlbResponse ListSlbWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/slb_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSlbResponse> ListSlbWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/slb_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSubAccountResponse ListSubAccount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubAccountWithOptions(headers, runtime);
        }

        public async Task<ListSubAccountResponse> ListSubAccountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubAccountWithOptionsAsync(headers, runtime);
        }

        public ListSubAccountResponse ListSubAccountWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubAccount",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/sub_account_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSubAccountResponse> ListSubAccountWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubAccount",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/sub_account_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/tag/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/tag/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserDefineRegionResponse ListUserDefineRegion(ListUserDefineRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserDefineRegionWithOptions(request, headers, runtime);
        }

        public async Task<ListUserDefineRegionResponse> ListUserDefineRegionAsync(ListUserDefineRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserDefineRegionWithOptionsAsync(request, headers, runtime);
        }

        public ListUserDefineRegionResponse ListUserDefineRegionWithOptions(ListUserDefineRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugEnable))
            {
                query["DebugEnable"] = request.DebugEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDefineRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/user_region_defs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDefineRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserDefineRegionResponse> ListUserDefineRegionWithOptionsAsync(ListUserDefineRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugEnable))
            {
                query["DebugEnable"] = request.DebugEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDefineRegion",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/user_region_defs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDefineRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVpcResponse ListVpc()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVpcWithOptions(headers, runtime);
        }

        public async Task<ListVpcResponse> ListVpcAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVpcWithOptionsAsync(headers, runtime);
        }

        public ListVpcResponse ListVpcWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpc",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/vpc_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVpcResponse> ListVpcWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpc",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/vpc_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MigrateEcuResponse MigrateEcu(MigrateEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MigrateEcuWithOptions(request, headers, runtime);
        }

        public async Task<MigrateEcuResponse> MigrateEcuAsync(MigrateEcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MigrateEcuWithOptionsAsync(request, headers, runtime);
        }

        public MigrateEcuResponse MigrateEcuWithOptions(MigrateEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/migrate_ecu",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateEcuResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MigrateEcuResponse> MigrateEcuWithOptionsAsync(MigrateEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateEcu",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/migrate_ecu",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateEcuResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyScalingRuleResponse ModifyScalingRule(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleAsync(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public ModifyScalingRuleResponse ModifyScalingRuleWithOptions(ModifyScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptEULA))
            {
                query["AcceptEULA"] = request.AcceptEULA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCondition))
            {
                query["InCondition"] = request.InCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCpu))
            {
                query["InCpu"] = request.InCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InDuration))
            {
                query["InDuration"] = request.InDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InEnable))
            {
                query["InEnable"] = request.InEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InInstanceNum))
            {
                query["InInstanceNum"] = request.InInstanceNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InLoad))
            {
                query["InLoad"] = request.InLoad;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InRT))
            {
                query["InRT"] = request.InRT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InStep))
            {
                query["InStep"] = request.InStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAzPolicy))
            {
                query["MultiAzPolicy"] = request.MultiAzPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCPU))
            {
                query["OutCPU"] = request.OutCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCondition))
            {
                query["OutCondition"] = request.OutCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutDuration))
            {
                query["OutDuration"] = request.OutDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutEnable))
            {
                query["OutEnable"] = request.OutEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutInstanceNum))
            {
                query["OutInstanceNum"] = request.OutInstanceNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutLoad))
            {
                query["OutLoad"] = request.OutLoad;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRT))
            {
                query["OutRT"] = request.OutRT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutStep))
            {
                query["OutStep"] = request.OutStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceFrom))
            {
                query["ResourceFrom"] = request.ResourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceId))
            {
                query["TemplateInstanceId"] = request.TemplateInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceName))
            {
                query["TemplateInstanceName"] = request.TemplateInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/scaling_rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleWithOptionsAsync(ModifyScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptEULA))
            {
                query["AcceptEULA"] = request.AcceptEULA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCondition))
            {
                query["InCondition"] = request.InCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCpu))
            {
                query["InCpu"] = request.InCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InDuration))
            {
                query["InDuration"] = request.InDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InEnable))
            {
                query["InEnable"] = request.InEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InInstanceNum))
            {
                query["InInstanceNum"] = request.InInstanceNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InLoad))
            {
                query["InLoad"] = request.InLoad;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InRT))
            {
                query["InRT"] = request.InRT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InStep))
            {
                query["InStep"] = request.InStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAzPolicy))
            {
                query["MultiAzPolicy"] = request.MultiAzPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCPU))
            {
                query["OutCPU"] = request.OutCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCondition))
            {
                query["OutCondition"] = request.OutCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutDuration))
            {
                query["OutDuration"] = request.OutDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutEnable))
            {
                query["OutEnable"] = request.OutEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutInstanceNum))
            {
                query["OutInstanceNum"] = request.OutInstanceNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutLoad))
            {
                query["OutLoad"] = request.OutLoad;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRT))
            {
                query["OutRT"] = request.OutRT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutStep))
            {
                query["OutStep"] = request.OutStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceFrom))
            {
                query["ResourceFrom"] = request.ResourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceId))
            {
                query["TemplateInstanceId"] = request.TemplateInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceName))
            {
                query["TemplateInstanceName"] = request.TemplateInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/scaling_rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryApplicationStatusResponse QueryApplicationStatus(QueryApplicationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryApplicationStatusWithOptions(request, headers, runtime);
        }

        public async Task<QueryApplicationStatusResponse> QueryApplicationStatusAsync(QueryApplicationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryApplicationStatusWithOptionsAsync(request, headers, runtime);
        }

        public QueryApplicationStatusResponse QueryApplicationStatusWithOptions(QueryApplicationStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryApplicationStatus",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApplicationStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryApplicationStatusResponse> QueryApplicationStatusWithOptionsAsync(QueryApplicationStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryApplicationStatus",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApplicationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryEccInfoResponse QueryEccInfo(QueryEccInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryEccInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryEccInfoResponse> QueryEccInfoAsync(QueryEccInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryEccInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryEccInfoResponse QueryEccInfoWithOptions(QueryEccInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccId))
            {
                query["EccId"] = request.EccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEccInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/ecc",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEccInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryEccInfoResponse> QueryEccInfoWithOptionsAsync(QueryEccInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccId))
            {
                query["EccId"] = request.EccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEccInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/ecc",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEccInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMigrateEcuListResponse QueryMigrateEcuList(QueryMigrateEcuListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryMigrateEcuListWithOptions(request, headers, runtime);
        }

        public async Task<QueryMigrateEcuListResponse> QueryMigrateEcuListAsync(QueryMigrateEcuListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryMigrateEcuListWithOptionsAsync(request, headers, runtime);
        }

        public QueryMigrateEcuListResponse QueryMigrateEcuListWithOptions(QueryMigrateEcuListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMigrateEcuList",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/migrate_ecu_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMigrateEcuListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMigrateEcuListResponse> QueryMigrateEcuListWithOptionsAsync(QueryMigrateEcuListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMigrateEcuList",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/migrate_ecu_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMigrateEcuListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMigrateRegionListResponse QueryMigrateRegionList(QueryMigrateRegionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryMigrateRegionListWithOptions(request, headers, runtime);
        }

        public async Task<QueryMigrateRegionListResponse> QueryMigrateRegionListAsync(QueryMigrateRegionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryMigrateRegionListWithOptionsAsync(request, headers, runtime);
        }

        public QueryMigrateRegionListResponse QueryMigrateRegionListWithOptions(QueryMigrateRegionListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMigrateRegionList",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/migrate_region_select",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMigrateRegionListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMigrateRegionListResponse> QueryMigrateRegionListWithOptionsAsync(QueryMigrateRegionListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMigrateRegionList",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/migrate_region_select",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMigrateRegionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRegionConfigResponse QueryRegionConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryRegionConfigWithOptions(headers, runtime);
        }

        public async Task<QueryRegionConfigResponse> QueryRegionConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryRegionConfigWithOptionsAsync(headers, runtime);
        }

        public QueryRegionConfigResponse QueryRegionConfigWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegionConfig",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/region_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegionConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRegionConfigResponse> QueryRegionConfigWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegionConfig",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/region_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySlsLogStoreListResponse QuerySlsLogStoreList(QuerySlsLogStoreListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySlsLogStoreListWithOptions(request, headers, runtime);
        }

        public async Task<QuerySlsLogStoreListResponse> QuerySlsLogStoreListAsync(QuerySlsLogStoreListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySlsLogStoreListWithOptionsAsync(request, headers, runtime);
        }

        public QuerySlsLogStoreListResponse QuerySlsLogStoreListWithOptions(QuerySlsLogStoreListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySlsLogStoreList",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/sls/query_sls_log_store_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySlsLogStoreListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySlsLogStoreListResponse> QuerySlsLogStoreListWithOptionsAsync(QuerySlsLogStoreListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySlsLogStoreList",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/sls/query_sls_log_store_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySlsLogStoreListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveMockRuleResponse RemoveMockRule(RemoveMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveMockRuleWithOptions(request, headers, runtime);
        }

        public async Task<RemoveMockRuleResponse> RemoveMockRuleAsync(RemoveMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveMockRuleWithOptionsAsync(request, headers, runtime);
        }

        public RemoveMockRuleResponse RemoveMockRuleWithOptions(RemoveMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/removeMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMockRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveMockRuleResponse> RemoveMockRuleWithOptionsAsync(RemoveMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/removeMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMockRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetApplicationResponse ResetApplication(ResetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResetApplicationWithOptions(request, headers, runtime);
        }

        public async Task<ResetApplicationResponse> ResetApplicationAsync(ResetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResetApplicationWithOptionsAsync(request, headers, runtime);
        }

        public ResetApplicationResponse ResetApplicationWithOptions(ResetApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_reset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetApplicationResponse> ResetApplicationWithOptionsAsync(ResetApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_reset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartApplicationResponse RestartApplication(RestartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartApplicationWithOptions(request, headers, runtime);
        }

        public async Task<RestartApplicationResponse> RestartApplicationAsync(RestartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartApplicationWithOptionsAsync(request, headers, runtime);
        }

        public RestartApplicationResponse RestartApplicationWithOptions(RestartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartApplicationResponse> RestartApplicationWithOptionsAsync(RestartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartK8sApplicationResponse RestartK8sApplication(RestartK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartK8sApplicationWithOptions(request, headers, runtime);
        }

        public async Task<RestartK8sApplicationResponse> RestartK8sApplicationAsync(RestartK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartK8sApplicationWithOptionsAsync(request, headers, runtime);
        }

        public RestartK8sApplicationResponse RestartK8sApplicationWithOptions(RestartK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/restart_k8s_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartK8sApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartK8sApplicationResponse> RestartK8sApplicationWithOptionsAsync(RestartK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/restart_k8s_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartK8sApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RetryChangeOrderTaskResponse RetryChangeOrderTask(RetryChangeOrderTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetryChangeOrderTaskWithOptions(request, headers, runtime);
        }

        public async Task<RetryChangeOrderTaskResponse> RetryChangeOrderTaskAsync(RetryChangeOrderTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetryChangeOrderTaskWithOptionsAsync(request, headers, runtime);
        }

        public RetryChangeOrderTaskResponse RetryChangeOrderTaskWithOptions(RetryChangeOrderTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStatus))
            {
                query["RetryStatus"] = request.RetryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryChangeOrderTask",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/task_retry",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryChangeOrderTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RetryChangeOrderTaskResponse> RetryChangeOrderTaskWithOptionsAsync(RetryChangeOrderTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStatus))
            {
                query["RetryStatus"] = request.RetryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryChangeOrderTask",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/task_retry",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryChangeOrderTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RollbackApplicationResponse RollbackApplication(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollbackApplicationWithOptions(request, headers, runtime);
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationAsync(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollbackApplicationWithOptionsAsync(request, headers, runtime);
        }

        public RollbackApplicationResponse RollbackApplicationWithOptions(RollbackApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Batch))
            {
                query["Batch"] = request.Batch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryVersion))
            {
                query["HistoryVersion"] = request.HistoryVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationWithOptionsAsync(RollbackApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Batch))
            {
                query["Batch"] = request.Batch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryVersion))
            {
                query["HistoryVersion"] = request.HistoryVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RollbackChangeOrderResponse RollbackChangeOrder(RollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollbackChangeOrderWithOptions(request, headers, runtime);
        }

        public async Task<RollbackChangeOrderResponse> RollbackChangeOrderAsync(RollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollbackChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        public RollbackChangeOrderResponse RollbackChangeOrderWithOptions(RollbackChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackChangeOrder",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/changeorder/rollback",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RollbackChangeOrderResponse> RollbackChangeOrderWithOptionsAsync(RollbackChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackChangeOrder",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/changeorder/rollback",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ScaleInApplicationResponse ScaleInApplication(ScaleInApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleInApplicationWithOptions(request, headers, runtime);
        }

        public async Task<ScaleInApplicationResponse> ScaleInApplicationAsync(ScaleInApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleInApplicationWithOptionsAsync(request, headers, runtime);
        }

        public ScaleInApplicationResponse ScaleInApplicationWithOptions(ScaleInApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStatus))
            {
                query["ForceStatus"] = request.ForceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleInApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_scale_in",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleInApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ScaleInApplicationResponse> ScaleInApplicationWithOptionsAsync(ScaleInApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStatus))
            {
                query["ForceStatus"] = request.ForceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleInApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_scale_in",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleInApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ScaleK8sApplicationResponse ScaleK8sApplication(ScaleK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleK8sApplicationWithOptions(request, headers, runtime);
        }

        public async Task<ScaleK8sApplicationResponse> ScaleK8sApplicationAsync(ScaleK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleK8sApplicationWithOptionsAsync(request, headers, runtime);
        }

        public ScaleK8sApplicationResponse ScaleK8sApplicationWithOptions(ScaleK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_apps",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleK8sApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ScaleK8sApplicationResponse> ScaleK8sApplicationWithOptionsAsync(ScaleK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_apps",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleK8sApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ScaleOutApplicationResponse ScaleOutApplication(ScaleOutApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleOutApplicationWithOptions(request, headers, runtime);
        }

        public async Task<ScaleOutApplicationResponse> ScaleOutApplicationAsync(ScaleOutApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleOutApplicationWithOptionsAsync(request, headers, runtime);
        }

        public ScaleOutApplicationResponse ScaleOutApplicationWithOptions(ScaleOutApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployGroup))
            {
                query["DeployGroup"] = request.DeployGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuInfo))
            {
                query["EcuInfo"] = request.EcuInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleOutApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_scale_out",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleOutApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ScaleOutApplicationResponse> ScaleOutApplicationWithOptionsAsync(ScaleOutApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployGroup))
            {
                query["DeployGroup"] = request.DeployGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuInfo))
            {
                query["EcuInfo"] = request.EcuInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleOutApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_scale_out",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleOutApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ScaleoutApplicationWithNewInstancesResponse ScaleoutApplicationWithNewInstances(ScaleoutApplicationWithNewInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleoutApplicationWithNewInstancesWithOptions(request, headers, runtime);
        }

        public async Task<ScaleoutApplicationWithNewInstancesResponse> ScaleoutApplicationWithNewInstancesAsync(ScaleoutApplicationWithNewInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleoutApplicationWithNewInstancesWithOptionsAsync(request, headers, runtime);
        }

        public ScaleoutApplicationWithNewInstancesResponse ScaleoutApplicationWithNewInstancesWithOptions(ScaleoutApplicationWithNewInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargePeriod))
            {
                query["InstanceChargePeriod"] = request.InstanceChargePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargePeriodUnit))
            {
                query["InstanceChargePeriodUnit"] = request.InstanceChargePeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingNum))
            {
                query["ScalingNum"] = request.ScalingNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceId))
            {
                query["TemplateInstanceId"] = request.TemplateInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleoutApplicationWithNewInstances",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/scaling/scale_out",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleoutApplicationWithNewInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ScaleoutApplicationWithNewInstancesResponse> ScaleoutApplicationWithNewInstancesWithOptionsAsync(ScaleoutApplicationWithNewInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargePeriod))
            {
                query["InstanceChargePeriod"] = request.InstanceChargePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargePeriodUnit))
            {
                query["InstanceChargePeriodUnit"] = request.InstanceChargePeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingNum))
            {
                query["ScalingNum"] = request.ScalingNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceId))
            {
                query["TemplateInstanceId"] = request.TemplateInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleoutApplicationWithNewInstances",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/scaling/scale_out",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleoutApplicationWithNewInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartApplicationWithOptions(request, headers, runtime);
        }

        public async Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartApplicationWithOptionsAsync(request, headers, runtime);
        }

        public StartApplicationResponse StartApplicationWithOptions(StartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartApplicationResponse> StartApplicationWithOptionsAsync(StartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartK8sApplicationResponse StartK8sApplication(StartK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartK8sApplicationWithOptions(request, headers, runtime);
        }

        public async Task<StartK8sApplicationResponse> StartK8sApplicationAsync(StartK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartK8sApplicationWithOptionsAsync(request, headers, runtime);
        }

        public StartK8sApplicationResponse StartK8sApplicationWithOptions(StartK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/start_k8s_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartK8sApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartK8sApplicationResponse> StartK8sApplicationWithOptionsAsync(StartK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/start_k8s_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartK8sApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopApplicationWithOptions(request, headers, runtime);
        }

        public async Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopApplicationWithOptionsAsync(request, headers, runtime);
        }

        public StopApplicationResponse StopApplicationWithOptions(StopApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopApplicationResponse> StopApplicationWithOptionsAsync(StopApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EccInfo))
            {
                query["EccInfo"] = request.EccInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopK8sApplicationResponse StopK8sApplication(StopK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopK8sApplicationWithOptions(request, headers, runtime);
        }

        public async Task<StopK8sApplicationResponse> StopK8sApplicationAsync(StopK8sApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopK8sApplicationWithOptionsAsync(request, headers, runtime);
        }

        public StopK8sApplicationResponse StopK8sApplicationWithOptions(StopK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/stop_k8s_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopK8sApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopK8sApplicationResponse> StopK8sApplicationWithOptionsAsync(StopK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopK8sApplication",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/stop_k8s_app",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopK8sApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchAdvancedMonitoringResponse SwitchAdvancedMonitoring(SwitchAdvancedMonitoringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SwitchAdvancedMonitoringWithOptions(request, headers, runtime);
        }

        public async Task<SwitchAdvancedMonitoringResponse> SwitchAdvancedMonitoringAsync(SwitchAdvancedMonitoringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SwitchAdvancedMonitoringWithOptionsAsync(request, headers, runtime);
        }

        public SwitchAdvancedMonitoringResponse SwitchAdvancedMonitoringWithOptions(SwitchAdvancedMonitoringRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAdvancedMonitoring))
            {
                query["EnableAdvancedMonitoring"] = request.EnableAdvancedMonitoring;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchAdvancedMonitoring",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/monitor/advancedMonitorInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchAdvancedMonitoringResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchAdvancedMonitoringResponse> SwitchAdvancedMonitoringWithOptionsAsync(SwitchAdvancedMonitoringRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAdvancedMonitoring))
            {
                query["EnableAdvancedMonitoring"] = request.EnableAdvancedMonitoring;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchAdvancedMonitoring",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/monitor/advancedMonitorInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchAdvancedMonitoringResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SynchronizeResourceResponse SynchronizeResource(SynchronizeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SynchronizeResourceWithOptions(request, headers, runtime);
        }

        public async Task<SynchronizeResourceResponse> SynchronizeResourceAsync(SynchronizeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SynchronizeResourceWithOptionsAsync(request, headers, runtime);
        }

        public SynchronizeResourceResponse SynchronizeResourceWithOptions(SynchronizeResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SynchronizeResource",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/pop_sync_resource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SynchronizeResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SynchronizeResourceResponse> SynchronizeResourceWithOptionsAsync(SynchronizeResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SynchronizeResource",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/pop_sync_resource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SynchronizeResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/tag/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/tag/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransformClusterMemberResponse TransformClusterMember(TransformClusterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TransformClusterMemberWithOptions(request, headers, runtime);
        }

        public async Task<TransformClusterMemberResponse> TransformClusterMemberAsync(TransformClusterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TransformClusterMemberWithOptionsAsync(request, headers, runtime);
        }

        public TransformClusterMemberResponse TransformClusterMemberWithOptions(TransformClusterMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetClusterId))
            {
                query["TargetClusterId"] = request.TargetClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformClusterMember",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/transform_cluster_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformClusterMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransformClusterMemberResponse> TransformClusterMemberWithOptionsAsync(TransformClusterMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetClusterId))
            {
                query["TargetClusterId"] = request.TargetClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformClusterMember",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/resource/transform_cluster_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformClusterMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindK8sSlbResponse UnbindK8sSlb(UnbindK8sSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindK8sSlbWithOptions(request, headers, runtime);
        }

        public async Task<UnbindK8sSlbResponse> UnbindK8sSlbAsync(UnbindK8sSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindK8sSlbWithOptionsAsync(request, headers, runtime);
        }

        public UnbindK8sSlbResponse UnbindK8sSlbWithOptions(UnbindK8sSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbName))
            {
                query["SlbName"] = request.SlbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindK8sSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_slb_binding",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindK8sSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindK8sSlbResponse> UnbindK8sSlbWithOptionsAsync(UnbindK8sSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbName))
            {
                query["SlbName"] = request.SlbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindK8sSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_slb_binding",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindK8sSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindSlbResponse UnbindSlb(UnbindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindSlbWithOptions(request, headers, runtime);
        }

        public async Task<UnbindSlbResponse> UnbindSlbAsync(UnbindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindSlbWithOptionsAsync(request, headers, runtime);
        }

        public UnbindSlbResponse UnbindSlbWithOptions(UnbindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteListener))
            {
                query["DeleteListener"] = request.DeleteListener;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/app/unbind_slb_json",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindSlbResponse> UnbindSlbWithOptionsAsync(UnbindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteListener))
            {
                query["DeleteListener"] = request.DeleteListener;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/app/unbind_slb_json",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAll))
            {
                query["DeleteAll"] = request.DeleteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/tag/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAll))
            {
                query["DeleteAll"] = request.DeleteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/tag/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAccountInfoResponse UpdateAccountInfo(UpdateAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAccountInfoWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAccountInfoResponse> UpdateAccountInfoAsync(UpdateAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAccountInfoWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAccountInfoResponse UpdateAccountInfoWithOptions(UpdateAccountInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccountInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/edit_account_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAccountInfoResponse> UpdateAccountInfoWithOptionsAsync(UpdateAccountInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccountInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/edit_account_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateApplicationBaseInfoResponse UpdateApplicationBaseInfo(UpdateApplicationBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationBaseInfoWithOptions(request, headers, runtime);
        }

        public async Task<UpdateApplicationBaseInfoResponse> UpdateApplicationBaseInfoAsync(UpdateApplicationBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationBaseInfoWithOptionsAsync(request, headers, runtime);
        }

        public UpdateApplicationBaseInfoResponse UpdateApplicationBaseInfoWithOptions(UpdateApplicationBaseInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationBaseInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/update_app_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationBaseInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateApplicationBaseInfoResponse> UpdateApplicationBaseInfoWithOptionsAsync(UpdateApplicationBaseInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationBaseInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/update_app_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationBaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateApplicationScalingRuleResponse UpdateApplicationScalingRule(UpdateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateApplicationScalingRuleResponse> UpdateApplicationScalingRuleAsync(UpdateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateApplicationScalingRuleResponse UpdateApplicationScalingRuleWithOptions(UpdateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleEnable))
            {
                query["ScalingRuleEnable"] = request.ScalingRuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTrigger))
            {
                query["ScalingRuleTrigger"] = request.ScalingRuleTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/application_scaling_rule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateApplicationScalingRuleResponse> UpdateApplicationScalingRuleWithOptionsAsync(UpdateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleEnable))
            {
                query["ScalingRuleEnable"] = request.ScalingRuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTrigger))
            {
                query["ScalingRuleTrigger"] = request.ScalingRuleTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationScalingRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/eam/scale/application_scaling_rule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateConfigTemplateResponse UpdateConfigTemplate(UpdateConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigTemplateWithOptions(request, headers, runtime);
        }

        public async Task<UpdateConfigTemplateResponse> UpdateConfigTemplateAsync(UpdateConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigTemplateWithOptionsAsync(request, headers, runtime);
        }

        public UpdateConfigTemplateResponse UpdateConfigTemplateWithOptions(UpdateConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigTemplate",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/config_template",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateConfigTemplateResponse> UpdateConfigTemplateWithOptionsAsync(UpdateConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigTemplate",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/config_template",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateContainerResponse UpdateContainer(UpdateContainerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateContainerWithOptions(request, headers, runtime);
        }

        public async Task<UpdateContainerResponse> UpdateContainerAsync(UpdateContainerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateContainerWithOptionsAsync(request, headers, runtime);
        }

        public UpdateContainerResponse UpdateContainerWithOptions(UpdateContainerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContainer",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_update_container",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContainerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateContainerResponse> UpdateContainerWithOptionsAsync(UpdateContainerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContainer",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/changeorder/co_update_container",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContainerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateContainerConfigurationResponse UpdateContainerConfiguration(UpdateContainerConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateContainerConfigurationWithOptions(request, headers, runtime);
        }

        public async Task<UpdateContainerConfigurationResponse> UpdateContainerConfigurationAsync(UpdateContainerConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateContainerConfigurationWithOptionsAsync(request, headers, runtime);
        }

        public UpdateContainerConfigurationResponse UpdateContainerConfigurationWithOptions(UpdateContainerConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextPath))
            {
                query["ContextPath"] = request.ContextPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpPort))
            {
                query["HttpPort"] = request.HttpPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxThreads))
            {
                query["MaxThreads"] = request.MaxThreads;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URIEncoding))
            {
                query["URIEncoding"] = request.URIEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContainerConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/container_config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContainerConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateContainerConfigurationResponse> UpdateContainerConfigurationWithOptionsAsync(UpdateContainerConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextPath))
            {
                query["ContextPath"] = request.ContextPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpPort))
            {
                query["HttpPort"] = request.HttpPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxThreads))
            {
                query["MaxThreads"] = request.MaxThreads;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URIEncoding))
            {
                query["URIEncoding"] = request.URIEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContainerConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/container_config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContainerConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHealthCheckUrlResponse UpdateHealthCheckUrl(UpdateHealthCheckUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHealthCheckUrlWithOptions(request, headers, runtime);
        }

        public async Task<UpdateHealthCheckUrlResponse> UpdateHealthCheckUrlAsync(UpdateHealthCheckUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHealthCheckUrlWithOptionsAsync(request, headers, runtime);
        }

        public UpdateHealthCheckUrlResponse UpdateHealthCheckUrlWithOptions(UpdateHealthCheckUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HcURL))
            {
                query["hcURL"] = request.HcURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHealthCheckUrl",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/modify_hc_url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHealthCheckUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHealthCheckUrlResponse> UpdateHealthCheckUrlWithOptionsAsync(UpdateHealthCheckUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HcURL))
            {
                query["hcURL"] = request.HcURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHealthCheckUrl",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/modify_hc_url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHealthCheckUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHookConfigurationResponse UpdateHookConfiguration(UpdateHookConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHookConfigurationWithOptions(request, headers, runtime);
        }

        public async Task<UpdateHookConfigurationResponse> UpdateHookConfigurationAsync(UpdateHookConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHookConfigurationWithOptionsAsync(request, headers, runtime);
        }

        public UpdateHookConfigurationResponse UpdateHookConfigurationWithOptions(UpdateHookConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hooks))
            {
                query["Hooks"] = request.Hooks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHookConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/app/config_app_hook_json",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHookConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHookConfigurationResponse> UpdateHookConfigurationWithOptionsAsync(UpdateHookConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hooks))
            {
                query["Hooks"] = request.Hooks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHookConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/app/config_app_hook_json",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHookConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateJvmConfigurationResponse UpdateJvmConfiguration(UpdateJvmConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateJvmConfigurationWithOptions(request, headers, runtime);
        }

        public async Task<UpdateJvmConfigurationResponse> UpdateJvmConfigurationAsync(UpdateJvmConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateJvmConfigurationWithOptionsAsync(request, headers, runtime);
        }

        public UpdateJvmConfigurationResponse UpdateJvmConfigurationWithOptions(UpdateJvmConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeapSize))
            {
                query["MaxHeapSize"] = request.MaxHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPermSize))
            {
                query["MaxPermSize"] = request.MaxPermSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeapSize))
            {
                query["MinHeapSize"] = request.MinHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJvmConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_jvm_config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJvmConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateJvmConfigurationResponse> UpdateJvmConfigurationWithOptionsAsync(UpdateJvmConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeapSize))
            {
                query["MaxHeapSize"] = request.MaxHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPermSize))
            {
                query["MaxPermSize"] = request.MaxPermSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeapSize))
            {
                query["MinHeapSize"] = request.MinHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJvmConfiguration",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/app/app_jvm_config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJvmConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sApplicationBaseInfoResponse UpdateK8sApplicationBaseInfo(UpdateK8sApplicationBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sApplicationBaseInfoWithOptions(request, headers, runtime);
        }

        public async Task<UpdateK8sApplicationBaseInfoResponse> UpdateK8sApplicationBaseInfoAsync(UpdateK8sApplicationBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sApplicationBaseInfoWithOptionsAsync(request, headers, runtime);
        }

        public UpdateK8sApplicationBaseInfoResponse UpdateK8sApplicationBaseInfoWithOptions(UpdateK8sApplicationBaseInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sApplicationBaseInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/update_app_basic_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sApplicationBaseInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sApplicationBaseInfoResponse> UpdateK8sApplicationBaseInfoWithOptionsAsync(UpdateK8sApplicationBaseInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sApplicationBaseInfo",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/update_app_basic_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sApplicationBaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sApplicationConfigResponse UpdateK8sApplicationConfig(UpdateK8sApplicationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sApplicationConfigWithOptions(request, headers, runtime);
        }

        public async Task<UpdateK8sApplicationConfigResponse> UpdateK8sApplicationConfigAsync(UpdateK8sApplicationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sApplicationConfigWithOptionsAsync(request, headers, runtime);
        }

        public UpdateK8sApplicationConfigResponse UpdateK8sApplicationConfigWithOptions(UpdateK8sApplicationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                query["CpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuRequest))
            {
                query["CpuRequest"] = request.CpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuLimit))
            {
                query["McpuLimit"] = request.McpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuRequest))
            {
                query["McpuRequest"] = request.McpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                query["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryRequest))
            {
                query["MemoryRequest"] = request.MemoryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sApplicationConfig",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_app_configuration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sApplicationConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sApplicationConfigResponse> UpdateK8sApplicationConfigWithOptionsAsync(UpdateK8sApplicationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                query["CpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuRequest))
            {
                query["CpuRequest"] = request.CpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuLimit))
            {
                query["McpuLimit"] = request.McpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuRequest))
            {
                query["McpuRequest"] = request.McpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                query["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryRequest))
            {
                query["MemoryRequest"] = request.MemoryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sApplicationConfig",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_app_configuration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sApplicationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sConfigMapResponse UpdateK8sConfigMap(UpdateK8sConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sConfigMapWithOptions(request, headers, runtime);
        }

        public async Task<UpdateK8sConfigMapResponse> UpdateK8sConfigMapAsync(UpdateK8sConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sConfigMapWithOptionsAsync(request, headers, runtime);
        }

        public UpdateK8sConfigMapResponse UpdateK8sConfigMapWithOptions(UpdateK8sConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sConfigMap",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_config_map",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sConfigMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sConfigMapResponse> UpdateK8sConfigMapWithOptionsAsync(UpdateK8sConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sConfigMap",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_config_map",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sIngressRuleResponse UpdateK8sIngressRule(UpdateK8sIngressRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sIngressRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateK8sIngressRuleResponse> UpdateK8sIngressRuleAsync(UpdateK8sIngressRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sIngressRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateK8sIngressRuleResponse UpdateK8sIngressRuleWithOptions(UpdateK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConf))
            {
                query["IngressConf"] = request.IngressConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sIngressRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_ingress",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sIngressRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sIngressRuleResponse> UpdateK8sIngressRuleWithOptionsAsync(UpdateK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConf))
            {
                query["IngressConf"] = request.IngressConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sIngressRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_ingress",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sIngressRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sResourceResponse UpdateK8sResource(UpdateK8sResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sResourceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateK8sResourceResponse> UpdateK8sResourceAsync(UpdateK8sResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sResourceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateK8sResourceResponse UpdateK8sResourceWithOptions(UpdateK8sResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceContent))
            {
                body["ResourceContent"] = request.ResourceContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sResource",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/update_k8s_resource_config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sResourceResponse> UpdateK8sResourceWithOptionsAsync(UpdateK8sResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceContent))
            {
                body["ResourceContent"] = request.ResourceContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sResource",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/oam/update_k8s_resource_config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sSecretResponse UpdateK8sSecret(UpdateK8sSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sSecretWithOptions(request, headers, runtime);
        }

        public async Task<UpdateK8sSecretResponse> UpdateK8sSecretAsync(UpdateK8sSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sSecretWithOptionsAsync(request, headers, runtime);
        }

        public UpdateK8sSecretResponse UpdateK8sSecretWithOptions(UpdateK8sSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Base64Encoded))
            {
                body["Base64Encoded"] = request.Base64Encoded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                body["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRegionId))
            {
                body["CertRegionId"] = request.CertRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sSecret",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_secret",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sSecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sSecretResponse> UpdateK8sSecretWithOptionsAsync(UpdateK8sSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Base64Encoded))
            {
                body["Base64Encoded"] = request.Base64Encoded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                body["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRegionId))
            {
                body["CertRegionId"] = request.CertRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sSecret",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_secret",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sServiceResponse UpdateK8sService(UpdateK8sServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sServiceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateK8sServiceResponse> UpdateK8sServiceAsync(UpdateK8sServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sServiceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateK8sServiceResponse UpdateK8sServiceWithOptions(UpdateK8sServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePorts))
            {
                query["ServicePorts"] = request.ServicePorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sService",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_service",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sServiceResponse> UpdateK8sServiceWithOptionsAsync(UpdateK8sServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePorts))
            {
                query["ServicePorts"] = request.ServicePorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sService",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_service",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sSlbResponse UpdateK8sSlb(UpdateK8sSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sSlbWithOptions(request, headers, runtime);
        }

        public async Task<UpdateK8sSlbResponse> UpdateK8sSlbAsync(UpdateK8sSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sSlbWithOptionsAsync(request, headers, runtime);
        }

        public UpdateK8sSlbResponse UpdateK8sSlbWithOptions(UpdateK8sSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableForceOverride))
            {
                query["DisableForceOverride"] = request.DisableForceOverride;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePortInfos))
            {
                query["ServicePortInfos"] = request.ServicePortInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbName))
            {
                query["SlbName"] = request.SlbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbProtocol))
            {
                query["SlbProtocol"] = request.SlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_slb_binding",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sSlbResponse> UpdateK8sSlbWithOptionsAsync(UpdateK8sSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableForceOverride))
            {
                query["DisableForceOverride"] = request.DisableForceOverride;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePortInfos))
            {
                query["ServicePortInfos"] = request.ServicePortInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbName))
            {
                query["SlbName"] = request.SlbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbProtocol))
            {
                query["SlbProtocol"] = request.SlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sSlb",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/acs/k8s_slb_binding",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateK8sSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMockRuleResponse UpdateMockRule(UpdateMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMockRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateMockRuleResponse> UpdateMockRuleAsync(UpdateMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMockRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateMockRuleResponse UpdateMockRuleWithOptions(UpdateMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboMockItemJson))
            {
                query["DubboMockItemJson"] = request.DubboMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraJson))
            {
                query["ExtraJson"] = request.ExtraJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScMockItemJson))
            {
                query["ScMockItemJson"] = request.ScMockItemJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/updateMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMockRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMockRuleResponse> UpdateMockRuleWithOptionsAsync(UpdateMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboMockItemJson))
            {
                query["DubboMockItemJson"] = request.DubboMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraJson))
            {
                query["ExtraJson"] = request.ExtraJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScMockItemJson))
            {
                query["ScMockItemJson"] = request.ScMockItemJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMockRule",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/sp/api/mock/updateMockRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMockRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRoleResponse UpdateRole(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRoleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRoleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRoleResponse UpdateRoleWithOptions(UpdateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionData))
            {
                query["ActionData"] = request.ActionData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/edit_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRoleResponse> UpdateRoleWithOptionsAsync(UpdateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionData))
            {
                query["ActionData"] = request.ActionData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/account/edit_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSlsLogStoreResponse UpdateSlsLogStore(UpdateSlsLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSlsLogStoreWithOptions(request, headers, runtime);
        }

        public async Task<UpdateSlsLogStoreResponse> UpdateSlsLogStoreAsync(UpdateSlsLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSlsLogStoreWithOptionsAsync(request, headers, runtime);
        }

        public UpdateSlsLogStoreResponse UpdateSlsLogStoreWithOptions(UpdateSlsLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSlsLogStore",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/sls/update_sls_log_store",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSlsLogStoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSlsLogStoreResponse> UpdateSlsLogStoreWithOptionsAsync(UpdateSlsLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSlsLogStore",
                Version = "2017-08-01",
                Protocol = "HTTPS",
                Pathname = "/pop/v5/k8s/sls/update_sls_log_store",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSlsLogStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
