// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CCC20200701.Models;

namespace AlibabaCloud.SDK.CCC20200701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "ccc.aliyuncs.com"},
                {"ap-south-1", "ccc.aliyuncs.com"},
                {"ap-southeast-1", "ccc.aliyuncs.com"},
                {"ap-southeast-2", "ccc.aliyuncs.com"},
                {"ap-southeast-3", "ccc.aliyuncs.com"},
                {"ap-southeast-5", "ccc.aliyuncs.com"},
                {"cn-beijing", "ccc.aliyuncs.com"},
                {"cn-chengdu", "ccc.aliyuncs.com"},
                {"cn-hongkong", "ccc.aliyuncs.com"},
                {"cn-huhehaote", "ccc.aliyuncs.com"},
                {"cn-qingdao", "ccc.aliyuncs.com"},
                {"cn-shenzhen", "ccc.aliyuncs.com"},
                {"cn-zhangjiakou", "ccc.aliyuncs.com"},
                {"eu-central-1", "ccc.aliyuncs.com"},
                {"eu-west-1", "ccc.aliyuncs.com"},
                {"me-east-1", "ccc.aliyuncs.com"},
                {"us-east-1", "ccc.aliyuncs.com"},
                {"us-west-1", "ccc.aliyuncs.com"},
                {"cn-hangzhou-finance", "ccc.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ccc.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ccc.aliyuncs.com"},
                {"cn-north-2-gov-1", "ccc.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ccc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddSkillGroupsToUserResponse AddSkillGroupsToUserWithOptions(AddSkillGroupsToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSkillGroupsToUserResponse>(DoRPCRequest("AddSkillGroupsToUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSkillGroupsToUserResponse> AddSkillGroupsToUserWithOptionsAsync(AddSkillGroupsToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSkillGroupsToUserResponse>(await DoRPCRequestAsync("AddSkillGroupsToUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSkillGroupsToUserResponse AddSkillGroupsToUser(AddSkillGroupsToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSkillGroupsToUserWithOptions(request, runtime);
        }

        public async Task<AddSkillGroupsToUserResponse> AddSkillGroupsToUserAsync(AddSkillGroupsToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSkillGroupsToUserWithOptionsAsync(request, runtime);
        }

        public SaveWebRTCStatsResponse SaveWebRTCStatsWithOptions(SaveWebRTCStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWebRTCStatsResponse>(DoRPCRequest("SaveWebRTCStats", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveWebRTCStatsResponse> SaveWebRTCStatsWithOptionsAsync(SaveWebRTCStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWebRTCStatsResponse>(await DoRPCRequestAsync("SaveWebRTCStats", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveWebRTCStatsResponse SaveWebRTCStats(SaveWebRTCStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveWebRTCStatsWithOptions(request, runtime);
        }

        public async Task<SaveWebRTCStatsResponse> SaveWebRTCStatsAsync(SaveWebRTCStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveWebRTCStatsWithOptionsAsync(request, runtime);
        }

        public GetMonoRecordingResponse GetMonoRecordingWithOptions(GetMonoRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonoRecordingResponse>(DoRPCRequest("GetMonoRecording", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMonoRecordingResponse> GetMonoRecordingWithOptionsAsync(GetMonoRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonoRecordingResponse>(await DoRPCRequestAsync("GetMonoRecording", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMonoRecordingResponse GetMonoRecording(GetMonoRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonoRecordingWithOptions(request, runtime);
        }

        public async Task<GetMonoRecordingResponse> GetMonoRecordingAsync(GetMonoRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonoRecordingWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        public ListAgentStateLogsResponse ListAgentStateLogsWithOptions(ListAgentStateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentStateLogsResponse>(DoRPCRequest("ListAgentStateLogs", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAgentStateLogsResponse> ListAgentStateLogsWithOptionsAsync(ListAgentStateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentStateLogsResponse>(await DoRPCRequestAsync("ListAgentStateLogs", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAgentStateLogsResponse ListAgentStateLogs(ListAgentStateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentStateLogsWithOptions(request, runtime);
        }

        public async Task<ListAgentStateLogsResponse> ListAgentStateLogsAsync(ListAgentStateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentStateLogsWithOptionsAsync(request, runtime);
        }

        public RemovePhoneNumberFromSkillGroupsResponse RemovePhoneNumberFromSkillGroupsWithOptions(RemovePhoneNumberFromSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePhoneNumberFromSkillGroupsResponse>(DoRPCRequest("RemovePhoneNumberFromSkillGroups", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemovePhoneNumberFromSkillGroupsResponse> RemovePhoneNumberFromSkillGroupsWithOptionsAsync(RemovePhoneNumberFromSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePhoneNumberFromSkillGroupsResponse>(await DoRPCRequestAsync("RemovePhoneNumberFromSkillGroups", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemovePhoneNumberFromSkillGroupsResponse RemovePhoneNumberFromSkillGroups(RemovePhoneNumberFromSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePhoneNumberFromSkillGroupsWithOptions(request, runtime);
        }

        public async Task<RemovePhoneNumberFromSkillGroupsResponse> RemovePhoneNumberFromSkillGroupsAsync(RemovePhoneNumberFromSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePhoneNumberFromSkillGroupsWithOptionsAsync(request, runtime);
        }

        public ListPhoneNumbersResponse ListPhoneNumbersWithOptions(ListPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhoneNumbersResponse>(DoRPCRequest("ListPhoneNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhoneNumbersResponse> ListPhoneNumbersWithOptionsAsync(ListPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhoneNumbersResponse>(await DoRPCRequestAsync("ListPhoneNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhoneNumbersWithOptions(request, runtime);
        }

        public async Task<ListPhoneNumbersResponse> ListPhoneNumbersAsync(ListPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhoneNumbersWithOptionsAsync(request, runtime);
        }

        public AddNumbersToSkillGroupResponse AddNumbersToSkillGroupWithOptions(AddNumbersToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddNumbersToSkillGroupResponse>(DoRPCRequest("AddNumbersToSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddNumbersToSkillGroupResponse> AddNumbersToSkillGroupWithOptionsAsync(AddNumbersToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddNumbersToSkillGroupResponse>(await DoRPCRequestAsync("AddNumbersToSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddNumbersToSkillGroupResponse AddNumbersToSkillGroup(AddNumbersToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddNumbersToSkillGroupWithOptions(request, runtime);
        }

        public async Task<AddNumbersToSkillGroupResponse> AddNumbersToSkillGroupAsync(AddNumbersToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddNumbersToSkillGroupWithOptionsAsync(request, runtime);
        }

        public ResetAgentStateResponse ResetAgentStateWithOptions(ResetAgentStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAgentStateResponse>(DoRPCRequest("ResetAgentState", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAgentStateResponse> ResetAgentStateWithOptionsAsync(ResetAgentStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAgentStateResponse>(await DoRPCRequestAsync("ResetAgentState", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetAgentStateResponse ResetAgentState(ResetAgentStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAgentStateWithOptions(request, runtime);
        }

        public async Task<ResetAgentStateResponse> ResetAgentStateAsync(ResetAgentStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAgentStateWithOptionsAsync(request, runtime);
        }

        public ChangeWorkModeResponse ChangeWorkModeWithOptions(ChangeWorkModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeWorkModeResponse>(DoRPCRequest("ChangeWorkMode", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeWorkModeResponse> ChangeWorkModeWithOptionsAsync(ChangeWorkModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeWorkModeResponse>(await DoRPCRequestAsync("ChangeWorkMode", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeWorkModeResponse ChangeWorkMode(ChangeWorkModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeWorkModeWithOptions(request, runtime);
        }

        public async Task<ChangeWorkModeResponse> ChangeWorkModeAsync(ChangeWorkModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeWorkModeWithOptionsAsync(request, runtime);
        }

        public GetTurnCredentialsResponse GetTurnCredentialsWithOptions(GetTurnCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTurnCredentialsResponse>(DoRPCRequest("GetTurnCredentials", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTurnCredentialsResponse> GetTurnCredentialsWithOptionsAsync(GetTurnCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTurnCredentialsResponse>(await DoRPCRequestAsync("GetTurnCredentials", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTurnCredentialsResponse GetTurnCredentials(GetTurnCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTurnCredentialsWithOptions(request, runtime);
        }

        public async Task<GetTurnCredentialsResponse> GetTurnCredentialsAsync(GetTurnCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTurnCredentialsWithOptionsAsync(request, runtime);
        }

        public AddPhoneNumbersResponse AddPhoneNumbersWithOptions(AddPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPhoneNumbersResponse>(DoRPCRequest("AddPhoneNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddPhoneNumbersResponse> AddPhoneNumbersWithOptionsAsync(AddPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPhoneNumbersResponse>(await DoRPCRequestAsync("AddPhoneNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddPhoneNumbersResponse AddPhoneNumbers(AddPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPhoneNumbersWithOptions(request, runtime);
        }

        public async Task<AddPhoneNumbersResponse> AddPhoneNumbersAsync(AddPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPhoneNumbersWithOptionsAsync(request, runtime);
        }

        public SaveWebRtcInfoResponse SaveWebRtcInfoWithOptions(SaveWebRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWebRtcInfoResponse>(DoRPCRequest("SaveWebRtcInfo", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveWebRtcInfoResponse> SaveWebRtcInfoWithOptionsAsync(SaveWebRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWebRtcInfoResponse>(await DoRPCRequestAsync("SaveWebRtcInfo", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveWebRtcInfoResponse SaveWebRtcInfo(SaveWebRtcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveWebRtcInfoWithOptions(request, runtime);
        }

        public async Task<SaveWebRtcInfoResponse> SaveWebRtcInfoAsync(SaveWebRtcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveWebRtcInfoWithOptionsAsync(request, runtime);
        }

        public ListIntervalSkillGroupReportResponse ListIntervalSkillGroupReportWithOptions(ListIntervalSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIntervalSkillGroupReportResponse>(DoRPCRequest("ListIntervalSkillGroupReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIntervalSkillGroupReportResponse> ListIntervalSkillGroupReportWithOptionsAsync(ListIntervalSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIntervalSkillGroupReportResponse>(await DoRPCRequestAsync("ListIntervalSkillGroupReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIntervalSkillGroupReportResponse ListIntervalSkillGroupReport(ListIntervalSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervalSkillGroupReportWithOptions(request, runtime);
        }

        public async Task<ListIntervalSkillGroupReportResponse> ListIntervalSkillGroupReportAsync(ListIntervalSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervalSkillGroupReportWithOptionsAsync(request, runtime);
        }

        public MonitorCallResponse MonitorCallWithOptions(MonitorCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MonitorCallResponse>(DoRPCRequest("MonitorCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MonitorCallResponse> MonitorCallWithOptionsAsync(MonitorCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MonitorCallResponse>(await DoRPCRequestAsync("MonitorCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MonitorCallResponse MonitorCall(MonitorCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MonitorCallWithOptions(request, runtime);
        }

        public async Task<MonitorCallResponse> MonitorCallAsync(MonitorCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MonitorCallWithOptionsAsync(request, runtime);
        }

        public RemoveUsersFromSkillGroupResponse RemoveUsersFromSkillGroupWithOptions(RemoveUsersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersFromSkillGroupResponse>(DoRPCRequest("RemoveUsersFromSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveUsersFromSkillGroupResponse> RemoveUsersFromSkillGroupWithOptionsAsync(RemoveUsersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersFromSkillGroupResponse>(await DoRPCRequestAsync("RemoveUsersFromSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveUsersFromSkillGroupResponse RemoveUsersFromSkillGroup(RemoveUsersFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersFromSkillGroupWithOptions(request, runtime);
        }

        public async Task<RemoveUsersFromSkillGroupResponse> RemoveUsersFromSkillGroupAsync(RemoveUsersFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersFromSkillGroupWithOptionsAsync(request, runtime);
        }

        public DeleteSkillGroupResponse DeleteSkillGroupWithOptions(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(DoRPCRequest("DeleteSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSkillGroupResponse> DeleteSkillGroupWithOptionsAsync(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(await DoRPCRequestAsync("DeleteSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public BlindTransferResponse BlindTransferWithOptions(BlindTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BlindTransferResponse>(DoRPCRequest("BlindTransfer", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BlindTransferResponse> BlindTransferWithOptionsAsync(BlindTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BlindTransferResponse>(await DoRPCRequestAsync("BlindTransfer", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BlindTransferResponse BlindTransfer(BlindTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BlindTransferWithOptions(request, runtime);
        }

        public async Task<BlindTransferResponse> BlindTransferAsync(BlindTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BlindTransferWithOptionsAsync(request, runtime);
        }

        public ListSkillLevelsOfUserResponse ListSkillLevelsOfUserWithOptions(ListSkillLevelsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillLevelsOfUserResponse>(DoRPCRequest("ListSkillLevelsOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSkillLevelsOfUserResponse> ListSkillLevelsOfUserWithOptionsAsync(ListSkillLevelsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillLevelsOfUserResponse>(await DoRPCRequestAsync("ListSkillLevelsOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSkillLevelsOfUserResponse ListSkillLevelsOfUser(ListSkillLevelsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillLevelsOfUserWithOptions(request, runtime);
        }

        public async Task<ListSkillLevelsOfUserResponse> ListSkillLevelsOfUserAsync(ListSkillLevelsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillLevelsOfUserWithOptionsAsync(request, runtime);
        }

        public ListUnassignedNumbersResponse ListUnassignedNumbersWithOptions(ListUnassignedNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUnassignedNumbersResponse>(DoRPCRequest("ListUnassignedNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUnassignedNumbersResponse> ListUnassignedNumbersWithOptionsAsync(ListUnassignedNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUnassignedNumbersResponse>(await DoRPCRequestAsync("ListUnassignedNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUnassignedNumbersResponse ListUnassignedNumbers(ListUnassignedNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUnassignedNumbersWithOptions(request, runtime);
        }

        public async Task<ListUnassignedNumbersResponse> ListUnassignedNumbersAsync(ListUnassignedNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUnassignedNumbersWithOptionsAsync(request, runtime);
        }

        public GetInstanceTrendingReportResponse GetInstanceTrendingReportWithOptions(GetInstanceTrendingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceTrendingReportResponse>(DoRPCRequest("GetInstanceTrendingReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceTrendingReportResponse> GetInstanceTrendingReportWithOptionsAsync(GetInstanceTrendingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceTrendingReportResponse>(await DoRPCRequestAsync("GetInstanceTrendingReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceTrendingReportResponse GetInstanceTrendingReport(GetInstanceTrendingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceTrendingReportWithOptions(request, runtime);
        }

        public async Task<GetInstanceTrendingReportResponse> GetInstanceTrendingReportAsync(GetInstanceTrendingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceTrendingReportWithOptionsAsync(request, runtime);
        }

        public ListInstancesOfUserResponse ListInstancesOfUserWithOptions(ListInstancesOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstancesOfUserResponse>(DoRPCRequest("ListInstancesOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstancesOfUserResponse> ListInstancesOfUserWithOptionsAsync(ListInstancesOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstancesOfUserResponse>(await DoRPCRequestAsync("ListInstancesOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstancesOfUserResponse ListInstancesOfUser(ListInstancesOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesOfUserWithOptions(request, runtime);
        }

        public async Task<ListInstancesOfUserResponse> ListInstancesOfUserAsync(ListInstancesOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesOfUserWithOptionsAsync(request, runtime);
        }

        public LaunchSurveyResponse LaunchSurveyWithOptions(LaunchSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchSurveyResponse>(DoRPCRequest("LaunchSurvey", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LaunchSurveyResponse> LaunchSurveyWithOptionsAsync(LaunchSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchSurveyResponse>(await DoRPCRequestAsync("LaunchSurvey", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LaunchSurveyResponse LaunchSurvey(LaunchSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LaunchSurveyWithOptions(request, runtime);
        }

        public async Task<LaunchSurveyResponse> LaunchSurveyAsync(LaunchSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LaunchSurveyWithOptionsAsync(request, runtime);
        }

        public ListIvrTrackingDetailsResponse ListIvrTrackingDetailsWithOptions(ListIvrTrackingDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIvrTrackingDetailsResponse>(DoRPCRequest("ListIvrTrackingDetails", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIvrTrackingDetailsResponse> ListIvrTrackingDetailsWithOptionsAsync(ListIvrTrackingDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIvrTrackingDetailsResponse>(await DoRPCRequestAsync("ListIvrTrackingDetails", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIvrTrackingDetailsResponse ListIvrTrackingDetails(ListIvrTrackingDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIvrTrackingDetailsWithOptions(request, runtime);
        }

        public async Task<ListIvrTrackingDetailsResponse> ListIvrTrackingDetailsAsync(ListIvrTrackingDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIvrTrackingDetailsWithOptionsAsync(request, runtime);
        }

        public ListBriefSkillGroupsResponse ListBriefSkillGroupsWithOptions(ListBriefSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBriefSkillGroupsResponse>(DoRPCRequest("ListBriefSkillGroups", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBriefSkillGroupsResponse> ListBriefSkillGroupsWithOptionsAsync(ListBriefSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBriefSkillGroupsResponse>(await DoRPCRequestAsync("ListBriefSkillGroups", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBriefSkillGroupsResponse ListBriefSkillGroups(ListBriefSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBriefSkillGroupsWithOptions(request, runtime);
        }

        public async Task<ListBriefSkillGroupsResponse> ListBriefSkillGroupsAsync(ListBriefSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBriefSkillGroupsWithOptionsAsync(request, runtime);
        }

        public UnmuteCallResponse UnmuteCallWithOptions(UnmuteCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnmuteCallResponse>(DoRPCRequest("UnmuteCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnmuteCallResponse> UnmuteCallWithOptionsAsync(UnmuteCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnmuteCallResponse>(await DoRPCRequestAsync("UnmuteCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnmuteCallResponse UnmuteCall(UnmuteCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnmuteCallWithOptions(request, runtime);
        }

        public async Task<UnmuteCallResponse> UnmuteCallAsync(UnmuteCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnmuteCallWithOptionsAsync(request, runtime);
        }

        public ModifySkillLevelsOfUserResponse ModifySkillLevelsOfUserWithOptions(ModifySkillLevelsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillLevelsOfUserResponse>(DoRPCRequest("ModifySkillLevelsOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySkillLevelsOfUserResponse> ModifySkillLevelsOfUserWithOptionsAsync(ModifySkillLevelsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillLevelsOfUserResponse>(await DoRPCRequestAsync("ModifySkillLevelsOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySkillLevelsOfUserResponse ModifySkillLevelsOfUser(ModifySkillLevelsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySkillLevelsOfUserWithOptions(request, runtime);
        }

        public async Task<ModifySkillLevelsOfUserResponse> ModifySkillLevelsOfUserAsync(ModifySkillLevelsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySkillLevelsOfUserWithOptionsAsync(request, runtime);
        }

        public AssignUsersResponse AssignUsersWithOptions(AssignUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignUsersResponse>(DoRPCRequest("AssignUsers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssignUsersResponse> AssignUsersWithOptionsAsync(AssignUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignUsersResponse>(await DoRPCRequestAsync("AssignUsers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssignUsersResponse AssignUsers(AssignUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignUsersWithOptions(request, runtime);
        }

        public async Task<AssignUsersResponse> AssignUsersAsync(AssignUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignUsersWithOptionsAsync(request, runtime);
        }

        public ListUserLevelsOfSkillGroupResponse ListUserLevelsOfSkillGroupWithOptions(ListUserLevelsOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserLevelsOfSkillGroupResponse>(DoRPCRequest("ListUserLevelsOfSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserLevelsOfSkillGroupResponse> ListUserLevelsOfSkillGroupWithOptionsAsync(ListUserLevelsOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserLevelsOfSkillGroupResponse>(await DoRPCRequestAsync("ListUserLevelsOfSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserLevelsOfSkillGroupResponse ListUserLevelsOfSkillGroup(ListUserLevelsOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserLevelsOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ListUserLevelsOfSkillGroupResponse> ListUserLevelsOfSkillGroupAsync(ListUserLevelsOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserLevelsOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRolesResponse>(DoRPCRequest("ListRoles", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRolesResponse>(await DoRPCRequestAsync("ListRoles", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateConfigItemsResponse UpdateConfigItemsWithOptions(UpdateConfigItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConfigItemsResponse>(DoRPCRequest("UpdateConfigItems", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateConfigItemsResponse> UpdateConfigItemsWithOptionsAsync(UpdateConfigItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConfigItemsResponse>(await DoRPCRequestAsync("UpdateConfigItems", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateConfigItemsResponse UpdateConfigItems(UpdateConfigItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConfigItemsWithOptions(request, runtime);
        }

        public async Task<UpdateConfigItemsResponse> UpdateConfigItemsAsync(UpdateConfigItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConfigItemsWithOptionsAsync(request, runtime);
        }

        public GetCallDetailRecordResponse GetCallDetailRecordWithOptions(GetCallDetailRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCallDetailRecordResponse>(DoRPCRequest("GetCallDetailRecord", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCallDetailRecordResponse> GetCallDetailRecordWithOptionsAsync(GetCallDetailRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCallDetailRecordResponse>(await DoRPCRequestAsync("GetCallDetailRecord", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCallDetailRecordResponse GetCallDetailRecord(GetCallDetailRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCallDetailRecordWithOptions(request, runtime);
        }

        public async Task<GetCallDetailRecordResponse> GetCallDetailRecordAsync(GetCallDetailRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCallDetailRecordWithOptionsAsync(request, runtime);
        }

        public ModifyPhoneNumberResponse ModifyPhoneNumberWithOptions(ModifyPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPhoneNumberResponse>(DoRPCRequest("ModifyPhoneNumber", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPhoneNumberResponse> ModifyPhoneNumberWithOptionsAsync(ModifyPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPhoneNumberResponse>(await DoRPCRequestAsync("ModifyPhoneNumber", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPhoneNumberResponse ModifyPhoneNumber(ModifyPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPhoneNumberWithOptions(request, runtime);
        }

        public async Task<ModifyPhoneNumberResponse> ModifyPhoneNumberAsync(ModifyPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPhoneNumberWithOptionsAsync(request, runtime);
        }

        public CoachCallResponse CoachCallWithOptions(CoachCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CoachCallResponse>(DoRPCRequest("CoachCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CoachCallResponse> CoachCallWithOptionsAsync(CoachCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CoachCallResponse>(await DoRPCRequestAsync("CoachCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CoachCallResponse CoachCall(CoachCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CoachCallWithOptions(request, runtime);
        }

        public async Task<CoachCallResponse> CoachCallAsync(CoachCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CoachCallWithOptionsAsync(request, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(DoRPCRequest("CreateUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(await DoRPCRequestAsync("CreateUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        public ListPrivilegesOfUserResponse ListPrivilegesOfUserWithOptions(ListPrivilegesOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPrivilegesOfUserResponse>(DoRPCRequest("ListPrivilegesOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPrivilegesOfUserResponse> ListPrivilegesOfUserWithOptionsAsync(ListPrivilegesOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPrivilegesOfUserResponse>(await DoRPCRequestAsync("ListPrivilegesOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPrivilegesOfUserResponse ListPrivilegesOfUser(ListPrivilegesOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivilegesOfUserWithOptions(request, runtime);
        }

        public async Task<ListPrivilegesOfUserResponse> ListPrivilegesOfUserAsync(ListPrivilegesOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivilegesOfUserWithOptionsAsync(request, runtime);
        }

        public AddPersonalNumbersToUserResponse AddPersonalNumbersToUserWithOptions(AddPersonalNumbersToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPersonalNumbersToUserResponse>(DoRPCRequest("AddPersonalNumbersToUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddPersonalNumbersToUserResponse> AddPersonalNumbersToUserWithOptionsAsync(AddPersonalNumbersToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPersonalNumbersToUserResponse>(await DoRPCRequestAsync("AddPersonalNumbersToUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddPersonalNumbersToUserResponse AddPersonalNumbersToUser(AddPersonalNumbersToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPersonalNumbersToUserWithOptions(request, runtime);
        }

        public async Task<AddPersonalNumbersToUserResponse> AddPersonalNumbersToUserAsync(AddPersonalNumbersToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPersonalNumbersToUserWithOptionsAsync(request, runtime);
        }

        public ListHistoricalAgentReportResponse ListHistoricalAgentReportWithOptions(ListHistoricalAgentReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHistoricalAgentReportResponse>(DoRPCRequest("ListHistoricalAgentReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHistoricalAgentReportResponse> ListHistoricalAgentReportWithOptionsAsync(ListHistoricalAgentReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHistoricalAgentReportResponse>(await DoRPCRequestAsync("ListHistoricalAgentReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHistoricalAgentReportResponse ListHistoricalAgentReport(ListHistoricalAgentReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHistoricalAgentReportWithOptions(request, runtime);
        }

        public async Task<ListHistoricalAgentReportResponse> ListHistoricalAgentReportAsync(ListHistoricalAgentReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHistoricalAgentReportWithOptionsAsync(request, runtime);
        }

        public InterceptCallResponse InterceptCallWithOptions(InterceptCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InterceptCallResponse>(DoRPCRequest("InterceptCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InterceptCallResponse> InterceptCallWithOptionsAsync(InterceptCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InterceptCallResponse>(await DoRPCRequestAsync("InterceptCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InterceptCallResponse InterceptCall(InterceptCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InterceptCallWithOptions(request, runtime);
        }

        public async Task<InterceptCallResponse> InterceptCallAsync(InterceptCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InterceptCallWithOptionsAsync(request, runtime);
        }

        public ListContactFlowsResponse ListContactFlowsWithOptions(ListContactFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListContactFlowsResponse>(DoRPCRequest("ListContactFlows", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListContactFlowsResponse> ListContactFlowsWithOptionsAsync(ListContactFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListContactFlowsResponse>(await DoRPCRequestAsync("ListContactFlows", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListContactFlowsResponse ListContactFlows(ListContactFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContactFlowsWithOptions(request, runtime);
        }

        public async Task<ListContactFlowsResponse> ListContactFlowsAsync(ListContactFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContactFlowsWithOptionsAsync(request, runtime);
        }

        public ListPersonalNumbersOfUserResponse ListPersonalNumbersOfUserWithOptions(ListPersonalNumbersOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonalNumbersOfUserResponse>(DoRPCRequest("ListPersonalNumbersOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonalNumbersOfUserResponse> ListPersonalNumbersOfUserWithOptionsAsync(ListPersonalNumbersOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonalNumbersOfUserResponse>(await DoRPCRequestAsync("ListPersonalNumbersOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPersonalNumbersOfUserResponse ListPersonalNumbersOfUser(ListPersonalNumbersOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonalNumbersOfUserWithOptions(request, runtime);
        }

        public async Task<ListPersonalNumbersOfUserResponse> ListPersonalNumbersOfUserAsync(ListPersonalNumbersOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonalNumbersOfUserWithOptionsAsync(request, runtime);
        }

        public StartPredictiveCallResponse StartPredictiveCallWithOptions(StartPredictiveCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartPredictiveCallResponse>(DoRPCRequest("StartPredictiveCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartPredictiveCallResponse> StartPredictiveCallWithOptionsAsync(StartPredictiveCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartPredictiveCallResponse>(await DoRPCRequestAsync("StartPredictiveCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartPredictiveCallResponse StartPredictiveCall(StartPredictiveCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartPredictiveCallWithOptions(request, runtime);
        }

        public async Task<StartPredictiveCallResponse> StartPredictiveCallAsync(StartPredictiveCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartPredictiveCallWithOptionsAsync(request, runtime);
        }

        public ListIntervalInstanceReportResponse ListIntervalInstanceReportWithOptions(ListIntervalInstanceReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIntervalInstanceReportResponse>(DoRPCRequest("ListIntervalInstanceReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIntervalInstanceReportResponse> ListIntervalInstanceReportWithOptionsAsync(ListIntervalInstanceReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIntervalInstanceReportResponse>(await DoRPCRequestAsync("ListIntervalInstanceReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIntervalInstanceReportResponse ListIntervalInstanceReport(ListIntervalInstanceReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervalInstanceReportWithOptions(request, runtime);
        }

        public async Task<ListIntervalInstanceReportResponse> ListIntervalInstanceReportAsync(ListIntervalInstanceReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervalInstanceReportWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public RemoveSkillGroupsFromUserResponse RemoveSkillGroupsFromUserWithOptions(RemoveSkillGroupsFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSkillGroupsFromUserResponse>(DoRPCRequest("RemoveSkillGroupsFromUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveSkillGroupsFromUserResponse> RemoveSkillGroupsFromUserWithOptionsAsync(RemoveSkillGroupsFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSkillGroupsFromUserResponse>(await DoRPCRequestAsync("RemoveSkillGroupsFromUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveSkillGroupsFromUserResponse RemoveSkillGroupsFromUser(RemoveSkillGroupsFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveSkillGroupsFromUserWithOptions(request, runtime);
        }

        public async Task<RemoveSkillGroupsFromUserResponse> RemoveSkillGroupsFromUserAsync(RemoveSkillGroupsFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveSkillGroupsFromUserWithOptionsAsync(request, runtime);
        }

        public ListRealtimeAgentStatesResponse ListRealtimeAgentStatesWithOptions(ListRealtimeAgentStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRealtimeAgentStatesResponse>(DoRPCRequest("ListRealtimeAgentStates", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRealtimeAgentStatesResponse> ListRealtimeAgentStatesWithOptionsAsync(ListRealtimeAgentStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRealtimeAgentStatesResponse>(await DoRPCRequestAsync("ListRealtimeAgentStates", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRealtimeAgentStatesResponse ListRealtimeAgentStates(ListRealtimeAgentStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealtimeAgentStatesWithOptions(request, runtime);
        }

        public async Task<ListRealtimeAgentStatesResponse> ListRealtimeAgentStatesAsync(ListRealtimeAgentStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealtimeAgentStatesWithOptionsAsync(request, runtime);
        }

        public LaunchAuthenticationResponse LaunchAuthenticationWithOptions(LaunchAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchAuthenticationResponse>(DoRPCRequest("LaunchAuthentication", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LaunchAuthenticationResponse> LaunchAuthenticationWithOptionsAsync(LaunchAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchAuthenticationResponse>(await DoRPCRequestAsync("LaunchAuthentication", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LaunchAuthenticationResponse LaunchAuthentication(LaunchAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LaunchAuthenticationWithOptions(request, runtime);
        }

        public async Task<LaunchAuthenticationResponse> LaunchAuthenticationAsync(LaunchAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LaunchAuthenticationWithOptionsAsync(request, runtime);
        }

        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstancesResponse>(DoRPCRequest("ListInstances", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstancesResponse>(await DoRPCRequestAsync("ListInstances", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        public GetHistoricalInstanceReportResponse GetHistoricalInstanceReportWithOptions(GetHistoricalInstanceReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHistoricalInstanceReportResponse>(DoRPCRequest("GetHistoricalInstanceReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHistoricalInstanceReportResponse> GetHistoricalInstanceReportWithOptionsAsync(GetHistoricalInstanceReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHistoricalInstanceReportResponse>(await DoRPCRequestAsync("GetHistoricalInstanceReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHistoricalInstanceReportResponse GetHistoricalInstanceReport(GetHistoricalInstanceReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistoricalInstanceReportWithOptions(request, runtime);
        }

        public async Task<GetHistoricalInstanceReportResponse> GetHistoricalInstanceReportAsync(GetHistoricalInstanceReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistoricalInstanceReportWithOptionsAsync(request, runtime);
        }

        public RemoveUsersResponse RemoveUsersWithOptions(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersResponse>(DoRPCRequest("RemoveUsers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveUsersResponse> RemoveUsersWithOptionsAsync(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersResponse>(await DoRPCRequestAsync("RemoveUsers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveUsersResponse RemoveUsers(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersWithOptions(request, runtime);
        }

        public async Task<RemoveUsersResponse> RemoveUsersAsync(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersWithOptionsAsync(request, runtime);
        }

        public StartBack2BackCallResponse StartBack2BackCallWithOptions(StartBack2BackCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBack2BackCallResponse>(DoRPCRequest("StartBack2BackCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartBack2BackCallResponse> StartBack2BackCallWithOptionsAsync(StartBack2BackCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBack2BackCallResponse>(await DoRPCRequestAsync("StartBack2BackCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartBack2BackCallResponse StartBack2BackCall(StartBack2BackCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBack2BackCallWithOptions(request, runtime);
        }

        public async Task<StartBack2BackCallResponse> StartBack2BackCallAsync(StartBack2BackCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBack2BackCallWithOptionsAsync(request, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(DoRPCRequest("GetUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(await DoRPCRequestAsync("GetUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        public RemovePhoneNumbersFromSkillGroupResponse RemovePhoneNumbersFromSkillGroupWithOptions(RemovePhoneNumbersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePhoneNumbersFromSkillGroupResponse>(DoRPCRequest("RemovePhoneNumbersFromSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemovePhoneNumbersFromSkillGroupResponse> RemovePhoneNumbersFromSkillGroupWithOptionsAsync(RemovePhoneNumbersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePhoneNumbersFromSkillGroupResponse>(await DoRPCRequestAsync("RemovePhoneNumbersFromSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemovePhoneNumbersFromSkillGroupResponse RemovePhoneNumbersFromSkillGroup(RemovePhoneNumbersFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePhoneNumbersFromSkillGroupWithOptions(request, runtime);
        }

        public async Task<RemovePhoneNumbersFromSkillGroupResponse> RemovePhoneNumbersFromSkillGroupAsync(RemovePhoneNumbersFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePhoneNumbersFromSkillGroupWithOptionsAsync(request, runtime);
        }

        public CompleteAttendedTransferResponse CompleteAttendedTransferWithOptions(CompleteAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteAttendedTransferResponse>(DoRPCRequest("CompleteAttendedTransfer", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompleteAttendedTransferResponse> CompleteAttendedTransferWithOptionsAsync(CompleteAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteAttendedTransferResponse>(await DoRPCRequestAsync("CompleteAttendedTransfer", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CompleteAttendedTransferResponse CompleteAttendedTransfer(CompleteAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteAttendedTransferWithOptions(request, runtime);
        }

        public async Task<CompleteAttendedTransferResponse> CompleteAttendedTransferAsync(CompleteAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteAttendedTransferWithOptionsAsync(request, runtime);
        }

        public ResetUserPasswordResponse ResetUserPasswordWithOptions(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(DoRPCRequest("ResetUserPassword", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetUserPasswordResponse> ResetUserPasswordWithOptionsAsync(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(await DoRPCRequestAsync("ResetUserPassword", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetUserPasswordWithOptions(request, runtime);
        }

        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetUserPasswordWithOptionsAsync(request, runtime);
        }

        public GetTurnServerListResponse GetTurnServerListWithOptions(GetTurnServerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTurnServerListResponse>(DoRPCRequest("GetTurnServerList", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTurnServerListResponse> GetTurnServerListWithOptionsAsync(GetTurnServerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTurnServerListResponse>(await DoRPCRequestAsync("GetTurnServerList", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTurnServerListResponse GetTurnServerList(GetTurnServerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTurnServerListWithOptions(request, runtime);
        }

        public async Task<GetTurnServerListResponse> GetTurnServerListAsync(GetTurnServerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTurnServerListWithOptionsAsync(request, runtime);
        }

        public GetNumberLocationResponse GetNumberLocationWithOptions(GetNumberLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNumberLocationResponse>(DoRPCRequest("GetNumberLocation", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNumberLocationResponse> GetNumberLocationWithOptionsAsync(GetNumberLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNumberLocationResponse>(await DoRPCRequestAsync("GetNumberLocation", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNumberLocationResponse GetNumberLocation(GetNumberLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNumberLocationWithOptions(request, runtime);
        }

        public async Task<GetNumberLocationResponse> GetNumberLocationAsync(GetNumberLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNumberLocationWithOptionsAsync(request, runtime);
        }

        public ListRamUsersResponse ListRamUsersWithOptions(ListRamUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRamUsersResponse>(DoRPCRequest("ListRamUsers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRamUsersResponse> ListRamUsersWithOptionsAsync(ListRamUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRamUsersResponse>(await DoRPCRequestAsync("ListRamUsers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRamUsersResponse ListRamUsers(ListRamUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRamUsersWithOptions(request, runtime);
        }

        public async Task<ListRamUsersResponse> ListRamUsersAsync(ListRamUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRamUsersWithOptionsAsync(request, runtime);
        }

        public MuteCallResponse MuteCallWithOptions(MuteCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MuteCallResponse>(DoRPCRequest("MuteCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MuteCallResponse> MuteCallWithOptionsAsync(MuteCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MuteCallResponse>(await DoRPCRequestAsync("MuteCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MuteCallResponse MuteCall(MuteCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MuteCallWithOptions(request, runtime);
        }

        public async Task<MuteCallResponse> MuteCallAsync(MuteCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MuteCallWithOptionsAsync(request, runtime);
        }

        public AnswerCallResponse AnswerCallWithOptions(AnswerCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AnswerCallResponse>(DoRPCRequest("AnswerCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AnswerCallResponse> AnswerCallWithOptionsAsync(AnswerCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AnswerCallResponse>(await DoRPCRequestAsync("AnswerCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListIntervalAgentReportResponse ListIntervalAgentReportWithOptions(ListIntervalAgentReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIntervalAgentReportResponse>(DoRPCRequest("ListIntervalAgentReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIntervalAgentReportResponse> ListIntervalAgentReportWithOptionsAsync(ListIntervalAgentReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIntervalAgentReportResponse>(await DoRPCRequestAsync("ListIntervalAgentReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIntervalAgentReportResponse ListIntervalAgentReport(ListIntervalAgentReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervalAgentReportWithOptions(request, runtime);
        }

        public async Task<ListIntervalAgentReportResponse> ListIntervalAgentReportAsync(ListIntervalAgentReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervalAgentReportWithOptionsAsync(request, runtime);
        }

        public ListCallDetailRecordsResponse ListCallDetailRecordsWithOptions(ListCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCallDetailRecordsResponse>(DoRPCRequest("ListCallDetailRecords", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCallDetailRecordsResponse> ListCallDetailRecordsWithOptionsAsync(ListCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCallDetailRecordsResponse>(await DoRPCRequestAsync("ListCallDetailRecords", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCallDetailRecordsResponse ListCallDetailRecords(ListCallDetailRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCallDetailRecordsWithOptions(request, runtime);
        }

        public async Task<ListCallDetailRecordsResponse> ListCallDetailRecordsAsync(ListCallDetailRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCallDetailRecordsWithOptionsAsync(request, runtime);
        }

        public RemovePhoneNumbersResponse RemovePhoneNumbersWithOptions(RemovePhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePhoneNumbersResponse>(DoRPCRequest("RemovePhoneNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemovePhoneNumbersResponse> RemovePhoneNumbersWithOptionsAsync(RemovePhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePhoneNumbersResponse>(await DoRPCRequestAsync("RemovePhoneNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemovePhoneNumbersResponse RemovePhoneNumbers(RemovePhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePhoneNumbersWithOptions(request, runtime);
        }

        public async Task<RemovePhoneNumbersResponse> RemovePhoneNumbersAsync(RemovePhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePhoneNumbersWithOptionsAsync(request, runtime);
        }

        public CancelAttendedTransferResponse CancelAttendedTransferWithOptions(CancelAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelAttendedTransferResponse>(DoRPCRequest("CancelAttendedTransfer", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelAttendedTransferResponse> CancelAttendedTransferWithOptionsAsync(CancelAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelAttendedTransferResponse>(await DoRPCRequestAsync("CancelAttendedTransfer", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelAttendedTransferResponse CancelAttendedTransfer(CancelAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAttendedTransferWithOptions(request, runtime);
        }

        public async Task<CancelAttendedTransferResponse> CancelAttendedTransferAsync(CancelAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAttendedTransferWithOptionsAsync(request, runtime);
        }

        public TakeBreakResponse TakeBreakWithOptions(TakeBreakRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TakeBreakResponse>(DoRPCRequest("TakeBreak", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TakeBreakResponse> TakeBreakWithOptionsAsync(TakeBreakRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TakeBreakResponse>(await DoRPCRequestAsync("TakeBreak", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TakeBreakResponse TakeBreak(TakeBreakRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TakeBreakWithOptions(request, runtime);
        }

        public async Task<TakeBreakResponse> TakeBreakAsync(TakeBreakRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TakeBreakWithOptionsAsync(request, runtime);
        }

        public ListHistoricalSkillGroupReportResponse ListHistoricalSkillGroupReportWithOptions(ListHistoricalSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHistoricalSkillGroupReportResponse>(DoRPCRequest("ListHistoricalSkillGroupReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHistoricalSkillGroupReportResponse> ListHistoricalSkillGroupReportWithOptionsAsync(ListHistoricalSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHistoricalSkillGroupReportResponse>(await DoRPCRequestAsync("ListHistoricalSkillGroupReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHistoricalSkillGroupReportResponse ListHistoricalSkillGroupReport(ListHistoricalSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHistoricalSkillGroupReportWithOptions(request, runtime);
        }

        public async Task<ListHistoricalSkillGroupReportResponse> ListHistoricalSkillGroupReportAsync(ListHistoricalSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHistoricalSkillGroupReportWithOptionsAsync(request, runtime);
        }

        public SendDtmfSignalingResponse SendDtmfSignalingWithOptions(SendDtmfSignalingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendDtmfSignalingResponse>(DoRPCRequest("SendDtmfSignaling", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendDtmfSignalingResponse> SendDtmfSignalingWithOptionsAsync(SendDtmfSignalingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendDtmfSignalingResponse>(await DoRPCRequestAsync("SendDtmfSignaling", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendDtmfSignalingResponse SendDtmfSignaling(SendDtmfSignalingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendDtmfSignalingWithOptions(request, runtime);
        }

        public async Task<SendDtmfSignalingResponse> SendDtmfSignalingAsync(SendDtmfSignalingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendDtmfSignalingWithOptionsAsync(request, runtime);
        }

        public ListRecentCallDetailRecordsResponse ListRecentCallDetailRecordsWithOptions(ListRecentCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecentCallDetailRecordsResponse>(DoRPCRequest("ListRecentCallDetailRecords", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRecentCallDetailRecordsResponse> ListRecentCallDetailRecordsWithOptionsAsync(ListRecentCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecentCallDetailRecordsResponse>(await DoRPCRequestAsync("ListRecentCallDetailRecords", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRecentCallDetailRecordsResponse ListRecentCallDetailRecords(ListRecentCallDetailRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecentCallDetailRecordsWithOptions(request, runtime);
        }

        public async Task<ListRecentCallDetailRecordsResponse> ListRecentCallDetailRecordsAsync(ListRecentCallDetailRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecentCallDetailRecordsWithOptionsAsync(request, runtime);
        }

        public InitiateAttendedTransferResponse InitiateAttendedTransferWithOptions(InitiateAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitiateAttendedTransferResponse>(DoRPCRequest("InitiateAttendedTransfer", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitiateAttendedTransferResponse> InitiateAttendedTransferWithOptionsAsync(InitiateAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitiateAttendedTransferResponse>(await DoRPCRequestAsync("InitiateAttendedTransfer", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitiateAttendedTransferResponse InitiateAttendedTransfer(InitiateAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitiateAttendedTransferWithOptions(request, runtime);
        }

        public async Task<InitiateAttendedTransferResponse> InitiateAttendedTransferAsync(InitiateAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitiateAttendedTransferWithOptionsAsync(request, runtime);
        }

        public MakeCallResponse MakeCallWithOptions(MakeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MakeCallResponse>(DoRPCRequest("MakeCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MakeCallResponse> MakeCallWithOptionsAsync(MakeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MakeCallResponse>(await DoRPCRequestAsync("MakeCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(DoRPCRequest("GetInstance", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(await DoRPCRequestAsync("GetInstance", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        public AddUsersToSkillGroupResponse AddUsersToSkillGroupWithOptions(AddUsersToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUsersToSkillGroupResponse>(DoRPCRequest("AddUsersToSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddUsersToSkillGroupResponse> AddUsersToSkillGroupWithOptionsAsync(AddUsersToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUsersToSkillGroupResponse>(await DoRPCRequestAsync("AddUsersToSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddUsersToSkillGroupResponse AddUsersToSkillGroup(AddUsersToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUsersToSkillGroupWithOptions(request, runtime);
        }

        public async Task<AddUsersToSkillGroupResponse> AddUsersToSkillGroupAsync(AddUsersToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUsersToSkillGroupWithOptionsAsync(request, runtime);
        }

        public ListConfigItemsResponse ListConfigItemsWithOptions(ListConfigItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConfigItemsResponse>(DoRPCRequest("ListConfigItems", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListConfigItemsResponse> ListConfigItemsWithOptionsAsync(ListConfigItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConfigItemsResponse>(await DoRPCRequestAsync("ListConfigItems", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListConfigItemsResponse ListConfigItems(ListConfigItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigItemsWithOptions(request, runtime);
        }

        public async Task<ListConfigItemsResponse> ListConfigItemsAsync(ListConfigItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigItemsWithOptionsAsync(request, runtime);
        }

        public SignInGroupResponse SignInGroupWithOptions(SignInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SignInGroupResponse>(DoRPCRequest("SignInGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SignInGroupResponse> SignInGroupWithOptionsAsync(SignInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SignInGroupResponse>(await DoRPCRequestAsync("SignInGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SignInGroupResponse SignInGroup(SignInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SignInGroupWithOptions(request, runtime);
        }

        public async Task<SignInGroupResponse> SignInGroupAsync(SignInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SignInGroupWithOptionsAsync(request, runtime);
        }

        public GetRealtimeInstanceStatesResponse GetRealtimeInstanceStatesWithOptions(GetRealtimeInstanceStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRealtimeInstanceStatesResponse>(DoRPCRequest("GetRealtimeInstanceStates", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRealtimeInstanceStatesResponse> GetRealtimeInstanceStatesWithOptionsAsync(GetRealtimeInstanceStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRealtimeInstanceStatesResponse>(await DoRPCRequestAsync("GetRealtimeInstanceStates", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRealtimeInstanceStatesResponse GetRealtimeInstanceStates(GetRealtimeInstanceStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRealtimeInstanceStatesWithOptions(request, runtime);
        }

        public async Task<GetRealtimeInstanceStatesResponse> GetRealtimeInstanceStatesAsync(GetRealtimeInstanceStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRealtimeInstanceStatesWithOptionsAsync(request, runtime);
        }

        public ModifySkillGroupResponse ModifySkillGroupWithOptions(ModifySkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillGroupResponse>(DoRPCRequest("ModifySkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySkillGroupResponse> ModifySkillGroupWithOptionsAsync(ModifySkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillGroupResponse>(await DoRPCRequestAsync("ModifySkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySkillGroupResponse ModifySkillGroup(ModifySkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySkillGroupWithOptions(request, runtime);
        }

        public async Task<ModifySkillGroupResponse> ModifySkillGroupAsync(ModifySkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySkillGroupWithOptionsAsync(request, runtime);
        }

        public ModifyUserResponse ModifyUserWithOptions(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserResponse>(DoRPCRequest("ModifyUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserResponse> ModifyUserWithOptionsAsync(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserResponse>(await DoRPCRequestAsync("ModifyUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUserResponse ModifyUser(ModifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserWithOptions(request, runtime);
        }

        public async Task<ModifyUserResponse> ModifyUserAsync(ModifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserWithOptionsAsync(request, runtime);
        }

        public AddPhoneNumberToSkillGroupsResponse AddPhoneNumberToSkillGroupsWithOptions(AddPhoneNumberToSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPhoneNumberToSkillGroupsResponse>(DoRPCRequest("AddPhoneNumberToSkillGroups", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddPhoneNumberToSkillGroupsResponse> AddPhoneNumberToSkillGroupsWithOptionsAsync(AddPhoneNumberToSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPhoneNumberToSkillGroupsResponse>(await DoRPCRequestAsync("AddPhoneNumberToSkillGroups", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddPhoneNumberToSkillGroupsResponse AddPhoneNumberToSkillGroups(AddPhoneNumberToSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPhoneNumberToSkillGroupsWithOptions(request, runtime);
        }

        public async Task<AddPhoneNumberToSkillGroupsResponse> AddPhoneNumberToSkillGroupsAsync(AddPhoneNumberToSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPhoneNumberToSkillGroupsWithOptionsAsync(request, runtime);
        }

        public ListDevicesResponse ListDevicesWithOptions(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevicesResponse>(DoRPCRequest("ListDevices", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevicesResponse> ListDevicesWithOptionsAsync(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevicesResponse>(await DoRPCRequestAsync("ListDevices", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevicesWithOptions(request, runtime);
        }

        public async Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevicesWithOptionsAsync(request, runtime);
        }

        public RetrieveCallResponse RetrieveCallWithOptions(RetrieveCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetrieveCallResponse>(DoRPCRequest("RetrieveCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RetrieveCallResponse> RetrieveCallWithOptionsAsync(RetrieveCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetrieveCallResponse>(await DoRPCRequestAsync("RetrieveCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RetrieveCallResponse RetrieveCall(RetrieveCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetrieveCallWithOptions(request, runtime);
        }

        public async Task<RetrieveCallResponse> RetrieveCallAsync(RetrieveCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetrieveCallWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupsResponse ListSkillGroupsWithOptions(ListSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupsResponse>(DoRPCRequest("ListSkillGroups", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSkillGroupsResponse> ListSkillGroupsWithOptionsAsync(ListSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupsResponse>(await DoRPCRequestAsync("ListSkillGroups", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSkillGroupsResponse ListSkillGroups(ListSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupsWithOptions(request, runtime);
        }

        public async Task<ListSkillGroupsResponse> ListSkillGroupsAsync(ListSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupsWithOptionsAsync(request, runtime);
        }

        public HoldCallResponse HoldCallWithOptions(HoldCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HoldCallResponse>(DoRPCRequest("HoldCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HoldCallResponse> HoldCallWithOptionsAsync(HoldCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HoldCallResponse>(await DoRPCRequestAsync("HoldCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(DoRPCRequest("RegisterDevice", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(await DoRPCRequestAsync("RegisterDevice", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceWithOptions(request, runtime);
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceWithOptionsAsync(request, runtime);
        }

        public RemovePersonalNumbersFromUserResponse RemovePersonalNumbersFromUserWithOptions(RemovePersonalNumbersFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePersonalNumbersFromUserResponse>(DoRPCRequest("RemovePersonalNumbersFromUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemovePersonalNumbersFromUserResponse> RemovePersonalNumbersFromUserWithOptionsAsync(RemovePersonalNumbersFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePersonalNumbersFromUserResponse>(await DoRPCRequestAsync("RemovePersonalNumbersFromUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemovePersonalNumbersFromUserResponse RemovePersonalNumbersFromUser(RemovePersonalNumbersFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePersonalNumbersFromUserWithOptions(request, runtime);
        }

        public async Task<RemovePersonalNumbersFromUserResponse> RemovePersonalNumbersFromUserAsync(RemovePersonalNumbersFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePersonalNumbersFromUserWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceResponse ModifyInstanceWithOptions(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(DoRPCRequest("ModifyInstance", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await DoRPCRequestAsync("ModifyInstance", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        public ListOutboundNumbersOfUserResponse ListOutboundNumbersOfUserWithOptions(ListOutboundNumbersOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOutboundNumbersOfUserResponse>(DoRPCRequest("ListOutboundNumbersOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOutboundNumbersOfUserResponse> ListOutboundNumbersOfUserWithOptionsAsync(ListOutboundNumbersOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOutboundNumbersOfUserResponse>(await DoRPCRequestAsync("ListOutboundNumbersOfUser", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOutboundNumbersOfUserResponse ListOutboundNumbersOfUser(ListOutboundNumbersOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundNumbersOfUserWithOptions(request, runtime);
        }

        public async Task<ListOutboundNumbersOfUserResponse> ListOutboundNumbersOfUserAsync(ListOutboundNumbersOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundNumbersOfUserWithOptionsAsync(request, runtime);
        }

        public PollUserStatusResponse PollUserStatusWithOptions(PollUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PollUserStatusResponse>(DoRPCRequest("PollUserStatus", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PollUserStatusResponse> PollUserStatusWithOptionsAsync(PollUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PollUserStatusResponse>(await DoRPCRequestAsync("PollUserStatus", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PollUserStatusResponse PollUserStatus(PollUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PollUserStatusWithOptions(request, runtime);
        }

        public async Task<PollUserStatusResponse> PollUserStatusAsync(PollUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PollUserStatusWithOptionsAsync(request, runtime);
        }

        public ReadyForServiceResponse ReadyForServiceWithOptions(ReadyForServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReadyForServiceResponse>(DoRPCRequest("ReadyForService", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReadyForServiceResponse> ReadyForServiceWithOptionsAsync(ReadyForServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReadyForServiceResponse>(await DoRPCRequestAsync("ReadyForService", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReadyForServiceResponse ReadyForService(ReadyForServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadyForServiceWithOptions(request, runtime);
        }

        public async Task<ReadyForServiceResponse> ReadyForServiceAsync(ReadyForServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadyForServiceWithOptionsAsync(request, runtime);
        }

        public GetMultiChannelRecordingResponse GetMultiChannelRecordingWithOptions(GetMultiChannelRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultiChannelRecordingResponse>(DoRPCRequest("GetMultiChannelRecording", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMultiChannelRecordingResponse> GetMultiChannelRecordingWithOptionsAsync(GetMultiChannelRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultiChannelRecordingResponse>(await DoRPCRequestAsync("GetMultiChannelRecording", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMultiChannelRecordingResponse GetMultiChannelRecording(GetMultiChannelRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultiChannelRecordingWithOptions(request, runtime);
        }

        public async Task<GetMultiChannelRecordingResponse> GetMultiChannelRecordingAsync(GetMultiChannelRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultiChannelRecordingWithOptionsAsync(request, runtime);
        }

        public BargeInCallResponse BargeInCallWithOptions(BargeInCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BargeInCallResponse>(DoRPCRequest("BargeInCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BargeInCallResponse> BargeInCallWithOptionsAsync(BargeInCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BargeInCallResponse>(await DoRPCRequestAsync("BargeInCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BargeInCallResponse BargeInCall(BargeInCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BargeInCallWithOptions(request, runtime);
        }

        public async Task<BargeInCallResponse> BargeInCallAsync(BargeInCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BargeInCallWithOptionsAsync(request, runtime);
        }

        public ListPhoneNumbersOfSkillGroupResponse ListPhoneNumbersOfSkillGroupWithOptions(ListPhoneNumbersOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhoneNumbersOfSkillGroupResponse>(DoRPCRequest("ListPhoneNumbersOfSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhoneNumbersOfSkillGroupResponse> ListPhoneNumbersOfSkillGroupWithOptionsAsync(ListPhoneNumbersOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhoneNumbersOfSkillGroupResponse>(await DoRPCRequestAsync("ListPhoneNumbersOfSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhoneNumbersOfSkillGroupResponse ListPhoneNumbersOfSkillGroup(ListPhoneNumbersOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhoneNumbersOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ListPhoneNumbersOfSkillGroupResponse> ListPhoneNumbersOfSkillGroupAsync(ListPhoneNumbersOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhoneNumbersOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public SignOutGroupResponse SignOutGroupWithOptions(SignOutGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SignOutGroupResponse>(DoRPCRequest("SignOutGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SignOutGroupResponse> SignOutGroupWithOptionsAsync(SignOutGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SignOutGroupResponse>(await DoRPCRequestAsync("SignOutGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SignOutGroupResponse SignOutGroup(SignOutGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SignOutGroupWithOptions(request, runtime);
        }

        public async Task<SignOutGroupResponse> SignOutGroupAsync(SignOutGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SignOutGroupWithOptionsAsync(request, runtime);
        }

        public SaveRTCStatsV2Response SaveRTCStatsV2WithOptions(SaveRTCStatsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveRTCStatsV2Response>(DoRPCRequest("SaveRTCStatsV2", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveRTCStatsV2Response> SaveRTCStatsV2WithOptionsAsync(SaveRTCStatsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveRTCStatsV2Response>(await DoRPCRequestAsync("SaveRTCStatsV2", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveRTCStatsV2Response SaveRTCStatsV2(SaveRTCStatsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRTCStatsV2WithOptions(request, runtime);
        }

        public async Task<SaveRTCStatsV2Response> SaveRTCStatsV2Async(SaveRTCStatsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRTCStatsV2WithOptionsAsync(request, runtime);
        }

        public GetHistoricalCallerReportResponse GetHistoricalCallerReportWithOptions(GetHistoricalCallerReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHistoricalCallerReportResponse>(DoRPCRequest("GetHistoricalCallerReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHistoricalCallerReportResponse> GetHistoricalCallerReportWithOptionsAsync(GetHistoricalCallerReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHistoricalCallerReportResponse>(await DoRPCRequestAsync("GetHistoricalCallerReport", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHistoricalCallerReportResponse GetHistoricalCallerReport(GetHistoricalCallerReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistoricalCallerReportWithOptions(request, runtime);
        }

        public async Task<GetHistoricalCallerReportResponse> GetHistoricalCallerReportAsync(GetHistoricalCallerReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistoricalCallerReportWithOptionsAsync(request, runtime);
        }

        public ModifyUserLevelsOfSkillGroupResponse ModifyUserLevelsOfSkillGroupWithOptions(ModifyUserLevelsOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserLevelsOfSkillGroupResponse>(DoRPCRequest("ModifyUserLevelsOfSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserLevelsOfSkillGroupResponse> ModifyUserLevelsOfSkillGroupWithOptionsAsync(ModifyUserLevelsOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserLevelsOfSkillGroupResponse>(await DoRPCRequestAsync("ModifyUserLevelsOfSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUserLevelsOfSkillGroupResponse ModifyUserLevelsOfSkillGroup(ModifyUserLevelsOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserLevelsOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ModifyUserLevelsOfSkillGroupResponse> ModifyUserLevelsOfSkillGroupAsync(ModifyUserLevelsOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserLevelsOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public SaveTerminalLogResponse SaveTerminalLogWithOptions(SaveTerminalLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTerminalLogResponse>(DoRPCRequest("SaveTerminalLog", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveTerminalLogResponse> SaveTerminalLogWithOptionsAsync(SaveTerminalLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTerminalLogResponse>(await DoRPCRequestAsync("SaveTerminalLog", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveTerminalLogResponse SaveTerminalLog(SaveTerminalLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTerminalLogWithOptions(request, runtime);
        }

        public async Task<SaveTerminalLogResponse> SaveTerminalLogAsync(SaveTerminalLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTerminalLogWithOptionsAsync(request, runtime);
        }

        public ListRealtimeSkillGroupStatesResponse ListRealtimeSkillGroupStatesWithOptions(ListRealtimeSkillGroupStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRealtimeSkillGroupStatesResponse>(DoRPCRequest("ListRealtimeSkillGroupStates", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRealtimeSkillGroupStatesResponse> ListRealtimeSkillGroupStatesWithOptionsAsync(ListRealtimeSkillGroupStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRealtimeSkillGroupStatesResponse>(await DoRPCRequestAsync("ListRealtimeSkillGroupStates", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRealtimeSkillGroupStatesResponse ListRealtimeSkillGroupStates(ListRealtimeSkillGroupStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealtimeSkillGroupStatesWithOptions(request, runtime);
        }

        public async Task<ListRealtimeSkillGroupStatesResponse> ListRealtimeSkillGroupStatesAsync(ListRealtimeSkillGroupStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealtimeSkillGroupStatesWithOptionsAsync(request, runtime);
        }

        public CreateSkillGroupResponse CreateSkillGroupWithOptions(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(DoRPCRequest("CreateSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSkillGroupResponse> CreateSkillGroupWithOptionsAsync(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(await DoRPCRequestAsync("CreateSkillGroup", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public PickOutboundNumbersResponse PickOutboundNumbersWithOptions(PickOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PickOutboundNumbersResponse>(DoRPCRequest("PickOutboundNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PickOutboundNumbersResponse> PickOutboundNumbersWithOptionsAsync(PickOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PickOutboundNumbersResponse>(await DoRPCRequestAsync("PickOutboundNumbers", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PickOutboundNumbersResponse PickOutboundNumbers(PickOutboundNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PickOutboundNumbersWithOptions(request, runtime);
        }

        public async Task<PickOutboundNumbersResponse> PickOutboundNumbersAsync(PickOutboundNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PickOutboundNumbersWithOptionsAsync(request, runtime);
        }

        public ReleaseCallResponse ReleaseCallWithOptions(ReleaseCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseCallResponse>(DoRPCRequest("ReleaseCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseCallResponse> ReleaseCallWithOptionsAsync(ReleaseCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseCallResponse>(await DoRPCRequestAsync("ReleaseCall", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseCallResponse ReleaseCall(ReleaseCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseCallWithOptions(request, runtime);
        }

        public async Task<ReleaseCallResponse> ReleaseCallAsync(ReleaseCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseCallWithOptionsAsync(request, runtime);
        }

        public GetLoginDetailsResponse GetLoginDetailsWithOptions(GetLoginDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLoginDetailsResponse>(DoRPCRequest("GetLoginDetails", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLoginDetailsResponse> GetLoginDetailsWithOptionsAsync(GetLoginDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLoginDetailsResponse>(await DoRPCRequestAsync("GetLoginDetails", "2020-07-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLoginDetailsResponse GetLoginDetails(GetLoginDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginDetailsWithOptions(request, runtime);
        }

        public async Task<GetLoginDetailsResponse> GetLoginDetailsAsync(GetLoginDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginDetailsWithOptionsAsync(request, runtime);
        }

    }
}
