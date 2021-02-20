// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Rtc20180111.Models;

namespace AlibabaCloud.SDK.Rtc20180111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rtc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddRecordTemplateResponse AddRecordTemplateWithOptions(AddRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRecordTemplateResponse>(DoRPCRequest("AddRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddRecordTemplateResponse> AddRecordTemplateWithOptionsAsync(AddRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRecordTemplateResponse>(await DoRPCRequestAsync("AddRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddRecordTemplateResponse AddRecordTemplate(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRecordTemplateWithOptions(request, runtime);
        }

        public async Task<AddRecordTemplateResponse> AddRecordTemplateAsync(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRecordTemplateWithOptionsAsync(request, runtime);
        }

        public CreateAutoLiveStreamRuleResponse CreateAutoLiveStreamRuleWithOptions(CreateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAutoLiveStreamRuleResponse>(DoRPCRequest("CreateAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAutoLiveStreamRuleResponse> CreateAutoLiveStreamRuleWithOptionsAsync(CreateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("CreateAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAutoLiveStreamRuleResponse CreateAutoLiveStreamRule(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<CreateAutoLiveStreamRuleResponse> CreateAutoLiveStreamRuleAsync(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public CreateChannelResponse CreateChannelWithOptions(CreateChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateChannelResponse>(DoRPCRequest("CreateChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateChannelResponse> CreateChannelWithOptionsAsync(CreateChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateChannelResponse>(await DoRPCRequestAsync("CreateChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChannelWithOptions(request, runtime);
        }

        public async Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChannelWithOptionsAsync(request, runtime);
        }

        public CreateConferenceResponse CreateConferenceWithOptions(CreateConferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConferenceResponse>(DoRPCRequest("CreateConference", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateConferenceResponse> CreateConferenceWithOptionsAsync(CreateConferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConferenceResponse>(await DoRPCRequestAsync("CreateConference", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateConferenceResponse CreateConference(CreateConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConferenceWithOptions(request, runtime);
        }

        public async Task<CreateConferenceResponse> CreateConferenceAsync(CreateConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConferenceWithOptionsAsync(request, runtime);
        }

        public CreateEventSubscribeResponse CreateEventSubscribeWithOptions(CreateEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEventSubscribeResponse>(DoRPCRequest("CreateEventSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEventSubscribeResponse> CreateEventSubscribeWithOptionsAsync(CreateEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEventSubscribeResponse>(await DoRPCRequestAsync("CreateEventSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEventSubscribeResponse CreateEventSubscribe(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventSubscribeWithOptions(request, runtime);
        }

        public async Task<CreateEventSubscribeResponse> CreateEventSubscribeAsync(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventSubscribeWithOptionsAsync(request, runtime);
        }

        public CreateMPULayoutResponse CreateMPULayoutWithOptions(CreateMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMPULayoutResponse>(DoRPCRequest("CreateMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMPULayoutResponse> CreateMPULayoutWithOptionsAsync(CreateMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMPULayoutResponse>(await DoRPCRequestAsync("CreateMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMPULayoutResponse CreateMPULayout(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMPULayoutWithOptions(request, runtime);
        }

        public async Task<CreateMPULayoutResponse> CreateMPULayoutAsync(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMPULayoutWithOptionsAsync(request, runtime);
        }

        public CreateMPURuleResponse CreateMPURuleWithOptions(CreateMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMPURuleResponse>(DoRPCRequest("CreateMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMPURuleResponse> CreateMPURuleWithOptionsAsync(CreateMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMPURuleResponse>(await DoRPCRequestAsync("CreateMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMPURuleResponse CreateMPURule(CreateMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMPURuleWithOptions(request, runtime);
        }

        public async Task<CreateMPURuleResponse> CreateMPURuleAsync(CreateMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMPURuleWithOptionsAsync(request, runtime);
        }

        public CreateServiceLinkedRoleForRtcResponse CreateServiceLinkedRoleForRtcWithOptions(CreateServiceLinkedRoleForRtcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleForRtcResponse>(DoRPCRequest("CreateServiceLinkedRoleForRtc", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServiceLinkedRoleForRtcResponse> CreateServiceLinkedRoleForRtcWithOptionsAsync(CreateServiceLinkedRoleForRtcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleForRtcResponse>(await DoRPCRequestAsync("CreateServiceLinkedRoleForRtc", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServiceLinkedRoleForRtcResponse CreateServiceLinkedRoleForRtc(CreateServiceLinkedRoleForRtcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleForRtcWithOptions(request, runtime);
        }

        public async Task<CreateServiceLinkedRoleForRtcResponse> CreateServiceLinkedRoleForRtcAsync(CreateServiceLinkedRoleForRtcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleForRtcWithOptionsAsync(request, runtime);
        }

        public CreateSubscribeResponse CreateSubscribeWithOptions(CreateSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSubscribeResponse>(DoRPCRequest("CreateSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSubscribeResponse> CreateSubscribeWithOptionsAsync(CreateSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSubscribeResponse>(await DoRPCRequestAsync("CreateSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSubscribeResponse CreateSubscribe(CreateSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubscribeWithOptions(request, runtime);
        }

        public async Task<CreateSubscribeResponse> CreateSubscribeAsync(CreateSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubscribeWithOptionsAsync(request, runtime);
        }

        public DeleteAutoLiveStreamRuleResponse DeleteAutoLiveStreamRuleWithOptions(DeleteAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoLiveStreamRuleResponse>(DoRPCRequest("DeleteAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAutoLiveStreamRuleResponse> DeleteAutoLiveStreamRuleWithOptionsAsync(DeleteAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("DeleteAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAutoLiveStreamRuleResponse DeleteAutoLiveStreamRule(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<DeleteAutoLiveStreamRuleResponse> DeleteAutoLiveStreamRuleAsync(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public DeleteChannelResponse DeleteChannelWithOptions(DeleteChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChannelResponse>(DoRPCRequest("DeleteChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteChannelResponse> DeleteChannelWithOptionsAsync(DeleteChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChannelResponse>(await DoRPCRequestAsync("DeleteChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChannelWithOptions(request, runtime);
        }

        public async Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChannelWithOptionsAsync(request, runtime);
        }

        public DeleteConferenceResponse DeleteConferenceWithOptions(DeleteConferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConferenceResponse>(DoRPCRequest("DeleteConference", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteConferenceResponse> DeleteConferenceWithOptionsAsync(DeleteConferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConferenceResponse>(await DoRPCRequestAsync("DeleteConference", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteConferenceResponse DeleteConference(DeleteConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConferenceWithOptions(request, runtime);
        }

        public async Task<DeleteConferenceResponse> DeleteConferenceAsync(DeleteConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConferenceWithOptionsAsync(request, runtime);
        }

        public DeleteEventSubscribeResponse DeleteEventSubscribeWithOptions(DeleteEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventSubscribeResponse>(DoRPCRequest("DeleteEventSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEventSubscribeResponse> DeleteEventSubscribeWithOptionsAsync(DeleteEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventSubscribeResponse>(await DoRPCRequestAsync("DeleteEventSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEventSubscribeResponse DeleteEventSubscribe(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventSubscribeWithOptions(request, runtime);
        }

        public async Task<DeleteEventSubscribeResponse> DeleteEventSubscribeAsync(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventSubscribeWithOptionsAsync(request, runtime);
        }

        public DeleteMPULayoutResponse DeleteMPULayoutWithOptions(DeleteMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMPULayoutResponse>(DoRPCRequest("DeleteMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMPULayoutResponse> DeleteMPULayoutWithOptionsAsync(DeleteMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMPULayoutResponse>(await DoRPCRequestAsync("DeleteMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMPULayoutResponse DeleteMPULayout(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMPULayoutWithOptions(request, runtime);
        }

        public async Task<DeleteMPULayoutResponse> DeleteMPULayoutAsync(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMPULayoutWithOptionsAsync(request, runtime);
        }

        public DeleteMPURuleResponse DeleteMPURuleWithOptions(DeleteMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMPURuleResponse>(DoRPCRequest("DeleteMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMPURuleResponse> DeleteMPURuleWithOptionsAsync(DeleteMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMPURuleResponse>(await DoRPCRequestAsync("DeleteMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMPURuleResponse DeleteMPURule(DeleteMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMPURuleWithOptions(request, runtime);
        }

        public async Task<DeleteMPURuleResponse> DeleteMPURuleAsync(DeleteMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMPURuleWithOptionsAsync(request, runtime);
        }

        public DeleteRecordTemplateResponse DeleteRecordTemplateWithOptions(DeleteRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordTemplateResponse>(DoRPCRequest("DeleteRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplateWithOptionsAsync(DeleteRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordTemplateResponse>(await DoRPCRequestAsync("DeleteRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRecordTemplateResponse DeleteRecordTemplate(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplateAsync(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteSubscribeResponse DeleteSubscribeWithOptions(DeleteSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSubscribeResponse>(DoRPCRequest("DeleteSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSubscribeResponse> DeleteSubscribeWithOptionsAsync(DeleteSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSubscribeResponse>(await DoRPCRequestAsync("DeleteSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSubscribeResponse DeleteSubscribe(DeleteSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubscribeWithOptions(request, runtime);
        }

        public async Task<DeleteSubscribeResponse> DeleteSubscribeAsync(DeleteSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubscribeWithOptionsAsync(request, runtime);
        }

        public DescribeAppsResponse DescribeAppsWithOptions(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppsResponse>(DoRPCRequest("DescribeApps", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppsResponse>(await DoRPCRequestAsync("DescribeApps", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppsWithOptions(request, runtime);
        }

        public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppsWithOptionsAsync(request, runtime);
        }

        public DescribeAutoLiveStreamRuleResponse DescribeAutoLiveStreamRuleWithOptions(DescribeAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoLiveStreamRuleResponse>(DoRPCRequest("DescribeAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoLiveStreamRuleResponse> DescribeAutoLiveStreamRuleWithOptionsAsync(DescribeAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("DescribeAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoLiveStreamRuleResponse DescribeAutoLiveStreamRule(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<DescribeAutoLiveStreamRuleResponse> DescribeAutoLiveStreamRuleAsync(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public DescribeChannelParticipantsResponse DescribeChannelParticipantsWithOptions(DescribeChannelParticipantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChannelParticipantsResponse>(DoRPCRequest("DescribeChannelParticipants", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeChannelParticipantsResponse> DescribeChannelParticipantsWithOptionsAsync(DescribeChannelParticipantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChannelParticipantsResponse>(await DoRPCRequestAsync("DescribeChannelParticipants", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeChannelParticipantsResponse DescribeChannelParticipants(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelParticipantsWithOptions(request, runtime);
        }

        public async Task<DescribeChannelParticipantsResponse> DescribeChannelParticipantsAsync(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelParticipantsWithOptionsAsync(request, runtime);
        }

        public DescribeChannelUsersResponse DescribeChannelUsersWithOptions(DescribeChannelUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChannelUsersResponse>(DoRPCRequest("DescribeChannelUsers", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeChannelUsersResponse> DescribeChannelUsersWithOptionsAsync(DescribeChannelUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChannelUsersResponse>(await DoRPCRequestAsync("DescribeChannelUsers", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeChannelUsersResponse DescribeChannelUsers(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUsersWithOptions(request, runtime);
        }

        public async Task<DescribeChannelUsersResponse> DescribeChannelUsersAsync(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUsersWithOptionsAsync(request, runtime);
        }

        public DescribeConferenceAuthInfoResponse DescribeConferenceAuthInfoWithOptions(DescribeConferenceAuthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConferenceAuthInfoResponse>(DoRPCRequest("DescribeConferenceAuthInfo", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConferenceAuthInfoResponse> DescribeConferenceAuthInfoWithOptionsAsync(DescribeConferenceAuthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConferenceAuthInfoResponse>(await DoRPCRequestAsync("DescribeConferenceAuthInfo", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeConferenceAuthInfoResponse DescribeConferenceAuthInfo(DescribeConferenceAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConferenceAuthInfoWithOptions(request, runtime);
        }

        public async Task<DescribeConferenceAuthInfoResponse> DescribeConferenceAuthInfoAsync(DescribeConferenceAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConferenceAuthInfoWithOptionsAsync(request, runtime);
        }

        public DescribeMPULayoutInfoResponse DescribeMPULayoutInfoWithOptions(DescribeMPULayoutInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPULayoutInfoResponse>(DoRPCRequest("DescribeMPULayoutInfo", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMPULayoutInfoResponse> DescribeMPULayoutInfoWithOptionsAsync(DescribeMPULayoutInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPULayoutInfoResponse>(await DoRPCRequestAsync("DescribeMPULayoutInfo", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMPULayoutInfoResponse DescribeMPULayoutInfo(DescribeMPULayoutInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPULayoutInfoWithOptions(request, runtime);
        }

        public async Task<DescribeMPULayoutInfoResponse> DescribeMPULayoutInfoAsync(DescribeMPULayoutInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPULayoutInfoWithOptionsAsync(request, runtime);
        }

        public DescribeMPULayoutInfoListResponse DescribeMPULayoutInfoListWithOptions(DescribeMPULayoutInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPULayoutInfoListResponse>(DoRPCRequest("DescribeMPULayoutInfoList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMPULayoutInfoListResponse> DescribeMPULayoutInfoListWithOptionsAsync(DescribeMPULayoutInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPULayoutInfoListResponse>(await DoRPCRequestAsync("DescribeMPULayoutInfoList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMPULayoutInfoListResponse DescribeMPULayoutInfoList(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPULayoutInfoListWithOptions(request, runtime);
        }

        public async Task<DescribeMPULayoutInfoListResponse> DescribeMPULayoutInfoListAsync(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPULayoutInfoListWithOptionsAsync(request, runtime);
        }

        public DescribeMPULayoutListResponse DescribeMPULayoutListWithOptions(DescribeMPULayoutListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPULayoutListResponse>(DoRPCRequest("DescribeMPULayoutList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMPULayoutListResponse> DescribeMPULayoutListWithOptionsAsync(DescribeMPULayoutListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPULayoutListResponse>(await DoRPCRequestAsync("DescribeMPULayoutList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMPULayoutListResponse DescribeMPULayoutList(DescribeMPULayoutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPULayoutListWithOptions(request, runtime);
        }

        public async Task<DescribeMPULayoutListResponse> DescribeMPULayoutListAsync(DescribeMPULayoutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPULayoutListWithOptionsAsync(request, runtime);
        }

        public DescribeMPURuleResponse DescribeMPURuleWithOptions(DescribeMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPURuleResponse>(DoRPCRequest("DescribeMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMPURuleResponse> DescribeMPURuleWithOptionsAsync(DescribeMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPURuleResponse>(await DoRPCRequestAsync("DescribeMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMPURuleResponse DescribeMPURule(DescribeMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPURuleWithOptions(request, runtime);
        }

        public async Task<DescribeMPURuleResponse> DescribeMPURuleAsync(DescribeMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPURuleWithOptionsAsync(request, runtime);
        }

        public DescribeRecordFilesResponse DescribeRecordFilesWithOptions(DescribeRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordFilesResponse>(DoRPCRequest("DescribeRecordFiles", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordFilesResponse> DescribeRecordFilesWithOptionsAsync(DescribeRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordFilesResponse>(await DoRPCRequestAsync("DescribeRecordFiles", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordFilesResponse DescribeRecordFiles(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordFilesWithOptions(request, runtime);
        }

        public async Task<DescribeRecordFilesResponse> DescribeRecordFilesAsync(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordFilesWithOptionsAsync(request, runtime);
        }

        public DescribeRecordTasksResponse DescribeRecordTasksWithOptions(DescribeRecordTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordTasksResponse>(DoRPCRequest("DescribeRecordTasks", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordTasksResponse> DescribeRecordTasksWithOptionsAsync(DescribeRecordTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordTasksResponse>(await DoRPCRequestAsync("DescribeRecordTasks", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordTasksResponse DescribeRecordTasks(DescribeRecordTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordTasksWithOptions(request, runtime);
        }

        public async Task<DescribeRecordTasksResponse> DescribeRecordTasksAsync(DescribeRecordTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordTasksWithOptionsAsync(request, runtime);
        }

        public DescribeRecordTemplatesResponse DescribeRecordTemplatesWithOptions(DescribeRecordTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordTemplatesResponse>(DoRPCRequest("DescribeRecordTemplates", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordTemplatesResponse> DescribeRecordTemplatesWithOptionsAsync(DescribeRecordTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordTemplatesResponse>(await DoRPCRequestAsync("DescribeRecordTemplates", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordTemplatesResponse DescribeRecordTemplates(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeRecordTemplatesResponse> DescribeRecordTemplatesAsync(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeRTCAppKeyResponse DescribeRTCAppKeyWithOptions(DescribeRTCAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRTCAppKeyResponse>(DoRPCRequest("DescribeRTCAppKey", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRTCAppKeyResponse> DescribeRTCAppKeyWithOptionsAsync(DescribeRTCAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRTCAppKeyResponse>(await DoRPCRequestAsync("DescribeRTCAppKey", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRTCAppKeyResponse DescribeRTCAppKey(DescribeRTCAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRTCAppKeyWithOptions(request, runtime);
        }

        public async Task<DescribeRTCAppKeyResponse> DescribeRTCAppKeyAsync(DescribeRTCAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRTCAppKeyWithOptionsAsync(request, runtime);
        }

        public DescribeRtcChannelCntDataResponse DescribeRtcChannelCntDataWithOptions(DescribeRtcChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelCntDataResponse>(DoRPCRequest("DescribeRtcChannelCntData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelCntDataResponse> DescribeRtcChannelCntDataWithOptionsAsync(DescribeRtcChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelCntDataResponse>(await DoRPCRequestAsync("DescribeRtcChannelCntData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcChannelCntDataResponse DescribeRtcChannelCntData(DescribeRtcChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelCntDataWithOptions(request, runtime);
        }

        public async Task<DescribeRtcChannelCntDataResponse> DescribeRtcChannelCntDataAsync(DescribeRtcChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelCntDataWithOptionsAsync(request, runtime);
        }

        public DescribeRtcChannelDetailResponse DescribeRtcChannelDetailWithOptions(DescribeRtcChannelDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelDetailResponse>(DoRPCRequest("DescribeRtcChannelDetail", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelDetailResponse> DescribeRtcChannelDetailWithOptionsAsync(DescribeRtcChannelDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelDetailResponse>(await DoRPCRequestAsync("DescribeRtcChannelDetail", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcChannelDetailResponse DescribeRtcChannelDetail(DescribeRtcChannelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelDetailWithOptions(request, runtime);
        }

        public async Task<DescribeRtcChannelDetailResponse> DescribeRtcChannelDetailAsync(DescribeRtcChannelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelDetailWithOptionsAsync(request, runtime);
        }

        public DescribeRtcChannelListResponse DescribeRtcChannelListWithOptions(DescribeRtcChannelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelListResponse>(DoRPCRequest("DescribeRtcChannelList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListWithOptionsAsync(DescribeRtcChannelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelListResponse>(await DoRPCRequestAsync("DescribeRtcChannelList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcChannelListResponse DescribeRtcChannelList(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelListWithOptions(request, runtime);
        }

        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListAsync(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelListWithOptionsAsync(request, runtime);
        }

        public DescribeRtcChannelMetricResponse DescribeRtcChannelMetricWithOptions(DescribeRtcChannelMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricResponse>(DoRPCRequest("DescribeRtcChannelMetric", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelMetricResponse> DescribeRtcChannelMetricWithOptionsAsync(DescribeRtcChannelMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricResponse>(await DoRPCRequestAsync("DescribeRtcChannelMetric", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcChannelMetricResponse DescribeRtcChannelMetric(DescribeRtcChannelMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelMetricWithOptions(request, runtime);
        }

        public async Task<DescribeRtcChannelMetricResponse> DescribeRtcChannelMetricAsync(DescribeRtcChannelMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelMetricWithOptionsAsync(request, runtime);
        }

        public DescribeRtcChannelMetricsResponse DescribeRtcChannelMetricsWithOptions(DescribeRtcChannelMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricsResponse>(DoRPCRequest("DescribeRtcChannelMetrics", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelMetricsResponse> DescribeRtcChannelMetricsWithOptionsAsync(DescribeRtcChannelMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricsResponse>(await DoRPCRequestAsync("DescribeRtcChannelMetrics", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcChannelMetricsResponse DescribeRtcChannelMetrics(DescribeRtcChannelMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelMetricsWithOptions(request, runtime);
        }

        public async Task<DescribeRtcChannelMetricsResponse> DescribeRtcChannelMetricsAsync(DescribeRtcChannelMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelMetricsWithOptionsAsync(request, runtime);
        }

        public DescribeRtcChannelsResponse DescribeRtcChannelsWithOptions(DescribeRtcChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelsResponse>(DoRPCRequest("DescribeRtcChannels", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelsResponse> DescribeRtcChannelsWithOptionsAsync(DescribeRtcChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelsResponse>(await DoRPCRequestAsync("DescribeRtcChannels", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcChannelsResponse DescribeRtcChannels(DescribeRtcChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelsWithOptions(request, runtime);
        }

        public async Task<DescribeRtcChannelsResponse> DescribeRtcChannelsAsync(DescribeRtcChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelsWithOptionsAsync(request, runtime);
        }

        public DescribeRtcChannelUserListResponse DescribeRtcChannelUserListWithOptions(DescribeRtcChannelUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelUserListResponse>(DoRPCRequest("DescribeRtcChannelUserList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelUserListResponse> DescribeRtcChannelUserListWithOptionsAsync(DescribeRtcChannelUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcChannelUserListResponse>(await DoRPCRequestAsync("DescribeRtcChannelUserList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcChannelUserListResponse DescribeRtcChannelUserList(DescribeRtcChannelUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelUserListWithOptions(request, runtime);
        }

        public async Task<DescribeRtcChannelUserListResponse> DescribeRtcChannelUserListAsync(DescribeRtcChannelUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelUserListWithOptionsAsync(request, runtime);
        }

        public DescribeRtcDurationDataResponse DescribeRtcDurationDataWithOptions(DescribeRtcDurationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcDurationDataResponse>(DoRPCRequest("DescribeRtcDurationData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcDurationDataResponse> DescribeRtcDurationDataWithOptionsAsync(DescribeRtcDurationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcDurationDataResponse>(await DoRPCRequestAsync("DescribeRtcDurationData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcDurationDataResponse DescribeRtcDurationData(DescribeRtcDurationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcDurationDataWithOptions(request, runtime);
        }

        public async Task<DescribeRtcDurationDataResponse> DescribeRtcDurationDataAsync(DescribeRtcDurationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcDurationDataWithOptionsAsync(request, runtime);
        }

        public DescribeRtcPeakChannelCntDataResponse DescribeRtcPeakChannelCntDataWithOptions(DescribeRtcPeakChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcPeakChannelCntDataResponse>(DoRPCRequest("DescribeRtcPeakChannelCntData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcPeakChannelCntDataResponse> DescribeRtcPeakChannelCntDataWithOptionsAsync(DescribeRtcPeakChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcPeakChannelCntDataResponse>(await DoRPCRequestAsync("DescribeRtcPeakChannelCntData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcPeakChannelCntDataResponse DescribeRtcPeakChannelCntData(DescribeRtcPeakChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcPeakChannelCntDataWithOptions(request, runtime);
        }

        public async Task<DescribeRtcPeakChannelCntDataResponse> DescribeRtcPeakChannelCntDataAsync(DescribeRtcPeakChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcPeakChannelCntDataWithOptionsAsync(request, runtime);
        }

        public DescribeRtcPeakUserCntDataResponse DescribeRtcPeakUserCntDataWithOptions(DescribeRtcPeakUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcPeakUserCntDataResponse>(DoRPCRequest("DescribeRtcPeakUserCntData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcPeakUserCntDataResponse> DescribeRtcPeakUserCntDataWithOptionsAsync(DescribeRtcPeakUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcPeakUserCntDataResponse>(await DoRPCRequestAsync("DescribeRtcPeakUserCntData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcPeakUserCntDataResponse DescribeRtcPeakUserCntData(DescribeRtcPeakUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcPeakUserCntDataWithOptions(request, runtime);
        }

        public async Task<DescribeRtcPeakUserCntDataResponse> DescribeRtcPeakUserCntDataAsync(DescribeRtcPeakUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcPeakUserCntDataWithOptionsAsync(request, runtime);
        }

        public DescribeRtcScaleResponse DescribeRtcScaleWithOptions(DescribeRtcScaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcScaleResponse>(DoRPCRequest("DescribeRtcScale", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcScaleResponse> DescribeRtcScaleWithOptionsAsync(DescribeRtcScaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcScaleResponse>(await DoRPCRequestAsync("DescribeRtcScale", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcScaleResponse DescribeRtcScale(DescribeRtcScaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcScaleWithOptions(request, runtime);
        }

        public async Task<DescribeRtcScaleResponse> DescribeRtcScaleAsync(DescribeRtcScaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcScaleWithOptionsAsync(request, runtime);
        }

        public DescribeRtcScaleDetailResponse DescribeRtcScaleDetailWithOptions(DescribeRtcScaleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcScaleDetailResponse>(DoRPCRequest("DescribeRtcScaleDetail", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcScaleDetailResponse> DescribeRtcScaleDetailWithOptionsAsync(DescribeRtcScaleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcScaleDetailResponse>(await DoRPCRequestAsync("DescribeRtcScaleDetail", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcScaleDetailResponse DescribeRtcScaleDetail(DescribeRtcScaleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcScaleDetailWithOptions(request, runtime);
        }

        public async Task<DescribeRtcScaleDetailResponse> DescribeRtcScaleDetailAsync(DescribeRtcScaleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcScaleDetailWithOptionsAsync(request, runtime);
        }

        public DescribeRtcUserCntDataResponse DescribeRtcUserCntDataWithOptions(DescribeRtcUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcUserCntDataResponse>(DoRPCRequest("DescribeRtcUserCntData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcUserCntDataResponse> DescribeRtcUserCntDataWithOptionsAsync(DescribeRtcUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcUserCntDataResponse>(await DoRPCRequestAsync("DescribeRtcUserCntData", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcUserCntDataResponse DescribeRtcUserCntData(DescribeRtcUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcUserCntDataWithOptions(request, runtime);
        }

        public async Task<DescribeRtcUserCntDataResponse> DescribeRtcUserCntDataAsync(DescribeRtcUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcUserCntDataWithOptionsAsync(request, runtime);
        }

        public DescribeRtcUserEventsResponse DescribeRtcUserEventsWithOptions(DescribeRtcUserEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcUserEventsResponse>(DoRPCRequest("DescribeRtcUserEvents", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcUserEventsResponse> DescribeRtcUserEventsWithOptionsAsync(DescribeRtcUserEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcUserEventsResponse>(await DoRPCRequestAsync("DescribeRtcUserEvents", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcUserEventsResponse DescribeRtcUserEvents(DescribeRtcUserEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcUserEventsWithOptions(request, runtime);
        }

        public async Task<DescribeRtcUserEventsResponse> DescribeRtcUserEventsAsync(DescribeRtcUserEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcUserEventsWithOptionsAsync(request, runtime);
        }

        public DescribeRtcUserListResponse DescribeRtcUserListWithOptions(DescribeRtcUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcUserListResponse>(DoRPCRequest("DescribeRtcUserList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRtcUserListResponse> DescribeRtcUserListWithOptionsAsync(DescribeRtcUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRtcUserListResponse>(await DoRPCRequestAsync("DescribeRtcUserList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRtcUserListResponse DescribeRtcUserList(DescribeRtcUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcUserListWithOptions(request, runtime);
        }

        public async Task<DescribeRtcUserListResponse> DescribeRtcUserListAsync(DescribeRtcUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcUserListWithOptionsAsync(request, runtime);
        }

        public DescribeUserInfoInChannelResponse DescribeUserInfoInChannelWithOptions(DescribeUserInfoInChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserInfoInChannelResponse>(DoRPCRequest("DescribeUserInfoInChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserInfoInChannelResponse> DescribeUserInfoInChannelWithOptionsAsync(DescribeUserInfoInChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserInfoInChannelResponse>(await DoRPCRequestAsync("DescribeUserInfoInChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserInfoInChannelResponse DescribeUserInfoInChannel(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserInfoInChannelWithOptions(request, runtime);
        }

        public async Task<DescribeUserInfoInChannelResponse> DescribeUserInfoInChannelAsync(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserInfoInChannelWithOptionsAsync(request, runtime);
        }

        public DisableMPURuleResponse DisableMPURuleWithOptions(DisableMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableMPURuleResponse>(DoRPCRequest("DisableMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableMPURuleResponse> DisableMPURuleWithOptionsAsync(DisableMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableMPURuleResponse>(await DoRPCRequestAsync("DisableMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableMPURuleResponse DisableMPURule(DisableMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableMPURuleWithOptions(request, runtime);
        }

        public async Task<DisableMPURuleResponse> DisableMPURuleAsync(DisableMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableMPURuleWithOptionsAsync(request, runtime);
        }

        public EnableMPURuleResponse EnableMPURuleWithOptions(EnableMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableMPURuleResponse>(DoRPCRequest("EnableMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableMPURuleResponse> EnableMPURuleWithOptionsAsync(EnableMPURuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableMPURuleResponse>(await DoRPCRequestAsync("EnableMPURule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableMPURuleResponse EnableMPURule(EnableMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableMPURuleWithOptions(request, runtime);
        }

        public async Task<EnableMPURuleResponse> EnableMPURuleAsync(EnableMPURuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableMPURuleWithOptionsAsync(request, runtime);
        }

        public GetMPUTaskStatusResponse GetMPUTaskStatusWithOptions(GetMPUTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMPUTaskStatusResponse>(DoRPCRequest("GetMPUTaskStatus", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMPUTaskStatusResponse> GetMPUTaskStatusWithOptionsAsync(GetMPUTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMPUTaskStatusResponse>(await DoRPCRequestAsync("GetMPUTaskStatus", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMPUTaskStatusResponse GetMPUTaskStatus(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMPUTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetMPUTaskStatusResponse> GetMPUTaskStatusAsync(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMPUTaskStatusWithOptionsAsync(request, runtime);
        }

        public ModifyAppResponse ModifyAppWithOptions(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAppResponse>(DoRPCRequest("ModifyApp", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAppResponse> ModifyAppWithOptionsAsync(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAppResponse>(await DoRPCRequestAsync("ModifyApp", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAppResponse ModifyApp(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppWithOptions(request, runtime);
        }

        public async Task<ModifyAppResponse> ModifyAppAsync(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppWithOptionsAsync(request, runtime);
        }

        public ModifyConferenceResponse ModifyConferenceWithOptions(ModifyConferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyConferenceResponse>(DoRPCRequest("ModifyConference", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyConferenceResponse> ModifyConferenceWithOptionsAsync(ModifyConferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyConferenceResponse>(await DoRPCRequestAsync("ModifyConference", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyConferenceResponse ModifyConference(ModifyConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyConferenceWithOptions(request, runtime);
        }

        public async Task<ModifyConferenceResponse> ModifyConferenceAsync(ModifyConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyConferenceWithOptionsAsync(request, runtime);
        }

        public ModifyMPULayoutResponse ModifyMPULayoutWithOptions(ModifyMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMPULayoutResponse>(DoRPCRequest("ModifyMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMPULayoutResponse> ModifyMPULayoutWithOptionsAsync(ModifyMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMPULayoutResponse>(await DoRPCRequestAsync("ModifyMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMPULayoutResponse ModifyMPULayout(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMPULayoutWithOptions(request, runtime);
        }

        public async Task<ModifyMPULayoutResponse> ModifyMPULayoutAsync(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMPULayoutWithOptionsAsync(request, runtime);
        }

        public MuteAudioResponse MuteAudioWithOptions(MuteAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MuteAudioResponse>(DoRPCRequest("MuteAudio", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MuteAudioResponse> MuteAudioWithOptionsAsync(MuteAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MuteAudioResponse>(await DoRPCRequestAsync("MuteAudio", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MuteAudioResponse MuteAudio(MuteAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MuteAudioWithOptions(request, runtime);
        }

        public async Task<MuteAudioResponse> MuteAudioAsync(MuteAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MuteAudioWithOptionsAsync(request, runtime);
        }

        public MuteAudioAllResponse MuteAudioAllWithOptions(MuteAudioAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MuteAudioAllResponse>(DoRPCRequest("MuteAudioAll", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MuteAudioAllResponse> MuteAudioAllWithOptionsAsync(MuteAudioAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MuteAudioAllResponse>(await DoRPCRequestAsync("MuteAudioAll", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MuteAudioAllResponse MuteAudioAll(MuteAudioAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MuteAudioAllWithOptions(request, runtime);
        }

        public async Task<MuteAudioAllResponse> MuteAudioAllAsync(MuteAudioAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MuteAudioAllWithOptionsAsync(request, runtime);
        }

        public ReceiveNotifyResponse ReceiveNotifyWithOptions(ReceiveNotifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReceiveNotifyResponse>(DoRPCRequest("ReceiveNotify", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReceiveNotifyResponse> ReceiveNotifyWithOptionsAsync(ReceiveNotifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReceiveNotifyResponse>(await DoRPCRequestAsync("ReceiveNotify", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReceiveNotifyResponse ReceiveNotify(ReceiveNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReceiveNotifyWithOptions(request, runtime);
        }

        public async Task<ReceiveNotifyResponse> ReceiveNotifyAsync(ReceiveNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReceiveNotifyWithOptionsAsync(request, runtime);
        }

        public RemoveParticipantsResponse RemoveParticipantsWithOptions(RemoveParticipantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveParticipantsResponse>(DoRPCRequest("RemoveParticipants", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveParticipantsResponse> RemoveParticipantsWithOptionsAsync(RemoveParticipantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveParticipantsResponse>(await DoRPCRequestAsync("RemoveParticipants", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveParticipantsResponse RemoveParticipants(RemoveParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveParticipantsWithOptions(request, runtime);
        }

        public async Task<RemoveParticipantsResponse> RemoveParticipantsAsync(RemoveParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveParticipantsWithOptionsAsync(request, runtime);
        }

        public RemoveTerminalsResponse RemoveTerminalsWithOptions(RemoveTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTerminalsResponse>(DoRPCRequest("RemoveTerminals", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveTerminalsResponse> RemoveTerminalsWithOptionsAsync(RemoveTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTerminalsResponse>(await DoRPCRequestAsync("RemoveTerminals", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveTerminalsResponse RemoveTerminals(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTerminalsWithOptions(request, runtime);
        }

        public async Task<RemoveTerminalsResponse> RemoveTerminalsAsync(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTerminalsWithOptionsAsync(request, runtime);
        }

        public SetChannelPropertyResponse SetChannelPropertyWithOptions(SetChannelPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetChannelPropertyResponse>(DoRPCRequest("SetChannelProperty", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetChannelPropertyResponse> SetChannelPropertyWithOptionsAsync(SetChannelPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetChannelPropertyResponse>(await DoRPCRequestAsync("SetChannelProperty", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetChannelPropertyResponse SetChannelProperty(SetChannelPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetChannelPropertyWithOptions(request, runtime);
        }

        public async Task<SetChannelPropertyResponse> SetChannelPropertyAsync(SetChannelPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetChannelPropertyWithOptionsAsync(request, runtime);
        }

        public StartMPUTaskResponse StartMPUTaskWithOptions(StartMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMPUTaskResponse>(DoRPCRequest("StartMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartMPUTaskResponse> StartMPUTaskWithOptionsAsync(StartMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMPUTaskResponse>(await DoRPCRequestAsync("StartMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartMPUTaskResponse StartMPUTask(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMPUTaskWithOptions(request, runtime);
        }

        public async Task<StartMPUTaskResponse> StartMPUTaskAsync(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMPUTaskWithOptionsAsync(request, runtime);
        }

        public StartRecordTaskResponse StartRecordTaskWithOptions(StartRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRecordTaskResponse>(DoRPCRequest("StartRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartRecordTaskResponse> StartRecordTaskWithOptionsAsync(StartRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRecordTaskResponse>(await DoRPCRequestAsync("StartRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartRecordTaskResponse StartRecordTask(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRecordTaskWithOptions(request, runtime);
        }

        public async Task<StartRecordTaskResponse> StartRecordTaskAsync(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRecordTaskWithOptionsAsync(request, runtime);
        }

        public StopChannelUserPublishResponse StopChannelUserPublishWithOptions(StopChannelUserPublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopChannelUserPublishResponse>(DoRPCRequest("StopChannelUserPublish", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopChannelUserPublishResponse> StopChannelUserPublishWithOptionsAsync(StopChannelUserPublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopChannelUserPublishResponse>(await DoRPCRequestAsync("StopChannelUserPublish", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopChannelUserPublishResponse StopChannelUserPublish(StopChannelUserPublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopChannelUserPublishWithOptions(request, runtime);
        }

        public async Task<StopChannelUserPublishResponse> StopChannelUserPublishAsync(StopChannelUserPublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopChannelUserPublishWithOptionsAsync(request, runtime);
        }

        public StopMPUTaskResponse StopMPUTaskWithOptions(StopMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMPUTaskResponse>(DoRPCRequest("StopMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopMPUTaskResponse> StopMPUTaskWithOptionsAsync(StopMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMPUTaskResponse>(await DoRPCRequestAsync("StopMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopMPUTaskResponse StopMPUTask(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMPUTaskWithOptions(request, runtime);
        }

        public async Task<StopMPUTaskResponse> StopMPUTaskAsync(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMPUTaskWithOptionsAsync(request, runtime);
        }

        public StopRecordTaskResponse StopRecordTaskWithOptions(StopRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopRecordTaskResponse>(DoRPCRequest("StopRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopRecordTaskResponse> StopRecordTaskWithOptionsAsync(StopRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopRecordTaskResponse>(await DoRPCRequestAsync("StopRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopRecordTaskResponse StopRecordTask(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRecordTaskWithOptions(request, runtime);
        }

        public async Task<StopRecordTaskResponse> StopRecordTaskAsync(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRecordTaskWithOptionsAsync(request, runtime);
        }

        public UnmuteAudioResponse UnmuteAudioWithOptions(UnmuteAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnmuteAudioResponse>(DoRPCRequest("UnmuteAudio", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnmuteAudioResponse> UnmuteAudioWithOptionsAsync(UnmuteAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnmuteAudioResponse>(await DoRPCRequestAsync("UnmuteAudio", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnmuteAudioResponse UnmuteAudio(UnmuteAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnmuteAudioWithOptions(request, runtime);
        }

        public async Task<UnmuteAudioResponse> UnmuteAudioAsync(UnmuteAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnmuteAudioWithOptionsAsync(request, runtime);
        }

        public UnmuteAudioAllResponse UnmuteAudioAllWithOptions(UnmuteAudioAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnmuteAudioAllResponse>(DoRPCRequest("UnmuteAudioAll", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnmuteAudioAllResponse> UnmuteAudioAllWithOptionsAsync(UnmuteAudioAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnmuteAudioAllResponse>(await DoRPCRequestAsync("UnmuteAudioAll", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnmuteAudioAllResponse UnmuteAudioAll(UnmuteAudioAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnmuteAudioAllWithOptions(request, runtime);
        }

        public async Task<UnmuteAudioAllResponse> UnmuteAudioAllAsync(UnmuteAudioAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnmuteAudioAllWithOptionsAsync(request, runtime);
        }

        public UpdateChannelResponse UpdateChannelWithOptions(UpdateChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateChannelResponse>(DoRPCRequest("UpdateChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateChannelResponse> UpdateChannelWithOptionsAsync(UpdateChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateChannelResponse>(await DoRPCRequestAsync("UpdateChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateChannelWithOptions(request, runtime);
        }

        public async Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateChannelWithOptionsAsync(request, runtime);
        }

        public UpdateMPULayoutResponse UpdateMPULayoutWithOptions(UpdateMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMPULayoutResponse>(DoRPCRequest("UpdateMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMPULayoutResponse> UpdateMPULayoutWithOptionsAsync(UpdateMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMPULayoutResponse>(await DoRPCRequestAsync("UpdateMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMPULayoutResponse UpdateMPULayout(UpdateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMPULayoutWithOptions(request, runtime);
        }

        public async Task<UpdateMPULayoutResponse> UpdateMPULayoutAsync(UpdateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMPULayoutWithOptionsAsync(request, runtime);
        }

        public UpdateRecordTaskResponse UpdateRecordTaskWithOptions(UpdateRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordTaskResponse>(DoRPCRequest("UpdateRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRecordTaskResponse> UpdateRecordTaskWithOptionsAsync(UpdateRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordTaskResponse>(await DoRPCRequestAsync("UpdateRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRecordTaskResponse UpdateRecordTask(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTaskWithOptions(request, runtime);
        }

        public async Task<UpdateRecordTaskResponse> UpdateRecordTaskAsync(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTaskWithOptionsAsync(request, runtime);
        }

        public UpdateRecordTemplateResponse UpdateRecordTemplateWithOptions(UpdateRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordTemplateResponse>(DoRPCRequest("UpdateRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplateWithOptionsAsync(UpdateRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordTemplateResponse>(await DoRPCRequestAsync("UpdateRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRecordTemplateResponse UpdateRecordTemplate(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplateAsync(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTemplateWithOptionsAsync(request, runtime);
        }

    }
}
