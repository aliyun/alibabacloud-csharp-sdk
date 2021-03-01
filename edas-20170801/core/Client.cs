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
            return TeaModel.ToObject<AbortAndRollbackChangeOrderResponse>(DoROARequest("AbortAndRollbackChangeOrder", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/changeorder/change_order_abort_and_rollback", "json", req, runtime));
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
            return TeaModel.ToObject<AbortAndRollbackChangeOrderResponse>(await DoROARequestAsync("AbortAndRollbackChangeOrder", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/changeorder/change_order_abort_and_rollback", "json", req, runtime));
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
            return TeaModel.ToObject<AbortChangeOrderResponse>(DoROARequest("AbortChangeOrder", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/changeorder/change_order_abort", "json", req, runtime));
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
            return TeaModel.ToObject<AbortChangeOrderResponse>(await DoROARequestAsync("AbortChangeOrder", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/changeorder/change_order_abort", "json", req, runtime));
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
            return TeaModel.ToObject<AddLogPathResponse>(DoROARequestWithForm("AddLogPath", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/log/popListLogDirs", "json", req, runtime));
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
            return TeaModel.ToObject<AddLogPathResponse>(await DoROARequestWithFormAsync("AddLogPath", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/log/popListLogDirs", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppId))
            {
                query["ProviderAppId"] = request.ProviderAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppName))
            {
                query["ProviderAppName"] = request.ProviderAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraJson))
            {
                query["ExtraJson"] = request.ExtraJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScMockItemJson))
            {
                query["ScMockItemJson"] = request.ScMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboMockItemJson))
            {
                query["DubboMockItemJson"] = request.DubboMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppsJson))
            {
                query["ConsumerAppsJson"] = request.ConsumerAppsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
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
            return TeaModel.ToObject<AddMockRuleResponse>(DoROARequest("AddMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/addMockRule", "json", req, runtime));
        }

        public async Task<AddMockRuleResponse> AddMockRuleWithOptionsAsync(AddMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppId))
            {
                query["ProviderAppId"] = request.ProviderAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppName))
            {
                query["ProviderAppName"] = request.ProviderAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraJson))
            {
                query["ExtraJson"] = request.ExtraJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScMockItemJson))
            {
                query["ScMockItemJson"] = request.ScMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboMockItemJson))
            {
                query["DubboMockItemJson"] = request.DubboMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppsJson))
            {
                query["ConsumerAppsJson"] = request.ConsumerAppsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
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
            return TeaModel.ToObject<AddMockRuleResponse>(await DoROARequestAsync("AddMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/addMockRule", "json", req, runtime));
        }

        public AddServiceTimeConfigResponse AddServiceTimeConfig(AddServiceTimeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddServiceTimeConfigWithOptions(request, headers, runtime);
        }

        public async Task<AddServiceTimeConfigResponse> AddServiceTimeConfigAsync(AddServiceTimeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddServiceTimeConfigWithOptionsAsync(request, headers, runtime);
        }

        public AddServiceTimeConfigResponse AddServiceTimeConfigWithOptions(AddServiceTimeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroup))
            {
                query["ServiceGroup"] = request.ServiceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppName))
            {
                query["ConsumerAppName"] = request.ConsumerAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
            return TeaModel.ToObject<AddServiceTimeConfigResponse>(DoROARequest("AddServiceTimeConfig", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/timeout/add", "json", req, runtime));
        }

        public async Task<AddServiceTimeConfigResponse> AddServiceTimeConfigWithOptionsAsync(AddServiceTimeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroup))
            {
                query["ServiceGroup"] = request.ServiceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppName))
            {
                query["ConsumerAppName"] = request.ConsumerAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
            return TeaModel.ToObject<AddServiceTimeConfigResponse>(await DoROARequestAsync("AddServiceTimeConfig", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/timeout/add", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AuthorizeApplicationResponse>(DoROARequest("AuthorizeApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/authorize_app", "json", req, runtime));
        }

        public async Task<AuthorizeApplicationResponse> AuthorizeApplicationWithOptionsAsync(AuthorizeApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AuthorizeApplicationResponse>(await DoROARequestAsync("AuthorizeApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/authorize_app", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AuthorizeResourceGroupResponse>(DoROARequest("AuthorizeResourceGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/authorize_res_group", "json", req, runtime));
        }

        public async Task<AuthorizeResourceGroupResponse> AuthorizeResourceGroupWithOptionsAsync(AuthorizeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AuthorizeResourceGroupResponse>(await DoROARequestAsync("AuthorizeResourceGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/authorize_res_group", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                query["RoleIds"] = request.RoleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AuthorizeRoleResponse>(DoROARequest("AuthorizeRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/authorize_role", "json", req, runtime));
        }

        public async Task<AuthorizeRoleResponse> AuthorizeRoleWithOptionsAsync(AuthorizeRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                query["RoleIds"] = request.RoleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AuthorizeRoleResponse>(await DoROARequestAsync("AuthorizeRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/authorize_role", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployGroupId))
            {
                query["DeployGroupId"] = request.DeployGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupName))
            {
                query["VServerGroupName"] = request.VServerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerHealthCheckUrl))
            {
                query["ListenerHealthCheckUrl"] = request.ListenerHealthCheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VForwardingUrlRule))
            {
                query["VForwardingUrlRule"] = request.VForwardingUrlRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<BindEcsSlbResponse>(DoROARequest("BindEcsSlb", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/slb/bind_slb", "json", req, runtime));
        }

        public async Task<BindEcsSlbResponse> BindEcsSlbWithOptionsAsync(BindEcsSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployGroupId))
            {
                query["DeployGroupId"] = request.DeployGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupName))
            {
                query["VServerGroupName"] = request.VServerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerHealthCheckUrl))
            {
                query["ListenerHealthCheckUrl"] = request.ListenerHealthCheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VForwardingUrlRule))
            {
                query["VForwardingUrlRule"] = request.VForwardingUrlRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<BindEcsSlbResponse>(await DoROARequestAsync("BindEcsSlb", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/slb/bind_slb", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbProtocol))
            {
                query["SlbProtocol"] = request.SlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePortInfos))
            {
                query["ServicePortInfos"] = request.ServicePortInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<BindK8sSlbResponse>(DoROARequest("BindK8sSlb", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/k8s_slb_binding", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbProtocol))
            {
                query["SlbProtocol"] = request.SlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePortInfos))
            {
                query["ServicePortInfos"] = request.ServicePortInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<BindK8sSlbResponse>(await DoROARequestAsync("BindK8sSlb", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/k8s_slb_binding", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
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
            return TeaModel.ToObject<BindSlbResponse>(DoROARequest("BindSlb", "2017-08-01", "HTTPS", "POST", "AK", "/pop/app/bind_slb_json", "json", req, runtime));
        }

        public async Task<BindSlbResponse> BindSlbWithOptionsAsync(BindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
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
            return TeaModel.ToObject<BindSlbResponse>(await DoROARequestAsync("BindSlb", "2017-08-01", "HTTPS", "POST", "AK", "/pop/app/bind_slb_json", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
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
            return TeaModel.ToObject<ChangeDeployGroupResponse>(DoROARequest("ChangeDeployGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_change_group", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
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
            return TeaModel.ToObject<ChangeDeployGroupResponse>(await DoROARequestAsync("ChangeDeployGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_change_group", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Confirm))
            {
                query["Confirm"] = request.Confirm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ContinuePipelineResponse>(DoROARequest("ContinuePipeline", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/changeorder/pipeline_batch_confirm", "json", req, runtime));
        }

        public async Task<ContinuePipelineResponse> ContinuePipelineWithOptionsAsync(ContinuePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Confirm))
            {
                query["Confirm"] = request.Confirm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ContinuePipelineResponse>(await DoROARequestAsync("ContinuePipeline", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/changeorder/pipeline_batch_confirm", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ConvertK8sResourceResponse>(DoROARequest("ConvertK8sResource", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/oam/k8s_resource_convert", "json", req, runtime));
        }

        public async Task<ConvertK8sResourceResponse> ConvertK8sResourceWithOptionsAsync(ConvertK8sResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ConvertK8sResourceResponse>(await DoROARequestAsync("ConvertK8sResource", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/oam/k8s_resource_convert", "json", req, runtime));
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
            return TeaModel.ToObject<CreateIDCImportCommandResponse>(DoROARequestWithForm("CreateIDCImportCommand", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/create_idc_import_command", "json", req, runtime));
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
            return TeaModel.ToObject<CreateIDCImportCommandResponse>(await DoROARequestWithFormAsync("CreateIDCImportCommand", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/create_idc_import_command", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateK8sIngressRuleResponse>(DoROARequest("CreateK8sIngressRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/k8s_ingress", "json", req, runtime));
        }

        public async Task<CreateK8sIngressRuleResponse> CreateK8sIngressRuleWithOptionsAsync(CreateK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateK8sIngressRuleResponse>(await DoROARequestAsync("CreateK8sIngressRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/k8s_ingress", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePorts))
            {
                query["ServicePorts"] = request.ServicePorts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateK8sServiceResponse>(DoROARequest("CreateK8sService", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/k8s_service", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePorts))
            {
                query["ServicePorts"] = request.ServicePorts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateK8sServiceResponse>(await DoROARequestAsync("CreateK8sService", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/k8s_service", "json", req, runtime));
        }

        public DelegateAdminRoleResponse DelegateAdminRole(DelegateAdminRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DelegateAdminRoleWithOptions(request, headers, runtime);
        }

        public async Task<DelegateAdminRoleResponse> DelegateAdminRoleAsync(DelegateAdminRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DelegateAdminRoleWithOptionsAsync(request, headers, runtime);
        }

        public DelegateAdminRoleResponse DelegateAdminRoleWithOptions(DelegateAdminRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DelegateAdminRoleResponse>(DoROARequest("DelegateAdminRole", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/account/delegate_admin_role", "json", req, runtime));
        }

        public async Task<DelegateAdminRoleResponse> DelegateAdminRoleWithOptionsAsync(DelegateAdminRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DelegateAdminRoleResponse>(await DoROARequestAsync("DelegateAdminRole", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/account/delegate_admin_role", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteApplicationResponse>(DoROARequest("DeleteApplication", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/changeorder/co_delete_app", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteApplicationResponse>(await DoROARequestAsync("DeleteApplication", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/changeorder/co_delete_app", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterResponse>(DoROARequest("DeleteCluster", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/resource/cluster", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterResponse>(await DoROARequestAsync("DeleteCluster", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/resource/cluster", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterMemberResponse>(DoROARequest("DeleteClusterMember", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/resource/cluster_member", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterMemberResponse>(await DoROARequestAsync("DeleteClusterMember", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/resource/cluster_member", "json", req, runtime));
        }

        public DeleteConfigCenterResponse DeleteConfigCenter(DeleteConfigCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigCenterWithOptions(request, headers, runtime);
        }

        public async Task<DeleteConfigCenterResponse> DeleteConfigCenterAsync(DeleteConfigCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigCenterWithOptionsAsync(request, headers, runtime);
        }

        public DeleteConfigCenterResponse DeleteConfigCenterWithOptions(DeleteConfigCenterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
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
            return TeaModel.ToObject<DeleteConfigCenterResponse>(DoROARequest("DeleteConfigCenter", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/configCenter", "json", req, runtime));
        }

        public async Task<DeleteConfigCenterResponse> DeleteConfigCenterWithOptionsAsync(DeleteConfigCenterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
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
            return TeaModel.ToObject<DeleteConfigCenterResponse>(await DoROARequestAsync("DeleteConfigCenter", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/configCenter", "json", req, runtime));
        }

        public DeleteDegradeControlResponse DeleteDegradeControl(DeleteDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDegradeControlWithOptions(request, headers, runtime);
        }

        public async Task<DeleteDegradeControlResponse> DeleteDegradeControlAsync(DeleteDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDegradeControlWithOptionsAsync(request, headers, runtime);
        }

        public DeleteDegradeControlResponse DeleteDegradeControlWithOptions(DeleteDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteDegradeControlResponse>(DoROARequest("DeleteDegradeControl", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/degradeControl", "json", req, runtime));
        }

        public async Task<DeleteDegradeControlResponse> DeleteDegradeControlWithOptionsAsync(DeleteDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteDegradeControlResponse>(await DoROARequestAsync("DeleteDegradeControl", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/degradeControl", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteDeployGroupResponse>(DoROARequest("DeleteDeployGroup", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/deploy_group", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteDeployGroupResponse>(await DoROARequestAsync("DeleteDeployGroup", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/deploy_group", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteEcuResponse>(DoROARequest("DeleteEcu", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/delete_ecu", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteEcuResponse>(await DoROARequestAsync("DeleteEcu", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/delete_ecu", "json", req, runtime));
        }

        public DeleteFlowControlResponse DeleteFlowControl(DeleteFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFlowControlWithOptions(request, headers, runtime);
        }

        public async Task<DeleteFlowControlResponse> DeleteFlowControlAsync(DeleteFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFlowControlWithOptionsAsync(request, headers, runtime);
        }

        public DeleteFlowControlResponse DeleteFlowControlWithOptions(DeleteFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFlowControlResponse>(DoROARequest("DeleteFlowControl", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/flowControl", "json", req, runtime));
        }

        public async Task<DeleteFlowControlResponse> DeleteFlowControlWithOptionsAsync(DeleteFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFlowControlResponse>(await DoROARequestAsync("DeleteFlowControl", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/flowControl", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteK8sApplicationResponse>(DoROARequest("DeleteK8sApplication", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/k8s/acs/k8s_apps", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteK8sApplicationResponse>(await DoROARequestAsync("DeleteK8sApplication", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/k8s/acs/k8s_apps", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
            return TeaModel.ToObject<DeleteK8sIngressRuleResponse>(DoROARequest("DeleteK8sIngressRule", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/k8s/acs/k8s_ingress", "json", req, runtime));
        }

        public async Task<DeleteK8sIngressRuleResponse> DeleteK8sIngressRuleWithOptionsAsync(DeleteK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteK8sIngressRuleResponse>(await DoROARequestAsync("DeleteK8sIngressRule", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/k8s/acs/k8s_ingress", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteK8sServiceResponse>(DoROARequest("DeleteK8sService", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/k8s/acs/k8s_service", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteK8sServiceResponse>(await DoROARequestAsync("DeleteK8sService", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/k8s/acs/k8s_service", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteLogPathResponse>(DoROARequest("DeleteLogPath", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/log/popListLogDirs", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteLogPathResponse>(await DoROARequestAsync("DeleteLogPath", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/log/popListLogDirs", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteRoleResponse>(DoROARequest("DeleteRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/delete_role", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteRoleResponse>(await DoROARequestAsync("DeleteRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/delete_role", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteServiceGroupResponse>(DoROARequest("DeleteServiceGroup", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/service/serviceGroups", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteServiceGroupResponse>(await DoROARequestAsync("DeleteServiceGroup", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/service/serviceGroups", "json", req, runtime));
        }

        public DeleteServiceTimeConfigResponse DeleteServiceTimeConfig(DeleteServiceTimeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceTimeConfigWithOptions(request, headers, runtime);
        }

        public async Task<DeleteServiceTimeConfigResponse> DeleteServiceTimeConfigAsync(DeleteServiceTimeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceTimeConfigWithOptionsAsync(request, headers, runtime);
        }

        public DeleteServiceTimeConfigResponse DeleteServiceTimeConfigWithOptions(DeleteServiceTimeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteServiceTimeConfigResponse>(DoROARequest("DeleteServiceTimeConfig", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/timeout/remove", "json", req, runtime));
        }

        public async Task<DeleteServiceTimeConfigResponse> DeleteServiceTimeConfigWithOptionsAsync(DeleteServiceTimeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteServiceTimeConfigResponse>(await DoROARequestAsync("DeleteServiceTimeConfig", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/timeout/remove", "json", req, runtime));
        }

        public DeleteSwimmingLaneResponse DeleteSwimmingLane(DeleteSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSwimmingLaneWithOptions(request, headers, runtime);
        }

        public async Task<DeleteSwimmingLaneResponse> DeleteSwimmingLaneAsync(DeleteSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSwimmingLaneWithOptionsAsync(request, headers, runtime);
        }

        public DeleteSwimmingLaneResponse DeleteSwimmingLaneWithOptions(DeleteSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteSwimmingLaneResponse>(DoROARequest("DeleteSwimmingLane", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/trafficmgnt/swimming_lanes", "json", req, runtime));
        }

        public async Task<DeleteSwimmingLaneResponse> DeleteSwimmingLaneWithOptionsAsync(DeleteSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteSwimmingLaneResponse>(await DoROARequestAsync("DeleteSwimmingLane", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/trafficmgnt/swimming_lanes", "json", req, runtime));
        }

        public DeleteSwimmingLaneGroupResponse DeleteSwimmingLaneGroup(DeleteSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSwimmingLaneGroupWithOptions(request, headers, runtime);
        }

        public async Task<DeleteSwimmingLaneGroupResponse> DeleteSwimmingLaneGroupAsync(DeleteSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSwimmingLaneGroupWithOptionsAsync(request, headers, runtime);
        }

        public DeleteSwimmingLaneGroupResponse DeleteSwimmingLaneGroupWithOptions(DeleteSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteSwimmingLaneGroupResponse>(DoROARequest("DeleteSwimmingLaneGroup", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/trafficmgnt/swimming_lane_groups", "json", req, runtime));
        }

        public async Task<DeleteSwimmingLaneGroupResponse> DeleteSwimmingLaneGroupWithOptionsAsync(DeleteSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteSwimmingLaneGroupResponse>(await DoROARequestAsync("DeleteSwimmingLaneGroup", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/trafficmgnt/swimming_lane_groups", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteUserDefineRegionResponse>(DoROARequest("DeleteUserDefineRegion", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/user_region_def", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteUserDefineRegionResponse>(await DoROARequestAsync("DeleteUserDefineRegion", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/user_region_def", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarUrl))
            {
                query["WarUrl"] = request.WarUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Batch))
            {
                query["Batch"] = request.Batch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppEnv))
            {
                query["AppEnv"] = request.AppEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["ComponentIds"] = request.ComponentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseType))
            {
                query["ReleaseType"] = request.ReleaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gray))
            {
                query["Gray"] = request.Gray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlStrategy))
            {
                query["TrafficControlStrategy"] = request.TrafficControlStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeployApplicationResponse>(DoROARequest("DeployApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_deploy", "json", req, runtime));
        }

        public async Task<DeployApplicationResponse> DeployApplicationWithOptionsAsync(DeployApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarUrl))
            {
                query["WarUrl"] = request.WarUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Batch))
            {
                query["Batch"] = request.Batch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppEnv))
            {
                query["AppEnv"] = request.AppEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["ComponentIds"] = request.ComponentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseType))
            {
                query["ReleaseType"] = request.ReleaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gray))
            {
                query["Gray"] = request.Gray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlStrategy))
            {
                query["TrafficControlStrategy"] = request.TrafficControlStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeployApplicationResponse>(await DoROARequestAsync("DeployApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_deploy", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTag))
            {
                query["ImageTag"] = request.ImageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                query["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                query["CpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                query["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuRequest))
            {
                query["CpuRequest"] = request.CpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryRequest))
            {
                query["MemoryRequest"] = request.MemoryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDescs))
            {
                query["MountDescs"] = request.MountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVolume))
            {
                query["LocalVolume"] = request.LocalVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JDK))
            {
                query["JDK"] = request.JDK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UriEncoding))
            {
                query["UriEncoding"] = request.UriEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuRequest))
            {
                query["McpuRequest"] = request.McpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuLimit))
            {
                query["McpuLimit"] = request.McpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumesStr))
            {
                query["VolumesStr"] = request.VolumesStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersionId))
            {
                query["PackageVersionId"] = request.PackageVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderDesc))
            {
                query["ChangeOrderDesc"] = request.ChangeOrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeClassName))
            {
                query["RuntimeClassName"] = request.RuntimeClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossZones))
            {
                query["DeployAcrossZones"] = request.DeployAcrossZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTimeout))
            {
                query["BatchTimeout"] = request.BatchTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainerConfig))
            {
                query["WebContainerConfig"] = request.WebContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaStartUpConfig))
            {
                query["JavaStartUpConfig"] = request.JavaStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossNodes))
            {
                query["DeployAcrossNodes"] = request.DeployAcrossNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlStrategy))
            {
                query["TrafficControlStrategy"] = request.TrafficControlStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeployK8sApplicationResponse>(DoROARequest("DeployK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/k8s_apps", "json", req, runtime));
        }

        public async Task<DeployK8sApplicationResponse> DeployK8sApplicationWithOptionsAsync(DeployK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTag))
            {
                query["ImageTag"] = request.ImageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                query["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                query["CpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                query["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuRequest))
            {
                query["CpuRequest"] = request.CpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryRequest))
            {
                query["MemoryRequest"] = request.MemoryRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDescs))
            {
                query["MountDescs"] = request.MountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVolume))
            {
                query["LocalVolume"] = request.LocalVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JDK))
            {
                query["JDK"] = request.JDK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UriEncoding))
            {
                query["UriEncoding"] = request.UriEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuRequest))
            {
                query["McpuRequest"] = request.McpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuLimit))
            {
                query["McpuLimit"] = request.McpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumesStr))
            {
                query["VolumesStr"] = request.VolumesStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersionId))
            {
                query["PackageVersionId"] = request.PackageVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderDesc))
            {
                query["ChangeOrderDesc"] = request.ChangeOrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeClassName))
            {
                query["RuntimeClassName"] = request.RuntimeClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossZones))
            {
                query["DeployAcrossZones"] = request.DeployAcrossZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTimeout))
            {
                query["BatchTimeout"] = request.BatchTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainerConfig))
            {
                query["WebContainerConfig"] = request.WebContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaStartUpConfig))
            {
                query["JavaStartUpConfig"] = request.JavaStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossNodes))
            {
                query["DeployAcrossNodes"] = request.DeployAcrossNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlStrategy))
            {
                query["TrafficControlStrategy"] = request.TrafficControlStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeployK8sApplicationResponse>(await DoROARequestAsync("DeployK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/k8s_apps", "json", req, runtime));
        }

        public DisableDegradeControlResponse DisableDegradeControl(DisableDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableDegradeControlWithOptions(request, headers, runtime);
        }

        public async Task<DisableDegradeControlResponse> DisableDegradeControlAsync(DisableDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableDegradeControlWithOptionsAsync(request, headers, runtime);
        }

        public DisableDegradeControlResponse DisableDegradeControlWithOptions(DisableDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DisableDegradeControlResponse>(DoROARequest("DisableDegradeControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/degradecontrol/disable", "json", req, runtime));
        }

        public async Task<DisableDegradeControlResponse> DisableDegradeControlWithOptionsAsync(DisableDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DisableDegradeControlResponse>(await DoROARequestAsync("DisableDegradeControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/degradecontrol/disable", "json", req, runtime));
        }

        public DisableFlowControlResponse DisableFlowControl(DisableFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableFlowControlWithOptions(request, headers, runtime);
        }

        public async Task<DisableFlowControlResponse> DisableFlowControlAsync(DisableFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableFlowControlWithOptionsAsync(request, headers, runtime);
        }

        public DisableFlowControlResponse DisableFlowControlWithOptions(DisableFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DisableFlowControlResponse>(DoROARequest("DisableFlowControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/flowcontrol/disable", "json", req, runtime));
        }

        public async Task<DisableFlowControlResponse> DisableFlowControlWithOptionsAsync(DisableFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DisableFlowControlResponse>(await DoROARequestAsync("DisableFlowControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/flowcontrol/disable", "json", req, runtime));
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
            return TeaModel.ToObject<DisableMockRuleResponse>(DoROARequest("DisableMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/disableMockRule", "json", req, runtime));
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
            return TeaModel.ToObject<DisableMockRuleResponse>(await DoROARequestAsync("DisableMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/disableMockRule", "json", req, runtime));
        }

        public EnableDegradeControlResponse EnableDegradeControl(EnableDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableDegradeControlWithOptions(request, headers, runtime);
        }

        public async Task<EnableDegradeControlResponse> EnableDegradeControlAsync(EnableDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableDegradeControlWithOptionsAsync(request, headers, runtime);
        }

        public EnableDegradeControlResponse EnableDegradeControlWithOptions(EnableDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<EnableDegradeControlResponse>(DoROARequest("EnableDegradeControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/degradecontrol/enable", "json", req, runtime));
        }

        public async Task<EnableDegradeControlResponse> EnableDegradeControlWithOptionsAsync(EnableDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<EnableDegradeControlResponse>(await DoROARequestAsync("EnableDegradeControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/degradecontrol/enable", "json", req, runtime));
        }

        public EnableFlowControlResponse EnableFlowControl(EnableFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableFlowControlWithOptions(request, headers, runtime);
        }

        public async Task<EnableFlowControlResponse> EnableFlowControlAsync(EnableFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableFlowControlWithOptionsAsync(request, headers, runtime);
        }

        public EnableFlowControlResponse EnableFlowControlWithOptions(EnableFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<EnableFlowControlResponse>(DoROARequest("EnableFlowControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/flowcontrol/enable", "json", req, runtime));
        }

        public async Task<EnableFlowControlResponse> EnableFlowControlWithOptionsAsync(EnableFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<EnableFlowControlResponse>(await DoROARequestAsync("EnableFlowControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/flowcontrol/enable", "json", req, runtime));
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
            return TeaModel.ToObject<EnableMockRuleResponse>(DoROARequest("EnableMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/enableMockRule", "json", req, runtime));
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
            return TeaModel.ToObject<EnableMockRuleResponse>(await DoROARequestAsync("EnableMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/enableMockRule", "json", req, runtime));
        }

        public ExecuteStatusResponse ExecuteStatus(ExecuteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteStatusWithOptions(request, headers, runtime);
        }

        public async Task<ExecuteStatusResponse> ExecuteStatusAsync(ExecuteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteStatusWithOptionsAsync(request, headers, runtime);
        }

        public ExecuteStatusResponse ExecuteStatusWithOptions(ExecuteStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodName))
            {
                query["PodName"] = request.PodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ExecuteStatusResponse>(DoROARequest("ExecuteStatus", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mse/status/execute", "json", req, runtime));
        }

        public async Task<ExecuteStatusResponse> ExecuteStatusWithOptionsAsync(ExecuteStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodName))
            {
                query["PodName"] = request.PodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ExecuteStatusResponse>(await DoROARequestAsync("ExecuteStatus", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mse/status/execute", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppName))
            {
                query["ConsumerAppName"] = request.ConsumerAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppName))
            {
                query["ProviderAppName"] = request.ProviderAppName;
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
            return TeaModel.ToObject<GetAccountMockRuleResponse>(DoROARequest("GetAccountMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/getAccountMockRule", "json", req, runtime));
        }

        public async Task<GetAccountMockRuleResponse> GetAccountMockRuleWithOptionsAsync(GetAccountMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppName))
            {
                query["ConsumerAppName"] = request.ConsumerAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppName))
            {
                query["ProviderAppName"] = request.ProviderAppName;
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
            return TeaModel.ToObject<GetAccountMockRuleResponse>(await DoROARequestAsync("GetAccountMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/getAccountMockRule", "json", req, runtime));
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
            return TeaModel.ToObject<GetApplicationResponse>(DoROARequest("GetApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/app_info", "json", req, runtime));
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
            return TeaModel.ToObject<GetApplicationResponse>(await DoROARequestAsync("GetApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/app_info", "json", req, runtime));
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
            return TeaModel.ToObject<GetChangeOrderInfoResponse>(DoROARequest("GetChangeOrderInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/change_order_info", "json", req, runtime));
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
            return TeaModel.ToObject<GetChangeOrderInfoResponse>(await DoROARequestAsync("GetChangeOrderInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/change_order_info", "json", req, runtime));
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
            return TeaModel.ToObject<GetClusterResponse>(DoROARequest("GetCluster", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/cluster", "json", req, runtime));
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
            return TeaModel.ToObject<GetClusterResponse>(await DoROARequestAsync("GetCluster", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/cluster", "json", req, runtime));
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
            return TeaModel.ToObject<GetContainerConfigurationResponse>(DoROARequest("GetContainerConfiguration", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/container_config", "json", req, runtime));
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
            return TeaModel.ToObject<GetContainerConfigurationResponse>(await DoROARequestAsync("GetContainerConfiguration", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/container_config", "json", req, runtime));
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
            return TeaModel.ToObject<GetJvmConfigurationResponse>(DoROARequest("GetJvmConfiguration", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/app_jvm_config", "json", req, runtime));
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
            return TeaModel.ToObject<GetJvmConfigurationResponse>(await DoROARequestAsync("GetJvmConfiguration", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/app_jvm_config", "json", req, runtime));
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
            return TeaModel.ToObject<GetK8sApplicationResponse>(DoROARequest("GetK8sApplication", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/changeorder/co_application", "json", req, runtime));
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
            return TeaModel.ToObject<GetK8sApplicationResponse>(await DoROARequestAsync("GetK8sApplication", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/changeorder/co_application", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetK8sClusterResponse>(DoROARequest("GetK8sCluster", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s_clusters", "json", req, runtime));
        }

        public async Task<GetK8sClusterResponse> GetK8sClusterWithOptionsAsync(GetK8sClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetK8sClusterResponse>(await DoROARequestAsync("GetK8sCluster", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s_clusters", "json", req, runtime));
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
            return TeaModel.ToObject<GetK8sServicesResponse>(DoROARequest("GetK8sServices", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/k8s/acs/k8s_service", "json", req, runtime));
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
            return TeaModel.ToObject<GetK8sServicesResponse>(await DoROARequestAsync("GetK8sServices", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/k8s/acs/k8s_service", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetMockRuleByConsumerAppIdResponse>(DoROARequest("GetMockRuleByConsumerAppId", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/getMockRuleByConsumerAppId", "json", req, runtime));
        }

        public async Task<GetMockRuleByConsumerAppIdResponse> GetMockRuleByConsumerAppIdWithOptionsAsync(GetMockRuleByConsumerAppIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetMockRuleByConsumerAppIdResponse>(await DoROARequestAsync("GetMockRuleByConsumerAppId", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/getMockRuleByConsumerAppId", "json", req, runtime));
        }

        public GetMockRuleByIdResponse GetMockRuleById(GetMockRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMockRuleByIdWithOptions(request, headers, runtime);
        }

        public async Task<GetMockRuleByIdResponse> GetMockRuleByIdAsync(GetMockRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMockRuleByIdWithOptionsAsync(request, headers, runtime);
        }

        public GetMockRuleByIdResponse GetMockRuleByIdWithOptions(GetMockRuleByIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetMockRuleByIdResponse>(DoROARequest("GetMockRuleById", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/getMockRuleById", "json", req, runtime));
        }

        public async Task<GetMockRuleByIdResponse> GetMockRuleByIdWithOptionsAsync(GetMockRuleByIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetMockRuleByIdResponse>(await DoROARequestAsync("GetMockRuleById", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/getMockRuleById", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppId))
            {
                query["ProviderAppId"] = request.ProviderAppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetMockRuleByProviderAppIdResponse>(DoROARequest("GetMockRuleByProviderAppId", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/getMockRuleByProviderAppId", "json", req, runtime));
        }

        public async Task<GetMockRuleByProviderAppIdResponse> GetMockRuleByProviderAppIdWithOptionsAsync(GetMockRuleByProviderAppIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderAppId))
            {
                query["ProviderAppId"] = request.ProviderAppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetMockRuleByProviderAppIdResponse>(await DoROARequestAsync("GetMockRuleByProviderAppId", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/getMockRuleByProviderAppId", "json", req, runtime));
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
            return TeaModel.ToObject<GetPackageStorageCredentialResponse>(DoROARequest("GetPackageStorageCredential", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/package_storage_credential", "json", req, runtime));
        }

        public async Task<GetPackageStorageCredentialResponse> GetPackageStorageCredentialWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetPackageStorageCredentialResponse>(await DoROARequestAsync("GetPackageStorageCredential", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/package_storage_credential", "json", req, runtime));
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
            return TeaModel.ToObject<GetScalingRulesResponse>(DoROARequest("GetScalingRules", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/scalingRules", "json", req, runtime));
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
            return TeaModel.ToObject<GetScalingRulesResponse>(await DoROARequestAsync("GetScalingRules", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/scalingRules", "json", req, runtime));
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
            return TeaModel.ToObject<GetSecureTokenResponse>(DoROARequest("GetSecureToken", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/secure_token", "json", req, runtime));
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
            return TeaModel.ToObject<GetSecureTokenResponse>(await DoROARequestAsync("GetSecureToken", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/secure_token", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
            return TeaModel.ToObject<GetServiceConsumersPageResponse>(DoROARequest("GetServiceConsumersPage", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceConsumersPage", "json", req, runtime));
        }

        public async Task<GetServiceConsumersPageResponse> GetServiceConsumersPageWithOptionsAsync(GetServiceConsumersPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
            return TeaModel.ToObject<GetServiceConsumersPageResponse>(await DoROARequestAsync("GetServiceConsumersPage", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceConsumersPage", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetServiceDetailResponse>(DoROARequest("GetServiceDetail", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceDetail", "json", req, runtime));
        }

        public async Task<GetServiceDetailResponse> GetServiceDetailWithOptionsAsync(GetServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetServiceDetailResponse>(await DoROARequestAsync("GetServiceDetail", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceDetail", "json", req, runtime));
        }

        public GetServiceListResponse GetServiceList(GetServiceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceListWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceListResponse> GetServiceListAsync(GetServiceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceListWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceListResponse GetServiceListWithOptions(GetServiceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["searchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                query["side"] = request.Side;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetServiceListResponse>(DoROARequest("GetServiceList", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceList", "json", req, runtime));
        }

        public async Task<GetServiceListResponse> GetServiceListWithOptionsAsync(GetServiceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["searchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                query["side"] = request.Side;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetServiceListResponse>(await DoROARequestAsync("GetServiceList", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceList", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["searchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                query["side"] = request.Side;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
            return TeaModel.ToObject<GetServiceListPageResponse>(DoROARequest("GetServiceListPage", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceListPage", "json", req, runtime));
        }

        public async Task<GetServiceListPageResponse> GetServiceListPageWithOptionsAsync(GetServiceListPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["searchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                query["side"] = request.Side;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
            return TeaModel.ToObject<GetServiceListPageResponse>(await DoROARequestAsync("GetServiceListPage", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceListPage", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodController))
            {
                query["methodController"] = request.MethodController;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetServiceMethodPageResponse>(DoROARequest("GetServiceMethodPage", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceMethodPage", "json", req, runtime));
        }

        public async Task<GetServiceMethodPageResponse> GetServiceMethodPageWithOptionsAsync(GetServiceMethodPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodController))
            {
                query["methodController"] = request.MethodController;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetServiceMethodPageResponse>(await DoROARequestAsync("GetServiceMethodPage", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceMethodPage", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
            return TeaModel.ToObject<GetServiceProvidersPageResponse>(DoROARequest("GetServiceProvidersPage", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceProvidersPage", "json", req, runtime));
        }

        public async Task<GetServiceProvidersPageResponse> GetServiceProvidersPageWithOptionsAsync(GetServiceProvidersPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["serviceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["registryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
            return TeaModel.ToObject<GetServiceProvidersPageResponse>(await DoROARequestAsync("GetServiceProvidersPage", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mseForOam/getServiceProvidersPage", "json", req, runtime));
        }

        public GetSubAccountInfoResponse GetSubAccountInfo(GetSubAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubAccountInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetSubAccountInfoResponse> GetSubAccountInfoAsync(GetSubAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubAccountInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetSubAccountInfoResponse GetSubAccountInfoWithOptions(GetSubAccountInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSubAccountInfoResponse>(DoROARequest("GetSubAccountInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/sub_account_info", "json", req, runtime));
        }

        public async Task<GetSubAccountInfoResponse> GetSubAccountInfoWithOptionsAsync(GetSubAccountInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSubAccountInfoResponse>(await DoROARequestAsync("GetSubAccountInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/sub_account_info", "json", req, runtime));
        }

        public GetSwimmingLaneResponse GetSwimmingLane(GetSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSwimmingLaneWithOptions(request, headers, runtime);
        }

        public async Task<GetSwimmingLaneResponse> GetSwimmingLaneAsync(GetSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSwimmingLaneWithOptionsAsync(request, headers, runtime);
        }

        public GetSwimmingLaneResponse GetSwimmingLaneWithOptions(GetSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSwimmingLaneResponse>(DoROARequest("GetSwimmingLane", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/trafficmgnt/swimming_lane", "json", req, runtime));
        }

        public async Task<GetSwimmingLaneResponse> GetSwimmingLaneWithOptionsAsync(GetSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSwimmingLaneResponse>(await DoROARequestAsync("GetSwimmingLane", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/trafficmgnt/swimming_lane", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAsm))
            {
                query["EnableAsm"] = request.EnableAsm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ImportK8sClusterResponse>(DoROARequest("ImportK8sCluster", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/import_k8s_cluster", "json", req, runtime));
        }

        public async Task<ImportK8sClusterResponse> ImportK8sClusterWithOptionsAsync(ImportK8sClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAsm))
            {
                query["EnableAsm"] = request.EnableAsm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ImportK8sClusterResponse>(await DoROARequestAsync("ImportK8sCluster", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/import_k8s_cluster", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPortStr))
            {
                query["ReservedPortStr"] = request.ReservedPortStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuInfo))
            {
                query["EcuInfo"] = request.EcuInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mem))
            {
                query["Mem"] = request.Mem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURL))
            {
                query["HealthCheckURL"] = request.HealthCheckURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["ComponentIds"] = request.ComponentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hooks))
            {
                query["Hooks"] = request.Hooks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JvmOptions))
            {
                query["JvmOptions"] = request.JvmOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeapSize))
            {
                query["MinHeapSize"] = request.MinHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPermSize))
            {
                query["MaxPermSize"] = request.MaxPermSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeapSize))
            {
                query["MaxHeapSize"] = request.MaxHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUrlCheck))
            {
                query["EnableUrlCheck"] = request.EnableUrlCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePortCheck))
            {
                query["EnablePortCheck"] = request.EnablePortCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckUrl))
            {
                query["HealthCheckUrl"] = request.HealthCheckUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertApplicationResponse>(DoROARequest("InsertApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_create_app", "json", req, runtime));
        }

        public async Task<InsertApplicationResponse> InsertApplicationWithOptionsAsync(InsertApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildPackId))
            {
                query["BuildPackId"] = request.BuildPackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPortStr))
            {
                query["ReservedPortStr"] = request.ReservedPortStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuInfo))
            {
                query["EcuInfo"] = request.EcuInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mem))
            {
                query["Mem"] = request.Mem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURL))
            {
                query["HealthCheckURL"] = request.HealthCheckURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["ComponentIds"] = request.ComponentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hooks))
            {
                query["Hooks"] = request.Hooks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JvmOptions))
            {
                query["JvmOptions"] = request.JvmOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeapSize))
            {
                query["MinHeapSize"] = request.MinHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPermSize))
            {
                query["MaxPermSize"] = request.MaxPermSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeapSize))
            {
                query["MaxHeapSize"] = request.MaxHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUrlCheck))
            {
                query["EnableUrlCheck"] = request.EnableUrlCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePortCheck))
            {
                query["EnablePortCheck"] = request.EnablePortCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckUrl))
            {
                query["HealthCheckUrl"] = request.HealthCheckUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertApplicationResponse>(await DoROARequestAsync("InsertApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_create_app", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkMode))
            {
                query["NetworkMode"] = request.NetworkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversoldFactor))
            {
                query["OversoldFactor"] = request.OversoldFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IaasProvider))
            {
                query["IaasProvider"] = request.IaasProvider;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertClusterResponse>(DoROARequest("InsertCluster", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/cluster", "json", req, runtime));
        }

        public async Task<InsertClusterResponse> InsertClusterWithOptionsAsync(InsertClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkMode))
            {
                query["NetworkMode"] = request.NetworkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversoldFactor))
            {
                query["OversoldFactor"] = request.OversoldFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IaasProvider))
            {
                query["IaasProvider"] = request.IaasProvider;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertClusterResponse>(await DoROARequestAsync("InsertCluster", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/cluster", "json", req, runtime));
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
            return TeaModel.ToObject<InsertClusterMemberResponse>(DoROARequest("InsertClusterMember", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/cluster_member", "json", req, runtime));
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
            return TeaModel.ToObject<InsertClusterMemberResponse>(await DoROARequestAsync("InsertClusterMember", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/cluster_member", "json", req, runtime));
        }

        public InsertConfigCenterResponse InsertConfigCenter(InsertConfigCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertConfigCenterWithOptions(request, headers, runtime);
        }

        public async Task<InsertConfigCenterResponse> InsertConfigCenterAsync(InsertConfigCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertConfigCenterWithOptionsAsync(request, headers, runtime);
        }

        public InsertConfigCenterResponse InsertConfigCenterWithOptions(InsertConfigCenterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertConfigCenterResponse>(DoROARequest("InsertConfigCenter", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/configCenter", "json", req, runtime));
        }

        public async Task<InsertConfigCenterResponse> InsertConfigCenterWithOptionsAsync(InsertConfigCenterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertConfigCenterResponse>(await DoROARequestAsync("InsertConfigCenter", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/configCenter", "json", req, runtime));
        }

        public InsertDegradeControlResponse InsertDegradeControl(InsertDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertDegradeControlWithOptions(request, headers, runtime);
        }

        public async Task<InsertDegradeControlResponse> InsertDegradeControlAsync(InsertDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertDegradeControlWithOptionsAsync(request, headers, runtime);
        }

        public InsertDegradeControlResponse InsertDegradeControlWithOptions(InsertDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RtThreshold))
            {
                query["RtThreshold"] = request.RtThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlVar))
            {
                query["UrlVar"] = request.UrlVar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertDegradeControlResponse>(DoROARequest("InsertDegradeControl", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/degradeControl", "json", req, runtime));
        }

        public async Task<InsertDegradeControlResponse> InsertDegradeControlWithOptionsAsync(InsertDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RtThreshold))
            {
                query["RtThreshold"] = request.RtThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlVar))
            {
                query["UrlVar"] = request.UrlVar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertDegradeControlResponse>(await DoROARequestAsync("InsertDegradeControl", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/degradeControl", "json", req, runtime));
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
            return TeaModel.ToObject<InsertDeployGroupResponse>(DoROARequest("InsertDeployGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/deploy_group", "json", req, runtime));
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
            return TeaModel.ToObject<InsertDeployGroupResponse>(await DoROARequestAsync("InsertDeployGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/deploy_group", "json", req, runtime));
        }

        public InsertFlowControlResponse InsertFlowControl(InsertFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertFlowControlWithOptions(request, headers, runtime);
        }

        public async Task<InsertFlowControlResponse> InsertFlowControlAsync(InsertFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertFlowControlWithOptionsAsync(request, headers, runtime);
        }

        public InsertFlowControlResponse InsertFlowControlWithOptions(InsertFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                query["Strategy"] = request.Strategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlVar))
            {
                query["UrlVar"] = request.UrlVar;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertFlowControlResponse>(DoROARequest("InsertFlowControl", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/flowControl", "json", req, runtime));
        }

        public async Task<InsertFlowControlResponse> InsertFlowControlWithOptionsAsync(InsertFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                query["Strategy"] = request.Strategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlVar))
            {
                query["UrlVar"] = request.UrlVar;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertFlowControlResponse>(await DoROARequestAsync("InsertFlowControl", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/flowControl", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetTargetPort))
            {
                query["IntranetTargetPort"] = request.IntranetTargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbPort))
            {
                query["IntranetSlbPort"] = request.IntranetSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationDescription))
            {
                query["ApplicationDescription"] = request.ApplicationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitCpu))
            {
                query["LimitCpu"] = request.LimitCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitMem))
            {
                query["LimitMem"] = request.LimitMem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsCpu))
            {
                query["RequestsCpu"] = request.RequestsCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsMem))
            {
                query["RequestsMem"] = request.RequestsMem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbProtocol))
            {
                query["IntranetSlbProtocol"] = request.IntranetSlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbId))
            {
                query["IntranetSlbId"] = request.IntranetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbId))
            {
                query["InternetSlbId"] = request.InternetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbProtocol))
            {
                query["InternetSlbProtocol"] = request.InternetSlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbPort))
            {
                query["InternetSlbPort"] = request.InternetSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetTargetPort))
            {
                query["InternetTargetPort"] = request.InternetTargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDescs))
            {
                query["MountDescs"] = request.MountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVolume))
            {
                query["LocalVolume"] = request.LocalVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JDK))
            {
                query["JDK"] = request.JDK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UriEncoding))
            {
                query["UriEncoding"] = request.UriEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsmCpu))
            {
                query["RequestsmCpu"] = request.RequestsmCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitmCpu))
            {
                query["LimitmCpu"] = request.LimitmCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeClassName))
            {
                query["RuntimeClassName"] = request.RuntimeClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossZones))
            {
                query["DeployAcrossZones"] = request.DeployAcrossZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainerConfig))
            {
                query["WebContainerConfig"] = request.WebContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaStartUpConfig))
            {
                query["JavaStartUpConfig"] = request.JavaStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMultilingualApp))
            {
                query["IsMultilingualApp"] = request.IsMultilingualApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossNodes))
            {
                query["DeployAcrossNodes"] = request.DeployAcrossNodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertK8sApplicationResponse>(DoROARequest("InsertK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/create_k8s_app", "json", req, runtime));
        }

        public async Task<InsertK8sApplicationResponse> InsertK8sApplicationWithOptionsAsync(InsertK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetTargetPort))
            {
                query["IntranetTargetPort"] = request.IntranetTargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbPort))
            {
                query["IntranetSlbPort"] = request.IntranetSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationDescription))
            {
                query["ApplicationDescription"] = request.ApplicationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitCpu))
            {
                query["LimitCpu"] = request.LimitCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitMem))
            {
                query["LimitMem"] = request.LimitMem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsCpu))
            {
                query["RequestsCpu"] = request.RequestsCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsMem))
            {
                query["RequestsMem"] = request.RequestsMem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbProtocol))
            {
                query["IntranetSlbProtocol"] = request.IntranetSlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbId))
            {
                query["IntranetSlbId"] = request.IntranetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbId))
            {
                query["InternetSlbId"] = request.InternetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbProtocol))
            {
                query["InternetSlbProtocol"] = request.InternetSlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbPort))
            {
                query["InternetSlbPort"] = request.InternetSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetTargetPort))
            {
                query["InternetTargetPort"] = request.InternetTargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDescs))
            {
                query["MountDescs"] = request.MountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVolume))
            {
                query["LocalVolume"] = request.LocalVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JDK))
            {
                query["JDK"] = request.JDK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UriEncoding))
            {
                query["UriEncoding"] = request.UriEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBodyEncoding))
            {
                query["UseBodyEncoding"] = request.UseBodyEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestsmCpu))
            {
                query["RequestsmCpu"] = request.RequestsmCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitmCpu))
            {
                query["LimitmCpu"] = request.LimitmCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeClassName))
            {
                query["RuntimeClassName"] = request.RuntimeClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossZones))
            {
                query["DeployAcrossZones"] = request.DeployAcrossZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainerConfig))
            {
                query["WebContainerConfig"] = request.WebContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaStartUpConfig))
            {
                query["JavaStartUpConfig"] = request.JavaStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMultilingualApp))
            {
                query["IsMultilingualApp"] = request.IsMultilingualApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployAcrossNodes))
            {
                query["DeployAcrossNodes"] = request.DeployAcrossNodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertK8sApplicationResponse>(await DoROARequestAsync("InsertK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/create_k8s_app", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionName))
            {
                query["RegionName"] = request.RegionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugEnable))
            {
                query["DebugEnable"] = request.DebugEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertOrUpdateRegionResponse>(DoROARequest("InsertOrUpdateRegion", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/user_region_def", "json", req, runtime));
        }

        public async Task<InsertOrUpdateRegionResponse> InsertOrUpdateRegionWithOptionsAsync(InsertOrUpdateRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                query["RegionTag"] = request.RegionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionName))
            {
                query["RegionName"] = request.RegionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugEnable))
            {
                query["DebugEnable"] = request.DebugEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertOrUpdateRegionResponse>(await DoROARequestAsync("InsertOrUpdateRegion", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/user_region_def", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionData))
            {
                query["ActionData"] = request.ActionData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertRoleResponse>(DoROARequest("InsertRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/create_role", "json", req, runtime));
        }

        public async Task<InsertRoleResponse> InsertRoleWithOptionsAsync(InsertRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionData))
            {
                query["ActionData"] = request.ActionData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertRoleResponse>(await DoROARequestAsync("InsertRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/create_role", "json", req, runtime));
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
            return TeaModel.ToObject<InsertServiceGroupResponse>(DoROARequest("InsertServiceGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/service/serviceGroups", "json", req, runtime));
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
            return TeaModel.ToObject<InsertServiceGroupResponse>(await DoROARequestAsync("InsertServiceGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/service/serviceGroups", "json", req, runtime));
        }

        public InsertSwimmingLaneResponse InsertSwimmingLane(InsertSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertSwimmingLaneWithOptions(request, headers, runtime);
        }

        public async Task<InsertSwimmingLaneResponse> InsertSwimmingLaneAsync(InsertSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertSwimmingLaneWithOptionsAsync(request, headers, runtime);
        }

        public InsertSwimmingLaneResponse InsertSwimmingLaneWithOptions(InsertSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryRules))
            {
                query["EntryRules"] = request.EntryRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRules))
            {
                query["EnableRules"] = request.EnableRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInfos))
            {
                query["AppInfos"] = request.AppInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertSwimmingLaneResponse>(DoROARequest("InsertSwimmingLane", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/trafficmgnt/swimming_lanes", "json", req, runtime));
        }

        public async Task<InsertSwimmingLaneResponse> InsertSwimmingLaneWithOptionsAsync(InsertSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryRules))
            {
                query["EntryRules"] = request.EntryRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRules))
            {
                query["EnableRules"] = request.EnableRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInfos))
            {
                query["AppInfos"] = request.AppInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InsertSwimmingLaneResponse>(await DoROARequestAsync("InsertSwimmingLane", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/trafficmgnt/swimming_lanes", "json", req, runtime));
        }

        public InsertSwimmingLaneGroupResponse InsertSwimmingLaneGroup(InsertSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InsertSwimmingLaneGroupWithOptions(request, headers, runtime);
        }

        public async Task<InsertSwimmingLaneGroupResponse> InsertSwimmingLaneGroupAsync(InsertSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InsertSwimmingLaneGroupWithOptionsAsync(request, headers, runtime);
        }

        public InsertSwimmingLaneGroupResponse InsertSwimmingLaneGroupWithOptions(InsertSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryApp))
            {
                query["EntryApp"] = request.EntryApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
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
            return TeaModel.ToObject<InsertSwimmingLaneGroupResponse>(DoROARequest("InsertSwimmingLaneGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/trafficmgnt/swimming_lane_groups", "json", req, runtime));
        }

        public async Task<InsertSwimmingLaneGroupResponse> InsertSwimmingLaneGroupWithOptionsAsync(InsertSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryApp))
            {
                query["EntryApp"] = request.EntryApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
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
            return TeaModel.ToObject<InsertSwimmingLaneGroupResponse>(await DoROARequestAsync("InsertSwimmingLaneGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/trafficmgnt/swimming_lane_groups", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DoAsync))
            {
                query["DoAsync"] = request.DoAsync;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallAgentResponse>(DoROARequest("InstallAgent", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/ecss/install_agent", "json", req, runtime));
        }

        public async Task<InstallAgentResponse> InstallAgentWithOptionsAsync(InstallAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DoAsync))
            {
                query["DoAsync"] = request.DoAsync;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallAgentResponse>(await DoROARequestAsync("InstallAgent", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/ecss/install_agent", "json", req, runtime));
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
            return TeaModel.ToObject<ListAliyunRegionResponse>(DoROARequest("ListAliyunRegion", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/region_list", "json", req, runtime));
        }

        public async Task<ListAliyunRegionResponse> ListAliyunRegionWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListAliyunRegionResponse>(await DoROARequestAsync("ListAliyunRegion", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/region_list", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionIdFilter))
            {
                query["LogicalRegionIdFilter"] = request.LogicalRegionIdFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListApplicationResponse>(DoROARequest("ListApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/app_list", "json", req, runtime));
        }

        public async Task<ListApplicationResponse> ListApplicationWithOptionsAsync(ListApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionIdFilter))
            {
                query["LogicalRegionIdFilter"] = request.LogicalRegionIdFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListApplicationResponse>(await DoROARequestAsync("ListApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/app_list", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListApplicationEcuResponse>(DoROARequest("ListApplicationEcu", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/ecu_list", "json", req, runtime));
        }

        public async Task<ListApplicationEcuResponse> ListApplicationEcuWithOptionsAsync(ListApplicationEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListApplicationEcuResponse>(await DoROARequestAsync("ListApplicationEcu", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/ecu_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListAuthorityResponse>(DoROARequest("ListAuthority", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/authority_list", "json", req, runtime));
        }

        public async Task<ListAuthorityResponse> ListAuthorityWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListAuthorityResponse>(await DoROARequestAsync("ListAuthority", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/authority_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListBuildPackResponse>(DoROARequest("ListBuildPack", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/build_pack_list", "json", req, runtime));
        }

        public async Task<ListBuildPackResponse> ListBuildPackWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListBuildPackResponse>(await DoROARequestAsync("ListBuildPack", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/build_pack_list", "json", req, runtime));
        }

        public ListChildrenStacksResponse ListChildrenStacks(ListChildrenStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChildrenStacksWithOptions(request, headers, runtime);
        }

        public async Task<ListChildrenStacksResponse> ListChildrenStacksAsync(ListChildrenStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChildrenStacksWithOptionsAsync(request, headers, runtime);
        }

        public ListChildrenStacksResponse ListChildrenStacksWithOptions(ListChildrenStacksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
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
            return TeaModel.ToObject<ListChildrenStacksResponse>(DoROARequest("ListChildrenStacks", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/s2i/list_children_stack", "json", req, runtime));
        }

        public async Task<ListChildrenStacksResponse> ListChildrenStacksWithOptionsAsync(ListChildrenStacksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
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
            return TeaModel.ToObject<ListChildrenStacksResponse>(await DoROARequestAsync("ListChildrenStacks", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/s2i/list_children_stack", "json", req, runtime));
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
            return TeaModel.ToObject<ListClusterResponse>(DoROARequest("ListCluster", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/cluster_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListClusterResponse>(await DoROARequestAsync("ListCluster", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/cluster_list", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsList))
            {
                query["EcsList"] = request.EcsList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListClusterMembersResponse>(DoROARequest("ListClusterMembers", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/cluster_member_list", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsList))
            {
                query["EcsList"] = request.EcsList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListClusterMembersResponse>(await DoROARequestAsync("ListClusterMembers", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/cluster_member_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListComponentsResponse>(DoROARequest("ListComponents", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/components", "json", req, runtime));
        }

        public async Task<ListComponentsResponse> ListComponentsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListComponentsResponse>(await DoROARequestAsync("ListComponents", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/components", "json", req, runtime));
        }

        public ListConfigCentersResponse ListConfigCenters(ListConfigCentersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigCentersWithOptions(request, headers, runtime);
        }

        public async Task<ListConfigCentersResponse> ListConfigCentersAsync(ListConfigCentersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigCentersWithOptionsAsync(request, headers, runtime);
        }

        public ListConfigCentersResponse ListConfigCentersWithOptions(ListConfigCentersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIdPattern))
            {
                query["DataIdPattern"] = request.DataIdPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListConfigCentersResponse>(DoROARequest("ListConfigCenters", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/configCenters", "json", req, runtime));
        }

        public async Task<ListConfigCentersResponse> ListConfigCentersWithOptionsAsync(ListConfigCentersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIdPattern))
            {
                query["DataIdPattern"] = request.DataIdPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListConfigCentersResponse>(await DoROARequestAsync("ListConfigCenters", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/configCenters", "json", req, runtime));
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
            return TeaModel.ToObject<ListConsumedServicesResponse>(DoROARequest("ListConsumedServices", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/service/listConsumedServices", "json", req, runtime));
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
            return TeaModel.ToObject<ListConsumedServicesResponse>(await DoROARequestAsync("ListConsumedServices", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/service/listConsumedServices", "json", req, runtime));
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
            return TeaModel.ToObject<ListConvertableEcuResponse>(DoROARequest("ListConvertableEcu", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/convertable_ecu_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListConvertableEcuResponse>(await DoROARequestAsync("ListConvertableEcu", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/convertable_ecu_list", "json", req, runtime));
        }

        public ListCSBGatewayResponse ListCSBGateway(ListCSBGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCSBGatewayWithOptions(request, headers, runtime);
        }

        public async Task<ListCSBGatewayResponse> ListCSBGatewayAsync(ListCSBGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCSBGatewayWithOptionsAsync(request, headers, runtime);
        }

        public ListCSBGatewayResponse ListCSBGatewayWithOptions(ListCSBGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListCSBGatewayResponse>(DoROARequest("ListCSBGateway", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/csbgateway/gateway", "json", req, runtime));
        }

        public async Task<ListCSBGatewayResponse> ListCSBGatewayWithOptionsAsync(ListCSBGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListCSBGatewayResponse>(await DoROARequestAsync("ListCSBGateway", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/csbgateway/gateway", "json", req, runtime));
        }

        public ListDegradeControlsResponse ListDegradeControls(ListDegradeControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDegradeControlsWithOptions(request, headers, runtime);
        }

        public async Task<ListDegradeControlsResponse> ListDegradeControlsAsync(ListDegradeControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDegradeControlsWithOptionsAsync(request, headers, runtime);
        }

        public ListDegradeControlsResponse ListDegradeControlsWithOptions(ListDegradeControlsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListDegradeControlsResponse>(DoROARequest("ListDegradeControls", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/degradeControls", "json", req, runtime));
        }

        public async Task<ListDegradeControlsResponse> ListDegradeControlsWithOptionsAsync(ListDegradeControlsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListDegradeControlsResponse>(await DoROARequestAsync("ListDegradeControls", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/degradeControls", "json", req, runtime));
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
            return TeaModel.ToObject<ListDeployGroupResponse>(DoROARequest("ListDeployGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/deploy_group_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListDeployGroupResponse>(await DoROARequestAsync("ListDeployGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/deploy_group_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListEcsNotInClusterResponse>(DoROARequest("ListEcsNotInCluster", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/ecs_not_in_cluster", "json", req, runtime));
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
            return TeaModel.ToObject<ListEcsNotInClusterResponse>(await DoROARequestAsync("ListEcsNotInCluster", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/ecs_not_in_cluster", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                query["Act"] = request.Act;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEcuByRegionResponse>(DoROARequest("ListEcuByRegion", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/ecu_list", "json", req, runtime));
        }

        public async Task<ListEcuByRegionResponse> ListEcuByRegionWithOptionsAsync(ListEcuByRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                query["Act"] = request.Act;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEcuByRegionResponse>(await DoROARequestAsync("ListEcuByRegion", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/ecu_list", "json", req, runtime));
        }

        public ListFlowControlsResponse ListFlowControls(ListFlowControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowControlsWithOptions(request, headers, runtime);
        }

        public async Task<ListFlowControlsResponse> ListFlowControlsAsync(ListFlowControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowControlsWithOptionsAsync(request, headers, runtime);
        }

        public ListFlowControlsResponse ListFlowControlsWithOptions(ListFlowControlsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListFlowControlsResponse>(DoROARequest("ListFlowControls", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/flowControls", "json", req, runtime));
        }

        public async Task<ListFlowControlsResponse> ListFlowControlsWithOptionsAsync(ListFlowControlsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListFlowControlsResponse>(await DoROARequestAsync("ListFlowControls", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/flowControls", "json", req, runtime));
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
            return TeaModel.ToObject<ListHistoryDeployVersionResponse>(DoROARequest("ListHistoryDeployVersion", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/deploy_history_version_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListHistoryDeployVersionResponse>(await DoROARequestAsync("ListHistoryDeployVersion", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/deploy_history_version_list", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
            return TeaModel.ToObject<ListK8sIngressRulesResponse>(DoROARequest("ListK8sIngressRules", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/k8s/acs/k8s_ingress", "json", req, runtime));
        }

        public async Task<ListK8sIngressRulesResponse> ListK8sIngressRulesWithOptionsAsync(ListK8sIngressRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
            return TeaModel.ToObject<ListK8sIngressRulesResponse>(await DoROARequestAsync("ListK8sIngressRules", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/k8s/acs/k8s_ingress", "json", req, runtime));
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
            return TeaModel.ToObject<ListMethodsResponse>(DoROARequest("ListMethods", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/service/list_methods", "json", req, runtime));
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
            return TeaModel.ToObject<ListMethodsResponse>(await DoROARequestAsync("ListMethods", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/service/list_methods", "json", req, runtime));
        }

        public ListOperationLogsResponse ListOperationLogs(ListOperationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOperationLogsWithOptions(request, headers, runtime);
        }

        public async Task<ListOperationLogsResponse> ListOperationLogsAsync(ListOperationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOperationLogsWithOptionsAsync(request, headers, runtime);
        }

        public ListOperationLogsResponse ListOperationLogsWithOptions(ListOperationLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
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
            return TeaModel.ToObject<ListOperationLogsResponse>(DoROARequest("ListOperationLogs", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/operationlog/log_list", "json", req, runtime));
        }

        public async Task<ListOperationLogsResponse> ListOperationLogsWithOptionsAsync(ListOperationLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
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
            return TeaModel.ToObject<ListOperationLogsResponse>(await DoROARequestAsync("ListOperationLogs", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/operationlog/log_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListPublishedServicesResponse>(DoROARequest("ListPublishedServices", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/service/listPublishedServices", "json", req, runtime));
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
            return TeaModel.ToObject<ListPublishedServicesResponse>(await DoROARequestAsync("ListPublishedServices", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/service/listPublishedServices", "json", req, runtime));
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
            return TeaModel.ToObject<ListRecentChangeOrderResponse>(DoROARequest("ListRecentChangeOrder", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/change_order_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListRecentChangeOrderResponse>(await DoROARequestAsync("ListRecentChangeOrder", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/change_order_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListResourceGroupResponse>(DoROARequest("ListResourceGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/reg_group_list", "json", req, runtime));
        }

        public async Task<ListResourceGroupResponse> ListResourceGroupWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListResourceGroupResponse>(await DoROARequestAsync("ListResourceGroup", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/reg_group_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListRoleResponse>(DoROARequest("ListRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/role_list", "json", req, runtime));
        }

        public async Task<ListRoleResponse> ListRoleWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListRoleResponse>(await DoROARequestAsync("ListRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/role_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListRootStacksResponse>(DoROARequest("ListRootStacks", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/s2i/list_root_stack", "json", req, runtime));
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
            return TeaModel.ToObject<ListRootStacksResponse>(await DoROARequestAsync("ListRootStacks", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/s2i/list_root_stack", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mem))
            {
                query["Mem"] = request.Mem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNum))
            {
                query["InstanceNum"] = request.InstanceNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListScaleOutEcuResponse>(DoROARequest("ListScaleOutEcu", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/scale_out_ecu_list", "json", req, runtime));
        }

        public async Task<ListScaleOutEcuResponse> ListScaleOutEcuWithOptionsAsync(ListScaleOutEcuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalRegionId))
            {
                query["LogicalRegionId"] = request.LogicalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mem))
            {
                query["Mem"] = request.Mem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNum))
            {
                query["InstanceNum"] = request.InstanceNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListScaleOutEcuResponse>(await DoROARequestAsync("ListScaleOutEcu", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/scale_out_ecu_list", "json", req, runtime));
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
            return TeaModel.ToObject<ListServiceGroupsResponse>(DoROARequest("ListServiceGroups", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/service/serviceGroups", "json", req, runtime));
        }

        public async Task<ListServiceGroupsResponse> ListServiceGroupsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListServiceGroupsResponse>(await DoROARequestAsync("ListServiceGroups", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/service/serviceGroups", "json", req, runtime));
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
            return TeaModel.ToObject<ListSlbResponse>(DoROARequest("ListSlb", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/slb_list", "json", req, runtime));
        }

        public async Task<ListSlbResponse> ListSlbWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSlbResponse>(await DoROARequestAsync("ListSlb", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/slb_list", "json", req, runtime));
        }

        public ListStatusResponse ListStatus(ListStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListStatusWithOptions(request, headers, runtime);
        }

        public async Task<ListStatusResponse> ListStatusAsync(ListStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListStatusWithOptionsAsync(request, headers, runtime);
        }

        public ListStatusResponse ListStatusWithOptions(ListStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodName))
            {
                query["PodName"] = request.PodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListStatusResponse>(DoROARequest("ListStatus", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mse/status/list", "json", req, runtime));
        }

        public async Task<ListStatusResponse> ListStatusWithOptionsAsync(ListStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodName))
            {
                query["PodName"] = request.PodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListStatusResponse>(await DoROARequestAsync("ListStatus", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mse/status/list", "json", req, runtime));
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
            return TeaModel.ToObject<ListSubAccountResponse>(DoROARequest("ListSubAccount", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/sub_account_list", "json", req, runtime));
        }

        public async Task<ListSubAccountResponse> ListSubAccountWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSubAccountResponse>(await DoROARequestAsync("ListSubAccount", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/sub_account_list", "json", req, runtime));
        }

        public ListSwimmingLaneResponse ListSwimmingLane(ListSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSwimmingLaneWithOptions(request, headers, runtime);
        }

        public async Task<ListSwimmingLaneResponse> ListSwimmingLaneAsync(ListSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSwimmingLaneWithOptionsAsync(request, headers, runtime);
        }

        public ListSwimmingLaneResponse ListSwimmingLaneWithOptions(ListSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListSwimmingLaneResponse>(DoROARequest("ListSwimmingLane", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/trafficmgnt/swimming_lanes", "json", req, runtime));
        }

        public async Task<ListSwimmingLaneResponse> ListSwimmingLaneWithOptionsAsync(ListSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListSwimmingLaneResponse>(await DoROARequestAsync("ListSwimmingLane", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/trafficmgnt/swimming_lanes", "json", req, runtime));
        }

        public ListSwimmingLaneGroupResponse ListSwimmingLaneGroup(ListSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSwimmingLaneGroupWithOptions(request, headers, runtime);
        }

        public async Task<ListSwimmingLaneGroupResponse> ListSwimmingLaneGroupAsync(ListSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSwimmingLaneGroupWithOptionsAsync(request, headers, runtime);
        }

        public ListSwimmingLaneGroupResponse ListSwimmingLaneGroupWithOptions(ListSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListSwimmingLaneGroupResponse>(DoROARequest("ListSwimmingLaneGroup", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/trafficmgnt/swimming_lane_groups", "json", req, runtime));
        }

        public async Task<ListSwimmingLaneGroupResponse> ListSwimmingLaneGroupWithOptionsAsync(ListSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListSwimmingLaneGroupResponse>(await DoROARequestAsync("ListSwimmingLaneGroup", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/trafficmgnt/swimming_lane_groups", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoROARequest("ListTagResources", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/tag/tags", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoROARequestAsync("ListTagResources", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/tag/tags", "json", req, runtime));
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
            return TeaModel.ToObject<ListUserDefineRegionResponse>(DoROARequest("ListUserDefineRegion", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/user_region_defs", "json", req, runtime));
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
            return TeaModel.ToObject<ListUserDefineRegionResponse>(await DoROARequestAsync("ListUserDefineRegion", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/user_region_defs", "json", req, runtime));
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
            return TeaModel.ToObject<ListVpcResponse>(DoROARequest("ListVpc", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/vpc_list", "json", req, runtime));
        }

        public async Task<ListVpcResponse> ListVpcWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListVpcResponse>(await DoROARequestAsync("ListVpc", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/vpc_list", "json", req, runtime));
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
            return TeaModel.ToObject<MigrateEcuResponse>(DoROARequest("MigrateEcu", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/migrate_ecu", "json", req, runtime));
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
            return TeaModel.ToObject<MigrateEcuResponse>(await DoROARequestAsync("MigrateEcu", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/migrate_ecu", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InEnable))
            {
                query["InEnable"] = request.InEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCpu))
            {
                query["InCpu"] = request.InCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InDuration))
            {
                query["InDuration"] = request.InDuration;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCondition))
            {
                query["OutCondition"] = request.OutCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCPU))
            {
                query["OutCPU"] = request.OutCPU;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceFrom))
            {
                query["ResourceFrom"] = request.ResourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAzPolicy))
            {
                query["MultiAzPolicy"] = request.MultiAzPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceId))
            {
                query["TemplateInstanceId"] = request.TemplateInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceName))
            {
                query["TemplateInstanceName"] = request.TemplateInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptEULA))
            {
                query["AcceptEULA"] = request.AcceptEULA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
            return TeaModel.ToObject<ModifyScalingRuleResponse>(DoROARequest("ModifyScalingRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/scaling_rules", "json", req, runtime));
        }

        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleWithOptionsAsync(ModifyScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCondition))
            {
                query["InCondition"] = request.InCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InEnable))
            {
                query["InEnable"] = request.InEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCpu))
            {
                query["InCpu"] = request.InCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InDuration))
            {
                query["InDuration"] = request.InDuration;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCondition))
            {
                query["OutCondition"] = request.OutCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCPU))
            {
                query["OutCPU"] = request.OutCPU;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceFrom))
            {
                query["ResourceFrom"] = request.ResourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAzPolicy))
            {
                query["MultiAzPolicy"] = request.MultiAzPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceId))
            {
                query["TemplateInstanceId"] = request.TemplateInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceName))
            {
                query["TemplateInstanceName"] = request.TemplateInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptEULA))
            {
                query["AcceptEULA"] = request.AcceptEULA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
            return TeaModel.ToObject<ModifyScalingRuleResponse>(await DoROARequestAsync("ModifyScalingRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/scaling_rules", "json", req, runtime));
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
            return TeaModel.ToObject<QueryApplicationStatusResponse>(DoROARequest("QueryApplicationStatus", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/app_status", "json", req, runtime));
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
            return TeaModel.ToObject<QueryApplicationStatusResponse>(await DoROARequestAsync("QueryApplicationStatus", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/app/app_status", "json", req, runtime));
        }

        public QueryConfigCenterResponse QueryConfigCenter(QueryConfigCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryConfigCenterWithOptions(request, headers, runtime);
        }

        public async Task<QueryConfigCenterResponse> QueryConfigCenterAsync(QueryConfigCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryConfigCenterWithOptionsAsync(request, headers, runtime);
        }

        public QueryConfigCenterResponse QueryConfigCenterWithOptions(QueryConfigCenterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
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
            return TeaModel.ToObject<QueryConfigCenterResponse>(DoROARequest("QueryConfigCenter", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/configCenter", "json", req, runtime));
        }

        public async Task<QueryConfigCenterResponse> QueryConfigCenterWithOptionsAsync(QueryConfigCenterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
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
            return TeaModel.ToObject<QueryConfigCenterResponse>(await DoROARequestAsync("QueryConfigCenter", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/configCenter", "json", req, runtime));
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
            return TeaModel.ToObject<QueryEccInfoResponse>(DoROARequest("QueryEccInfo", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/ecc", "json", req, runtime));
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
            return TeaModel.ToObject<QueryEccInfoResponse>(await DoROARequestAsync("QueryEccInfo", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/ecc", "json", req, runtime));
        }

        public QueryK8sClusterLogProjectInfoResponse QueryK8sClusterLogProjectInfo(QueryK8sClusterLogProjectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryK8sClusterLogProjectInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryK8sClusterLogProjectInfoResponse> QueryK8sClusterLogProjectInfoAsync(QueryK8sClusterLogProjectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryK8sClusterLogProjectInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryK8sClusterLogProjectInfoResponse QueryK8sClusterLogProjectInfoWithOptions(QueryK8sClusterLogProjectInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryK8sClusterLogProjectInfoResponse>(DoROARequest("QueryK8sClusterLogProjectInfo", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/k8s/sls/project", "json", req, runtime));
        }

        public async Task<QueryK8sClusterLogProjectInfoResponse> QueryK8sClusterLogProjectInfoWithOptionsAsync(QueryK8sClusterLogProjectInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryK8sClusterLogProjectInfoResponse>(await DoROARequestAsync("QueryK8sClusterLogProjectInfo", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/k8s/sls/project", "json", req, runtime));
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
            return TeaModel.ToObject<QueryMigrateEcuListResponse>(DoROARequest("QueryMigrateEcuList", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/migrate_ecu_list", "json", req, runtime));
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
            return TeaModel.ToObject<QueryMigrateEcuListResponse>(await DoROARequestAsync("QueryMigrateEcuList", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/migrate_ecu_list", "json", req, runtime));
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
            return TeaModel.ToObject<QueryMigrateRegionListResponse>(DoROARequest("QueryMigrateRegionList", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/migrate_region_select", "json", req, runtime));
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
            return TeaModel.ToObject<QueryMigrateRegionListResponse>(await DoROARequestAsync("QueryMigrateRegionList", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/migrate_region_select", "json", req, runtime));
        }

        public QueryMonitorInfoResponse QueryMonitorInfo(QueryMonitorInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryMonitorInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryMonitorInfoResponse> QueryMonitorInfoAsync(QueryMonitorInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryMonitorInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryMonitorInfoResponse QueryMonitorInfoWithOptions(QueryMonitorInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                query["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregator))
            {
                query["Aggregator"] = request.Aggregator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMonitorInfoResponse>(DoROARequest("QueryMonitorInfo", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/monitor/queryMonitorInfo", "json", req, runtime));
        }

        public async Task<QueryMonitorInfoResponse> QueryMonitorInfoWithOptionsAsync(QueryMonitorInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                query["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregator))
            {
                query["Aggregator"] = request.Aggregator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMonitorInfoResponse>(await DoROARequestAsync("QueryMonitorInfo", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/monitor/queryMonitorInfo", "json", req, runtime));
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
            return TeaModel.ToObject<QueryRegionConfigResponse>(DoROARequest("QueryRegionConfig", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/region_config", "json", req, runtime));
        }

        public async Task<QueryRegionConfigResponse> QueryRegionConfigWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<QueryRegionConfigResponse>(await DoROARequestAsync("QueryRegionConfig", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/region_config", "json", req, runtime));
        }

        public QueryServiceTimeConfigResponse QueryServiceTimeConfig(QueryServiceTimeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryServiceTimeConfigWithOptions(request, headers, runtime);
        }

        public async Task<QueryServiceTimeConfigResponse> QueryServiceTimeConfigAsync(QueryServiceTimeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryServiceTimeConfigWithOptionsAsync(request, headers, runtime);
        }

        public QueryServiceTimeConfigResponse QueryServiceTimeConfigWithOptions(QueryServiceTimeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroup))
            {
                query["ServiceGroup"] = request.ServiceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
            return TeaModel.ToObject<QueryServiceTimeConfigResponse>(DoROARequest("QueryServiceTimeConfig", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/timeout/page", "json", req, runtime));
        }

        public async Task<QueryServiceTimeConfigResponse> QueryServiceTimeConfigWithOptionsAsync(QueryServiceTimeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroup))
            {
                query["ServiceGroup"] = request.ServiceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
            return TeaModel.ToObject<QueryServiceTimeConfigResponse>(await DoROARequestAsync("QueryServiceTimeConfig", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/timeout/page", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QuerySlsLogStoreListResponse>(DoROARequest("QuerySlsLogStoreList", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/k8s/sls/query_sls_log_store_list", "json", req, runtime));
        }

        public async Task<QuerySlsLogStoreListResponse> QuerySlsLogStoreListWithOptionsAsync(QuerySlsLogStoreListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QuerySlsLogStoreListResponse>(await DoROARequestAsync("QuerySlsLogStoreList", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/k8s/sls/query_sls_log_store_list", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveMockRuleResponse>(DoROARequest("RemoveMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/removeMockRule", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveMockRuleResponse>(await DoROARequestAsync("RemoveMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/removeMockRule", "json", req, runtime));
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
            return TeaModel.ToObject<ResetApplicationResponse>(DoROARequest("ResetApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_reset", "json", req, runtime));
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
            return TeaModel.ToObject<ResetApplicationResponse>(await DoROARequestAsync("ResetApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_reset", "json", req, runtime));
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
            return TeaModel.ToObject<RestartApplicationResponse>(DoROARequest("RestartApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_restart", "json", req, runtime));
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
            return TeaModel.ToObject<RestartApplicationResponse>(await DoROARequestAsync("RestartApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_restart", "json", req, runtime));
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
            return TeaModel.ToObject<RestartK8sApplicationResponse>(DoROARequest("RestartK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/restart_k8s_app", "json", req, runtime));
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
            return TeaModel.ToObject<RestartK8sApplicationResponse>(await DoROARequestAsync("RestartK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/restart_k8s_app", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryVersion))
            {
                query["HistoryVersion"] = request.HistoryVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Batch))
            {
                query["Batch"] = request.Batch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(DoROARequest("RollbackApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_rollback", "json", req, runtime));
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationWithOptionsAsync(RollbackApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryVersion))
            {
                query["HistoryVersion"] = request.HistoryVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Batch))
            {
                query["Batch"] = request.Batch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(await DoROARequestAsync("RollbackApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_rollback", "json", req, runtime));
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
            return TeaModel.ToObject<RollbackChangeOrderResponse>(DoROARequest("RollbackChangeOrder", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/oam/changeorder/rollback", "json", req, runtime));
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
            return TeaModel.ToObject<RollbackChangeOrderResponse>(await DoROARequestAsync("RollbackChangeOrder", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/oam/changeorder/rollback", "json", req, runtime));
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
            return TeaModel.ToObject<ScaleInApplicationResponse>(DoROARequest("ScaleInApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_scale_in", "json", req, runtime));
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
            return TeaModel.ToObject<ScaleInApplicationResponse>(await DoROARequestAsync("ScaleInApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_scale_in", "json", req, runtime));
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
            return TeaModel.ToObject<ScaleK8sApplicationResponse>(DoROARequest("ScaleK8sApplication", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_apps", "json", req, runtime));
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
            return TeaModel.ToObject<ScaleK8sApplicationResponse>(await DoROARequestAsync("ScaleK8sApplication", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_apps", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuInfo))
            {
                query["EcuInfo"] = request.EcuInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployGroup))
            {
                query["DeployGroup"] = request.DeployGroup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ScaleOutApplicationResponse>(DoROARequest("ScaleOutApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_scale_out", "json", req, runtime));
        }

        public async Task<ScaleOutApplicationResponse> ScaleOutApplicationWithOptionsAsync(ScaleOutApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcuInfo))
            {
                query["EcuInfo"] = request.EcuInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployGroup))
            {
                query["DeployGroup"] = request.DeployGroup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ScaleOutApplicationResponse>(await DoROARequestAsync("ScaleOutApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_scale_out", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingNum))
            {
                query["ScalingNum"] = request.ScalingNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceId))
            {
                query["TemplateInstanceId"] = request.TemplateInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargePeriodUnit))
            {
                query["InstanceChargePeriodUnit"] = request.InstanceChargePeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargePeriod))
            {
                query["InstanceChargePeriod"] = request.InstanceChargePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ScaleoutApplicationWithNewInstancesResponse>(DoROARequest("ScaleoutApplicationWithNewInstances", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/scaling/scale_out", "json", req, runtime));
        }

        public async Task<ScaleoutApplicationWithNewInstancesResponse> ScaleoutApplicationWithNewInstancesWithOptionsAsync(ScaleoutApplicationWithNewInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingNum))
            {
                query["ScalingNum"] = request.ScalingNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInstanceId))
            {
                query["TemplateInstanceId"] = request.TemplateInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargePeriodUnit))
            {
                query["InstanceChargePeriodUnit"] = request.InstanceChargePeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargePeriod))
            {
                query["InstanceChargePeriod"] = request.InstanceChargePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ScaleoutApplicationWithNewInstancesResponse>(await DoROARequestAsync("ScaleoutApplicationWithNewInstances", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/scaling/scale_out", "json", req, runtime));
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
            return TeaModel.ToObject<StartApplicationResponse>(DoROARequest("StartApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_start", "json", req, runtime));
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
            return TeaModel.ToObject<StartApplicationResponse>(await DoROARequestAsync("StartApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_start", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StartK8sApplicationResponse>(DoROARequest("StartK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/start_k8s_app", "json", req, runtime));
        }

        public async Task<StartK8sApplicationResponse> StartK8sApplicationWithOptionsAsync(StartK8sApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StartK8sApplicationResponse>(await DoROARequestAsync("StartK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/start_k8s_app", "json", req, runtime));
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
            return TeaModel.ToObject<StopApplicationResponse>(DoROARequest("StopApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_stop", "json", req, runtime));
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
            return TeaModel.ToObject<StopApplicationResponse>(await DoROARequestAsync("StopApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_stop", "json", req, runtime));
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
            return TeaModel.ToObject<StopK8sApplicationResponse>(DoROARequest("StopK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/stop_k8s_app", "json", req, runtime));
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
            return TeaModel.ToObject<StopK8sApplicationResponse>(await DoROARequestAsync("StopK8sApplication", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/acs/stop_k8s_app", "json", req, runtime));
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
            return TeaModel.ToObject<SwitchAdvancedMonitoringResponse>(DoROARequest("SwitchAdvancedMonitoring", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/monitor/advancedMonitorInfo", "json", req, runtime));
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
            return TeaModel.ToObject<SwitchAdvancedMonitoringResponse>(await DoROARequestAsync("SwitchAdvancedMonitoring", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/monitor/advancedMonitorInfo", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SynchronizeResourceResponse>(DoROARequest("SynchronizeResource", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/pop_sync_resource", "json", req, runtime));
        }

        public async Task<SynchronizeResourceResponse> SynchronizeResourceWithOptionsAsync(SynchronizeResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SynchronizeResourceResponse>(await DoROARequestAsync("SynchronizeResource", "2017-08-01", "HTTPS", "GET", "AK", "/pop/v5/resource/pop_sync_resource", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoROARequest("TagResources", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/tag/tags", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoROARequestAsync("TagResources", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/tag/tags", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetClusterId))
            {
                query["TargetClusterId"] = request.TargetClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<TransformClusterMemberResponse>(DoROARequest("TransformClusterMember", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/transform_cluster_member", "json", req, runtime));
        }

        public async Task<TransformClusterMemberResponse> TransformClusterMemberWithOptionsAsync(TransformClusterMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetClusterId))
            {
                query["TargetClusterId"] = request.TargetClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<TransformClusterMemberResponse>(await DoROARequestAsync("TransformClusterMember", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/resource/transform_cluster_member", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbName))
            {
                query["SlbName"] = request.SlbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UnbindK8sSlbResponse>(DoROARequest("UnbindK8sSlb", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/k8s/acs/k8s_slb_binding", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbName))
            {
                query["SlbName"] = request.SlbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UnbindK8sSlbResponse>(await DoROARequestAsync("UnbindK8sSlb", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/k8s/acs/k8s_slb_binding", "json", req, runtime));
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
            return TeaModel.ToObject<UnbindSlbResponse>(DoROARequest("UnbindSlb", "2017-08-01", "HTTPS", "POST", "AK", "/pop/app/unbind_slb_json", "json", req, runtime));
        }

        public async Task<UnbindSlbResponse> UnbindSlbWithOptionsAsync(UnbindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            return TeaModel.ToObject<UnbindSlbResponse>(await DoROARequestAsync("UnbindSlb", "2017-08-01", "HTTPS", "POST", "AK", "/pop/app/unbind_slb_json", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAll))
            {
                query["DeleteAll"] = request.DeleteAll;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoROARequest("UntagResources", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/tag/tags", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAll))
            {
                query["DeleteAll"] = request.DeleteAll;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoROARequestAsync("UntagResources", "2017-08-01", "HTTPS", "DELETE", "AK", "/pop/v5/tag/tags", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAccountInfoResponse>(DoROARequest("UpdateAccountInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/edit_account_info", "json", req, runtime));
        }

        public async Task<UpdateAccountInfoResponse> UpdateAccountInfoWithOptionsAsync(UpdateAccountInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAccountInfoResponse>(await DoROARequestAsync("UpdateAccountInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/edit_account_info", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateApplicationBaseInfoResponse>(DoROARequest("UpdateApplicationBaseInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/update_app_info", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateApplicationBaseInfoResponse>(await DoROARequestAsync("UpdateApplicationBaseInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/update_app_info", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateContainerResponse>(DoROARequest("UpdateContainer", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_update_container", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateContainerResponse>(await DoROARequestAsync("UpdateContainer", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/changeorder/co_update_container", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextPath))
            {
                query["ContextPath"] = request.ContextPath;
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
            return TeaModel.ToObject<UpdateContainerConfigurationResponse>(DoROARequest("UpdateContainerConfiguration", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/container_config", "json", req, runtime));
        }

        public async Task<UpdateContainerConfigurationResponse> UpdateContainerConfigurationWithOptionsAsync(UpdateContainerConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextPath))
            {
                query["ContextPath"] = request.ContextPath;
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
            return TeaModel.ToObject<UpdateContainerConfigurationResponse>(await DoROARequestAsync("UpdateContainerConfiguration", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/container_config", "json", req, runtime));
        }

        public UpdateDegradeControlResponse UpdateDegradeControl(UpdateDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDegradeControlWithOptions(request, headers, runtime);
        }

        public async Task<UpdateDegradeControlResponse> UpdateDegradeControlAsync(UpdateDegradeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDegradeControlWithOptionsAsync(request, headers, runtime);
        }

        public UpdateDegradeControlResponse UpdateDegradeControlWithOptions(UpdateDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RtThreshold))
            {
                query["RtThreshold"] = request.RtThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlVar))
            {
                query["UrlVar"] = request.UrlVar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateDegradeControlResponse>(DoROARequest("UpdateDegradeControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/degradeControl", "json", req, runtime));
        }

        public async Task<UpdateDegradeControlResponse> UpdateDegradeControlWithOptionsAsync(UpdateDegradeControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RtThreshold))
            {
                query["RtThreshold"] = request.RtThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlVar))
            {
                query["UrlVar"] = request.UrlVar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateDegradeControlResponse>(await DoROARequestAsync("UpdateDegradeControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/degradeControl", "json", req, runtime));
        }

        public UpdateFlowControlResponse UpdateFlowControl(UpdateFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFlowControlWithOptions(request, headers, runtime);
        }

        public async Task<UpdateFlowControlResponse> UpdateFlowControlAsync(UpdateFlowControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFlowControlWithOptionsAsync(request, headers, runtime);
        }

        public UpdateFlowControlResponse UpdateFlowControlWithOptions(UpdateFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                query["Strategy"] = request.Strategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlVar))
            {
                query["UrlVar"] = request.UrlVar;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateFlowControlResponse>(DoROARequest("UpdateFlowControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/flowControl", "json", req, runtime));
        }

        public async Task<UpdateFlowControlResponse> UpdateFlowControlWithOptionsAsync(UpdateFlowControlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAppId))
            {
                query["ConsumerAppId"] = request.ConsumerAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                query["Strategy"] = request.Strategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlVar))
            {
                query["UrlVar"] = request.UrlVar;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateFlowControlResponse>(await DoROARequestAsync("UpdateFlowControl", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/flowControl", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateHealthCheckUrlResponse>(DoROARequest("UpdateHealthCheckUrl", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/modify_hc_url", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateHealthCheckUrlResponse>(await DoROARequestAsync("UpdateHealthCheckUrl", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/modify_hc_url", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateHookConfigurationResponse>(DoROARequest("UpdateHookConfiguration", "2017-08-01", "HTTPS", "POST", "AK", "/pop/app/config_app_hook_json", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateHookConfigurationResponse>(await DoROARequestAsync("UpdateHookConfiguration", "2017-08-01", "HTTPS", "POST", "AK", "/pop/app/config_app_hook_json", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeapSize))
            {
                query["MinHeapSize"] = request.MinHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPermSize))
            {
                query["MaxPermSize"] = request.MaxPermSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeapSize))
            {
                query["MaxHeapSize"] = request.MaxHeapSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateJvmConfigurationResponse>(DoROARequest("UpdateJvmConfiguration", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/app_jvm_config", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeapSize))
            {
                query["MinHeapSize"] = request.MinHeapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPermSize))
            {
                query["MaxPermSize"] = request.MaxPermSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeapSize))
            {
                query["MaxHeapSize"] = request.MaxHeapSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateJvmConfigurationResponse>(await DoROARequestAsync("UpdateJvmConfiguration", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/app/app_jvm_config", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateK8sApplicationBaseInfoResponse>(DoROARequest("UpdateK8sApplicationBaseInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/oam/update_app_basic_info", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateK8sApplicationBaseInfoResponse>(await DoROARequestAsync("UpdateK8sApplicationBaseInfo", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/oam/update_app_basic_info", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                query["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuLimit))
            {
                query["McpuLimit"] = request.McpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuRequest))
            {
                query["CpuRequest"] = request.CpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuRequest))
            {
                query["McpuRequest"] = request.McpuRequest;
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
            return TeaModel.ToObject<UpdateK8sApplicationConfigResponse>(DoROARequest("UpdateK8sApplicationConfig", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_app_configuration", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                query["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuLimit))
            {
                query["McpuLimit"] = request.McpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuRequest))
            {
                query["CpuRequest"] = request.CpuRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpuRequest))
            {
                query["McpuRequest"] = request.McpuRequest;
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
            return TeaModel.ToObject<UpdateK8sApplicationConfigResponse>(await DoROARequestAsync("UpdateK8sApplicationConfig", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_app_configuration", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateK8sIngressRuleResponse>(DoROARequest("UpdateK8sIngressRule", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_ingress", "json", req, runtime));
        }

        public async Task<UpdateK8sIngressRuleResponse> UpdateK8sIngressRuleWithOptionsAsync(UpdateK8sIngressRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateK8sIngressRuleResponse>(await DoROARequestAsync("UpdateK8sIngressRule", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_ingress", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateK8sResourceResponse>(DoROARequestWithForm("UpdateK8sResource", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/oam/update_k8s_resource_config", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateK8sResourceResponse>(await DoROARequestWithFormAsync("UpdateK8sResource", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/oam/update_k8s_resource_config", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePorts))
            {
                query["ServicePorts"] = request.ServicePorts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateK8sServiceResponse>(DoROARequest("UpdateK8sService", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_service", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePorts))
            {
                query["ServicePorts"] = request.ServicePorts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateK8sServiceResponse>(await DoROARequestAsync("UpdateK8sService", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_service", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbProtocol))
            {
                query["SlbProtocol"] = request.SlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePortInfos))
            {
                query["ServicePortInfos"] = request.ServicePortInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbName))
            {
                query["SlbName"] = request.SlbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateK8sSlbResponse>(DoROARequest("UpdateK8sSlb", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_slb_binding", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbProtocol))
            {
                query["SlbProtocol"] = request.SlbProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePortInfos))
            {
                query["ServicePortInfos"] = request.ServicePortInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbName))
            {
                query["SlbName"] = request.SlbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateK8sSlbResponse>(await DoROARequestAsync("UpdateK8sSlb", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/k8s/acs/k8s_slb_binding", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraJson))
            {
                query["ExtraJson"] = request.ExtraJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScMockItemJson))
            {
                query["ScMockItemJson"] = request.ScMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboMockItemJson))
            {
                query["DubboMockItemJson"] = request.DubboMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateMockRuleResponse>(DoROARequest("UpdateMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/updateMockRule", "json", req, runtime));
        }

        public async Task<UpdateMockRuleResponse> UpdateMockRuleWithOptionsAsync(UpdateMockRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraJson))
            {
                query["ExtraJson"] = request.ExtraJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScMockItemJson))
            {
                query["ScMockItemJson"] = request.ScMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboMockItemJson))
            {
                query["DubboMockItemJson"] = request.DubboMockItemJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateMockRuleResponse>(await DoROARequestAsync("UpdateMockRule", "2017-08-01", "HTTPS", "POST", "AK", "/pop/sp/api/mock/updateMockRule", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionData))
            {
                query["ActionData"] = request.ActionData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateRoleResponse>(DoROARequest("UpdateRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/edit_role", "json", req, runtime));
        }

        public async Task<UpdateRoleResponse> UpdateRoleWithOptionsAsync(UpdateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionData))
            {
                query["ActionData"] = request.ActionData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateRoleResponse>(await DoROARequestAsync("UpdateRole", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/account/edit_role", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateSlsLogStoreResponse>(DoROARequestWithForm("UpdateSlsLogStore", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/sls/update_sls_log_store", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateSlsLogStoreResponse>(await DoROARequestWithFormAsync("UpdateSlsLogStore", "2017-08-01", "HTTPS", "POST", "AK", "/pop/v5/k8s/sls/update_sls_log_store", "json", req, runtime));
        }

        public UpdateSwimmingLaneResponse UpdateSwimmingLane(UpdateSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSwimmingLaneWithOptions(request, headers, runtime);
        }

        public async Task<UpdateSwimmingLaneResponse> UpdateSwimmingLaneAsync(UpdateSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSwimmingLaneWithOptionsAsync(request, headers, runtime);
        }

        public UpdateSwimmingLaneResponse UpdateSwimmingLaneWithOptions(UpdateSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRules))
            {
                query["EnableRules"] = request.EnableRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInfos))
            {
                query["AppInfos"] = request.AppInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryRules))
            {
                query["EntryRules"] = request.EntryRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateSwimmingLaneResponse>(DoROARequest("UpdateSwimmingLane", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/trafficmgnt/swimming_lanes", "json", req, runtime));
        }

        public async Task<UpdateSwimmingLaneResponse> UpdateSwimmingLaneWithOptionsAsync(UpdateSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRules))
            {
                query["EnableRules"] = request.EnableRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInfos))
            {
                query["AppInfos"] = request.AppInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryRules))
            {
                query["EntryRules"] = request.EntryRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateSwimmingLaneResponse>(await DoROARequestAsync("UpdateSwimmingLane", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/trafficmgnt/swimming_lanes", "json", req, runtime));
        }

        public UpdateSwimmingLaneGroupResponse UpdateSwimmingLaneGroup(UpdateSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSwimmingLaneGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpdateSwimmingLaneGroupResponse> UpdateSwimmingLaneGroupAsync(UpdateSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSwimmingLaneGroupWithOptionsAsync(request, headers, runtime);
        }

        public UpdateSwimmingLaneGroupResponse UpdateSwimmingLaneGroupWithOptions(UpdateSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryApp))
            {
                query["EntryApp"] = request.EntryApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateSwimmingLaneGroupResponse>(DoROARequest("UpdateSwimmingLaneGroup", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/trafficmgnt/swimming_lane_groups", "json", req, runtime));
        }

        public async Task<UpdateSwimmingLaneGroupResponse> UpdateSwimmingLaneGroupWithOptionsAsync(UpdateSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryApp))
            {
                query["EntryApp"] = request.EntryApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateSwimmingLaneGroupResponse>(await DoROARequestAsync("UpdateSwimmingLaneGroup", "2017-08-01", "HTTPS", "PUT", "AK", "/pop/v5/trafficmgnt/swimming_lane_groups", "json", req, runtime));
        }

    }
}
