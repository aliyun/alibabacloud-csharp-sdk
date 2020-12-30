// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dyiotapi20171111.Models;

namespace AlibabaCloud.SDK.Dyiotapi20171111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dyiotapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DoIotChgBindOrUnBindResponse DoIotChgBindOrUnBindWithOptions(DoIotChgBindOrUnBindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotChgBindOrUnBindResponse>(DoRPCRequest("DoIotChgBindOrUnBind", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoIotChgBindOrUnBindResponse> DoIotChgBindOrUnBindWithOptionsAsync(DoIotChgBindOrUnBindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotChgBindOrUnBindResponse>(await DoRPCRequestAsync("DoIotChgBindOrUnBind", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoIotChgBindOrUnBindResponse DoIotChgBindOrUnBind(DoIotChgBindOrUnBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoIotChgBindOrUnBindWithOptions(request, runtime);
        }

        public async Task<DoIotChgBindOrUnBindResponse> DoIotChgBindOrUnBindAsync(DoIotChgBindOrUnBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoIotChgBindOrUnBindWithOptionsAsync(request, runtime);
        }

        public DoIotIsImeiExistResponse DoIotIsImeiExistWithOptions(DoIotIsImeiExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotIsImeiExistResponse>(DoRPCRequest("DoIotIsImeiExist", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoIotIsImeiExistResponse> DoIotIsImeiExistWithOptionsAsync(DoIotIsImeiExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotIsImeiExistResponse>(await DoRPCRequestAsync("DoIotIsImeiExist", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoIotIsImeiExistResponse DoIotIsImeiExist(DoIotIsImeiExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoIotIsImeiExistWithOptions(request, runtime);
        }

        public async Task<DoIotIsImeiExistResponse> DoIotIsImeiExistAsync(DoIotIsImeiExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoIotIsImeiExistWithOptionsAsync(request, runtime);
        }

        public DoIotPostImeiResponse DoIotPostImeiWithOptions(DoIotPostImeiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotPostImeiResponse>(DoRPCRequest("DoIotPostImei", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoIotPostImeiResponse> DoIotPostImeiWithOptionsAsync(DoIotPostImeiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotPostImeiResponse>(await DoRPCRequestAsync("DoIotPostImei", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoIotPostImeiResponse DoIotPostImei(DoIotPostImeiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoIotPostImeiWithOptions(request, runtime);
        }

        public async Task<DoIotPostImeiResponse> DoIotPostImeiAsync(DoIotPostImeiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoIotPostImeiWithOptionsAsync(request, runtime);
        }

        public DoIotRechargeResponse DoIotRechargeWithOptions(DoIotRechargeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotRechargeResponse>(DoRPCRequest("DoIotRecharge", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoIotRechargeResponse> DoIotRechargeWithOptionsAsync(DoIotRechargeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotRechargeResponse>(await DoRPCRequestAsync("DoIotRecharge", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoIotRechargeResponse DoIotRecharge(DoIotRechargeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoIotRechargeWithOptions(request, runtime);
        }

        public async Task<DoIotRechargeResponse> DoIotRechargeAsync(DoIotRechargeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoIotRechargeWithOptionsAsync(request, runtime);
        }

        public DoIotSetAbsoluteRemindConfigResponse DoIotSetAbsoluteRemindConfigWithOptions(DoIotSetAbsoluteRemindConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotSetAbsoluteRemindConfigResponse>(DoRPCRequest("DoIotSetAbsoluteRemindConfig", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoIotSetAbsoluteRemindConfigResponse> DoIotSetAbsoluteRemindConfigWithOptionsAsync(DoIotSetAbsoluteRemindConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotSetAbsoluteRemindConfigResponse>(await DoRPCRequestAsync("DoIotSetAbsoluteRemindConfig", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoIotSetAbsoluteRemindConfigResponse DoIotSetAbsoluteRemindConfig(DoIotSetAbsoluteRemindConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoIotSetAbsoluteRemindConfigWithOptions(request, runtime);
        }

        public async Task<DoIotSetAbsoluteRemindConfigResponse> DoIotSetAbsoluteRemindConfigAsync(DoIotSetAbsoluteRemindConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoIotSetAbsoluteRemindConfigWithOptionsAsync(request, runtime);
        }

        public DoIotSetRemindConfigResponse DoIotSetRemindConfigWithOptions(DoIotSetRemindConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotSetRemindConfigResponse>(DoRPCRequest("DoIotSetRemindConfig", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoIotSetRemindConfigResponse> DoIotSetRemindConfigWithOptionsAsync(DoIotSetRemindConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotSetRemindConfigResponse>(await DoRPCRequestAsync("DoIotSetRemindConfig", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoIotSetRemindConfigResponse DoIotSetRemindConfig(DoIotSetRemindConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoIotSetRemindConfigWithOptions(request, runtime);
        }

        public async Task<DoIotSetRemindConfigResponse> DoIotSetRemindConfigAsync(DoIotSetRemindConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoIotSetRemindConfigWithOptionsAsync(request, runtime);
        }

        public DoIotUnbindResumeResponse DoIotUnbindResumeWithOptions(DoIotUnbindResumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotUnbindResumeResponse>(DoRPCRequest("DoIotUnbindResume", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoIotUnbindResumeResponse> DoIotUnbindResumeWithOptionsAsync(DoIotUnbindResumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotUnbindResumeResponse>(await DoRPCRequestAsync("DoIotUnbindResume", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoIotUnbindResumeResponse DoIotUnbindResume(DoIotUnbindResumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoIotUnbindResumeWithOptions(request, runtime);
        }

        public async Task<DoIotUnbindResumeResponse> DoIotUnbindResumeAsync(DoIotUnbindResumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoIotUnbindResumeWithOptionsAsync(request, runtime);
        }

        public DoIotUserStopResumeResponse DoIotUserStopResumeWithOptions(DoIotUserStopResumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotUserStopResumeResponse>(DoRPCRequest("DoIotUserStopResume", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoIotUserStopResumeResponse> DoIotUserStopResumeWithOptionsAsync(DoIotUserStopResumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoIotUserStopResumeResponse>(await DoRPCRequestAsync("DoIotUserStopResume", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoIotUserStopResumeResponse DoIotUserStopResume(DoIotUserStopResumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoIotUserStopResumeWithOptions(request, runtime);
        }

        public async Task<DoIotUserStopResumeResponse> DoIotUserStopResumeAsync(DoIotUserStopResumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoIotUserStopResumeWithOptionsAsync(request, runtime);
        }

        public DoSendIotSmsResponse DoSendIotSmsWithOptions(DoSendIotSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoSendIotSmsResponse>(DoRPCRequest("DoSendIotSms", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoSendIotSmsResponse> DoSendIotSmsWithOptionsAsync(DoSendIotSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoSendIotSmsResponse>(await DoRPCRequestAsync("DoSendIotSms", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoSendIotSmsResponse DoSendIotSms(DoSendIotSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoSendIotSmsWithOptions(request, runtime);
        }

        public async Task<DoSendIotSmsResponse> DoSendIotSmsAsync(DoSendIotSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoSendIotSmsWithOptionsAsync(request, runtime);
        }

        public QueryCardFlowInfoResponse QueryCardFlowInfoWithOptions(QueryCardFlowInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardFlowInfoResponse>(DoRPCRequest("QueryCardFlowInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCardFlowInfoResponse> QueryCardFlowInfoWithOptionsAsync(QueryCardFlowInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardFlowInfoResponse>(await DoRPCRequestAsync("QueryCardFlowInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCardFlowInfoResponse QueryCardFlowInfo(QueryCardFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCardFlowInfoWithOptions(request, runtime);
        }

        public async Task<QueryCardFlowInfoResponse> QueryCardFlowInfoAsync(QueryCardFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCardFlowInfoWithOptionsAsync(request, runtime);
        }

        public QueryCardHistoryFlowInfoResponse QueryCardHistoryFlowInfoWithOptions(QueryCardHistoryFlowInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardHistoryFlowInfoResponse>(DoRPCRequest("QueryCardHistoryFlowInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCardHistoryFlowInfoResponse> QueryCardHistoryFlowInfoWithOptionsAsync(QueryCardHistoryFlowInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardHistoryFlowInfoResponse>(await DoRPCRequestAsync("QueryCardHistoryFlowInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCardHistoryFlowInfoResponse QueryCardHistoryFlowInfo(QueryCardHistoryFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCardHistoryFlowInfoWithOptions(request, runtime);
        }

        public async Task<QueryCardHistoryFlowInfoResponse> QueryCardHistoryFlowInfoAsync(QueryCardHistoryFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCardHistoryFlowInfoWithOptionsAsync(request, runtime);
        }

        public QueryCardInfoResponse QueryCardInfoWithOptions(QueryCardInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardInfoResponse>(DoRPCRequest("QueryCardInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCardInfoResponse> QueryCardInfoWithOptionsAsync(QueryCardInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardInfoResponse>(await DoRPCRequestAsync("QueryCardInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCardInfoResponse QueryCardInfo(QueryCardInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCardInfoWithOptions(request, runtime);
        }

        public async Task<QueryCardInfoResponse> QueryCardInfoAsync(QueryCardInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCardInfoWithOptionsAsync(request, runtime);
        }

        public QueryCardsInfoResponse QueryCardsInfoWithOptions(QueryCardsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardsInfoResponse>(DoRPCRequest("QueryCardsInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCardsInfoResponse> QueryCardsInfoWithOptionsAsync(QueryCardsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardsInfoResponse>(await DoRPCRequestAsync("QueryCardsInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCardsInfoResponse QueryCardsInfo(QueryCardsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCardsInfoWithOptions(request, runtime);
        }

        public async Task<QueryCardsInfoResponse> QueryCardsInfoAsync(QueryCardsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCardsInfoWithOptionsAsync(request, runtime);
        }

        public QueryCardStatusResponse QueryCardStatusWithOptions(QueryCardStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardStatusResponse>(DoRPCRequest("QueryCardStatus", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCardStatusResponse> QueryCardStatusWithOptionsAsync(QueryCardStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardStatusResponse>(await DoRPCRequestAsync("QueryCardStatus", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCardStatusResponse QueryCardStatus(QueryCardStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCardStatusWithOptions(request, runtime);
        }

        public async Task<QueryCardStatusResponse> QueryCardStatusAsync(QueryCardStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCardStatusWithOptionsAsync(request, runtime);
        }

        public QueryIotCardOfferDtlResponse QueryIotCardOfferDtlWithOptions(QueryIotCardOfferDtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIotCardOfferDtlResponse>(DoRPCRequest("QueryIotCardOfferDtl", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryIotCardOfferDtlResponse> QueryIotCardOfferDtlWithOptionsAsync(QueryIotCardOfferDtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIotCardOfferDtlResponse>(await DoRPCRequestAsync("QueryIotCardOfferDtl", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryIotCardOfferDtlResponse QueryIotCardOfferDtl(QueryIotCardOfferDtlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIotCardOfferDtlWithOptions(request, runtime);
        }

        public async Task<QueryIotCardOfferDtlResponse> QueryIotCardOfferDtlAsync(QueryIotCardOfferDtlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIotCardOfferDtlWithOptionsAsync(request, runtime);
        }

        public QueryPersonalInfoResponse QueryPersonalInfoWithOptions(QueryPersonalInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPersonalInfoResponse>(DoRPCRequest("QueryPersonalInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPersonalInfoResponse> QueryPersonalInfoWithOptionsAsync(QueryPersonalInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPersonalInfoResponse>(await DoRPCRequestAsync("QueryPersonalInfo", "2017-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPersonalInfoResponse QueryPersonalInfo(QueryPersonalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPersonalInfoWithOptions(request, runtime);
        }

        public async Task<QueryPersonalInfoResponse> QueryPersonalInfoAsync(QueryPersonalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPersonalInfoWithOptionsAsync(request, runtime);
        }

    }
}
