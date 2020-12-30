// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Teambition_aliyun20200226.Models;

namespace AlibabaCloud.SDK.Teambition_aliyun20200226
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("teambition-aliyun", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddProjectMembersResponse AddProjectMembersWithOptions(AddProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProjectMembersResponse>(DoRPCRequest("AddProjectMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddProjectMembersResponse> AddProjectMembersWithOptionsAsync(AddProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProjectMembersResponse>(await DoRPCRequestAsync("AddProjectMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddProjectMembersResponse AddProjectMembers(AddProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddProjectMembersWithOptions(request, runtime);
        }

        public async Task<AddProjectMembersResponse> AddProjectMembersAsync(AddProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddProjectMembersWithOptionsAsync(request, runtime);
        }

        public ApplySmallMicroResponse ApplySmallMicroWithOptions(ApplySmallMicroRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplySmallMicroResponse>(DoRPCRequest("ApplySmallMicro", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplySmallMicroResponse> ApplySmallMicroWithOptionsAsync(ApplySmallMicroRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplySmallMicroResponse>(await DoRPCRequestAsync("ApplySmallMicro", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplySmallMicroResponse ApplySmallMicro(ApplySmallMicroRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplySmallMicroWithOptions(request, runtime);
        }

        public async Task<ApplySmallMicroResponse> ApplySmallMicroAsync(ApplySmallMicroRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplySmallMicroWithOptionsAsync(request, runtime);
        }

        public BactchInsertMembersResponse BactchInsertMembersWithOptions(BactchInsertMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BactchInsertMembersResponse>(DoRPCRequest("BactchInsertMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BactchInsertMembersResponse> BactchInsertMembersWithOptionsAsync(BactchInsertMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BactchInsertMembersResponse>(await DoRPCRequestAsync("BactchInsertMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BactchInsertMembersResponse BactchInsertMembers(BactchInsertMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BactchInsertMembersWithOptions(request, runtime);
        }

        public async Task<BactchInsertMembersResponse> BactchInsertMembersAsync(BactchInsertMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BactchInsertMembersWithOptionsAsync(request, runtime);
        }

        public CheckAliyunUserExistsResponse CheckAliyunUserExistsWithOptions(CheckAliyunUserExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckAliyunUserExistsResponse>(DoRPCRequest("CheckAliyunUserExists", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckAliyunUserExistsResponse> CheckAliyunUserExistsWithOptionsAsync(CheckAliyunUserExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckAliyunUserExistsResponse>(await DoRPCRequestAsync("CheckAliyunUserExists", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckAliyunUserExistsResponse CheckAliyunUserExists(CheckAliyunUserExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAliyunUserExistsWithOptions(request, runtime);
        }

        public async Task<CheckAliyunUserExistsResponse> CheckAliyunUserExistsAsync(CheckAliyunUserExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAliyunUserExistsWithOptionsAsync(request, runtime);
        }

        public CreateDevopsOrgResponse CreateDevopsOrgWithOptions(CreateDevopsOrgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsOrgResponse>(DoRPCRequest("CreateDevopsOrg", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDevopsOrgResponse> CreateDevopsOrgWithOptionsAsync(CreateDevopsOrgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevopsOrgResponse>(await DoRPCRequestAsync("CreateDevopsOrg", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDevopsOrgResponse CreateDevopsOrg(CreateDevopsOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDevopsOrgWithOptions(request, runtime);
        }

        public async Task<CreateDevopsOrgResponse> CreateDevopsOrgAsync(CreateDevopsOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDevopsOrgWithOptionsAsync(request, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(DoRPCRequest("CreateProject", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(await DoRPCRequestAsync("CreateProject", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        public CreateProjectSprintResponse CreateProjectSprintWithOptions(CreateProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectSprintResponse>(DoRPCRequest("CreateProjectSprint", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectSprintResponse> CreateProjectSprintWithOptionsAsync(CreateProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectSprintResponse>(await DoRPCRequestAsync("CreateProjectSprint", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectSprintResponse CreateProjectSprint(CreateProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectSprintWithOptions(request, runtime);
        }

        public async Task<CreateProjectSprintResponse> CreateProjectSprintAsync(CreateProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectSprintWithOptionsAsync(request, runtime);
        }

        public CreateProjectTaskResponse CreateProjectTaskWithOptions(CreateProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectTaskResponse>(DoRPCRequest("CreateProjectTask", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectTaskResponse> CreateProjectTaskWithOptionsAsync(CreateProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectTaskResponse>(await DoRPCRequestAsync("CreateProjectTask", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectTaskResponse CreateProjectTask(CreateProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectTaskWithOptions(request, runtime);
        }

        public async Task<CreateProjectTaskResponse> CreateProjectTaskAsync(CreateProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectTaskWithOptionsAsync(request, runtime);
        }

        public DeleteMembersForOrgResponse DeleteMembersForOrgWithOptions(DeleteMembersForOrgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMembersForOrgResponse>(DoRPCRequest("DeleteMembersForOrg", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMembersForOrgResponse> DeleteMembersForOrgWithOptionsAsync(DeleteMembersForOrgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMembersForOrgResponse>(await DoRPCRequestAsync("DeleteMembersForOrg", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMembersForOrgResponse DeleteMembersForOrg(DeleteMembersForOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMembersForOrgWithOptions(request, runtime);
        }

        public async Task<DeleteMembersForOrgResponse> DeleteMembersForOrgAsync(DeleteMembersForOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMembersForOrgWithOptionsAsync(request, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(DoRPCRequest("DeleteProject", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await DoRPCRequestAsync("DeleteProject", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        public DeleteProjectMembersResponse DeleteProjectMembersWithOptions(DeleteProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectMembersResponse>(DoRPCRequest("DeleteProjectMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectMembersResponse> DeleteProjectMembersWithOptionsAsync(DeleteProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectMembersResponse>(await DoRPCRequestAsync("DeleteProjectMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProjectMembersResponse DeleteProjectMembers(DeleteProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectMembersWithOptions(request, runtime);
        }

        public async Task<DeleteProjectMembersResponse> DeleteProjectMembersAsync(DeleteProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectMembersWithOptionsAsync(request, runtime);
        }

        public DeleteProjectSprintResponse DeleteProjectSprintWithOptions(DeleteProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectSprintResponse>(DoRPCRequest("DeleteProjectSprint", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectSprintResponse> DeleteProjectSprintWithOptionsAsync(DeleteProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectSprintResponse>(await DoRPCRequestAsync("DeleteProjectSprint", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProjectSprintResponse DeleteProjectSprint(DeleteProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectSprintWithOptions(request, runtime);
        }

        public async Task<DeleteProjectSprintResponse> DeleteProjectSprintAsync(DeleteProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectSprintWithOptionsAsync(request, runtime);
        }

        public DeleteProjectTaskResponse DeleteProjectTaskWithOptions(DeleteProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectTaskResponse>(DoRPCRequest("DeleteProjectTask", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectTaskResponse> DeleteProjectTaskWithOptionsAsync(DeleteProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectTaskResponse>(await DoRPCRequestAsync("DeleteProjectTask", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProjectTaskResponse DeleteProjectTask(DeleteProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectTaskWithOptions(request, runtime);
        }

        public async Task<DeleteProjectTaskResponse> DeleteProjectTaskAsync(DeleteProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectTaskWithOptionsAsync(request, runtime);
        }

        public GetOrganizationMembersResponse GetOrganizationMembersWithOptions(GetOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOrganizationMembersResponse>(DoRPCRequest("GetOrganizationMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOrganizationMembersResponse> GetOrganizationMembersWithOptionsAsync(GetOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOrganizationMembersResponse>(await DoRPCRequestAsync("GetOrganizationMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOrganizationMembersResponse GetOrganizationMembers(GetOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrganizationMembersWithOptions(request, runtime);
        }

        public async Task<GetOrganizationMembersResponse> GetOrganizationMembersAsync(GetOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrganizationMembersWithOptionsAsync(request, runtime);
        }

        public GetProjectInfoResponse GetProjectInfoWithOptions(GetProjectInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectInfoResponse>(DoRPCRequest("GetProjectInfo", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProjectInfoResponse> GetProjectInfoWithOptionsAsync(GetProjectInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectInfoResponse>(await DoRPCRequestAsync("GetProjectInfo", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProjectInfoResponse GetProjectInfo(GetProjectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectInfoWithOptions(request, runtime);
        }

        public async Task<GetProjectInfoResponse> GetProjectInfoAsync(GetProjectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectInfoWithOptionsAsync(request, runtime);
        }

        public GetProjectMembersResponse GetProjectMembersWithOptions(GetProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectMembersResponse>(DoRPCRequest("GetProjectMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProjectMembersResponse> GetProjectMembersWithOptionsAsync(GetProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectMembersResponse>(await DoRPCRequestAsync("GetProjectMembers", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProjectMembersResponse GetProjectMembers(GetProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectMembersWithOptions(request, runtime);
        }

        public async Task<GetProjectMembersResponse> GetProjectMembersAsync(GetProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectMembersWithOptionsAsync(request, runtime);
        }

        public GetProjectSprintInfoResponse GetProjectSprintInfoWithOptions(GetProjectSprintInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectSprintInfoResponse>(DoRPCRequest("GetProjectSprintInfo", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProjectSprintInfoResponse> GetProjectSprintInfoWithOptionsAsync(GetProjectSprintInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectSprintInfoResponse>(await DoRPCRequestAsync("GetProjectSprintInfo", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProjectSprintInfoResponse GetProjectSprintInfo(GetProjectSprintInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectSprintInfoWithOptions(request, runtime);
        }

        public async Task<GetProjectSprintInfoResponse> GetProjectSprintInfoAsync(GetProjectSprintInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectSprintInfoWithOptionsAsync(request, runtime);
        }

        public GetProjectTaskInfoResponse GetProjectTaskInfoWithOptions(GetProjectTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectTaskInfoResponse>(DoRPCRequest("GetProjectTaskInfo", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProjectTaskInfoResponse> GetProjectTaskInfoWithOptionsAsync(GetProjectTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectTaskInfoResponse>(await DoRPCRequestAsync("GetProjectTaskInfo", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProjectTaskInfoResponse GetProjectTaskInfo(GetProjectTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectTaskInfoWithOptions(request, runtime);
        }

        public async Task<GetProjectTaskInfoResponse> GetProjectTaskInfoAsync(GetProjectTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectTaskInfoWithOptionsAsync(request, runtime);
        }

        public GetUserByUidResponse GetUserByUidWithOptions(GetUserByUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserByUidResponse>(DoRPCRequest("GetUserByUid", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserByUidResponse> GetUserByUidWithOptionsAsync(GetUserByUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserByUidResponse>(await DoRPCRequestAsync("GetUserByUid", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserByUidResponse GetUserByUid(GetUserByUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserByUidWithOptions(request, runtime);
        }

        public async Task<GetUserByUidResponse> GetUserByUidAsync(GetUserByUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserByUidWithOptionsAsync(request, runtime);
        }

        public InsertDevopsMemberResponse InsertDevopsMemberWithOptions(InsertDevopsMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertDevopsMemberResponse>(DoRPCRequest("InsertDevopsMember", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InsertDevopsMemberResponse> InsertDevopsMemberWithOptionsAsync(InsertDevopsMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertDevopsMemberResponse>(await DoRPCRequestAsync("InsertDevopsMember", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InsertDevopsMemberResponse InsertDevopsMember(InsertDevopsMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertDevopsMemberWithOptions(request, runtime);
        }

        public async Task<InsertDevopsMemberResponse> InsertDevopsMemberAsync(InsertDevopsMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertDevopsMemberWithOptionsAsync(request, runtime);
        }

        public ListProjectSprintsResponse ListProjectSprintsWithOptions(ListProjectSprintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectSprintsResponse>(DoRPCRequest("ListProjectSprints", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectSprintsResponse> ListProjectSprintsWithOptionsAsync(ListProjectSprintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectSprintsResponse>(await DoRPCRequestAsync("ListProjectSprints", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectSprintsResponse ListProjectSprints(ListProjectSprintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectSprintsWithOptions(request, runtime);
        }

        public async Task<ListProjectSprintsResponse> ListProjectSprintsAsync(ListProjectSprintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectSprintsWithOptionsAsync(request, runtime);
        }

        public ListProjectTaskFlowResponse ListProjectTaskFlowWithOptions(ListProjectTaskFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectTaskFlowResponse>(DoRPCRequest("ListProjectTaskFlow", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectTaskFlowResponse> ListProjectTaskFlowWithOptionsAsync(ListProjectTaskFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectTaskFlowResponse>(await DoRPCRequestAsync("ListProjectTaskFlow", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectTaskFlowResponse ListProjectTaskFlow(ListProjectTaskFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectTaskFlowWithOptions(request, runtime);
        }

        public async Task<ListProjectTaskFlowResponse> ListProjectTaskFlowAsync(ListProjectTaskFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectTaskFlowWithOptionsAsync(request, runtime);
        }

        public ListProjectTaskFlowStatusResponse ListProjectTaskFlowStatusWithOptions(ListProjectTaskFlowStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectTaskFlowStatusResponse>(DoRPCRequest("ListProjectTaskFlowStatus", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectTaskFlowStatusResponse> ListProjectTaskFlowStatusWithOptionsAsync(ListProjectTaskFlowStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectTaskFlowStatusResponse>(await DoRPCRequestAsync("ListProjectTaskFlowStatus", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectTaskFlowStatusResponse ListProjectTaskFlowStatus(ListProjectTaskFlowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectTaskFlowStatusWithOptions(request, runtime);
        }

        public async Task<ListProjectTaskFlowStatusResponse> ListProjectTaskFlowStatusAsync(ListProjectTaskFlowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectTaskFlowStatusWithOptionsAsync(request, runtime);
        }

        public ListProjectTasksResponse ListProjectTasksWithOptions(ListProjectTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectTasksResponse>(DoRPCRequest("ListProjectTasks", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectTasksResponse> ListProjectTasksWithOptionsAsync(ListProjectTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectTasksResponse>(await DoRPCRequestAsync("ListProjectTasks", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectTasksResponse ListProjectTasks(ListProjectTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectTasksWithOptions(request, runtime);
        }

        public async Task<ListProjectTasksResponse> ListProjectTasksAsync(ListProjectTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectTasksWithOptionsAsync(request, runtime);
        }

        public ListScenarioFieldConfigResponse ListScenarioFieldConfigWithOptions(ListScenarioFieldConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScenarioFieldConfigResponse>(DoRPCRequest("ListScenarioFieldConfig", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScenarioFieldConfigResponse> ListScenarioFieldConfigWithOptionsAsync(ListScenarioFieldConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScenarioFieldConfigResponse>(await DoRPCRequestAsync("ListScenarioFieldConfig", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScenarioFieldConfigResponse ListScenarioFieldConfig(ListScenarioFieldConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScenarioFieldConfigWithOptions(request, runtime);
        }

        public async Task<ListScenarioFieldConfigResponse> ListScenarioFieldConfigAsync(ListScenarioFieldConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScenarioFieldConfigWithOptionsAsync(request, runtime);
        }

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(DoRPCRequest("UpdateProject", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await DoRPCRequestAsync("UpdateProject", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectWithOptions(request, runtime);
        }

        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectWithOptionsAsync(request, runtime);
        }

        public UpdateProjectSprintResponse UpdateProjectSprintWithOptions(UpdateProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectSprintResponse>(DoRPCRequest("UpdateProjectSprint", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectSprintResponse> UpdateProjectSprintWithOptionsAsync(UpdateProjectSprintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectSprintResponse>(await DoRPCRequestAsync("UpdateProjectSprint", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateProjectSprintResponse UpdateProjectSprint(UpdateProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectSprintWithOptions(request, runtime);
        }

        public async Task<UpdateProjectSprintResponse> UpdateProjectSprintAsync(UpdateProjectSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectSprintWithOptionsAsync(request, runtime);
        }

        public UpdateProjectTaskResponse UpdateProjectTaskWithOptions(UpdateProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectTaskResponse>(DoRPCRequest("UpdateProjectTask", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectTaskResponse> UpdateProjectTaskWithOptionsAsync(UpdateProjectTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectTaskResponse>(await DoRPCRequestAsync("UpdateProjectTask", "2020-02-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateProjectTaskResponse UpdateProjectTask(UpdateProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectTaskWithOptions(request, runtime);
        }

        public async Task<UpdateProjectTaskResponse> UpdateProjectTaskAsync(UpdateProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectTaskWithOptionsAsync(request, runtime);
        }

    }
}
