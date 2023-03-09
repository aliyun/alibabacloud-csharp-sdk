// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Agency20171030.Models;

namespace AlibabaCloud.SDK.Agency20171030
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "agency.aliyuncs.com"},
                {"ap-northeast-2-pop", "agency.aliyuncs.com"},
                {"ap-south-1", "agency.aliyuncs.com"},
                {"ap-southeast-2", "agency.aliyuncs.com"},
                {"ap-southeast-3", "agency.aliyuncs.com"},
                {"ap-southeast-5", "agency.aliyuncs.com"},
                {"cn-beijing", "agency.aliyuncs.com"},
                {"cn-beijing-finance-1", "agency.aliyuncs.com"},
                {"cn-beijing-finance-pop", "agency.aliyuncs.com"},
                {"cn-beijing-gov-1", "agency.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "agency.aliyuncs.com"},
                {"cn-chengdu", "agency.aliyuncs.com"},
                {"cn-edge-1", "agency.aliyuncs.com"},
                {"cn-fujian", "agency.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "agency.aliyuncs.com"},
                {"cn-hangzhou", "agency.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "agency.aliyuncs.com"},
                {"cn-hangzhou-finance", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "agency.aliyuncs.com"},
                {"cn-hangzhou-test-306", "agency.aliyuncs.com"},
                {"cn-hongkong", "agency.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "agency.aliyuncs.com"},
                {"cn-huhehaote", "agency.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "agency.aliyuncs.com"},
                {"cn-north-2-gov-1", "agency.aliyuncs.com"},
                {"cn-qingdao", "agency.aliyuncs.com"},
                {"cn-qingdao-nebula", "agency.aliyuncs.com"},
                {"cn-shanghai", "agency.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "agency.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "agency.aliyuncs.com"},
                {"cn-shanghai-finance-1", "agency.aliyuncs.com"},
                {"cn-shanghai-inner", "agency.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "agency.aliyuncs.com"},
                {"cn-shenzhen", "agency.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "agency.aliyuncs.com"},
                {"cn-shenzhen-inner", "agency.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "agency.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "agency.aliyuncs.com"},
                {"cn-wuhan", "agency.aliyuncs.com"},
                {"cn-wulanchabu", "agency.aliyuncs.com"},
                {"cn-yushanfang", "agency.aliyuncs.com"},
                {"cn-zhangbei", "agency.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "agency.aliyuncs.com"},
                {"cn-zhangjiakou", "agency.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "agency.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "agency.aliyuncs.com"},
                {"eu-central-1", "agency.aliyuncs.com"},
                {"eu-west-1", "agency.aliyuncs.com"},
                {"eu-west-1-oxs", "agency.aliyuncs.com"},
                {"me-east-1", "agency.aliyuncs.com"},
                {"rus-west-1-pop", "agency.aliyuncs.com"},
                {"us-east-1", "agency.aliyuncs.com"},
                {"us-west-1", "agency.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("agency", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DoDefineRegisterNotificationResponse DoDefineRegisterNotificationWithOptions(DoDefineRegisterNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountTraceId))
            {
                query["accountTraceId"] = request.AccountTraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailTemplate))
            {
                query["emailTemplate"] = request.EmailTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailTemplateParamsJsonString))
            {
                query["emailTemplateParamsJsonString"] = request.EmailTemplateParamsJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interrupt))
            {
                query["interrupt"] = request.Interrupt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoker))
            {
                query["invoker"] = request.Invoker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplate))
            {
                query["smsTemplate"] = request.SmsTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParamsJsonString))
            {
                query["smsTemplateParamsJsonString"] = request.SmsTemplateParamsJsonString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DoDefineRegisterNotification",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoDefineRegisterNotificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DoDefineRegisterNotificationResponse> DoDefineRegisterNotificationWithOptionsAsync(DoDefineRegisterNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountTraceId))
            {
                query["accountTraceId"] = request.AccountTraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailTemplate))
            {
                query["emailTemplate"] = request.EmailTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailTemplateParamsJsonString))
            {
                query["emailTemplateParamsJsonString"] = request.EmailTemplateParamsJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interrupt))
            {
                query["interrupt"] = request.Interrupt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoker))
            {
                query["invoker"] = request.Invoker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplate))
            {
                query["smsTemplate"] = request.SmsTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParamsJsonString))
            {
                query["smsTemplateParamsJsonString"] = request.SmsTemplateParamsJsonString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DoDefineRegisterNotification",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoDefineRegisterNotificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DoDefineRegisterNotificationResponse DoDefineRegisterNotification(DoDefineRegisterNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoDefineRegisterNotificationWithOptions(request, runtime);
        }

        public async Task<DoDefineRegisterNotificationResponse> DoDefineRegisterNotificationAsync(DoDefineRegisterNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoDefineRegisterNotificationWithOptionsAsync(request, runtime);
        }

        public FindAvailableInstancesResponse FindAvailableInstancesWithOptions(FindAvailableInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindAvailableInstances",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindAvailableInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FindAvailableInstancesResponse> FindAvailableInstancesWithOptionsAsync(FindAvailableInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindAvailableInstances",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindAvailableInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FindAvailableInstancesResponse FindAvailableInstances(FindAvailableInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindAvailableInstancesWithOptions(request, runtime);
        }

        public async Task<FindAvailableInstancesResponse> FindAvailableInstancesAsync(FindAvailableInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindAvailableInstancesWithOptionsAsync(request, runtime);
        }

        public GetMonthDetailLinkResponse GetMonthDetailLinkWithOptions(GetMonthDetailLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonthDetailLink",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthDetailLinkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMonthDetailLinkResponse> GetMonthDetailLinkWithOptionsAsync(GetMonthDetailLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonthDetailLink",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthDetailLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMonthDetailLinkResponse GetMonthDetailLink(GetMonthDetailLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonthDetailLinkWithOptions(request, runtime);
        }

        public async Task<GetMonthDetailLinkResponse> GetMonthDetailLinkAsync(GetMonthDetailLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonthDetailLinkWithOptionsAsync(request, runtime);
        }

        public QueryFxUserDebtsResponse QueryFxUserDebtsWithOptions(QueryFxUserDebtsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFxUserDebts",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFxUserDebtsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFxUserDebtsResponse> QueryFxUserDebtsWithOptionsAsync(QueryFxUserDebtsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFxUserDebts",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFxUserDebtsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFxUserDebtsResponse QueryFxUserDebts(QueryFxUserDebtsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFxUserDebtsWithOptions(request, runtime);
        }

        public async Task<QueryFxUserDebtsResponse> QueryFxUserDebtsAsync(QueryFxUserDebtsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFxUserDebtsWithOptionsAsync(request, runtime);
        }

        public TransferFxResellerToUserResponse TransferFxResellerToUserWithOptions(TransferFxResellerToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TansferScene))
            {
                query["TansferScene"] = request.TansferScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferUid))
            {
                query["TransferUid"] = request.TransferUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferFxResellerToUser",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferFxResellerToUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferFxResellerToUserResponse> TransferFxResellerToUserWithOptionsAsync(TransferFxResellerToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TansferScene))
            {
                query["TansferScene"] = request.TansferScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferUid))
            {
                query["TransferUid"] = request.TransferUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferFxResellerToUser",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferFxResellerToUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferFxResellerToUserResponse TransferFxResellerToUser(TransferFxResellerToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferFxResellerToUserWithOptions(request, runtime);
        }

        public async Task<TransferFxResellerToUserResponse> TransferFxResellerToUserAsync(TransferFxResellerToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferFxResellerToUserWithOptionsAsync(request, runtime);
        }

        public TransferFxUserToResellerResponse TransferFxUserToResellerWithOptions(TransferFxUserToResellerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUid))
            {
                query["ParentUid"] = request.ParentUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaAmount))
            {
                query["QuotaAmount"] = request.QuotaAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownStatus))
            {
                query["ShutdownStatus"] = request.ShutdownStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TansferScene))
            {
                query["TansferScene"] = request.TansferScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferUid))
            {
                query["TransferUid"] = request.TransferUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferFxUserToReseller",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferFxUserToResellerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferFxUserToResellerResponse> TransferFxUserToResellerWithOptionsAsync(TransferFxUserToResellerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUid))
            {
                query["ParentUid"] = request.ParentUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaAmount))
            {
                query["QuotaAmount"] = request.QuotaAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownStatus))
            {
                query["ShutdownStatus"] = request.ShutdownStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TansferScene))
            {
                query["TansferScene"] = request.TansferScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferUid))
            {
                query["TransferUid"] = request.TransferUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferFxUserToReseller",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferFxUserToResellerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferFxUserToResellerResponse TransferFxUserToReseller(TransferFxUserToResellerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferFxUserToResellerWithOptions(request, runtime);
        }

        public async Task<TransferFxUserToResellerResponse> TransferFxUserToResellerAsync(TransferFxUserToResellerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferFxUserToResellerWithOptionsAsync(request, runtime);
        }

        public TransferReplaceResellerResponse TransferReplaceResellerWithOptions(TransferReplaceResellerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateReason))
            {
                query["OperateReason"] = request.OperateReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operater))
            {
                query["Operater"] = request.Operater;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperaterEmpid))
            {
                query["OperaterEmpid"] = request.OperaterEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperaterOrganization))
            {
                query["OperaterOrganization"] = request.OperaterOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUid))
            {
                query["ParentUid"] = request.ParentUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaAmount))
            {
                query["QuotaAmount"] = request.QuotaAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownStatus))
            {
                query["ShutdownStatus"] = request.ShutdownStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TansferScene))
            {
                query["TansferScene"] = request.TansferScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferUid))
            {
                query["TransferUid"] = request.TransferUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferReplaceReseller",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferReplaceResellerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferReplaceResellerResponse> TransferReplaceResellerWithOptionsAsync(TransferReplaceResellerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateReason))
            {
                query["OperateReason"] = request.OperateReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operater))
            {
                query["Operater"] = request.Operater;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperaterEmpid))
            {
                query["OperaterEmpid"] = request.OperaterEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperaterOrganization))
            {
                query["OperaterOrganization"] = request.OperaterOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUid))
            {
                query["ParentUid"] = request.ParentUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaAmount))
            {
                query["QuotaAmount"] = request.QuotaAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownStatus))
            {
                query["ShutdownStatus"] = request.ShutdownStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TansferScene))
            {
                query["TansferScene"] = request.TansferScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferUid))
            {
                query["TransferUid"] = request.TransferUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferReplaceReseller",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferReplaceResellerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferReplaceResellerResponse TransferReplaceReseller(TransferReplaceResellerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferReplaceResellerWithOptions(request, runtime);
        }

        public async Task<TransferReplaceResellerResponse> TransferReplaceResellerAsync(TransferReplaceResellerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferReplaceResellerWithOptionsAsync(request, runtime);
        }

        public DoCheckResourceResponse DoCheckResourceWithOptions(DoCheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtWakeup))
            {
                query["GmtWakeup"] = request.GmtWakeup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hid))
            {
                query["Hid"] = request.Hid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interrupt))
            {
                query["Interrupt"] = request.Interrupt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoker))
            {
                query["Invoker"] = request.Invoker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                query["Success"] = request.Success;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExtraData))
            {
                query["TaskExtraData"] = request.TaskExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdentifier))
            {
                query["TaskIdentifier"] = request.TaskIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "doCheckResource",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoCheckResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DoCheckResourceResponse> DoCheckResourceWithOptionsAsync(DoCheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtWakeup))
            {
                query["GmtWakeup"] = request.GmtWakeup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hid))
            {
                query["Hid"] = request.Hid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interrupt))
            {
                query["Interrupt"] = request.Interrupt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoker))
            {
                query["Invoker"] = request.Invoker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                query["Success"] = request.Success;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExtraData))
            {
                query["TaskExtraData"] = request.TaskExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdentifier))
            {
                query["TaskIdentifier"] = request.TaskIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "doCheckResource",
                Version = "2017-10-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoCheckResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DoCheckResourceResponse DoCheckResource(DoCheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoCheckResourceWithOptions(request, runtime);
        }

        public async Task<DoCheckResourceResponse> DoCheckResourceAsync(DoCheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoCheckResourceWithOptionsAsync(request, runtime);
        }

    }
}
