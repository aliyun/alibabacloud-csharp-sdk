// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Devops_rdc20200303.Models;

namespace AlibabaCloud.SDK.Devops_rdc20200303
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("devops-rdc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public InsertPipelineMemberResponse InsertPipelineMemberWithOptions(InsertPipelineMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertPipelineMemberResponse>(DoRPCRequest("InsertPipelineMember", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InsertPipelineMemberResponse> InsertPipelineMemberWithOptionsAsync(InsertPipelineMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertPipelineMemberResponse>(await DoRPCRequestAsync("InsertPipelineMember", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InsertPipelineMemberResponse InsertPipelineMember(InsertPipelineMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertPipelineMemberWithOptions(request, runtime);
        }

        public async Task<InsertPipelineMemberResponse> InsertPipelineMemberAsync(InsertPipelineMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertPipelineMemberWithOptionsAsync(request, runtime);
        }

        public ListDevopsProjectTaskFlowResponse ListDevopsProjectTaskFlowWithOptions(ListDevopsProjectTaskFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectTaskFlowResponse>(DoRPCRequest("ListDevopsProjectTaskFlow", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevopsProjectTaskFlowResponse> ListDevopsProjectTaskFlowWithOptionsAsync(ListDevopsProjectTaskFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectTaskFlowResponse>(await DoRPCRequestAsync("ListDevopsProjectTaskFlow", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevopsProjectTaskFlowResponse ListDevopsProjectTaskFlow(ListDevopsProjectTaskFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevopsProjectTaskFlowWithOptions(request, runtime);
        }

        public async Task<ListDevopsProjectTaskFlowResponse> ListDevopsProjectTaskFlowAsync(ListDevopsProjectTaskFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevopsProjectTaskFlowWithOptionsAsync(request, runtime);
        }

        public GetDevopsProjectMembersResponse GetDevopsProjectMembersWithOptions(GetDevopsProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsProjectMembersResponse>(DoRPCRequest("GetDevopsProjectMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDevopsProjectMembersResponse> GetDevopsProjectMembersWithOptionsAsync(GetDevopsProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsProjectMembersResponse>(await DoRPCRequestAsync("GetDevopsProjectMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDevopsProjectMembersResponse GetDevopsProjectMembers(GetDevopsProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDevopsProjectMembersWithOptions(request, runtime);
        }

        public async Task<GetDevopsProjectMembersResponse> GetDevopsProjectMembersAsync(GetDevopsProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDevopsProjectMembersWithOptionsAsync(request, runtime);
        }

        public AddCodeupSourceToPipelineResponse AddCodeupSourceToPipelineWithOptions(AddCodeupSourceToPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCodeupSourceToPipelineResponse>(DoRPCRequest("AddCodeupSourceToPipeline", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCodeupSourceToPipelineResponse> AddCodeupSourceToPipelineWithOptionsAsync(AddCodeupSourceToPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCodeupSourceToPipelineResponse>(await DoRPCRequestAsync("AddCodeupSourceToPipeline", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCodeupSourceToPipelineResponse AddCodeupSourceToPipeline(AddCodeupSourceToPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCodeupSourceToPipelineWithOptions(request, runtime);
        }

        public async Task<AddCodeupSourceToPipelineResponse> AddCodeupSourceToPipelineAsync(AddCodeupSourceToPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCodeupSourceToPipelineWithOptionsAsync(request, runtime);
        }

        public DeleteDevopsProjectSprintResponse DeleteDevopsProjectSprintWithOptions(DeleteDevopsProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsProjectSprintResponse>(DoRPCRequest("DeleteDevopsProjectSprint", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDevopsProjectSprintResponse> DeleteDevopsProjectSprintWithOptionsAsync(DeleteDevopsProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsProjectSprintResponse>(await DoRPCRequestAsync("DeleteDevopsProjectSprint", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDevopsProjectSprintResponse DeleteDevopsProjectSprint(DeleteDevopsProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevopsProjectSprintWithOptions(request, runtime);
        }

        public async Task<DeleteDevopsProjectSprintResponse> DeleteDevopsProjectSprintAsync(DeleteDevopsProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevopsProjectSprintWithOptionsAsync(request, runtime);
        }

        public DeleteCommonGroupResponse DeleteCommonGroupWithOptions(DeleteCommonGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCommonGroupResponse>(DoRPCRequest("DeleteCommonGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCommonGroupResponse> DeleteCommonGroupWithOptionsAsync(DeleteCommonGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCommonGroupResponse>(await DoRPCRequestAsync("DeleteCommonGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCommonGroupResponse DeleteCommonGroup(DeleteCommonGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCommonGroupWithOptions(request, runtime);
        }

        public async Task<DeleteCommonGroupResponse> DeleteCommonGroupAsync(DeleteCommonGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCommonGroupWithOptionsAsync(request, runtime);
        }

        public ListProjectCustomFieldsResponse ListProjectCustomFieldsWithOptions(ListProjectCustomFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectCustomFieldsResponse>(DoRPCRequest("ListProjectCustomFields", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectCustomFieldsResponse> ListProjectCustomFieldsWithOptionsAsync(ListProjectCustomFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectCustomFieldsResponse>(await DoRPCRequestAsync("ListProjectCustomFields", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectCustomFieldsResponse ListProjectCustomFields(ListProjectCustomFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectCustomFieldsWithOptions(request, runtime);
        }

        public async Task<ListProjectCustomFieldsResponse> ListProjectCustomFieldsAsync(ListProjectCustomFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectCustomFieldsWithOptionsAsync(request, runtime);
        }

        public InsertDevopsUserResponse InsertDevopsUserWithOptions(InsertDevopsUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertDevopsUserResponse>(DoRPCRequest("InsertDevopsUser", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InsertDevopsUserResponse> InsertDevopsUserWithOptionsAsync(InsertDevopsUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertDevopsUserResponse>(await DoRPCRequestAsync("InsertDevopsUser", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InsertDevopsUserResponse InsertDevopsUser(InsertDevopsUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertDevopsUserWithOptions(request, runtime);
        }

        public async Task<InsertDevopsUserResponse> InsertDevopsUserAsync(InsertDevopsUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertDevopsUserWithOptionsAsync(request, runtime);
        }

        public UpdateDevopsProjectResponse UpdateDevopsProjectWithOptions(UpdateDevopsProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDevopsProjectResponse>(DoRPCRequest("UpdateDevopsProject", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDevopsProjectResponse> UpdateDevopsProjectWithOptionsAsync(UpdateDevopsProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDevopsProjectResponse>(await DoRPCRequestAsync("UpdateDevopsProject", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDevopsProjectResponse UpdateDevopsProject(UpdateDevopsProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDevopsProjectWithOptions(request, runtime);
        }

        public async Task<UpdateDevopsProjectResponse> UpdateDevopsProjectAsync(UpdateDevopsProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDevopsProjectWithOptionsAsync(request, runtime);
        }

        public CheckAliyunAccountExistsResponse CheckAliyunAccountExistsWithOptions(CheckAliyunAccountExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckAliyunAccountExistsResponse>(DoRPCRequest("CheckAliyunAccountExists", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckAliyunAccountExistsResponse> CheckAliyunAccountExistsWithOptionsAsync(CheckAliyunAccountExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckAliyunAccountExistsResponse>(await DoRPCRequestAsync("CheckAliyunAccountExists", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckAliyunAccountExistsResponse CheckAliyunAccountExists(CheckAliyunAccountExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAliyunAccountExistsWithOptions(request, runtime);
        }

        public async Task<CheckAliyunAccountExistsResponse> CheckAliyunAccountExistsAsync(CheckAliyunAccountExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAliyunAccountExistsWithOptionsAsync(request, runtime);
        }

        public GetPipelineInstanceInfoResponse GetPipelineInstanceInfoWithOptions(GetPipelineInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstanceInfoResponse>(DoRPCRequest("GetPipelineInstanceInfo", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPipelineInstanceInfoResponse> GetPipelineInstanceInfoWithOptionsAsync(GetPipelineInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstanceInfoResponse>(await DoRPCRequestAsync("GetPipelineInstanceInfo", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPipelineInstanceInfoResponse GetPipelineInstanceInfo(GetPipelineInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineInstanceInfoWithOptions(request, runtime);
        }

        public async Task<GetPipelineInstanceInfoResponse> GetPipelineInstanceInfoAsync(GetPipelineInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineInstanceInfoWithOptionsAsync(request, runtime);
        }

        public BatchInsertMembersResponse BatchInsertMembersWithOptions(BatchInsertMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchInsertMembersResponse>(DoRPCRequest("BatchInsertMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchInsertMembersResponse> BatchInsertMembersWithOptionsAsync(BatchInsertMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchInsertMembersResponse>(await DoRPCRequestAsync("BatchInsertMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchInsertMembersResponse BatchInsertMembers(BatchInsertMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchInsertMembersWithOptions(request, runtime);
        }

        public async Task<BatchInsertMembersResponse> BatchInsertMembersAsync(BatchInsertMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchInsertMembersWithOptionsAsync(request, runtime);
        }

        public ListServiceConnectionsResponse ListServiceConnectionsWithOptions(ListServiceConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServiceConnectionsResponse>(DoRPCRequest("ListServiceConnections", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListServiceConnectionsResponse> ListServiceConnectionsWithOptionsAsync(ListServiceConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServiceConnectionsResponse>(await DoRPCRequestAsync("ListServiceConnections", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListServiceConnectionsResponse ListServiceConnections(ListServiceConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceConnectionsWithOptions(request, runtime);
        }

        public async Task<ListServiceConnectionsResponse> ListServiceConnectionsAsync(ListServiceConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceConnectionsWithOptionsAsync(request, runtime);
        }

        public GetUserNameResponse GetUserNameWithOptions(GetUserNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserNameResponse>(DoRPCRequest("GetUserName", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserNameResponse> GetUserNameWithOptionsAsync(GetUserNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserNameResponse>(await DoRPCRequestAsync("GetUserName", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserNameResponse GetUserName(GetUserNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserNameWithOptions(request, runtime);
        }

        public async Task<GetUserNameResponse> GetUserNameAsync(GetUserNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserNameWithOptionsAsync(request, runtime);
        }

        public InsertProjectMembersResponse InsertProjectMembersWithOptions(InsertProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertProjectMembersResponse>(DoRPCRequest("InsertProjectMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InsertProjectMembersResponse> InsertProjectMembersWithOptionsAsync(InsertProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertProjectMembersResponse>(await DoRPCRequestAsync("InsertProjectMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InsertProjectMembersResponse InsertProjectMembers(InsertProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertProjectMembersWithOptions(request, runtime);
        }

        public async Task<InsertProjectMembersResponse> InsertProjectMembersAsync(InsertProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertProjectMembersWithOptionsAsync(request, runtime);
        }

        public ListDevopsProjectTaskListResponse ListDevopsProjectTaskListWithOptions(ListDevopsProjectTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectTaskListResponse>(DoRPCRequest("ListDevopsProjectTaskList", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevopsProjectTaskListResponse> ListDevopsProjectTaskListWithOptionsAsync(ListDevopsProjectTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectTaskListResponse>(await DoRPCRequestAsync("ListDevopsProjectTaskList", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevopsProjectTaskListResponse ListDevopsProjectTaskList(ListDevopsProjectTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevopsProjectTaskListWithOptions(request, runtime);
        }

        public async Task<ListDevopsProjectTaskListResponse> ListDevopsProjectTaskListAsync(ListDevopsProjectTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevopsProjectTaskListWithOptionsAsync(request, runtime);
        }

        public GetTaskDetailBaseResponse GetTaskDetailBaseWithOptions(GetTaskDetailBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskDetailBaseResponse>(DoRPCRequest("GetTaskDetailBase", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskDetailBaseResponse> GetTaskDetailBaseWithOptionsAsync(GetTaskDetailBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskDetailBaseResponse>(await DoRPCRequestAsync("GetTaskDetailBase", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTaskDetailBaseResponse GetTaskDetailBase(GetTaskDetailBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskDetailBaseWithOptions(request, runtime);
        }

        public async Task<GetTaskDetailBaseResponse> GetTaskDetailBaseAsync(GetTaskDetailBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskDetailBaseWithOptionsAsync(request, runtime);
        }

        public DeleteDevopsProjectMembersResponse DeleteDevopsProjectMembersWithOptions(DeleteDevopsProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsProjectMembersResponse>(DoRPCRequest("DeleteDevopsProjectMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDevopsProjectMembersResponse> DeleteDevopsProjectMembersWithOptionsAsync(DeleteDevopsProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsProjectMembersResponse>(await DoRPCRequestAsync("DeleteDevopsProjectMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDevopsProjectMembersResponse DeleteDevopsProjectMembers(DeleteDevopsProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevopsProjectMembersWithOptions(request, runtime);
        }

        public async Task<DeleteDevopsProjectMembersResponse> DeleteDevopsProjectMembersAsync(DeleteDevopsProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevopsProjectMembersWithOptionsAsync(request, runtime);
        }

        public CreateDevopsProjectSprintResponse CreateDevopsProjectSprintWithOptions(CreateDevopsProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsProjectSprintResponse>(DoRPCRequest("CreateDevopsProjectSprint", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDevopsProjectSprintResponse> CreateDevopsProjectSprintWithOptionsAsync(CreateDevopsProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsProjectSprintResponse>(await DoRPCRequestAsync("CreateDevopsProjectSprint", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDevopsProjectSprintResponse CreateDevopsProjectSprint(CreateDevopsProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDevopsProjectSprintWithOptions(request, runtime);
        }

        public async Task<CreateDevopsProjectSprintResponse> CreateDevopsProjectSprintAsync(CreateDevopsProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDevopsProjectSprintWithOptionsAsync(request, runtime);
        }

        public UpdateDevopsProjectSprintResponse UpdateDevopsProjectSprintWithOptions(UpdateDevopsProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDevopsProjectSprintResponse>(DoRPCRequest("UpdateDevopsProjectSprint", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDevopsProjectSprintResponse> UpdateDevopsProjectSprintWithOptionsAsync(UpdateDevopsProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDevopsProjectSprintResponse>(await DoRPCRequestAsync("UpdateDevopsProjectSprint", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDevopsProjectSprintResponse UpdateDevopsProjectSprint(UpdateDevopsProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDevopsProjectSprintWithOptions(request, runtime);
        }

        public async Task<UpdateDevopsProjectSprintResponse> UpdateDevopsProjectSprintAsync(UpdateDevopsProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDevopsProjectSprintWithOptionsAsync(request, runtime);
        }

        public DeleteDevopsOrganizationResponse DeleteDevopsOrganizationWithOptions(DeleteDevopsOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsOrganizationResponse>(DoRPCRequest("DeleteDevopsOrganization", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDevopsOrganizationResponse> DeleteDevopsOrganizationWithOptionsAsync(DeleteDevopsOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsOrganizationResponse>(await DoRPCRequestAsync("DeleteDevopsOrganization", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDevopsOrganizationResponse DeleteDevopsOrganization(DeleteDevopsOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevopsOrganizationWithOptions(request, runtime);
        }

        public async Task<DeleteDevopsOrganizationResponse> DeleteDevopsOrganizationAsync(DeleteDevopsOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevopsOrganizationWithOptionsAsync(request, runtime);
        }

        public CancelPipelineResponse CancelPipelineWithOptions(CancelPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPipelineResponse>(DoRPCRequest("CancelPipeline", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelPipelineResponse> CancelPipelineWithOptionsAsync(CancelPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPipelineResponse>(await DoRPCRequestAsync("CancelPipeline", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelPipelineResponse CancelPipeline(CancelPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPipelineWithOptions(request, runtime);
        }

        public async Task<CancelPipelineResponse> CancelPipelineAsync(CancelPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPipelineWithOptionsAsync(request, runtime);
        }

        public ListDevopsProjectTaskFlowStatusResponse ListDevopsProjectTaskFlowStatusWithOptions(ListDevopsProjectTaskFlowStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectTaskFlowStatusResponse>(DoRPCRequest("ListDevopsProjectTaskFlowStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevopsProjectTaskFlowStatusResponse> ListDevopsProjectTaskFlowStatusWithOptionsAsync(ListDevopsProjectTaskFlowStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectTaskFlowStatusResponse>(await DoRPCRequestAsync("ListDevopsProjectTaskFlowStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevopsProjectTaskFlowStatusResponse ListDevopsProjectTaskFlowStatus(ListDevopsProjectTaskFlowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevopsProjectTaskFlowStatusWithOptions(request, runtime);
        }

        public async Task<ListDevopsProjectTaskFlowStatusResponse> ListDevopsProjectTaskFlowStatusAsync(ListDevopsProjectTaskFlowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevopsProjectTaskFlowStatusWithOptionsAsync(request, runtime);
        }

        public ListUserOrganizationResponse ListUserOrganizationWithOptions(ListUserOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserOrganizationResponse>(DoRPCRequest("ListUserOrganization", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserOrganizationResponse> ListUserOrganizationWithOptionsAsync(ListUserOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserOrganizationResponse>(await DoRPCRequestAsync("ListUserOrganization", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserOrganizationResponse ListUserOrganization(ListUserOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserOrganizationWithOptions(request, runtime);
        }

        public async Task<ListUserOrganizationResponse> ListUserOrganizationAsync(ListUserOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserOrganizationWithOptionsAsync(request, runtime);
        }

        public UpdatePipelineEnvVarsResponse UpdatePipelineEnvVarsWithOptions(UpdatePipelineEnvVarsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePipelineEnvVarsResponse>(DoRPCRequest("UpdatePipelineEnvVars", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePipelineEnvVarsResponse> UpdatePipelineEnvVarsWithOptionsAsync(UpdatePipelineEnvVarsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePipelineEnvVarsResponse>(await DoRPCRequestAsync("UpdatePipelineEnvVars", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePipelineEnvVarsResponse UpdatePipelineEnvVars(UpdatePipelineEnvVarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePipelineEnvVarsWithOptions(request, runtime);
        }

        public async Task<UpdatePipelineEnvVarsResponse> UpdatePipelineEnvVarsAsync(UpdatePipelineEnvVarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePipelineEnvVarsWithOptionsAsync(request, runtime);
        }

        public DeleteDevopsProjectResponse DeleteDevopsProjectWithOptions(DeleteDevopsProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsProjectResponse>(DoRPCRequest("DeleteDevopsProject", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDevopsProjectResponse> DeleteDevopsProjectWithOptionsAsync(DeleteDevopsProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsProjectResponse>(await DoRPCRequestAsync("DeleteDevopsProject", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDevopsProjectResponse DeleteDevopsProject(DeleteDevopsProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevopsProjectWithOptions(request, runtime);
        }

        public async Task<DeleteDevopsProjectResponse> DeleteDevopsProjectAsync(DeleteDevopsProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevopsProjectWithOptionsAsync(request, runtime);
        }

        public GetPipelineInstanceStatusResponse GetPipelineInstanceStatusWithOptions(GetPipelineInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstanceStatusResponse>(DoRPCRequest("GetPipelineInstanceStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPipelineInstanceStatusResponse> GetPipelineInstanceStatusWithOptionsAsync(GetPipelineInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstanceStatusResponse>(await DoRPCRequestAsync("GetPipelineInstanceStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPipelineInstanceStatusResponse GetPipelineInstanceStatus(GetPipelineInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineInstanceStatusWithOptions(request, runtime);
        }

        public async Task<GetPipelineInstanceStatusResponse> GetPipelineInstanceStatusAsync(GetPipelineInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineInstanceStatusWithOptionsAsync(request, runtime);
        }

        public GetPipelineLogResponse GetPipelineLogWithOptions(GetPipelineLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineLogResponse>(DoRPCRequest("GetPipelineLog", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPipelineLogResponse> GetPipelineLogWithOptionsAsync(GetPipelineLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineLogResponse>(await DoRPCRequestAsync("GetPipelineLog", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPipelineLogResponse GetPipelineLog(GetPipelineLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineLogWithOptions(request, runtime);
        }

        public async Task<GetPipelineLogResponse> GetPipelineLogAsync(GetPipelineLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineLogWithOptionsAsync(request, runtime);
        }

        public GetUserByAliyunUidResponse GetUserByAliyunUidWithOptions(GetUserByAliyunUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserByAliyunUidResponse>(DoRPCRequest("GetUserByAliyunUid", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserByAliyunUidResponse> GetUserByAliyunUidWithOptionsAsync(GetUserByAliyunUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserByAliyunUidResponse>(await DoRPCRequestAsync("GetUserByAliyunUid", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserByAliyunUidResponse GetUserByAliyunUid(GetUserByAliyunUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserByAliyunUidWithOptions(request, runtime);
        }

        public async Task<GetUserByAliyunUidResponse> GetUserByAliyunUidAsync(GetUserByAliyunUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserByAliyunUidWithOptionsAsync(request, runtime);
        }

        public UpdatePipelineMemberResponse UpdatePipelineMemberWithOptions(UpdatePipelineMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePipelineMemberResponse>(DoRPCRequest("UpdatePipelineMember", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePipelineMemberResponse> UpdatePipelineMemberWithOptionsAsync(UpdatePipelineMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePipelineMemberResponse>(await DoRPCRequestAsync("UpdatePipelineMember", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePipelineMemberResponse UpdatePipelineMember(UpdatePipelineMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePipelineMemberWithOptions(request, runtime);
        }

        public async Task<UpdatePipelineMemberResponse> UpdatePipelineMemberAsync(UpdatePipelineMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePipelineMemberWithOptionsAsync(request, runtime);
        }

        public ListDevopsProjectsResponse ListDevopsProjectsWithOptions(ListDevopsProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectsResponse>(DoRPCRequest("ListDevopsProjects", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevopsProjectsResponse> ListDevopsProjectsWithOptionsAsync(ListDevopsProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectsResponse>(await DoRPCRequestAsync("ListDevopsProjects", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevopsProjectsResponse ListDevopsProjects(ListDevopsProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevopsProjectsWithOptions(request, runtime);
        }

        public async Task<ListDevopsProjectsResponse> ListDevopsProjectsAsync(ListDevopsProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevopsProjectsWithOptionsAsync(request, runtime);
        }

        public CreateDevopsProjectTaskResponse CreateDevopsProjectTaskWithOptions(CreateDevopsProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsProjectTaskResponse>(DoRPCRequest("CreateDevopsProjectTask", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDevopsProjectTaskResponse> CreateDevopsProjectTaskWithOptionsAsync(CreateDevopsProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsProjectTaskResponse>(await DoRPCRequestAsync("CreateDevopsProjectTask", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDevopsProjectTaskResponse CreateDevopsProjectTask(CreateDevopsProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDevopsProjectTaskWithOptions(request, runtime);
        }

        public async Task<CreateDevopsProjectTaskResponse> CreateDevopsProjectTaskAsync(CreateDevopsProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDevopsProjectTaskWithOptionsAsync(request, runtime);
        }

        public GetPipelineInstanceBuildNumberStatusResponse GetPipelineInstanceBuildNumberStatusWithOptions(GetPipelineInstanceBuildNumberStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstanceBuildNumberStatusResponse>(DoRPCRequest("GetPipelineInstanceBuildNumberStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPipelineInstanceBuildNumberStatusResponse> GetPipelineInstanceBuildNumberStatusWithOptionsAsync(GetPipelineInstanceBuildNumberStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstanceBuildNumberStatusResponse>(await DoRPCRequestAsync("GetPipelineInstanceBuildNumberStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPipelineInstanceBuildNumberStatusResponse GetPipelineInstanceBuildNumberStatus(GetPipelineInstanceBuildNumberStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineInstanceBuildNumberStatusWithOptions(request, runtime);
        }

        public async Task<GetPipelineInstanceBuildNumberStatusResponse> GetPipelineInstanceBuildNumberStatusAsync(GetPipelineInstanceBuildNumberStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineInstanceBuildNumberStatusWithOptionsAsync(request, runtime);
        }

        public ListDevopsProjectSprintsResponse ListDevopsProjectSprintsWithOptions(ListDevopsProjectSprintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectSprintsResponse>(DoRPCRequest("ListDevopsProjectSprints", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevopsProjectSprintsResponse> ListDevopsProjectSprintsWithOptionsAsync(ListDevopsProjectSprintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectSprintsResponse>(await DoRPCRequestAsync("ListDevopsProjectSprints", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevopsProjectSprintsResponse ListDevopsProjectSprints(ListDevopsProjectSprintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevopsProjectSprintsWithOptions(request, runtime);
        }

        public async Task<ListDevopsProjectSprintsResponse> ListDevopsProjectSprintsAsync(ListDevopsProjectSprintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevopsProjectSprintsWithOptionsAsync(request, runtime);
        }

        public GetDevopsProjectInfoResponse GetDevopsProjectInfoWithOptions(GetDevopsProjectInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsProjectInfoResponse>(DoRPCRequest("GetDevopsProjectInfo", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDevopsProjectInfoResponse> GetDevopsProjectInfoWithOptionsAsync(GetDevopsProjectInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsProjectInfoResponse>(await DoRPCRequestAsync("GetDevopsProjectInfo", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDevopsProjectInfoResponse GetDevopsProjectInfo(GetDevopsProjectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDevopsProjectInfoWithOptions(request, runtime);
        }

        public async Task<GetDevopsProjectInfoResponse> GetDevopsProjectInfoAsync(GetDevopsProjectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDevopsProjectInfoWithOptionsAsync(request, runtime);
        }

        public DeletePipelineMemberResponse DeletePipelineMemberWithOptions(DeletePipelineMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePipelineMemberResponse>(DoRPCRequest("DeletePipelineMember", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePipelineMemberResponse> DeletePipelineMemberWithOptionsAsync(DeletePipelineMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePipelineMemberResponse>(await DoRPCRequestAsync("DeletePipelineMember", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePipelineMemberResponse DeletePipelineMember(DeletePipelineMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePipelineMemberWithOptions(request, runtime);
        }

        public async Task<DeletePipelineMemberResponse> DeletePipelineMemberAsync(DeletePipelineMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePipelineMemberWithOptionsAsync(request, runtime);
        }

        public GetDevopsProjectSprintInfoResponse GetDevopsProjectSprintInfoWithOptions(GetDevopsProjectSprintInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsProjectSprintInfoResponse>(DoRPCRequest("GetDevopsProjectSprintInfo", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDevopsProjectSprintInfoResponse> GetDevopsProjectSprintInfoWithOptionsAsync(GetDevopsProjectSprintInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsProjectSprintInfoResponse>(await DoRPCRequestAsync("GetDevopsProjectSprintInfo", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDevopsProjectSprintInfoResponse GetDevopsProjectSprintInfo(GetDevopsProjectSprintInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDevopsProjectSprintInfoWithOptions(request, runtime);
        }

        public async Task<GetDevopsProjectSprintInfoResponse> GetDevopsProjectSprintInfoAsync(GetDevopsProjectSprintInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDevopsProjectSprintInfoWithOptionsAsync(request, runtime);
        }

        public DeleteDevopsOrganizationMembersResponse DeleteDevopsOrganizationMembersWithOptions(DeleteDevopsOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsOrganizationMembersResponse>(DoRPCRequest("DeleteDevopsOrganizationMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDevopsOrganizationMembersResponse> DeleteDevopsOrganizationMembersWithOptionsAsync(DeleteDevopsOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsOrganizationMembersResponse>(await DoRPCRequestAsync("DeleteDevopsOrganizationMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDevopsOrganizationMembersResponse DeleteDevopsOrganizationMembers(DeleteDevopsOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevopsOrganizationMembersWithOptions(request, runtime);
        }

        public async Task<DeleteDevopsOrganizationMembersResponse> DeleteDevopsOrganizationMembersAsync(DeleteDevopsOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevopsOrganizationMembersWithOptionsAsync(request, runtime);
        }

        public GetLastWorkspaceResponse GetLastWorkspaceWithOptions(GetLastWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLastWorkspaceResponse>(DoRPCRequest("GetLastWorkspace", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLastWorkspaceResponse> GetLastWorkspaceWithOptionsAsync(GetLastWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLastWorkspaceResponse>(await DoRPCRequestAsync("GetLastWorkspace", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLastWorkspaceResponse GetLastWorkspace(GetLastWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLastWorkspaceWithOptions(request, runtime);
        }

        public async Task<GetLastWorkspaceResponse> GetLastWorkspaceAsync(GetLastWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLastWorkspaceWithOptionsAsync(request, runtime);
        }

        public CreateCredentialResponse CreateCredentialWithOptions(CreateCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCredentialResponse>(DoRPCRequest("CreateCredential", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCredentialResponse> CreateCredentialWithOptionsAsync(CreateCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCredentialResponse>(await DoRPCRequestAsync("CreateCredential", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCredentialResponse CreateCredential(CreateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCredentialWithOptions(request, runtime);
        }

        public async Task<CreateCredentialResponse> CreateCredentialAsync(CreateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCredentialWithOptionsAsync(request, runtime);
        }

        public ListCredentialsResponse ListCredentialsWithOptions(ListCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCredentialsResponse>(DoRPCRequest("ListCredentials", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCredentialsResponse> ListCredentialsWithOptionsAsync(ListCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCredentialsResponse>(await DoRPCRequestAsync("ListCredentials", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCredentialsResponse ListCredentials(ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCredentialsWithOptions(request, runtime);
        }

        public async Task<ListCredentialsResponse> ListCredentialsAsync(ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCredentialsWithOptionsAsync(request, runtime);
        }

        public CreatePipelineResponse CreatePipelineWithOptions(CreatePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePipelineResponse>(DoRPCRequest("CreatePipeline", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePipelineResponse> CreatePipelineWithOptionsAsync(CreatePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePipelineResponse>(await DoRPCRequestAsync("CreatePipeline", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePipelineWithOptions(request, runtime);
        }

        public async Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePipelineWithOptionsAsync(request, runtime);
        }

        public ListPipelinesResponse ListPipelinesWithOptions(ListPipelinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPipelinesResponse>(DoRPCRequest("ListPipelines", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPipelinesResponse> ListPipelinesWithOptionsAsync(ListPipelinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPipelinesResponse>(await DoRPCRequestAsync("ListPipelines", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPipelinesWithOptions(request, runtime);
        }

        public async Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPipelinesWithOptionsAsync(request, runtime);
        }

        public CreatePipelineFromTemplateResponse CreatePipelineFromTemplateWithOptions(CreatePipelineFromTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePipelineFromTemplateResponse>(DoRPCRequest("CreatePipelineFromTemplate", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePipelineFromTemplateResponse> CreatePipelineFromTemplateWithOptionsAsync(CreatePipelineFromTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePipelineFromTemplateResponse>(await DoRPCRequestAsync("CreatePipelineFromTemplate", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePipelineFromTemplateResponse CreatePipelineFromTemplate(CreatePipelineFromTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePipelineFromTemplateWithOptions(request, runtime);
        }

        public async Task<CreatePipelineFromTemplateResponse> CreatePipelineFromTemplateAsync(CreatePipelineFromTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePipelineFromTemplateWithOptionsAsync(request, runtime);
        }

        public ListSmartGroupResponse ListSmartGroupWithOptions(ListSmartGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmartGroupResponse>(DoRPCRequest("ListSmartGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSmartGroupResponse> ListSmartGroupWithOptionsAsync(ListSmartGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmartGroupResponse>(await DoRPCRequestAsync("ListSmartGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSmartGroupResponse ListSmartGroup(ListSmartGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmartGroupWithOptions(request, runtime);
        }

        public async Task<ListSmartGroupResponse> ListSmartGroupAsync(ListSmartGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmartGroupWithOptionsAsync(request, runtime);
        }

        public TransferPipelineOwnerResponse TransferPipelineOwnerWithOptions(TransferPipelineOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferPipelineOwnerResponse>(DoRPCRequest("TransferPipelineOwner", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferPipelineOwnerResponse> TransferPipelineOwnerWithOptionsAsync(TransferPipelineOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferPipelineOwnerResponse>(await DoRPCRequestAsync("TransferPipelineOwner", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TransferPipelineOwnerResponse TransferPipelineOwner(TransferPipelineOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferPipelineOwnerWithOptions(request, runtime);
        }

        public async Task<TransferPipelineOwnerResponse> TransferPipelineOwnerAsync(TransferPipelineOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferPipelineOwnerWithOptionsAsync(request, runtime);
        }

        public CreateCommonGroupResponse CreateCommonGroupWithOptions(CreateCommonGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCommonGroupResponse>(DoRPCRequest("CreateCommonGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCommonGroupResponse> CreateCommonGroupWithOptionsAsync(CreateCommonGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCommonGroupResponse>(await DoRPCRequestAsync("CreateCommonGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCommonGroupResponse CreateCommonGroup(CreateCommonGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCommonGroupWithOptions(request, runtime);
        }

        public async Task<CreateCommonGroupResponse> CreateCommonGroupAsync(CreateCommonGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCommonGroupWithOptionsAsync(request, runtime);
        }

        public CreateDevopsOrganizationResponse CreateDevopsOrganizationWithOptions(CreateDevopsOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsOrganizationResponse>(DoRPCRequest("CreateDevopsOrganization", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDevopsOrganizationResponse> CreateDevopsOrganizationWithOptionsAsync(CreateDevopsOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsOrganizationResponse>(await DoRPCRequestAsync("CreateDevopsOrganization", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDevopsOrganizationResponse CreateDevopsOrganization(CreateDevopsOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDevopsOrganizationWithOptions(request, runtime);
        }

        public async Task<CreateDevopsOrganizationResponse> CreateDevopsOrganizationAsync(CreateDevopsOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDevopsOrganizationWithOptionsAsync(request, runtime);
        }

        public ListDevopsScenarioFieldConfigResponse ListDevopsScenarioFieldConfigWithOptions(ListDevopsScenarioFieldConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsScenarioFieldConfigResponse>(DoRPCRequest("ListDevopsScenarioFieldConfig", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevopsScenarioFieldConfigResponse> ListDevopsScenarioFieldConfigWithOptionsAsync(ListDevopsScenarioFieldConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsScenarioFieldConfigResponse>(await DoRPCRequestAsync("ListDevopsScenarioFieldConfig", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevopsScenarioFieldConfigResponse ListDevopsScenarioFieldConfig(ListDevopsScenarioFieldConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevopsScenarioFieldConfigWithOptions(request, runtime);
        }

        public async Task<ListDevopsScenarioFieldConfigResponse> ListDevopsScenarioFieldConfigAsync(ListDevopsScenarioFieldConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevopsScenarioFieldConfigWithOptionsAsync(request, runtime);
        }

        public ListPipelineTemplatesResponse ListPipelineTemplatesWithOptions(ListPipelineTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListPipelineTemplatesResponse>(DoRPCRequest("ListPipelineTemplates", "2020-03-03", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListPipelineTemplatesResponse> ListPipelineTemplatesWithOptionsAsync(ListPipelineTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListPipelineTemplatesResponse>(await DoRPCRequestAsync("ListPipelineTemplates", "2020-03-03", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListPipelineTemplatesResponse ListPipelineTemplates(ListPipelineTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPipelineTemplatesWithOptions(request, runtime);
        }

        public async Task<ListPipelineTemplatesResponse> ListPipelineTemplatesAsync(ListPipelineTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPipelineTemplatesWithOptionsAsync(request, runtime);
        }

        public UpdateDevopsProjectTaskResponse UpdateDevopsProjectTaskWithOptions(UpdateDevopsProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDevopsProjectTaskResponse>(DoRPCRequest("UpdateDevopsProjectTask", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDevopsProjectTaskResponse> UpdateDevopsProjectTaskWithOptionsAsync(UpdateDevopsProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDevopsProjectTaskResponse>(await DoRPCRequestAsync("UpdateDevopsProjectTask", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDevopsProjectTaskResponse UpdateDevopsProjectTask(UpdateDevopsProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDevopsProjectTaskWithOptions(request, runtime);
        }

        public async Task<UpdateDevopsProjectTaskResponse> UpdateDevopsProjectTaskAsync(UpdateDevopsProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDevopsProjectTaskWithOptionsAsync(request, runtime);
        }

        public GetDevopsProjectTaskInfoResponse GetDevopsProjectTaskInfoWithOptions(GetDevopsProjectTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsProjectTaskInfoResponse>(DoRPCRequest("GetDevopsProjectTaskInfo", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDevopsProjectTaskInfoResponse> GetDevopsProjectTaskInfoWithOptionsAsync(GetDevopsProjectTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsProjectTaskInfoResponse>(await DoRPCRequestAsync("GetDevopsProjectTaskInfo", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDevopsProjectTaskInfoResponse GetDevopsProjectTaskInfo(GetDevopsProjectTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDevopsProjectTaskInfoWithOptions(request, runtime);
        }

        public async Task<GetDevopsProjectTaskInfoResponse> GetDevopsProjectTaskInfoAsync(GetDevopsProjectTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDevopsProjectTaskInfoWithOptionsAsync(request, runtime);
        }

        public GetPipelineInstanceGroupStatusResponse GetPipelineInstanceGroupStatusWithOptions(GetPipelineInstanceGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstanceGroupStatusResponse>(DoRPCRequest("GetPipelineInstanceGroupStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPipelineInstanceGroupStatusResponse> GetPipelineInstanceGroupStatusWithOptionsAsync(GetPipelineInstanceGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstanceGroupStatusResponse>(await DoRPCRequestAsync("GetPipelineInstanceGroupStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPipelineInstanceGroupStatusResponse GetPipelineInstanceGroupStatus(GetPipelineInstanceGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineInstanceGroupStatusWithOptions(request, runtime);
        }

        public async Task<GetPipelineInstanceGroupStatusResponse> GetPipelineInstanceGroupStatusAsync(GetPipelineInstanceGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineInstanceGroupStatusWithOptionsAsync(request, runtime);
        }

        public UpdateTaskDetailResponse UpdateTaskDetailWithOptions(UpdateTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTaskDetailResponse>(DoRPCRequest("UpdateTaskDetail", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTaskDetailResponse> UpdateTaskDetailWithOptionsAsync(UpdateTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTaskDetailResponse>(await DoRPCRequestAsync("UpdateTaskDetail", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTaskDetailResponse UpdateTaskDetail(UpdateTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTaskDetailWithOptions(request, runtime);
        }

        public async Task<UpdateTaskDetailResponse> UpdateTaskDetailAsync(UpdateTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTaskDetailWithOptionsAsync(request, runtime);
        }

        public GetTaskListFilterResponse GetTaskListFilterWithOptions(GetTaskListFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskListFilterResponse>(DoRPCRequest("GetTaskListFilter", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskListFilterResponse> GetTaskListFilterWithOptionsAsync(GetTaskListFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskListFilterResponse>(await DoRPCRequestAsync("GetTaskListFilter", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTaskListFilterResponse GetTaskListFilter(GetTaskListFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskListFilterWithOptions(request, runtime);
        }

        public async Task<GetTaskListFilterResponse> GetTaskListFilterAsync(GetTaskListFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskListFilterWithOptionsAsync(request, runtime);
        }

        public GetProjectOptionResponse GetProjectOptionWithOptions(GetProjectOptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectOptionResponse>(DoRPCRequest("GetProjectOption", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProjectOptionResponse> GetProjectOptionWithOptionsAsync(GetProjectOptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectOptionResponse>(await DoRPCRequestAsync("GetProjectOption", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProjectOptionResponse GetProjectOption(GetProjectOptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectOptionWithOptions(request, runtime);
        }

        public async Task<GetProjectOptionResponse> GetProjectOptionAsync(GetProjectOptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectOptionWithOptionsAsync(request, runtime);
        }

        public UpdateCommonGroupResponse UpdateCommonGroupWithOptions(UpdateCommonGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCommonGroupResponse>(DoRPCRequest("UpdateCommonGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCommonGroupResponse> UpdateCommonGroupWithOptionsAsync(UpdateCommonGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCommonGroupResponse>(await DoRPCRequestAsync("UpdateCommonGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCommonGroupResponse UpdateCommonGroup(UpdateCommonGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCommonGroupWithOptions(request, runtime);
        }

        public async Task<UpdateCommonGroupResponse> UpdateCommonGroupAsync(UpdateCommonGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCommonGroupWithOptionsAsync(request, runtime);
        }

        public ListCommonGroupResponse ListCommonGroupWithOptions(ListCommonGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCommonGroupResponse>(DoRPCRequest("ListCommonGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCommonGroupResponse> ListCommonGroupWithOptionsAsync(ListCommonGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCommonGroupResponse>(await DoRPCRequestAsync("ListCommonGroup", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCommonGroupResponse ListCommonGroup(ListCommonGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCommonGroupWithOptions(request, runtime);
        }

        public async Task<ListCommonGroupResponse> ListCommonGroupAsync(ListCommonGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCommonGroupWithOptionsAsync(request, runtime);
        }

        public DeleteDevopsProjectTaskResponse DeleteDevopsProjectTaskWithOptions(DeleteDevopsProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsProjectTaskResponse>(DoRPCRequest("DeleteDevopsProjectTask", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDevopsProjectTaskResponse> DeleteDevopsProjectTaskWithOptionsAsync(DeleteDevopsProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDevopsProjectTaskResponse>(await DoRPCRequestAsync("DeleteDevopsProjectTask", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDevopsProjectTaskResponse DeleteDevopsProjectTask(DeleteDevopsProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevopsProjectTaskWithOptions(request, runtime);
        }

        public async Task<DeleteDevopsProjectTaskResponse> DeleteDevopsProjectTaskAsync(DeleteDevopsProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevopsProjectTaskWithOptionsAsync(request, runtime);
        }

        public GetDevopsOrganizationMembersResponse GetDevopsOrganizationMembersWithOptions(GetDevopsOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsOrganizationMembersResponse>(DoRPCRequest("GetDevopsOrganizationMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDevopsOrganizationMembersResponse> GetDevopsOrganizationMembersWithOptionsAsync(GetDevopsOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevopsOrganizationMembersResponse>(await DoRPCRequestAsync("GetDevopsOrganizationMembers", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDevopsOrganizationMembersResponse GetDevopsOrganizationMembers(GetDevopsOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDevopsOrganizationMembersWithOptions(request, runtime);
        }

        public async Task<GetDevopsOrganizationMembersResponse> GetDevopsOrganizationMembersAsync(GetDevopsOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDevopsOrganizationMembersWithOptionsAsync(request, runtime);
        }

        public CreateDevopsProjectResponse CreateDevopsProjectWithOptions(CreateDevopsProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsProjectResponse>(DoRPCRequest("CreateDevopsProject", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDevopsProjectResponse> CreateDevopsProjectWithOptionsAsync(CreateDevopsProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsProjectResponse>(await DoRPCRequestAsync("CreateDevopsProject", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDevopsProjectResponse CreateDevopsProject(CreateDevopsProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDevopsProjectWithOptions(request, runtime);
        }

        public async Task<CreateDevopsProjectResponse> CreateDevopsProjectAsync(CreateDevopsProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDevopsProjectWithOptionsAsync(request, runtime);
        }

        public GetTaskDetailActivityResponse GetTaskDetailActivityWithOptions(GetTaskDetailActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskDetailActivityResponse>(DoRPCRequest("GetTaskDetailActivity", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskDetailActivityResponse> GetTaskDetailActivityWithOptionsAsync(GetTaskDetailActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskDetailActivityResponse>(await DoRPCRequestAsync("GetTaskDetailActivity", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTaskDetailActivityResponse GetTaskDetailActivity(GetTaskDetailActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskDetailActivityWithOptions(request, runtime);
        }

        public async Task<GetTaskDetailActivityResponse> GetTaskDetailActivityAsync(GetTaskDetailActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskDetailActivityWithOptionsAsync(request, runtime);
        }

        public ExecutePipelineResponse ExecutePipelineWithOptions(ExecutePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecutePipelineResponse>(DoRPCRequest("ExecutePipeline", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecutePipelineResponse> ExecutePipelineWithOptionsAsync(ExecutePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecutePipelineResponse>(await DoRPCRequestAsync("ExecutePipeline", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecutePipelineResponse ExecutePipeline(ExecutePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecutePipelineWithOptions(request, runtime);
        }

        public async Task<ExecutePipelineResponse> ExecutePipelineAsync(ExecutePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecutePipelineWithOptionsAsync(request, runtime);
        }

        public CreateServiceConnectionResponse CreateServiceConnectionWithOptions(CreateServiceConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceConnectionResponse>(DoRPCRequest("CreateServiceConnection", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServiceConnectionResponse> CreateServiceConnectionWithOptionsAsync(CreateServiceConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceConnectionResponse>(await DoRPCRequestAsync("CreateServiceConnection", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServiceConnectionResponse CreateServiceConnection(CreateServiceConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceConnectionWithOptions(request, runtime);
        }

        public async Task<CreateServiceConnectionResponse> CreateServiceConnectionAsync(CreateServiceConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceConnectionWithOptionsAsync(request, runtime);
        }

        public GetPipelineInstHistoryResponse GetPipelineInstHistoryWithOptions(GetPipelineInstHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstHistoryResponse>(DoRPCRequest("GetPipelineInstHistory", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPipelineInstHistoryResponse> GetPipelineInstHistoryWithOptionsAsync(GetPipelineInstHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineInstHistoryResponse>(await DoRPCRequestAsync("GetPipelineInstHistory", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPipelineInstHistoryResponse GetPipelineInstHistory(GetPipelineInstHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineInstHistoryWithOptions(request, runtime);
        }

        public async Task<GetPipelineInstHistoryResponse> GetPipelineInstHistoryAsync(GetPipelineInstHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineInstHistoryWithOptionsAsync(request, runtime);
        }

        public GetPipelineStepLogResponse GetPipelineStepLogWithOptions(GetPipelineStepLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineStepLogResponse>(DoRPCRequest("GetPipelineStepLog", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPipelineStepLogResponse> GetPipelineStepLogWithOptionsAsync(GetPipelineStepLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipelineStepLogResponse>(await DoRPCRequestAsync("GetPipelineStepLog", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPipelineStepLogResponse GetPipelineStepLog(GetPipelineStepLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineStepLogWithOptions(request, runtime);
        }

        public async Task<GetPipelineStepLogResponse> GetPipelineStepLogAsync(GetPipelineStepLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineStepLogWithOptionsAsync(request, runtime);
        }

        public GetPipleineLatestInstanceStatusResponse GetPipleineLatestInstanceStatusWithOptions(GetPipleineLatestInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipleineLatestInstanceStatusResponse>(DoRPCRequest("GetPipleineLatestInstanceStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPipleineLatestInstanceStatusResponse> GetPipleineLatestInstanceStatusWithOptionsAsync(GetPipleineLatestInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPipleineLatestInstanceStatusResponse>(await DoRPCRequestAsync("GetPipleineLatestInstanceStatus", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPipleineLatestInstanceStatusResponse GetPipleineLatestInstanceStatus(GetPipleineLatestInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipleineLatestInstanceStatusWithOptions(request, runtime);
        }

        public async Task<GetPipleineLatestInstanceStatusResponse> GetPipleineLatestInstanceStatusAsync(GetPipleineLatestInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipleineLatestInstanceStatusWithOptionsAsync(request, runtime);
        }

        public ListDevopsProjectTasksResponse ListDevopsProjectTasksWithOptions(ListDevopsProjectTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectTasksResponse>(DoRPCRequest("ListDevopsProjectTasks", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevopsProjectTasksResponse> ListDevopsProjectTasksWithOptionsAsync(ListDevopsProjectTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevopsProjectTasksResponse>(await DoRPCRequestAsync("ListDevopsProjectTasks", "2020-03-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevopsProjectTasksResponse ListDevopsProjectTasks(ListDevopsProjectTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevopsProjectTasksWithOptions(request, runtime);
        }

        public async Task<ListDevopsProjectTasksResponse> ListDevopsProjectTasksAsync(ListDevopsProjectTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevopsProjectTasksWithOptionsAsync(request, runtime);
        }

    }
}
