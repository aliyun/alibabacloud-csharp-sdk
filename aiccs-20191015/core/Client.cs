// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Aiccs20191015.Models;

namespace AlibabaCloud.SDK.Aiccs20191015
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aiccs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public SendHotlineHeartBeatResponse SendHotlineHeartBeatWithOptions(SendHotlineHeartBeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendHotlineHeartBeatResponse>(DoRPCRequest("SendHotlineHeartBeat", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendHotlineHeartBeatResponse> SendHotlineHeartBeatWithOptionsAsync(SendHotlineHeartBeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendHotlineHeartBeatResponse>(await DoRPCRequestAsync("SendHotlineHeartBeat", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendHotlineHeartBeatResponse SendHotlineHeartBeat(SendHotlineHeartBeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendHotlineHeartBeatWithOptions(request, runtime);
        }

        public async Task<SendHotlineHeartBeatResponse> SendHotlineHeartBeatAsync(SendHotlineHeartBeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendHotlineHeartBeatWithOptionsAsync(request, runtime);
        }

        public StartChatWorkResponse StartChatWorkWithOptions(StartChatWorkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartChatWorkResponse>(DoRPCRequest("StartChatWork", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartChatWorkResponse> StartChatWorkWithOptionsAsync(StartChatWorkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartChatWorkResponse>(await DoRPCRequestAsync("StartChatWork", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartChatWorkResponse StartChatWork(StartChatWorkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartChatWorkWithOptions(request, runtime);
        }

        public async Task<StartChatWorkResponse> StartChatWorkAsync(StartChatWorkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartChatWorkWithOptionsAsync(request, runtime);
        }

        public HangUpDoubleCallResponse HangUpDoubleCallWithOptions(HangUpDoubleCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HangUpDoubleCallResponse>(DoRPCRequest("HangUpDoubleCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HangUpDoubleCallResponse> HangUpDoubleCallWithOptionsAsync(HangUpDoubleCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HangUpDoubleCallResponse>(await DoRPCRequestAsync("HangUpDoubleCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HangUpDoubleCallResponse HangUpDoubleCall(HangUpDoubleCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HangUpDoubleCallWithOptions(request, runtime);
        }

        public async Task<HangUpDoubleCallResponse> HangUpDoubleCallAsync(HangUpDoubleCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HangUpDoubleCallWithOptionsAsync(request, runtime);
        }

        public UpdateAgentResponse UpdateAgentWithOptions(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAgentResponse>(DoRPCRequest("UpdateAgent", "2019-10-15", "HTTPS", "PUT", "AK", "json", req, runtime));
        }

        public async Task<UpdateAgentResponse> UpdateAgentWithOptionsAsync(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAgentResponse>(await DoRPCRequestAsync("UpdateAgent", "2019-10-15", "HTTPS", "PUT", "AK", "json", req, runtime));
        }

        public UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgentWithOptions(request, runtime);
        }

        public async Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgentWithOptionsAsync(request, runtime);
        }

        public EditQualityRuleTagResponse EditQualityRuleTagWithOptions(EditQualityRuleTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditQualityRuleTagResponse>(DoRPCRequest("EditQualityRuleTag", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditQualityRuleTagResponse> EditQualityRuleTagWithOptionsAsync(EditQualityRuleTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditQualityRuleTagResponse>(await DoRPCRequestAsync("EditQualityRuleTag", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditQualityRuleTagResponse EditQualityRuleTag(EditQualityRuleTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditQualityRuleTagWithOptions(request, runtime);
        }

        public async Task<EditQualityRuleTagResponse> EditQualityRuleTagAsync(EditQualityRuleTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditQualityRuleTagWithOptionsAsync(request, runtime);
        }

        public GetOnlineServiceVolumeResponse GetOnlineServiceVolumeWithOptions(GetOnlineServiceVolumeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOnlineServiceVolumeShrinkRequest request = new GetOnlineServiceVolumeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetOnlineServiceVolumeResponse>(DoRPCRequest("GetOnlineServiceVolume", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetOnlineServiceVolumeResponse> GetOnlineServiceVolumeWithOptionsAsync(GetOnlineServiceVolumeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOnlineServiceVolumeShrinkRequest request = new GetOnlineServiceVolumeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetOnlineServiceVolumeResponse>(await DoRPCRequestAsync("GetOnlineServiceVolume", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetOnlineServiceVolumeResponse GetOnlineServiceVolume(GetOnlineServiceVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOnlineServiceVolumeWithOptions(request, runtime);
        }

        public async Task<GetOnlineServiceVolumeResponse> GetOnlineServiceVolumeAsync(GetOnlineServiceVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOnlineServiceVolumeWithOptionsAsync(request, runtime);
        }

        public DeleteOutboundTaskResponse DeleteOutboundTaskWithOptions(DeleteOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOutboundTaskResponse>(DoRPCRequest("DeleteOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteOutboundTaskResponse> DeleteOutboundTaskWithOptionsAsync(DeleteOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOutboundTaskResponse>(await DoRPCRequestAsync("DeleteOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteOutboundTaskResponse DeleteOutboundTask(DeleteOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOutboundTaskWithOptions(request, runtime);
        }

        public async Task<DeleteOutboundTaskResponse> DeleteOutboundTaskAsync(DeleteOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOutboundTaskWithOptionsAsync(request, runtime);
        }

        public AddOuterAccountResponse AddOuterAccountWithOptions(AddOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddOuterAccountResponse>(DoRPCRequest("AddOuterAccount", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddOuterAccountResponse> AddOuterAccountWithOptionsAsync(AddOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddOuterAccountResponse>(await DoRPCRequestAsync("AddOuterAccount", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddOuterAccountResponse AddOuterAccount(AddOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddOuterAccountWithOptions(request, runtime);
        }

        public async Task<AddOuterAccountResponse> AddOuterAccountAsync(AddOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddOuterAccountWithOptionsAsync(request, runtime);
        }

        public GetAgentByIdResponse GetAgentByIdWithOptions(GetAgentByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentByIdResponse>(DoRPCRequest("GetAgentById", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAgentByIdResponse> GetAgentByIdWithOptionsAsync(GetAgentByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentByIdResponse>(await DoRPCRequestAsync("GetAgentById", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAgentByIdResponse GetAgentById(GetAgentByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentByIdWithOptions(request, runtime);
        }

        public async Task<GetAgentByIdResponse> GetAgentByIdAsync(GetAgentByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentByIdWithOptionsAsync(request, runtime);
        }

        public GetQualityRuleDetailResponse GetQualityRuleDetailWithOptions(GetQualityRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityRuleDetailResponse>(DoRPCRequest("GetQualityRuleDetail", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityRuleDetailResponse> GetQualityRuleDetailWithOptionsAsync(GetQualityRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityRuleDetailResponse>(await DoRPCRequestAsync("GetQualityRuleDetail", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityRuleDetailResponse GetQualityRuleDetail(GetQualityRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityRuleDetailWithOptions(request, runtime);
        }

        public async Task<GetQualityRuleDetailResponse> GetQualityRuleDetailAsync(GetQualityRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityRuleDetailWithOptionsAsync(request, runtime);
        }

        public GetQualityProjectLogResponse GetQualityProjectLogWithOptions(GetQualityProjectLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityProjectLogResponse>(DoRPCRequest("GetQualityProjectLog", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityProjectLogResponse> GetQualityProjectLogWithOptionsAsync(GetQualityProjectLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityProjectLogResponse>(await DoRPCRequestAsync("GetQualityProjectLog", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityProjectLogResponse GetQualityProjectLog(GetQualityProjectLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityProjectLogWithOptions(request, runtime);
        }

        public async Task<GetQualityProjectLogResponse> GetQualityProjectLogAsync(GetQualityProjectLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityProjectLogWithOptionsAsync(request, runtime);
        }

        public ListHotlineRecordDetailResponse ListHotlineRecordDetailWithOptions(ListHotlineRecordDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListHotlineRecordDetailResponse>(DoRPCRequest("ListHotlineRecordDetail", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListHotlineRecordDetailResponse> ListHotlineRecordDetailWithOptionsAsync(ListHotlineRecordDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListHotlineRecordDetailResponse>(await DoRPCRequestAsync("ListHotlineRecordDetail", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListHotlineRecordDetailResponse ListHotlineRecordDetail(ListHotlineRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotlineRecordDetailWithOptions(request, runtime);
        }

        public async Task<ListHotlineRecordDetailResponse> ListHotlineRecordDetailAsync(ListHotlineRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotlineRecordDetailWithOptionsAsync(request, runtime);
        }

        public GetHotlineMessageLogResponse GetHotlineMessageLogWithOptions(GetHotlineMessageLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineMessageLogResponse>(DoRPCRequest("GetHotlineMessageLog", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineMessageLogResponse> GetHotlineMessageLogWithOptionsAsync(GetHotlineMessageLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineMessageLogResponse>(await DoRPCRequestAsync("GetHotlineMessageLog", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetHotlineMessageLogResponse GetHotlineMessageLog(GetHotlineMessageLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineMessageLogWithOptions(request, runtime);
        }

        public async Task<GetHotlineMessageLogResponse> GetHotlineMessageLogAsync(GetHotlineMessageLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineMessageLogWithOptionsAsync(request, runtime);
        }

        public GetQualityProjectListResponse GetQualityProjectListWithOptions(GetQualityProjectListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityProjectListResponse>(DoRPCRequest("GetQualityProjectList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityProjectListResponse> GetQualityProjectListWithOptionsAsync(GetQualityProjectListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityProjectListResponse>(await DoRPCRequestAsync("GetQualityProjectList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityProjectListResponse GetQualityProjectList(GetQualityProjectListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityProjectListWithOptions(request, runtime);
        }

        public async Task<GetQualityProjectListResponse> GetQualityProjectListAsync(GetQualityProjectListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityProjectListWithOptionsAsync(request, runtime);
        }

        public CreateOutboundTaskResponse CreateOutboundTaskWithOptions(CreateOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOutboundTaskResponse>(DoRPCRequest("CreateOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOutboundTaskResponse> CreateOutboundTaskWithOptionsAsync(CreateOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOutboundTaskResponse>(await DoRPCRequestAsync("CreateOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOutboundTaskResponse CreateOutboundTask(CreateOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOutboundTaskWithOptions(request, runtime);
        }

        public async Task<CreateOutboundTaskResponse> CreateOutboundTaskAsync(CreateOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOutboundTaskWithOptionsAsync(request, runtime);
        }

        public GetHotlineRuntimeInfoResponse GetHotlineRuntimeInfoWithOptions(GetHotlineRuntimeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineRuntimeInfoResponse>(DoRPCRequest("GetHotlineRuntimeInfo", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineRuntimeInfoResponse> GetHotlineRuntimeInfoWithOptionsAsync(GetHotlineRuntimeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineRuntimeInfoResponse>(await DoRPCRequestAsync("GetHotlineRuntimeInfo", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetHotlineRuntimeInfoResponse GetHotlineRuntimeInfo(GetHotlineRuntimeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineRuntimeInfoWithOptions(request, runtime);
        }

        public async Task<GetHotlineRuntimeInfoResponse> GetHotlineRuntimeInfoAsync(GetHotlineRuntimeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineRuntimeInfoWithOptionsAsync(request, runtime);
        }

        public MakeDoubleCallResponse MakeDoubleCallWithOptions(MakeDoubleCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MakeDoubleCallResponse>(DoRPCRequest("MakeDoubleCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MakeDoubleCallResponse> MakeDoubleCallWithOptionsAsync(MakeDoubleCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MakeDoubleCallResponse>(await DoRPCRequestAsync("MakeDoubleCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MakeDoubleCallResponse MakeDoubleCall(MakeDoubleCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MakeDoubleCallWithOptions(request, runtime);
        }

        public async Task<MakeDoubleCallResponse> MakeDoubleCallAsync(MakeDoubleCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MakeDoubleCallWithOptionsAsync(request, runtime);
        }

        public GetSkillGroupAgentStatusDetailsResponse GetSkillGroupAgentStatusDetailsWithOptions(GetSkillGroupAgentStatusDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupAgentStatusDetailsShrinkRequest request = new GetSkillGroupAgentStatusDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupAgentStatusDetailsResponse>(DoRPCRequest("GetSkillGroupAgentStatusDetails", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSkillGroupAgentStatusDetailsResponse> GetSkillGroupAgentStatusDetailsWithOptionsAsync(GetSkillGroupAgentStatusDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupAgentStatusDetailsShrinkRequest request = new GetSkillGroupAgentStatusDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupAgentStatusDetailsResponse>(await DoRPCRequestAsync("GetSkillGroupAgentStatusDetails", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSkillGroupAgentStatusDetailsResponse GetSkillGroupAgentStatusDetails(GetSkillGroupAgentStatusDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupAgentStatusDetailsWithOptions(request, runtime);
        }

        public async Task<GetSkillGroupAgentStatusDetailsResponse> GetSkillGroupAgentStatusDetailsAsync(GetSkillGroupAgentStatusDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupAgentStatusDetailsWithOptionsAsync(request, runtime);
        }

        public GetAgentServiceStatusResponse GetAgentServiceStatusWithOptions(GetAgentServiceStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentServiceStatusShrinkRequest request = new GetAgentServiceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentServiceStatusResponse>(DoRPCRequest("GetAgentServiceStatus", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAgentServiceStatusResponse> GetAgentServiceStatusWithOptionsAsync(GetAgentServiceStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentServiceStatusShrinkRequest request = new GetAgentServiceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentServiceStatusResponse>(await DoRPCRequestAsync("GetAgentServiceStatus", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAgentServiceStatusResponse GetAgentServiceStatus(GetAgentServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentServiceStatusWithOptions(request, runtime);
        }

        public async Task<GetAgentServiceStatusResponse> GetAgentServiceStatusAsync(GetAgentServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentServiceStatusWithOptionsAsync(request, runtime);
        }

        public GetNumLocationResponse GetNumLocationWithOptions(GetNumLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetNumLocationResponse>(DoRPCRequest("GetNumLocation", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetNumLocationResponse> GetNumLocationWithOptionsAsync(GetNumLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetNumLocationResponse>(await DoRPCRequestAsync("GetNumLocation", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetNumLocationResponse GetNumLocation(GetNumLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNumLocationWithOptions(request, runtime);
        }

        public async Task<GetNumLocationResponse> GetNumLocationAsync(GetNumLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNumLocationWithOptionsAsync(request, runtime);
        }

        public GetQualityRuleListResponse GetQualityRuleListWithOptions(GetQualityRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityRuleListResponse>(DoRPCRequest("GetQualityRuleList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityRuleListResponse> GetQualityRuleListWithOptionsAsync(GetQualityRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityRuleListResponse>(await DoRPCRequestAsync("GetQualityRuleList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityRuleListResponse GetQualityRuleList(GetQualityRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityRuleListWithOptions(request, runtime);
        }

        public async Task<GetQualityRuleListResponse> GetQualityRuleListAsync(GetQualityRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityRuleListWithOptionsAsync(request, runtime);
        }

        public ListOutboundPhoneNumberResponse ListOutboundPhoneNumberWithOptions(ListOutboundPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListOutboundPhoneNumberResponse>(DoRPCRequest("ListOutboundPhoneNumber", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListOutboundPhoneNumberResponse> ListOutboundPhoneNumberWithOptionsAsync(ListOutboundPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListOutboundPhoneNumberResponse>(await DoRPCRequestAsync("ListOutboundPhoneNumber", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListOutboundPhoneNumberResponse ListOutboundPhoneNumber(ListOutboundPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundPhoneNumberWithOptions(request, runtime);
        }

        public async Task<ListOutboundPhoneNumberResponse> ListOutboundPhoneNumberAsync(ListOutboundPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundPhoneNumberWithOptionsAsync(request, runtime);
        }

        public ListAgentBySkillGroupIdResponse ListAgentBySkillGroupIdWithOptions(ListAgentBySkillGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAgentBySkillGroupIdResponse>(DoRPCRequest("ListAgentBySkillGroupId", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAgentBySkillGroupIdResponse> ListAgentBySkillGroupIdWithOptionsAsync(ListAgentBySkillGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAgentBySkillGroupIdResponse>(await DoRPCRequestAsync("ListAgentBySkillGroupId", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAgentBySkillGroupIdResponse ListAgentBySkillGroupId(ListAgentBySkillGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentBySkillGroupIdWithOptions(request, runtime);
        }

        public async Task<ListAgentBySkillGroupIdResponse> ListAgentBySkillGroupIdAsync(ListAgentBySkillGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentBySkillGroupIdWithOptionsAsync(request, runtime);
        }

        public HangupThirdCallResponse HangupThirdCallWithOptions(HangupThirdCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HangupThirdCallResponse>(DoRPCRequest("HangupThirdCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HangupThirdCallResponse> HangupThirdCallWithOptionsAsync(HangupThirdCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HangupThirdCallResponse>(await DoRPCRequestAsync("HangupThirdCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HangupThirdCallResponse HangupThirdCall(HangupThirdCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HangupThirdCallWithOptions(request, runtime);
        }

        public async Task<HangupThirdCallResponse> HangupThirdCallAsync(HangupThirdCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HangupThirdCallWithOptionsAsync(request, runtime);
        }

        public StartHotlineServiceResponse StartHotlineServiceWithOptions(StartHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartHotlineServiceResponse>(DoRPCRequest("StartHotlineService", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartHotlineServiceResponse> StartHotlineServiceWithOptionsAsync(StartHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartHotlineServiceResponse>(await DoRPCRequestAsync("StartHotlineService", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartHotlineServiceResponse StartHotlineService(StartHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartHotlineServiceWithOptions(request, runtime);
        }

        public async Task<StartHotlineServiceResponse> StartHotlineServiceAsync(StartHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartHotlineServiceWithOptionsAsync(request, runtime);
        }

        public GetAgentResponse GetAgentWithOptions(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentResponse>(DoRPCRequest("GetAgent", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAgentResponse> GetAgentWithOptionsAsync(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentResponse>(await DoRPCRequestAsync("GetAgent", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAgentResponse GetAgent(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentWithOptions(request, runtime);
        }

        public async Task<GetAgentResponse> GetAgentAsync(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentWithOptionsAsync(request, runtime);
        }

        public GetAgentIndexRealTimeResponse GetAgentIndexRealTimeWithOptions(GetAgentIndexRealTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentIndexRealTimeResponse>(DoRPCRequest("GetAgentIndexRealTime", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAgentIndexRealTimeResponse> GetAgentIndexRealTimeWithOptionsAsync(GetAgentIndexRealTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentIndexRealTimeResponse>(await DoRPCRequestAsync("GetAgentIndexRealTime", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAgentIndexRealTimeResponse GetAgentIndexRealTime(GetAgentIndexRealTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentIndexRealTimeWithOptions(request, runtime);
        }

        public async Task<GetAgentIndexRealTimeResponse> GetAgentIndexRealTimeAsync(GetAgentIndexRealTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentIndexRealTimeWithOptionsAsync(request, runtime);
        }

        public GetHotlineGroupDetailReportResponse GetHotlineGroupDetailReportWithOptions(GetHotlineGroupDetailReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotlineGroupDetailReportResponse>(DoRPCRequest("GetHotlineGroupDetailReport", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineGroupDetailReportResponse> GetHotlineGroupDetailReportWithOptionsAsync(GetHotlineGroupDetailReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotlineGroupDetailReportResponse>(await DoRPCRequestAsync("GetHotlineGroupDetailReport", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHotlineGroupDetailReportResponse GetHotlineGroupDetailReport(GetHotlineGroupDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineGroupDetailReportWithOptions(request, runtime);
        }

        public async Task<GetHotlineGroupDetailReportResponse> GetHotlineGroupDetailReportAsync(GetHotlineGroupDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineGroupDetailReportWithOptionsAsync(request, runtime);
        }

        public EncryptPhoneNumResponse EncryptPhoneNumWithOptions(EncryptPhoneNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EncryptPhoneNumResponse>(DoRPCRequest("EncryptPhoneNum", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<EncryptPhoneNumResponse> EncryptPhoneNumWithOptionsAsync(EncryptPhoneNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EncryptPhoneNumResponse>(await DoRPCRequestAsync("EncryptPhoneNum", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public EncryptPhoneNumResponse EncryptPhoneNum(EncryptPhoneNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncryptPhoneNumWithOptions(request, runtime);
        }

        public async Task<EncryptPhoneNumResponse> EncryptPhoneNumAsync(EncryptPhoneNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncryptPhoneNumWithOptionsAsync(request, runtime);
        }

        public GetInstanceListResponse GetInstanceListWithOptions(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceListResponse>(DoRPCRequest("GetInstanceList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceListResponse> GetInstanceListWithOptionsAsync(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceListResponse>(await DoRPCRequestAsync("GetInstanceList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceListResponse GetInstanceList(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceListWithOptions(request, runtime);
        }

        public async Task<GetInstanceListResponse> GetInstanceListAsync(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceListWithOptionsAsync(request, runtime);
        }

        public GetQualityProjectDetailResponse GetQualityProjectDetailWithOptions(GetQualityProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityProjectDetailResponse>(DoRPCRequest("GetQualityProjectDetail", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityProjectDetailResponse> GetQualityProjectDetailWithOptionsAsync(GetQualityProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityProjectDetailResponse>(await DoRPCRequestAsync("GetQualityProjectDetail", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityProjectDetailResponse GetQualityProjectDetail(GetQualityProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityProjectDetailWithOptions(request, runtime);
        }

        public async Task<GetQualityProjectDetailResponse> GetQualityProjectDetailAsync(GetQualityProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityProjectDetailWithOptionsAsync(request, runtime);
        }

        public SendCcoSmartCallOperateResponse SendCcoSmartCallOperateWithOptions(SendCcoSmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCcoSmartCallOperateResponse>(DoRPCRequest("SendCcoSmartCallOperate", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendCcoSmartCallOperateResponse> SendCcoSmartCallOperateWithOptionsAsync(SendCcoSmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCcoSmartCallOperateResponse>(await DoRPCRequestAsync("SendCcoSmartCallOperate", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendCcoSmartCallOperateResponse SendCcoSmartCallOperate(SendCcoSmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCcoSmartCallOperateWithOptions(request, runtime);
        }

        public async Task<SendCcoSmartCallOperateResponse> SendCcoSmartCallOperateAsync(SendCcoSmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCcoSmartCallOperateWithOptionsAsync(request, runtime);
        }

        public AnswerCallResponse AnswerCallWithOptions(AnswerCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AnswerCallResponse>(DoRPCRequest("AnswerCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AnswerCallResponse> AnswerCallWithOptionsAsync(AnswerCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AnswerCallResponse>(await DoRPCRequestAsync("AnswerCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AnswerCallResponse AnswerCall(AnswerCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AnswerCallWithOptions(request, runtime);
        }

        public async Task<AnswerCallResponse> AnswerCallAsync(AnswerCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AnswerCallWithOptionsAsync(request, runtime);
        }

        public StartMicroOutboundResponse StartMicroOutboundWithOptions(StartMicroOutboundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMicroOutboundResponse>(DoRPCRequest("StartMicroOutbound", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartMicroOutboundResponse> StartMicroOutboundWithOptionsAsync(StartMicroOutboundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMicroOutboundResponse>(await DoRPCRequestAsync("StartMicroOutbound", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartMicroOutboundResponse StartMicroOutbound(StartMicroOutboundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMicroOutboundWithOptions(request, runtime);
        }

        public async Task<StartMicroOutboundResponse> StartMicroOutboundAsync(StartMicroOutboundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMicroOutboundWithOptionsAsync(request, runtime);
        }

        public SuspendHotlineServiceResponse SuspendHotlineServiceWithOptions(SuspendHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendHotlineServiceResponse>(DoRPCRequest("SuspendHotlineService", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendHotlineServiceResponse> SuspendHotlineServiceWithOptionsAsync(SuspendHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendHotlineServiceResponse>(await DoRPCRequestAsync("SuspendHotlineService", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendHotlineServiceResponse SuspendHotlineService(SuspendHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendHotlineServiceWithOptions(request, runtime);
        }

        public async Task<SuspendHotlineServiceResponse> SuspendHotlineServiceAsync(SuspendHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendHotlineServiceWithOptionsAsync(request, runtime);
        }

        public GetAgentStatisticsResponse GetAgentStatisticsWithOptions(GetAgentStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentStatisticsShrinkRequest request = new GetAgentStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentStatisticsResponse>(DoRPCRequest("GetAgentStatistics", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAgentStatisticsResponse> GetAgentStatisticsWithOptionsAsync(GetAgentStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentStatisticsShrinkRequest request = new GetAgentStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentStatisticsResponse>(await DoRPCRequestAsync("GetAgentStatistics", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAgentStatisticsResponse GetAgentStatistics(GetAgentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentStatisticsWithOptions(request, runtime);
        }

        public async Task<GetAgentStatisticsResponse> GetAgentStatisticsAsync(GetAgentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentStatisticsWithOptionsAsync(request, runtime);
        }

        public UpdateOuterAccountResponse UpdateOuterAccountWithOptions(UpdateOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpdateOuterAccountResponse>(DoRPCRequest("UpdateOuterAccount", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<UpdateOuterAccountResponse> UpdateOuterAccountWithOptionsAsync(UpdateOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpdateOuterAccountResponse>(await DoRPCRequestAsync("UpdateOuterAccount", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public UpdateOuterAccountResponse UpdateOuterAccount(UpdateOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOuterAccountWithOptions(request, runtime);
        }

        public async Task<UpdateOuterAccountResponse> UpdateOuterAccountAsync(UpdateOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOuterAccountWithOptionsAsync(request, runtime);
        }

        public GetHotlineWaitingNumberResponse GetHotlineWaitingNumberWithOptions(GetHotlineWaitingNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineWaitingNumberResponse>(DoRPCRequest("GetHotlineWaitingNumber", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineWaitingNumberResponse> GetHotlineWaitingNumberWithOptionsAsync(GetHotlineWaitingNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineWaitingNumberResponse>(await DoRPCRequestAsync("GetHotlineWaitingNumber", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetHotlineWaitingNumberResponse GetHotlineWaitingNumber(GetHotlineWaitingNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineWaitingNumberWithOptions(request, runtime);
        }

        public async Task<GetHotlineWaitingNumberResponse> GetHotlineWaitingNumberAsync(GetHotlineWaitingNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineWaitingNumberWithOptionsAsync(request, runtime);
        }

        public HoldCallResponse HoldCallWithOptions(HoldCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HoldCallResponse>(DoRPCRequest("HoldCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HoldCallResponse> HoldCallWithOptionsAsync(HoldCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HoldCallResponse>(await DoRPCRequestAsync("HoldCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HoldCallResponse HoldCall(HoldCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HoldCallWithOptions(request, runtime);
        }

        public async Task<HoldCallResponse> HoldCallAsync(HoldCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HoldCallWithOptionsAsync(request, runtime);
        }

        public GetSeatInformationResponse GetSeatInformationWithOptions(GetSeatInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSeatInformationShrinkRequest request = new GetSeatInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "depIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSeatInformationResponse>(DoRPCRequest("GetSeatInformation", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSeatInformationResponse> GetSeatInformationWithOptionsAsync(GetSeatInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSeatInformationShrinkRequest request = new GetSeatInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "depIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSeatInformationResponse>(await DoRPCRequestAsync("GetSeatInformation", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSeatInformationResponse GetSeatInformation(GetSeatInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSeatInformationWithOptions(request, runtime);
        }

        public async Task<GetSeatInformationResponse> GetSeatInformationAsync(GetSeatInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSeatInformationWithOptionsAsync(request, runtime);
        }

        public GetRtcTokenResponse GetRtcTokenWithOptions(GetRtcTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetRtcTokenResponse>(DoRPCRequest("GetRtcToken", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetRtcTokenResponse> GetRtcTokenWithOptionsAsync(GetRtcTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetRtcTokenResponse>(await DoRPCRequestAsync("GetRtcToken", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetRtcTokenResponse GetRtcToken(GetRtcTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRtcTokenWithOptions(request, runtime);
        }

        public async Task<GetRtcTokenResponse> GetRtcTokenAsync(GetRtcTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRtcTokenWithOptionsAsync(request, runtime);
        }

        public GetSkillGroupAndAgentStatusSummaryResponse GetSkillGroupAndAgentStatusSummaryWithOptions(GetSkillGroupAndAgentStatusSummaryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupAndAgentStatusSummaryShrinkRequest request = new GetSkillGroupAndAgentStatusSummaryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupAndAgentStatusSummaryResponse>(DoRPCRequest("GetSkillGroupAndAgentStatusSummary", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSkillGroupAndAgentStatusSummaryResponse> GetSkillGroupAndAgentStatusSummaryWithOptionsAsync(GetSkillGroupAndAgentStatusSummaryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupAndAgentStatusSummaryShrinkRequest request = new GetSkillGroupAndAgentStatusSummaryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupAndAgentStatusSummaryResponse>(await DoRPCRequestAsync("GetSkillGroupAndAgentStatusSummary", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSkillGroupAndAgentStatusSummaryResponse GetSkillGroupAndAgentStatusSummary(GetSkillGroupAndAgentStatusSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupAndAgentStatusSummaryWithOptions(request, runtime);
        }

        public async Task<GetSkillGroupAndAgentStatusSummaryResponse> GetSkillGroupAndAgentStatusSummaryAsync(GetSkillGroupAndAgentStatusSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupAndAgentStatusSummaryWithOptionsAsync(request, runtime);
        }

        public GetRecordDataResponse GetRecordDataWithOptions(GetRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRecordDataResponse>(DoRPCRequest("GetRecordData", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRecordDataResponse> GetRecordDataWithOptionsAsync(GetRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRecordDataResponse>(await DoRPCRequestAsync("GetRecordData", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRecordDataResponse GetRecordData(GetRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRecordDataWithOptions(request, runtime);
        }

        public async Task<GetRecordDataResponse> GetRecordDataAsync(GetRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRecordDataWithOptionsAsync(request, runtime);
        }

        public GetSkillGroupLatitudeStateResponse GetSkillGroupLatitudeStateWithOptions(GetSkillGroupLatitudeStateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupLatitudeStateShrinkRequest request = new GetSkillGroupLatitudeStateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupLatitudeStateResponse>(DoRPCRequest("GetSkillGroupLatitudeState", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSkillGroupLatitudeStateResponse> GetSkillGroupLatitudeStateWithOptionsAsync(GetSkillGroupLatitudeStateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupLatitudeStateShrinkRequest request = new GetSkillGroupLatitudeStateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupLatitudeStateResponse>(await DoRPCRequestAsync("GetSkillGroupLatitudeState", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSkillGroupLatitudeStateResponse GetSkillGroupLatitudeState(GetSkillGroupLatitudeStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupLatitudeStateWithOptions(request, runtime);
        }

        public async Task<GetSkillGroupLatitudeStateResponse> GetSkillGroupLatitudeStateAsync(GetSkillGroupLatitudeStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupLatitudeStateWithOptionsAsync(request, runtime);
        }

        public DeleteQualityRuleResponse DeleteQualityRuleWithOptions(DeleteQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityRuleResponse>(DoRPCRequest("DeleteQualityRule", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQualityRuleResponse> DeleteQualityRuleWithOptionsAsync(DeleteQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityRuleResponse>(await DoRPCRequestAsync("DeleteQualityRule", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQualityRuleResponse DeleteQualityRule(DeleteQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityRuleWithOptions(request, runtime);
        }

        public async Task<DeleteQualityRuleResponse> DeleteQualityRuleAsync(DeleteQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityRuleWithOptionsAsync(request, runtime);
        }

        public SuspendOutboundTaskResponse SuspendOutboundTaskWithOptions(SuspendOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendOutboundTaskResponse>(DoRPCRequest("SuspendOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendOutboundTaskResponse> SuspendOutboundTaskWithOptionsAsync(SuspendOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendOutboundTaskResponse>(await DoRPCRequestAsync("SuspendOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendOutboundTaskResponse SuspendOutboundTask(SuspendOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendOutboundTaskWithOptions(request, runtime);
        }

        public async Task<SuspendOutboundTaskResponse> SuspendOutboundTaskAsync(SuspendOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendOutboundTaskWithOptionsAsync(request, runtime);
        }

        public GetHotlineServiceStatisticsResponse GetHotlineServiceStatisticsWithOptions(GetHotlineServiceStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotlineServiceStatisticsShrinkRequest request = new GetHotlineServiceStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineServiceStatisticsResponse>(DoRPCRequest("GetHotlineServiceStatistics", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineServiceStatisticsResponse> GetHotlineServiceStatisticsWithOptionsAsync(GetHotlineServiceStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotlineServiceStatisticsShrinkRequest request = new GetHotlineServiceStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineServiceStatisticsResponse>(await DoRPCRequestAsync("GetHotlineServiceStatistics", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetHotlineServiceStatisticsResponse GetHotlineServiceStatistics(GetHotlineServiceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineServiceStatisticsWithOptions(request, runtime);
        }

        public async Task<GetHotlineServiceStatisticsResponse> GetHotlineServiceStatisticsAsync(GetHotlineServiceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineServiceStatisticsWithOptionsAsync(request, runtime);
        }

        public EditQualityProjectResponse EditQualityProjectWithOptions(EditQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditQualityProjectResponse>(DoRPCRequest("EditQualityProject", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditQualityProjectResponse> EditQualityProjectWithOptionsAsync(EditQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditQualityProjectResponse>(await DoRPCRequestAsync("EditQualityProject", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditQualityProjectResponse EditQualityProject(EditQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditQualityProjectWithOptions(request, runtime);
        }

        public async Task<EditQualityProjectResponse> EditQualityProjectAsync(EditQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditQualityProjectWithOptionsAsync(request, runtime);
        }

        public ListOuterOrderedNumbersResponse ListOuterOrderedNumbersWithOptions(ListOuterOrderedNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOuterOrderedNumbersResponse>(DoRPCRequest("ListOuterOrderedNumbers", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOuterOrderedNumbersResponse> ListOuterOrderedNumbersWithOptionsAsync(ListOuterOrderedNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOuterOrderedNumbersResponse>(await DoRPCRequestAsync("ListOuterOrderedNumbers", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOuterOrderedNumbersResponse ListOuterOrderedNumbers(ListOuterOrderedNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOuterOrderedNumbersWithOptions(request, runtime);
        }

        public async Task<ListOuterOrderedNumbersResponse> ListOuterOrderedNumbersAsync(ListOuterOrderedNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOuterOrderedNumbersWithOptionsAsync(request, runtime);
        }

        public GetAgentBasisStatusResponse GetAgentBasisStatusWithOptions(GetAgentBasisStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentBasisStatusShrinkRequest request = new GetAgentBasisStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentBasisStatusResponse>(DoRPCRequest("GetAgentBasisStatus", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAgentBasisStatusResponse> GetAgentBasisStatusWithOptionsAsync(GetAgentBasisStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentBasisStatusShrinkRequest request = new GetAgentBasisStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentBasisStatusResponse>(await DoRPCRequestAsync("GetAgentBasisStatus", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAgentBasisStatusResponse GetAgentBasisStatus(GetAgentBasisStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentBasisStatusWithOptions(request, runtime);
        }

        public async Task<GetAgentBasisStatusResponse> GetAgentBasisStatusAsync(GetAgentBasisStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentBasisStatusWithOptionsAsync(request, runtime);
        }

        public GetQualityResultResponse GetQualityResultWithOptions(GetQualityResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityResultResponse>(DoRPCRequest("GetQualityResult", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityResultResponse> GetQualityResultWithOptionsAsync(GetQualityResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityResultResponse>(await DoRPCRequestAsync("GetQualityResult", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityResultResponse GetQualityResult(GetQualityResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityResultWithOptions(request, runtime);
        }

        public async Task<GetQualityResultResponse> GetQualityResultAsync(GetQualityResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityResultWithOptionsAsync(request, runtime);
        }

        public GetIndexCurrentValueResponse GetIndexCurrentValueWithOptions(GetIndexCurrentValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIndexCurrentValueResponse>(DoRPCRequest("GetIndexCurrentValue", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetIndexCurrentValueResponse> GetIndexCurrentValueWithOptionsAsync(GetIndexCurrentValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIndexCurrentValueResponse>(await DoRPCRequestAsync("GetIndexCurrentValue", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetIndexCurrentValueResponse GetIndexCurrentValue(GetIndexCurrentValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIndexCurrentValueWithOptions(request, runtime);
        }

        public async Task<GetIndexCurrentValueResponse> GetIndexCurrentValueAsync(GetIndexCurrentValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIndexCurrentValueWithOptionsAsync(request, runtime);
        }

        public GenerateWebSocketSignResponse GenerateWebSocketSignWithOptions(GenerateWebSocketSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateWebSocketSignResponse>(DoRPCRequest("GenerateWebSocketSign", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateWebSocketSignResponse> GenerateWebSocketSignWithOptionsAsync(GenerateWebSocketSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateWebSocketSignResponse>(await DoRPCRequestAsync("GenerateWebSocketSign", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateWebSocketSignResponse GenerateWebSocketSign(GenerateWebSocketSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateWebSocketSignWithOptions(request, runtime);
        }

        public async Task<GenerateWebSocketSignResponse> GenerateWebSocketSignAsync(GenerateWebSocketSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateWebSocketSignWithOptionsAsync(request, runtime);
        }

        public CreateAgentResponse CreateAgentWithOptions(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAgentResponse>(DoRPCRequest("CreateAgent", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAgentResponse> CreateAgentWithOptionsAsync(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAgentResponse>(await DoRPCRequestAsync("CreateAgent", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentWithOptions(request, runtime);
        }

        public async Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentWithOptionsAsync(request, runtime);
        }

        public QueryTaskDetailResponse QueryTaskDetailWithOptions(QueryTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskDetailResponse>(DoRPCRequest("QueryTaskDetail", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTaskDetailResponse> QueryTaskDetailWithOptionsAsync(QueryTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskDetailResponse>(await DoRPCRequestAsync("QueryTaskDetail", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTaskDetailResponse QueryTaskDetail(QueryTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskDetailWithOptions(request, runtime);
        }

        public async Task<QueryTaskDetailResponse> QueryTaskDetailAsync(QueryTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskDetailWithOptionsAsync(request, runtime);
        }

        public EditQualityRuleResponse EditQualityRuleWithOptions(EditQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditQualityRuleResponse>(DoRPCRequest("EditQualityRule", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditQualityRuleResponse> EditQualityRuleWithOptionsAsync(EditQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditQualityRuleResponse>(await DoRPCRequestAsync("EditQualityRule", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditQualityRuleResponse EditQualityRule(EditQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditQualityRuleWithOptions(request, runtime);
        }

        public async Task<EditQualityRuleResponse> EditQualityRuleAsync(EditQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditQualityRuleWithOptionsAsync(request, runtime);
        }

        public GetMcuLvsIpResponse GetMcuLvsIpWithOptions(GetMcuLvsIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMcuLvsIpResponse>(DoRPCRequest("GetMcuLvsIp", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMcuLvsIpResponse> GetMcuLvsIpWithOptionsAsync(GetMcuLvsIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMcuLvsIpResponse>(await DoRPCRequestAsync("GetMcuLvsIp", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMcuLvsIpResponse GetMcuLvsIp(GetMcuLvsIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcuLvsIpWithOptions(request, runtime);
        }

        public async Task<GetMcuLvsIpResponse> GetMcuLvsIpAsync(GetMcuLvsIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcuLvsIpWithOptionsAsync(request, runtime);
        }

        public GetDepGroupTreeDataResponse GetDepGroupTreeDataWithOptions(GetDepGroupTreeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDepGroupTreeDataResponse>(DoRPCRequest("GetDepGroupTreeData", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDepGroupTreeDataResponse> GetDepGroupTreeDataWithOptionsAsync(GetDepGroupTreeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDepGroupTreeDataResponse>(await DoRPCRequestAsync("GetDepGroupTreeData", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDepGroupTreeDataResponse GetDepGroupTreeData(GetDepGroupTreeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDepGroupTreeDataWithOptions(request, runtime);
        }

        public async Task<GetDepGroupTreeDataResponse> GetDepGroupTreeDataAsync(GetDepGroupTreeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDepGroupTreeDataWithOptionsAsync(request, runtime);
        }

        public DeleteAgentResponse DeleteAgentWithOptions(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAgentResponse>(DoRPCRequest("DeleteAgent", "2019-10-15", "HTTPS", "DELETE", "AK", "json", req, runtime));
        }

        public async Task<DeleteAgentResponse> DeleteAgentWithOptionsAsync(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAgentResponse>(await DoRPCRequestAsync("DeleteAgent", "2019-10-15", "HTTPS", "DELETE", "AK", "json", req, runtime));
        }

        public DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAgentWithOptions(request, runtime);
        }

        public async Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAgentWithOptionsAsync(request, runtime);
        }

        public GetCustomerInfoResponse GetCustomerInfoWithOptions(GetCustomerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCustomerInfoResponse>(DoRPCRequest("GetCustomerInfo", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetCustomerInfoResponse> GetCustomerInfoWithOptionsAsync(GetCustomerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCustomerInfoResponse>(await DoRPCRequestAsync("GetCustomerInfo", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetCustomerInfoResponse GetCustomerInfo(GetCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerInfoWithOptions(request, runtime);
        }

        public async Task<GetCustomerInfoResponse> GetCustomerInfoAsync(GetCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerInfoWithOptionsAsync(request, runtime);
        }

        public GetHotlineAgentDetailReportResponse GetHotlineAgentDetailReportWithOptions(GetHotlineAgentDetailReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotlineAgentDetailReportResponse>(DoRPCRequest("GetHotlineAgentDetailReport", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineAgentDetailReportResponse> GetHotlineAgentDetailReportWithOptionsAsync(GetHotlineAgentDetailReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotlineAgentDetailReportResponse>(await DoRPCRequestAsync("GetHotlineAgentDetailReport", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHotlineAgentDetailReportResponse GetHotlineAgentDetailReport(GetHotlineAgentDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineAgentDetailReportWithOptions(request, runtime);
        }

        public async Task<GetHotlineAgentDetailReportResponse> GetHotlineAgentDetailReportAsync(GetHotlineAgentDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineAgentDetailReportWithOptionsAsync(request, runtime);
        }

        public SendCcoSmartCallResponse SendCcoSmartCallWithOptions(SendCcoSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCcoSmartCallResponse>(DoRPCRequest("SendCcoSmartCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendCcoSmartCallResponse> SendCcoSmartCallWithOptionsAsync(SendCcoSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCcoSmartCallResponse>(await DoRPCRequestAsync("SendCcoSmartCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendCcoSmartCallResponse SendCcoSmartCall(SendCcoSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCcoSmartCallWithOptions(request, runtime);
        }

        public async Task<SendCcoSmartCallResponse> SendCcoSmartCallAsync(SendCcoSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCcoSmartCallWithOptionsAsync(request, runtime);
        }

        public ListChatRecordDetailResponse ListChatRecordDetailWithOptions(ListChatRecordDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListChatRecordDetailResponse>(DoRPCRequest("ListChatRecordDetail", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListChatRecordDetailResponse> ListChatRecordDetailWithOptionsAsync(ListChatRecordDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListChatRecordDetailResponse>(await DoRPCRequestAsync("ListChatRecordDetail", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListChatRecordDetailResponse ListChatRecordDetail(ListChatRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatRecordDetailWithOptions(request, runtime);
        }

        public async Task<ListChatRecordDetailResponse> ListChatRecordDetailAsync(ListChatRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatRecordDetailWithOptionsAsync(request, runtime);
        }

        public AddSkillGroupResponse AddSkillGroupWithOptions(AddSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddSkillGroupResponse>(DoRPCRequest("AddSkillGroup", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddSkillGroupResponse> AddSkillGroupWithOptionsAsync(AddSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddSkillGroupResponse>(await DoRPCRequestAsync("AddSkillGroup", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddSkillGroupResponse AddSkillGroup(AddSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSkillGroupWithOptions(request, runtime);
        }

        public async Task<AddSkillGroupResponse> AddSkillGroupAsync(AddSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSkillGroupWithOptionsAsync(request, runtime);
        }

        public HangupCallResponse HangupCallWithOptions(HangupCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HangupCallResponse>(DoRPCRequest("HangupCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HangupCallResponse> HangupCallWithOptionsAsync(HangupCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HangupCallResponse>(await DoRPCRequestAsync("HangupCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HangupCallResponse HangupCall(HangupCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HangupCallWithOptions(request, runtime);
        }

        public async Task<HangupCallResponse> HangupCallAsync(HangupCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HangupCallWithOptionsAsync(request, runtime);
        }

        public DeleteSkillGroupResponse DeleteSkillGroupWithOptions(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(DoRPCRequest("DeleteSkillGroup", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteSkillGroupResponse> DeleteSkillGroupWithOptionsAsync(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(await DoRPCRequestAsync("DeleteSkillGroup", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteSkillGroupResponse DeleteSkillGroup(DeleteSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSkillGroupWithOptions(request, runtime);
        }

        public async Task<DeleteSkillGroupResponse> DeleteSkillGroupAsync(DeleteSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSkillGroupWithOptionsAsync(request, runtime);
        }

        public CreateQualityProjectResponse CreateQualityProjectWithOptions(CreateQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityProjectResponse>(DoRPCRequest("CreateQualityProject", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQualityProjectResponse> CreateQualityProjectWithOptionsAsync(CreateQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityProjectResponse>(await DoRPCRequestAsync("CreateQualityProject", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQualityProjectResponse CreateQualityProject(CreateQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityProjectWithOptions(request, runtime);
        }

        public async Task<CreateQualityProjectResponse> CreateQualityProjectAsync(CreateQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityProjectWithOptionsAsync(request, runtime);
        }

        public QuerySkillGroupsResponse QuerySkillGroupsWithOptions(QuerySkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySkillGroupsResponse>(DoRPCRequest("QuerySkillGroups", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySkillGroupsResponse> QuerySkillGroupsWithOptionsAsync(QuerySkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySkillGroupsResponse>(await DoRPCRequestAsync("QuerySkillGroups", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySkillGroupsResponse QuerySkillGroups(QuerySkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySkillGroupsWithOptions(request, runtime);
        }

        public async Task<QuerySkillGroupsResponse> QuerySkillGroupsAsync(QuerySkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySkillGroupsWithOptionsAsync(request, runtime);
        }

        public CreateQualityRuleResponse CreateQualityRuleWithOptions(CreateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityRuleResponse>(DoRPCRequest("CreateQualityRule", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQualityRuleResponse> CreateQualityRuleWithOptionsAsync(CreateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityRuleResponse>(await DoRPCRequestAsync("CreateQualityRule", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQualityRuleResponse CreateQualityRule(CreateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityRuleWithOptions(request, runtime);
        }

        public async Task<CreateQualityRuleResponse> CreateQualityRuleAsync(CreateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityRuleWithOptionsAsync(request, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListRolesResponse>(DoRPCRequest("ListRoles", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListRolesResponse>(await DoRPCRequestAsync("ListRoles", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRolesWithOptions(request, runtime);
        }

        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRolesWithOptionsAsync(request, runtime);
        }

        public GetHotlineCallActionResponse GetHotlineCallActionWithOptions(GetHotlineCallActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotlineCallActionResponse>(DoRPCRequest("GetHotlineCallAction", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineCallActionResponse> GetHotlineCallActionWithOptionsAsync(GetHotlineCallActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotlineCallActionResponse>(await DoRPCRequestAsync("GetHotlineCallAction", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHotlineCallActionResponse GetHotlineCallAction(GetHotlineCallActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineCallActionWithOptions(request, runtime);
        }

        public async Task<GetHotlineCallActionResponse> GetHotlineCallActionAsync(GetHotlineCallActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineCallActionWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupResponse ListSkillGroupWithOptions(ListSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSkillGroupResponse>(DoRPCRequest("ListSkillGroup", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListSkillGroupResponse> ListSkillGroupWithOptionsAsync(ListSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSkillGroupResponse>(await DoRPCRequestAsync("ListSkillGroup", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListSkillGroupResponse ListSkillGroup(ListSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupWithOptions(request, runtime);
        }

        public async Task<ListSkillGroupResponse> ListSkillGroupAsync(ListSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupWithOptionsAsync(request, runtime);
        }

        public GetOnlineSeatInformationResponse GetOnlineSeatInformationWithOptions(GetOnlineSeatInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOnlineSeatInformationShrinkRequest request = new GetOnlineSeatInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetOnlineSeatInformationResponse>(DoRPCRequest("GetOnlineSeatInformation", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetOnlineSeatInformationResponse> GetOnlineSeatInformationWithOptionsAsync(GetOnlineSeatInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOnlineSeatInformationShrinkRequest request = new GetOnlineSeatInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetOnlineSeatInformationResponse>(await DoRPCRequestAsync("GetOnlineSeatInformation", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetOnlineSeatInformationResponse GetOnlineSeatInformation(GetOnlineSeatInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOnlineSeatInformationWithOptions(request, runtime);
        }

        public async Task<GetOnlineSeatInformationResponse> GetOnlineSeatInformationAsync(GetOnlineSeatInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOnlineSeatInformationWithOptionsAsync(request, runtime);
        }

        public DeleteQualityProjectResponse DeleteQualityProjectWithOptions(DeleteQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityProjectResponse>(DoRPCRequest("DeleteQualityProject", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQualityProjectResponse> DeleteQualityProjectWithOptionsAsync(DeleteQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityProjectResponse>(await DoRPCRequestAsync("DeleteQualityProject", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQualityProjectResponse DeleteQualityProject(DeleteQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityProjectWithOptions(request, runtime);
        }

        public async Task<DeleteQualityProjectResponse> DeleteQualityProjectAsync(DeleteQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityProjectWithOptionsAsync(request, runtime);
        }

        public QueryTouchListResponse QueryTouchListWithOptions(QueryTouchListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTouchListResponse>(DoRPCRequest("QueryTouchList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTouchListResponse> QueryTouchListWithOptionsAsync(QueryTouchListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTouchListResponse>(await DoRPCRequestAsync("QueryTouchList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTouchListResponse QueryTouchList(QueryTouchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTouchListWithOptions(request, runtime);
        }

        public async Task<QueryTouchListResponse> QueryTouchListAsync(QueryTouchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTouchListWithOptionsAsync(request, runtime);
        }

        public QueryHotlineInQueueResponse QueryHotlineInQueueWithOptions(QueryHotlineInQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryHotlineInQueueResponse>(DoRPCRequest("QueryHotlineInQueue", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryHotlineInQueueResponse> QueryHotlineInQueueWithOptionsAsync(QueryHotlineInQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryHotlineInQueueResponse>(await DoRPCRequestAsync("QueryHotlineInQueue", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryHotlineInQueueResponse QueryHotlineInQueue(QueryHotlineInQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHotlineInQueueWithOptions(request, runtime);
        }

        public async Task<QueryHotlineInQueueResponse> QueryHotlineInQueueAsync(QueryHotlineInQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHotlineInQueueWithOptionsAsync(request, runtime);
        }

        public FinishHotlineServiceResponse FinishHotlineServiceWithOptions(FinishHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FinishHotlineServiceResponse>(DoRPCRequest("FinishHotlineService", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FinishHotlineServiceResponse> FinishHotlineServiceWithOptionsAsync(FinishHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FinishHotlineServiceResponse>(await DoRPCRequestAsync("FinishHotlineService", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FinishHotlineServiceResponse FinishHotlineService(FinishHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FinishHotlineServiceWithOptions(request, runtime);
        }

        public async Task<FinishHotlineServiceResponse> FinishHotlineServiceAsync(FinishHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FinishHotlineServiceWithOptionsAsync(request, runtime);
        }

        public ListOutboundStrategiesResponse ListOutboundStrategiesWithOptions(ListOutboundStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOutboundStrategiesResponse>(DoRPCRequest("ListOutboundStrategies", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOutboundStrategiesResponse> ListOutboundStrategiesWithOptionsAsync(ListOutboundStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOutboundStrategiesResponse>(await DoRPCRequestAsync("ListOutboundStrategies", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOutboundStrategiesResponse ListOutboundStrategies(ListOutboundStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundStrategiesWithOptions(request, runtime);
        }

        public async Task<ListOutboundStrategiesResponse> ListOutboundStrategiesAsync(ListOutboundStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundStrategiesWithOptionsAsync(request, runtime);
        }

        public ListHotlineRecordResponse ListHotlineRecordWithOptions(ListHotlineRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListHotlineRecordResponse>(DoRPCRequest("ListHotlineRecord", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListHotlineRecordResponse> ListHotlineRecordWithOptionsAsync(ListHotlineRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListHotlineRecordResponse>(await DoRPCRequestAsync("ListHotlineRecord", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListHotlineRecordResponse ListHotlineRecord(ListHotlineRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotlineRecordWithOptions(request, runtime);
        }

        public async Task<ListHotlineRecordResponse> ListHotlineRecordAsync(ListHotlineRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotlineRecordWithOptionsAsync(request, runtime);
        }

        public ChangeQualityProjectStatusResponse ChangeQualityProjectStatusWithOptions(ChangeQualityProjectStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeQualityProjectStatusResponse>(DoRPCRequest("ChangeQualityProjectStatus", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeQualityProjectStatusResponse> ChangeQualityProjectStatusWithOptionsAsync(ChangeQualityProjectStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeQualityProjectStatusResponse>(await DoRPCRequestAsync("ChangeQualityProjectStatus", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeQualityProjectStatusResponse ChangeQualityProjectStatus(ChangeQualityProjectStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeQualityProjectStatusWithOptions(request, runtime);
        }

        public async Task<ChangeQualityProjectStatusResponse> ChangeQualityProjectStatusAsync(ChangeQualityProjectStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeQualityProjectStatusWithOptionsAsync(request, runtime);
        }

        public TransferCallToSkillGroupResponse TransferCallToSkillGroupWithOptions(TransferCallToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferCallToSkillGroupResponse>(DoRPCRequest("TransferCallToSkillGroup", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferCallToSkillGroupResponse> TransferCallToSkillGroupWithOptionsAsync(TransferCallToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferCallToSkillGroupResponse>(await DoRPCRequestAsync("TransferCallToSkillGroup", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TransferCallToSkillGroupResponse TransferCallToSkillGroup(TransferCallToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferCallToSkillGroupWithOptions(request, runtime);
        }

        public async Task<TransferCallToSkillGroupResponse> TransferCallToSkillGroupAsync(TransferCallToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferCallToSkillGroupWithOptionsAsync(request, runtime);
        }

        public GetSkillGroupServiceCapabilityResponse GetSkillGroupServiceCapabilityWithOptions(GetSkillGroupServiceCapabilityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupServiceCapabilityShrinkRequest request = new GetSkillGroupServiceCapabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupServiceCapabilityResponse>(DoRPCRequest("GetSkillGroupServiceCapability", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSkillGroupServiceCapabilityResponse> GetSkillGroupServiceCapabilityWithOptionsAsync(GetSkillGroupServiceCapabilityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupServiceCapabilityShrinkRequest request = new GetSkillGroupServiceCapabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupServiceCapabilityResponse>(await DoRPCRequestAsync("GetSkillGroupServiceCapability", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSkillGroupServiceCapabilityResponse GetSkillGroupServiceCapability(GetSkillGroupServiceCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupServiceCapabilityWithOptions(request, runtime);
        }

        public async Task<GetSkillGroupServiceCapabilityResponse> GetSkillGroupServiceCapabilityAsync(GetSkillGroupServiceCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupServiceCapabilityWithOptionsAsync(request, runtime);
        }

        public RemoveSkillGroupResponse RemoveSkillGroupWithOptions(RemoveSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSkillGroupResponse>(DoRPCRequest("RemoveSkillGroup", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveSkillGroupResponse> RemoveSkillGroupWithOptionsAsync(RemoveSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSkillGroupResponse>(await DoRPCRequestAsync("RemoveSkillGroup", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveSkillGroupResponse RemoveSkillGroup(RemoveSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveSkillGroupWithOptions(request, runtime);
        }

        public async Task<RemoveSkillGroupResponse> RemoveSkillGroupAsync(RemoveSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveSkillGroupWithOptionsAsync(request, runtime);
        }

        public StartCallV2Response StartCallV2WithOptions(StartCallV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCallV2Response>(DoRPCRequest("StartCallV2", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartCallV2Response> StartCallV2WithOptionsAsync(StartCallV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCallV2Response>(await DoRPCRequestAsync("StartCallV2", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartCallV2Response StartCallV2(StartCallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCallV2WithOptions(request, runtime);
        }

        public async Task<StartCallV2Response> StartCallV2Async(StartCallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCallV2WithOptionsAsync(request, runtime);
        }

        public ChangeChatAgentStatusResponse ChangeChatAgentStatusWithOptions(ChangeChatAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeChatAgentStatusResponse>(DoRPCRequest("ChangeChatAgentStatus", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeChatAgentStatusResponse> ChangeChatAgentStatusWithOptionsAsync(ChangeChatAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeChatAgentStatusResponse>(await DoRPCRequestAsync("ChangeChatAgentStatus", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeChatAgentStatusResponse ChangeChatAgentStatus(ChangeChatAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeChatAgentStatusWithOptions(request, runtime);
        }

        public async Task<ChangeChatAgentStatusResponse> ChangeChatAgentStatusAsync(ChangeChatAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeChatAgentStatusWithOptionsAsync(request, runtime);
        }

        public DescribeRecordDataResponse DescribeRecordDataWithOptions(DescribeRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordDataResponse>(DoRPCRequest("DescribeRecordData", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordDataResponse> DescribeRecordDataWithOptionsAsync(DescribeRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordDataResponse>(await DoRPCRequestAsync("DescribeRecordData", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordDataResponse DescribeRecordData(DescribeRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordDataWithOptions(request, runtime);
        }

        public async Task<DescribeRecordDataResponse> DescribeRecordDataAsync(DescribeRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordDataWithOptionsAsync(request, runtime);
        }

        public DeleteOuterAccountResponse DeleteOuterAccountWithOptions(DeleteOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteOuterAccountResponse>(DoRPCRequest("DeleteOuterAccount", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteOuterAccountResponse> DeleteOuterAccountWithOptionsAsync(DeleteOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteOuterAccountResponse>(await DoRPCRequestAsync("DeleteOuterAccount", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteOuterAccountResponse DeleteOuterAccount(DeleteOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOuterAccountWithOptions(request, runtime);
        }

        public async Task<DeleteOuterAccountResponse> DeleteOuterAccountAsync(DeleteOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOuterAccountWithOptionsAsync(request, runtime);
        }

        public GetDepartmentalLatitudeAgentStatusResponse GetDepartmentalLatitudeAgentStatusWithOptions(GetDepartmentalLatitudeAgentStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDepartmentalLatitudeAgentStatusShrinkRequest request = new GetDepartmentalLatitudeAgentStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDepartmentalLatitudeAgentStatusResponse>(DoRPCRequest("GetDepartmentalLatitudeAgentStatus", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDepartmentalLatitudeAgentStatusResponse> GetDepartmentalLatitudeAgentStatusWithOptionsAsync(GetDepartmentalLatitudeAgentStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDepartmentalLatitudeAgentStatusShrinkRequest request = new GetDepartmentalLatitudeAgentStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDepartmentalLatitudeAgentStatusResponse>(await DoRPCRequestAsync("GetDepartmentalLatitudeAgentStatus", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDepartmentalLatitudeAgentStatusResponse GetDepartmentalLatitudeAgentStatus(GetDepartmentalLatitudeAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDepartmentalLatitudeAgentStatusWithOptions(request, runtime);
        }

        public async Task<GetDepartmentalLatitudeAgentStatusResponse> GetDepartmentalLatitudeAgentStatusAsync(GetDepartmentalLatitudeAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDepartmentalLatitudeAgentStatusWithOptionsAsync(request, runtime);
        }

        public GetHotlineAgentDetailResponse GetHotlineAgentDetailWithOptions(GetHotlineAgentDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineAgentDetailResponse>(DoRPCRequest("GetHotlineAgentDetail", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineAgentDetailResponse> GetHotlineAgentDetailWithOptionsAsync(GetHotlineAgentDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHotlineAgentDetailResponse>(await DoRPCRequestAsync("GetHotlineAgentDetail", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetHotlineAgentDetailResponse GetHotlineAgentDetail(GetHotlineAgentDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineAgentDetailWithOptions(request, runtime);
        }

        public async Task<GetHotlineAgentDetailResponse> GetHotlineAgentDetailAsync(GetHotlineAgentDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineAgentDetailWithOptionsAsync(request, runtime);
        }

        public MakeCallResponse MakeCallWithOptions(MakeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MakeCallResponse>(DoRPCRequest("MakeCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MakeCallResponse> MakeCallWithOptionsAsync(MakeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MakeCallResponse>(await DoRPCRequestAsync("MakeCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MakeCallResponse MakeCall(MakeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MakeCallWithOptions(request, runtime);
        }

        public async Task<MakeCallResponse> MakeCallAsync(MakeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MakeCallWithOptionsAsync(request, runtime);
        }

        public FetchCallResponse FetchCallWithOptions(FetchCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchCallResponse>(DoRPCRequest("FetchCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FetchCallResponse> FetchCallWithOptionsAsync(FetchCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchCallResponse>(await DoRPCRequestAsync("FetchCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FetchCallResponse FetchCall(FetchCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchCallWithOptions(request, runtime);
        }

        public async Task<FetchCallResponse> FetchCallAsync(FetchCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchCallWithOptionsAsync(request, runtime);
        }

        public GetHotlineAgentStatusResponse GetHotlineAgentStatusWithOptions(GetHotlineAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotlineAgentStatusResponse>(DoRPCRequest("GetHotlineAgentStatus", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHotlineAgentStatusResponse> GetHotlineAgentStatusWithOptionsAsync(GetHotlineAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotlineAgentStatusResponse>(await DoRPCRequestAsync("GetHotlineAgentStatus", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHotlineAgentStatusResponse GetHotlineAgentStatus(GetHotlineAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineAgentStatusWithOptions(request, runtime);
        }

        public async Task<GetHotlineAgentStatusResponse> GetHotlineAgentStatusAsync(GetHotlineAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineAgentStatusWithOptionsAsync(request, runtime);
        }

        public StartCallResponse StartCallWithOptions(StartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCallResponse>(DoRPCRequest("StartCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartCallResponse> StartCallWithOptionsAsync(StartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCallResponse>(await DoRPCRequestAsync("StartCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartCallResponse StartCall(StartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCallWithOptions(request, runtime);
        }

        public async Task<StartCallResponse> StartCallAsync(StartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCallWithOptionsAsync(request, runtime);
        }

        public GetQualityRuleTagListResponse GetQualityRuleTagListWithOptions(GetQualityRuleTagListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityRuleTagListResponse>(DoRPCRequest("GetQualityRuleTagList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityRuleTagListResponse> GetQualityRuleTagListWithOptionsAsync(GetQualityRuleTagListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityRuleTagListResponse>(await DoRPCRequestAsync("GetQualityRuleTagList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityRuleTagListResponse GetQualityRuleTagList(GetQualityRuleTagListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityRuleTagListWithOptions(request, runtime);
        }

        public async Task<GetQualityRuleTagListResponse> GetQualityRuleTagListAsync(GetQualityRuleTagListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityRuleTagListWithOptionsAsync(request, runtime);
        }

        public GetOutbounNumListResponse GetOutbounNumListWithOptions(GetOutbounNumListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOutbounNumListResponse>(DoRPCRequest("GetOutbounNumList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOutbounNumListResponse> GetOutbounNumListWithOptionsAsync(GetOutbounNumListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOutbounNumListResponse>(await DoRPCRequestAsync("GetOutbounNumList", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOutbounNumListResponse GetOutbounNumList(GetOutbounNumListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOutbounNumListWithOptions(request, runtime);
        }

        public async Task<GetOutbounNumListResponse> GetOutbounNumListAsync(GetOutbounNumListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOutbounNumListWithOptionsAsync(request, runtime);
        }

        public CreateThirdSsoAgentResponse CreateThirdSsoAgentWithOptions(CreateThirdSsoAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateThirdSsoAgentResponse>(DoRPCRequest("CreateThirdSsoAgent", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateThirdSsoAgentResponse> CreateThirdSsoAgentWithOptionsAsync(CreateThirdSsoAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateThirdSsoAgentResponse>(await DoRPCRequestAsync("CreateThirdSsoAgent", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateThirdSsoAgentResponse CreateThirdSsoAgent(CreateThirdSsoAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateThirdSsoAgentWithOptions(request, runtime);
        }

        public async Task<CreateThirdSsoAgentResponse> CreateThirdSsoAgentAsync(CreateThirdSsoAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateThirdSsoAgentWithOptionsAsync(request, runtime);
        }

        public GetSkillGroupStatusTotalResponse GetSkillGroupStatusTotalWithOptions(GetSkillGroupStatusTotalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupStatusTotalShrinkRequest request = new GetSkillGroupStatusTotalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupStatusTotalResponse>(DoRPCRequest("GetSkillGroupStatusTotal", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSkillGroupStatusTotalResponse> GetSkillGroupStatusTotalWithOptionsAsync(GetSkillGroupStatusTotalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupStatusTotalShrinkRequest request = new GetSkillGroupStatusTotalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupStatusTotalResponse>(await DoRPCRequestAsync("GetSkillGroupStatusTotal", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSkillGroupStatusTotalResponse GetSkillGroupStatusTotal(GetSkillGroupStatusTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupStatusTotalWithOptions(request, runtime);
        }

        public async Task<GetSkillGroupStatusTotalResponse> GetSkillGroupStatusTotalAsync(GetSkillGroupStatusTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupStatusTotalWithOptionsAsync(request, runtime);
        }

        public BatchCreateQualityProjectsResponse BatchCreateQualityProjectsWithOptions(BatchCreateQualityProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchCreateQualityProjectsResponse>(DoRPCRequest("BatchCreateQualityProjects", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchCreateQualityProjectsResponse> BatchCreateQualityProjectsWithOptionsAsync(BatchCreateQualityProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchCreateQualityProjectsResponse>(await DoRPCRequestAsync("BatchCreateQualityProjects", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchCreateQualityProjectsResponse BatchCreateQualityProjects(BatchCreateQualityProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateQualityProjectsWithOptions(request, runtime);
        }

        public async Task<BatchCreateQualityProjectsResponse> BatchCreateQualityProjectsAsync(BatchCreateQualityProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateQualityProjectsWithOptionsAsync(request, runtime);
        }

        public InsertTaskDetailResponse InsertTaskDetailWithOptions(InsertTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertTaskDetailResponse>(DoRPCRequest("InsertTaskDetail", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InsertTaskDetailResponse> InsertTaskDetailWithOptionsAsync(InsertTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertTaskDetailResponse>(await DoRPCRequestAsync("InsertTaskDetail", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InsertTaskDetailResponse InsertTaskDetail(InsertTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertTaskDetailWithOptions(request, runtime);
        }

        public async Task<InsertTaskDetailResponse> InsertTaskDetailAsync(InsertTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertTaskDetailWithOptionsAsync(request, runtime);
        }

        public UpdateSkillGroupResponse UpdateSkillGroupWithOptions(UpdateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSkillGroupResponse>(DoRPCRequest("UpdateSkillGroup", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSkillGroupResponse> UpdateSkillGroupWithOptionsAsync(UpdateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSkillGroupResponse>(await DoRPCRequestAsync("UpdateSkillGroup", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSkillGroupResponse UpdateSkillGroup(UpdateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSkillGroupWithOptions(request, runtime);
        }

        public async Task<UpdateSkillGroupResponse> UpdateSkillGroupAsync(UpdateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSkillGroupWithOptionsAsync(request, runtime);
        }

        public HotlineSessionQueryResponse HotlineSessionQueryWithOptions(HotlineSessionQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HotlineSessionQueryResponse>(DoRPCRequest("HotlineSessionQuery", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HotlineSessionQueryResponse> HotlineSessionQueryWithOptionsAsync(HotlineSessionQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HotlineSessionQueryResponse>(await DoRPCRequestAsync("HotlineSessionQuery", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HotlineSessionQueryResponse HotlineSessionQuery(HotlineSessionQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HotlineSessionQueryWithOptions(request, runtime);
        }

        public async Task<HotlineSessionQueryResponse> HotlineSessionQueryAsync(HotlineSessionQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HotlineSessionQueryWithOptionsAsync(request, runtime);
        }

        public GetQueueInformationResponse GetQueueInformationWithOptions(GetQueueInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetQueueInformationShrinkRequest request = new GetQueueInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetQueueInformationResponse>(DoRPCRequest("GetQueueInformation", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetQueueInformationResponse> GetQueueInformationWithOptionsAsync(GetQueueInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetQueueInformationShrinkRequest request = new GetQueueInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetQueueInformationResponse>(await DoRPCRequestAsync("GetQueueInformation", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetQueueInformationResponse GetQueueInformation(GetQueueInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueInformationWithOptions(request, runtime);
        }

        public async Task<GetQueueInformationResponse> GetQueueInformationAsync(GetQueueInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueInformationWithOptionsAsync(request, runtime);
        }

        public GetSkillGroupServiceStatusResponse GetSkillGroupServiceStatusWithOptions(GetSkillGroupServiceStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupServiceStatusShrinkRequest request = new GetSkillGroupServiceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupServiceStatusResponse>(DoRPCRequest("GetSkillGroupServiceStatus", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSkillGroupServiceStatusResponse> GetSkillGroupServiceStatusWithOptionsAsync(GetSkillGroupServiceStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupServiceStatusShrinkRequest request = new GetSkillGroupServiceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSkillGroupServiceStatusResponse>(await DoRPCRequestAsync("GetSkillGroupServiceStatus", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSkillGroupServiceStatusResponse GetSkillGroupServiceStatus(GetSkillGroupServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupServiceStatusWithOptions(request, runtime);
        }

        public async Task<GetSkillGroupServiceStatusResponse> GetSkillGroupServiceStatusAsync(GetSkillGroupServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupServiceStatusWithOptionsAsync(request, runtime);
        }

        public GetAgentDetailReportResponse GetAgentDetailReportWithOptions(GetAgentDetailReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentDetailReportShrinkRequest request = new GetAgentDetailReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentDetailReportResponse>(DoRPCRequest("GetAgentDetailReport", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAgentDetailReportResponse> GetAgentDetailReportWithOptionsAsync(GetAgentDetailReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentDetailReportShrinkRequest request = new GetAgentDetailReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentDetailReportResponse>(await DoRPCRequestAsync("GetAgentDetailReport", "2019-10-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAgentDetailReportResponse GetAgentDetailReport(GetAgentDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentDetailReportWithOptions(request, runtime);
        }

        public async Task<GetAgentDetailReportResponse> GetAgentDetailReportAsync(GetAgentDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentDetailReportWithOptionsAsync(request, runtime);
        }

        public QueryTicketsResponse QueryTicketsWithOptions(QueryTicketsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTicketsShrinkRequest request = new QueryTicketsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTicketsResponse>(DoRPCRequest("QueryTickets", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTicketsResponse> QueryTicketsWithOptionsAsync(QueryTicketsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTicketsShrinkRequest request = new QueryTicketsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTicketsResponse>(await DoRPCRequestAsync("QueryTickets", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTicketsResponse QueryTickets(QueryTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTicketsWithOptions(request, runtime);
        }

        public async Task<QueryTicketsResponse> QueryTicketsAsync(QueryTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTicketsWithOptionsAsync(request, runtime);
        }

        public QueryOutboundTaskResponse QueryOutboundTaskWithOptions(QueryOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOutboundTaskResponse>(DoRPCRequest("QueryOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOutboundTaskResponse> QueryOutboundTaskWithOptionsAsync(QueryOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOutboundTaskResponse>(await DoRPCRequestAsync("QueryOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOutboundTaskResponse QueryOutboundTask(QueryOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOutboundTaskWithOptions(request, runtime);
        }

        public async Task<QueryOutboundTaskResponse> QueryOutboundTaskAsync(QueryOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOutboundTaskWithOptionsAsync(request, runtime);
        }

        public JoinThirdCallResponse JoinThirdCallWithOptions(JoinThirdCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinThirdCallResponse>(DoRPCRequest("JoinThirdCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinThirdCallResponse> JoinThirdCallWithOptionsAsync(JoinThirdCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinThirdCallResponse>(await DoRPCRequestAsync("JoinThirdCall", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinThirdCallResponse JoinThirdCall(JoinThirdCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinThirdCallWithOptions(request, runtime);
        }

        public async Task<JoinThirdCallResponse> JoinThirdCallAsync(JoinThirdCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinThirdCallWithOptionsAsync(request, runtime);
        }

        public CreateSkillGroupResponse CreateSkillGroupWithOptions(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(DoRPCRequest("CreateSkillGroup", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSkillGroupResponse> CreateSkillGroupWithOptionsAsync(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(await DoRPCRequestAsync("CreateSkillGroup", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSkillGroupResponse CreateSkillGroup(CreateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillGroupWithOptions(request, runtime);
        }

        public async Task<CreateSkillGroupResponse> CreateSkillGroupAsync(CreateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillGroupWithOptionsAsync(request, runtime);
        }

        public RestartOutboundTaskResponse RestartOutboundTaskWithOptions(RestartOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartOutboundTaskResponse>(DoRPCRequest("RestartOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartOutboundTaskResponse> RestartOutboundTaskWithOptionsAsync(RestartOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartOutboundTaskResponse>(await DoRPCRequestAsync("RestartOutboundTask", "2019-10-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartOutboundTaskResponse RestartOutboundTask(RestartOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartOutboundTaskWithOptions(request, runtime);
        }

        public async Task<RestartOutboundTaskResponse> RestartOutboundTaskAsync(RestartOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartOutboundTaskWithOptionsAsync(request, runtime);
        }

    }
}
