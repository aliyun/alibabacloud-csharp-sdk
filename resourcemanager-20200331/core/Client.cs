// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ResourceManager20200331.Models;

namespace AlibabaCloud.SDK.ResourceManager20200331
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("resourcemanager", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleWithOptions(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(DoRequest("CreateServiceLinkedRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleWithOptionsAsync(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(await DoRequestAsync("CreateServiceLinkedRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public GetServiceLinkedRoleDeletionStatusResponse GetServiceLinkedRoleDeletionStatusWithOptions(GetServiceLinkedRoleDeletionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetServiceLinkedRoleDeletionStatusResponse>(DoRequest("GetServiceLinkedRoleDeletionStatus", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetServiceLinkedRoleDeletionStatusResponse> GetServiceLinkedRoleDeletionStatusWithOptionsAsync(GetServiceLinkedRoleDeletionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetServiceLinkedRoleDeletionStatusResponse>(await DoRequestAsync("GetServiceLinkedRoleDeletionStatus", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetServiceLinkedRoleDeletionStatusResponse GetServiceLinkedRoleDeletionStatus(GetServiceLinkedRoleDeletionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceLinkedRoleDeletionStatusWithOptions(request, runtime);
        }

        public async Task<GetServiceLinkedRoleDeletionStatusResponse> GetServiceLinkedRoleDeletionStatusAsync(GetServiceLinkedRoleDeletionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceLinkedRoleDeletionStatusWithOptionsAsync(request, runtime);
        }

        public ListTrustedServiceStatusResponse ListTrustedServiceStatusWithOptions(ListTrustedServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTrustedServiceStatusResponse>(DoRequest("ListTrustedServiceStatus", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTrustedServiceStatusResponse> ListTrustedServiceStatusWithOptionsAsync(ListTrustedServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTrustedServiceStatusResponse>(await DoRequestAsync("ListTrustedServiceStatus", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListTrustedServiceStatusResponse ListTrustedServiceStatus(ListTrustedServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrustedServiceStatusWithOptions(request, runtime);
        }

        public async Task<ListTrustedServiceStatusResponse> ListTrustedServiceStatusAsync(ListTrustedServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrustedServiceStatusWithOptionsAsync(request, runtime);
        }

        public DeleteServiceLinkedRoleResponse DeleteServiceLinkedRoleWithOptions(DeleteServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteServiceLinkedRoleResponse>(DoRequest("DeleteServiceLinkedRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRoleWithOptionsAsync(DeleteServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteServiceLinkedRoleResponse>(await DoRequestAsync("DeleteServiceLinkedRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DeleteServiceLinkedRoleResponse DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public UpdateRoleResponse UpdateRoleWithOptions(UpdateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRoleResponse>(DoRequest("UpdateRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateRoleResponse> UpdateRoleWithOptionsAsync(UpdateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRoleResponse>(await DoRequestAsync("UpdateRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public UpdateRoleResponse UpdateRole(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRoleWithOptions(request, runtime);
        }

        public async Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRoleWithOptionsAsync(request, runtime);
        }

        public ListResourcesResponse ListResourcesWithOptions(ListResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourcesResponse>(DoRequest("ListResources", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListResourcesResponse> ListResourcesWithOptionsAsync(ListResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourcesResponse>(await DoRequestAsync("ListResources", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourcesWithOptions(request, runtime);
        }

        public async Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourcesWithOptionsAsync(request, runtime);
        }

        public CreateCloudAccountResponse CreateCloudAccountWithOptions(CreateCloudAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateCloudAccountResponse>(DoRequest("CreateCloudAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateCloudAccountResponse> CreateCloudAccountWithOptionsAsync(CreateCloudAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateCloudAccountResponse>(await DoRequestAsync("CreateCloudAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CreateCloudAccountResponse CreateCloudAccount(CreateCloudAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCloudAccountWithOptions(request, runtime);
        }

        public async Task<CreateCloudAccountResponse> CreateCloudAccountAsync(CreateCloudAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCloudAccountWithOptionsAsync(request, runtime);
        }

        public DeleteRoleResponse DeleteRoleWithOptions(DeleteRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRoleResponse>(DoRequest("DeleteRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteRoleResponse> DeleteRoleWithOptionsAsync(DeleteRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRoleResponse>(await DoRequestAsync("DeleteRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRoleWithOptions(request, runtime);
        }

        public async Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRoleWithOptionsAsync(request, runtime);
        }

        public GetRoleResponse GetRoleWithOptions(GetRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRoleResponse>(DoRequest("GetRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetRoleResponse> GetRoleWithOptionsAsync(GetRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRoleResponse>(await DoRequestAsync("GetRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetRoleResponse GetRole(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRoleWithOptions(request, runtime);
        }

        public async Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRoleWithOptionsAsync(request, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRolesResponse>(DoRequest("ListRoles", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRolesResponse>(await DoRequestAsync("ListRoles", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
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

        public CreateRoleResponse CreateRoleWithOptions(CreateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRoleResponse>(DoRequest("CreateRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRoleResponse> CreateRoleWithOptionsAsync(CreateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRoleResponse>(await DoRequestAsync("CreateRole", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRoleWithOptions(request, runtime);
        }

        public async Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRoleWithOptionsAsync(request, runtime);
        }

        public ListPolicyAttachmentsResponse ListPolicyAttachmentsWithOptions(ListPolicyAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPolicyAttachmentsResponse>(DoRequest("ListPolicyAttachments", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPolicyAttachmentsResponse> ListPolicyAttachmentsWithOptionsAsync(ListPolicyAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPolicyAttachmentsResponse>(await DoRequestAsync("ListPolicyAttachments", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListPolicyAttachmentsResponse ListPolicyAttachments(ListPolicyAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicyAttachmentsWithOptions(request, runtime);
        }

        public async Task<ListPolicyAttachmentsResponse> ListPolicyAttachmentsAsync(ListPolicyAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicyAttachmentsWithOptionsAsync(request, runtime);
        }

        public DetachPolicyResponse DetachPolicyWithOptions(DetachPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DetachPolicyResponse>(DoRequest("DetachPolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DetachPolicyResponse> DetachPolicyWithOptionsAsync(DetachPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DetachPolicyResponse>(await DoRequestAsync("DetachPolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachPolicyWithOptions(request, runtime);
        }

        public async Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachPolicyWithOptionsAsync(request, runtime);
        }

        public AttachPolicyResponse AttachPolicyWithOptions(AttachPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AttachPolicyResponse>(DoRequest("AttachPolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AttachPolicyResponse> AttachPolicyWithOptionsAsync(AttachPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AttachPolicyResponse>(await DoRequestAsync("AttachPolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachPolicyWithOptions(request, runtime);
        }

        public async Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachPolicyWithOptionsAsync(request, runtime);
        }

        public GetPolicyVersionResponse GetPolicyVersionWithOptions(GetPolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPolicyVersionResponse>(DoRequest("GetPolicyVersion", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPolicyVersionResponse> GetPolicyVersionWithOptionsAsync(GetPolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPolicyVersionResponse>(await DoRequestAsync("GetPolicyVersion", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyVersionWithOptions(request, runtime);
        }

        public async Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyVersionWithOptionsAsync(request, runtime);
        }

        public SetDefaultPolicyVersionResponse SetDefaultPolicyVersionWithOptions(SetDefaultPolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDefaultPolicyVersionResponse>(DoRequest("SetDefaultPolicyVersion", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionWithOptionsAsync(SetDefaultPolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDefaultPolicyVersionResponse>(await DoRequestAsync("SetDefaultPolicyVersion", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultPolicyVersionWithOptions(request, runtime);
        }

        public async Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultPolicyVersionWithOptionsAsync(request, runtime);
        }

        public DeleteResourceGroupResponse DeleteResourceGroupWithOptions(DeleteResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteResourceGroupResponse>(DoRequest("DeleteResourceGroup", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteResourceGroupResponse> DeleteResourceGroupWithOptionsAsync(DeleteResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteResourceGroupResponse>(await DoRequestAsync("DeleteResourceGroup", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DeleteResourceGroupResponse DeleteResourceGroup(DeleteResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourceGroupWithOptions(request, runtime);
        }

        public async Task<DeleteResourceGroupResponse> DeleteResourceGroupAsync(DeleteResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourceGroupWithOptionsAsync(request, runtime);
        }

        public GetPolicyResponse GetPolicyWithOptions(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPolicyResponse>(DoRequest("GetPolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPolicyResponse> GetPolicyWithOptionsAsync(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPolicyResponse>(await DoRequestAsync("GetPolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyWithOptions(request, runtime);
        }

        public async Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyWithOptionsAsync(request, runtime);
        }

        public UpdateResourceGroupResponse UpdateResourceGroupWithOptions(UpdateResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateResourceGroupResponse>(DoRequest("UpdateResourceGroup", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateResourceGroupResponse> UpdateResourceGroupWithOptionsAsync(UpdateResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateResourceGroupResponse>(await DoRequestAsync("UpdateResourceGroup", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public UpdateResourceGroupResponse UpdateResourceGroup(UpdateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateResourceGroupWithOptions(request, runtime);
        }

        public async Task<UpdateResourceGroupResponse> UpdateResourceGroupAsync(UpdateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateResourceGroupWithOptionsAsync(request, runtime);
        }

        public ListResourceGroupsResponse ListResourceGroupsWithOptions(ListResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourceGroupsResponse>(DoRequest("ListResourceGroups", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListResourceGroupsResponse> ListResourceGroupsWithOptionsAsync(ListResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourceGroupsResponse>(await DoRequestAsync("ListResourceGroups", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListResourceGroupsResponse ListResourceGroups(ListResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceGroupsWithOptions(request, runtime);
        }

        public async Task<ListResourceGroupsResponse> ListResourceGroupsAsync(ListResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceGroupsWithOptionsAsync(request, runtime);
        }

        public ListPoliciesResponse ListPoliciesWithOptions(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPoliciesResponse>(DoRequest("ListPolicies", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPoliciesResponse> ListPoliciesWithOptionsAsync(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPoliciesResponse>(await DoRequestAsync("ListPolicies", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesWithOptions(request, runtime);
        }

        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesWithOptionsAsync(request, runtime);
        }

        public ListPolicyVersionsResponse ListPolicyVersionsWithOptions(ListPolicyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPolicyVersionsResponse>(DoRequest("ListPolicyVersions", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPolicyVersionsResponse> ListPolicyVersionsWithOptionsAsync(ListPolicyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPolicyVersionsResponse>(await DoRequestAsync("ListPolicyVersions", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicyVersionsWithOptions(request, runtime);
        }

        public async Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicyVersionsWithOptionsAsync(request, runtime);
        }

        public CreateResourceAccountResponse CreateResourceAccountWithOptions(CreateResourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateResourceAccountResponse>(DoRequest("CreateResourceAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateResourceAccountResponse> CreateResourceAccountWithOptionsAsync(CreateResourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateResourceAccountResponse>(await DoRequestAsync("CreateResourceAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CreateResourceAccountResponse CreateResourceAccount(CreateResourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceAccountWithOptions(request, runtime);
        }

        public async Task<CreateResourceAccountResponse> CreateResourceAccountAsync(CreateResourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceAccountWithOptionsAsync(request, runtime);
        }

        public ListHandshakesForResourceDirectoryResponse ListHandshakesForResourceDirectoryWithOptions(ListHandshakesForResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListHandshakesForResourceDirectoryResponse>(DoRequest("ListHandshakesForResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListHandshakesForResourceDirectoryResponse> ListHandshakesForResourceDirectoryWithOptionsAsync(ListHandshakesForResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListHandshakesForResourceDirectoryResponse>(await DoRequestAsync("ListHandshakesForResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListHandshakesForResourceDirectoryResponse ListHandshakesForResourceDirectory(ListHandshakesForResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHandshakesForResourceDirectoryWithOptions(request, runtime);
        }

        public async Task<ListHandshakesForResourceDirectoryResponse> ListHandshakesForResourceDirectoryAsync(ListHandshakesForResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHandshakesForResourceDirectoryWithOptionsAsync(request, runtime);
        }

        public DestroyResourceDirectoryResponse DestroyResourceDirectoryWithOptions(DestroyResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DestroyResourceDirectoryResponse>(DoRequest("DestroyResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DestroyResourceDirectoryResponse> DestroyResourceDirectoryWithOptionsAsync(DestroyResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DestroyResourceDirectoryResponse>(await DoRequestAsync("DestroyResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DestroyResourceDirectoryResponse DestroyResourceDirectory(DestroyResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DestroyResourceDirectoryWithOptions(request, runtime);
        }

        public async Task<DestroyResourceDirectoryResponse> DestroyResourceDirectoryAsync(DestroyResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DestroyResourceDirectoryWithOptionsAsync(request, runtime);
        }

        public CreatePolicyVersionResponse CreatePolicyVersionWithOptions(CreatePolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePolicyVersionResponse>(DoRequest("CreatePolicyVersion", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePolicyVersionResponse> CreatePolicyVersionWithOptionsAsync(CreatePolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePolicyVersionResponse>(await DoRequestAsync("CreatePolicyVersion", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyVersionWithOptions(request, runtime);
        }

        public async Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyVersionWithOptionsAsync(request, runtime);
        }

        public DeletePolicyVersionResponse DeletePolicyVersionWithOptions(DeletePolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePolicyVersionResponse>(DoRequest("DeletePolicyVersion", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePolicyVersionResponse> DeletePolicyVersionWithOptionsAsync(DeletePolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePolicyVersionResponse>(await DoRequestAsync("DeletePolicyVersion", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyVersionWithOptions(request, runtime);
        }

        public async Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyVersionWithOptionsAsync(request, runtime);
        }

        public GetResourceGroupResponse GetResourceGroupWithOptions(GetResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetResourceGroupResponse>(DoRequest("GetResourceGroup", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetResourceGroupResponse> GetResourceGroupWithOptionsAsync(GetResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetResourceGroupResponse>(await DoRequestAsync("GetResourceGroup", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetResourceGroupResponse GetResourceGroup(GetResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceGroupWithOptions(request, runtime);
        }

        public async Task<GetResourceGroupResponse> GetResourceGroupAsync(GetResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceGroupWithOptionsAsync(request, runtime);
        }

        public InitResourceDirectoryResponse InitResourceDirectoryWithOptions(InitResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InitResourceDirectoryResponse>(DoRequest("InitResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InitResourceDirectoryResponse> InitResourceDirectoryWithOptionsAsync(InitResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InitResourceDirectoryResponse>(await DoRequestAsync("InitResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public InitResourceDirectoryResponse InitResourceDirectory(InitResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitResourceDirectoryWithOptions(request, runtime);
        }

        public async Task<InitResourceDirectoryResponse> InitResourceDirectoryAsync(InitResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitResourceDirectoryWithOptionsAsync(request, runtime);
        }

        public GetHandshakeResponse GetHandshakeWithOptions(GetHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetHandshakeResponse>(DoRequest("GetHandshake", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetHandshakeResponse> GetHandshakeWithOptionsAsync(GetHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetHandshakeResponse>(await DoRequestAsync("GetHandshake", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetHandshakeResponse GetHandshake(GetHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHandshakeWithOptions(request, runtime);
        }

        public async Task<GetHandshakeResponse> GetHandshakeAsync(GetHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHandshakeWithOptionsAsync(request, runtime);
        }

        public CancelHandshakeResponse CancelHandshakeWithOptions(CancelHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelHandshakeResponse>(DoRequest("CancelHandshake", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelHandshakeResponse> CancelHandshakeWithOptionsAsync(CancelHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelHandshakeResponse>(await DoRequestAsync("CancelHandshake", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CancelHandshakeResponse CancelHandshake(CancelHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelHandshakeWithOptions(request, runtime);
        }

        public async Task<CancelHandshakeResponse> CancelHandshakeAsync(CancelHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelHandshakeWithOptionsAsync(request, runtime);
        }

        public CreatePolicyResponse CreatePolicyWithOptions(CreatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePolicyResponse>(DoRequest("CreatePolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePolicyResponse> CreatePolicyWithOptionsAsync(CreatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePolicyResponse>(await DoRequestAsync("CreatePolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyWithOptions(request, runtime);
        }

        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyWithOptionsAsync(request, runtime);
        }

        public DeclineHandshakeResponse DeclineHandshakeWithOptions(DeclineHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeclineHandshakeResponse>(DoRequest("DeclineHandshake", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeclineHandshakeResponse> DeclineHandshakeWithOptionsAsync(DeclineHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeclineHandshakeResponse>(await DoRequestAsync("DeclineHandshake", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DeclineHandshakeResponse DeclineHandshake(DeclineHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeclineHandshakeWithOptions(request, runtime);
        }

        public async Task<DeclineHandshakeResponse> DeclineHandshakeAsync(DeclineHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeclineHandshakeWithOptionsAsync(request, runtime);
        }

        public DeletePolicyResponse DeletePolicyWithOptions(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePolicyResponse>(DoRequest("DeletePolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePolicyResponse> DeletePolicyWithOptionsAsync(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePolicyResponse>(await DoRequestAsync("DeletePolicy", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyWithOptions(request, runtime);
        }

        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyWithOptionsAsync(request, runtime);
        }

        public ListHandshakesForAccountResponse ListHandshakesForAccountWithOptions(ListHandshakesForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListHandshakesForAccountResponse>(DoRequest("ListHandshakesForAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListHandshakesForAccountResponse> ListHandshakesForAccountWithOptionsAsync(ListHandshakesForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListHandshakesForAccountResponse>(await DoRequestAsync("ListHandshakesForAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListHandshakesForAccountResponse ListHandshakesForAccount(ListHandshakesForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHandshakesForAccountWithOptions(request, runtime);
        }

        public async Task<ListHandshakesForAccountResponse> ListHandshakesForAccountAsync(ListHandshakesForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHandshakesForAccountWithOptionsAsync(request, runtime);
        }

        public InviteAccountToResourceDirectoryResponse InviteAccountToResourceDirectoryWithOptions(InviteAccountToResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InviteAccountToResourceDirectoryResponse>(DoRequest("InviteAccountToResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InviteAccountToResourceDirectoryResponse> InviteAccountToResourceDirectoryWithOptionsAsync(InviteAccountToResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InviteAccountToResourceDirectoryResponse>(await DoRequestAsync("InviteAccountToResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public InviteAccountToResourceDirectoryResponse InviteAccountToResourceDirectory(InviteAccountToResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InviteAccountToResourceDirectoryWithOptions(request, runtime);
        }

        public async Task<InviteAccountToResourceDirectoryResponse> InviteAccountToResourceDirectoryAsync(InviteAccountToResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InviteAccountToResourceDirectoryWithOptionsAsync(request, runtime);
        }

        public AcceptHandshakeResponse AcceptHandshakeWithOptions(AcceptHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AcceptHandshakeResponse>(DoRequest("AcceptHandshake", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AcceptHandshakeResponse> AcceptHandshakeWithOptionsAsync(AcceptHandshakeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AcceptHandshakeResponse>(await DoRequestAsync("AcceptHandshake", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public AcceptHandshakeResponse AcceptHandshake(AcceptHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptHandshakeWithOptions(request, runtime);
        }

        public async Task<AcceptHandshakeResponse> AcceptHandshakeAsync(AcceptHandshakeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptHandshakeWithOptionsAsync(request, runtime);
        }

        public UpdateAccountResponse UpdateAccountWithOptions(UpdateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateAccountResponse>(DoRequest("UpdateAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateAccountResponse> UpdateAccountWithOptionsAsync(UpdateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateAccountResponse>(await DoRequestAsync("UpdateAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccountWithOptions(request, runtime);
        }

        public async Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccountWithOptionsAsync(request, runtime);
        }

        public GetFolderResponse GetFolderWithOptions(GetFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFolderResponse>(DoRequest("GetFolder", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetFolderResponse> GetFolderWithOptionsAsync(GetFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFolderResponse>(await DoRequestAsync("GetFolder", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetFolderResponse GetFolder(GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFolderWithOptions(request, runtime);
        }

        public async Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFolderWithOptionsAsync(request, runtime);
        }

        public ListAccountsForParentResponse ListAccountsForParentWithOptions(ListAccountsForParentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAccountsForParentResponse>(DoRequest("ListAccountsForParent", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListAccountsForParentResponse> ListAccountsForParentWithOptionsAsync(ListAccountsForParentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAccountsForParentResponse>(await DoRequestAsync("ListAccountsForParent", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListAccountsForParentResponse ListAccountsForParent(ListAccountsForParentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountsForParentWithOptions(request, runtime);
        }

        public async Task<ListAccountsForParentResponse> ListAccountsForParentAsync(ListAccountsForParentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountsForParentWithOptionsAsync(request, runtime);
        }

        public CreateResourceGroupResponse CreateResourceGroupWithOptions(CreateResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateResourceGroupResponse>(DoRequest("CreateResourceGroup", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateResourceGroupResponse> CreateResourceGroupWithOptionsAsync(CreateResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateResourceGroupResponse>(await DoRequestAsync("CreateResourceGroup", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceGroupWithOptions(request, runtime);
        }

        public async Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceGroupWithOptionsAsync(request, runtime);
        }

        public PromoteResourceAccountResponse PromoteResourceAccountWithOptions(PromoteResourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PromoteResourceAccountResponse>(DoRequest("PromoteResourceAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PromoteResourceAccountResponse> PromoteResourceAccountWithOptionsAsync(PromoteResourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PromoteResourceAccountResponse>(await DoRequestAsync("PromoteResourceAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public PromoteResourceAccountResponse PromoteResourceAccount(PromoteResourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PromoteResourceAccountWithOptions(request, runtime);
        }

        public async Task<PromoteResourceAccountResponse> PromoteResourceAccountAsync(PromoteResourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PromoteResourceAccountWithOptionsAsync(request, runtime);
        }

        public ListAccountsResponse ListAccountsWithOptions(ListAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAccountsResponse>(DoRequest("ListAccounts", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListAccountsResponse> ListAccountsWithOptionsAsync(ListAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAccountsResponse>(await DoRequestAsync("ListAccounts", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountsWithOptions(request, runtime);
        }

        public async Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountsWithOptionsAsync(request, runtime);
        }

        public CancelPromoteResourceAccountResponse CancelPromoteResourceAccountWithOptions(CancelPromoteResourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelPromoteResourceAccountResponse>(DoRequest("CancelPromoteResourceAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelPromoteResourceAccountResponse> CancelPromoteResourceAccountWithOptionsAsync(CancelPromoteResourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelPromoteResourceAccountResponse>(await DoRequestAsync("CancelPromoteResourceAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CancelPromoteResourceAccountResponse CancelPromoteResourceAccount(CancelPromoteResourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPromoteResourceAccountWithOptions(request, runtime);
        }

        public async Task<CancelPromoteResourceAccountResponse> CancelPromoteResourceAccountAsync(CancelPromoteResourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPromoteResourceAccountWithOptionsAsync(request, runtime);
        }

        public CreateFolderResponse CreateFolderWithOptions(CreateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFolderResponse>(DoRequest("CreateFolder", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateFolderResponse> CreateFolderWithOptionsAsync(CreateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFolderResponse>(await DoRequestAsync("CreateFolder", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CreateFolderResponse CreateFolder(CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFolderWithOptions(request, runtime);
        }

        public async Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFolderWithOptionsAsync(request, runtime);
        }

        public DeleteFolderResponse DeleteFolderWithOptions(DeleteFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFolderResponse>(DoRequest("DeleteFolder", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteFolderResponse> DeleteFolderWithOptionsAsync(DeleteFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFolderResponse>(await DoRequestAsync("DeleteFolder", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public DeleteFolderResponse DeleteFolder(DeleteFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFolderWithOptions(request, runtime);
        }

        public async Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFolderWithOptionsAsync(request, runtime);
        }

        public GetAccountResponse GetAccountWithOptions(GetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAccountResponse>(DoRequest("GetAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetAccountResponse> GetAccountWithOptionsAsync(GetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAccountResponse>(await DoRequestAsync("GetAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetAccountResponse GetAccount(GetAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountWithOptions(request, runtime);
        }

        public async Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountWithOptionsAsync(request, runtime);
        }

        public GetResourceDirectoryResponse GetResourceDirectoryWithOptions(GetResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetResourceDirectoryResponse>(DoRequest("GetResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetResourceDirectoryResponse> GetResourceDirectoryWithOptionsAsync(GetResourceDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetResourceDirectoryResponse>(await DoRequestAsync("GetResourceDirectory", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetResourceDirectoryResponse GetResourceDirectory(GetResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceDirectoryWithOptions(request, runtime);
        }

        public async Task<GetResourceDirectoryResponse> GetResourceDirectoryAsync(GetResourceDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceDirectoryWithOptionsAsync(request, runtime);
        }

        public UpdateFolderResponse UpdateFolderWithOptions(UpdateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFolderResponse>(DoRequest("UpdateFolder", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateFolderResponse> UpdateFolderWithOptionsAsync(UpdateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFolderResponse>(await DoRequestAsync("UpdateFolder", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public UpdateFolderResponse UpdateFolder(UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFolderWithOptions(request, runtime);
        }

        public async Task<UpdateFolderResponse> UpdateFolderAsync(UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFolderWithOptionsAsync(request, runtime);
        }

        public MoveAccountResponse MoveAccountWithOptions(MoveAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<MoveAccountResponse>(DoRequest("MoveAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<MoveAccountResponse> MoveAccountWithOptionsAsync(MoveAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<MoveAccountResponse>(await DoRequestAsync("MoveAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public MoveAccountResponse MoveAccount(MoveAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveAccountWithOptions(request, runtime);
        }

        public async Task<MoveAccountResponse> MoveAccountAsync(MoveAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveAccountWithOptionsAsync(request, runtime);
        }

        public ListAncestorsResponse ListAncestorsWithOptions(ListAncestorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAncestorsResponse>(DoRequest("ListAncestors", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListAncestorsResponse> ListAncestorsWithOptionsAsync(ListAncestorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAncestorsResponse>(await DoRequestAsync("ListAncestors", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListAncestorsResponse ListAncestors(ListAncestorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAncestorsWithOptions(request, runtime);
        }

        public async Task<ListAncestorsResponse> ListAncestorsAsync(ListAncestorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAncestorsWithOptionsAsync(request, runtime);
        }

        public ResendCreateCloudAccountEmailResponse ResendCreateCloudAccountEmailWithOptions(ResendCreateCloudAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResendCreateCloudAccountEmailResponse>(DoRequest("ResendCreateCloudAccountEmail", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResendCreateCloudAccountEmailResponse> ResendCreateCloudAccountEmailWithOptionsAsync(ResendCreateCloudAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResendCreateCloudAccountEmailResponse>(await DoRequestAsync("ResendCreateCloudAccountEmail", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ResendCreateCloudAccountEmailResponse ResendCreateCloudAccountEmail(ResendCreateCloudAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendCreateCloudAccountEmailWithOptions(request, runtime);
        }

        public async Task<ResendCreateCloudAccountEmailResponse> ResendCreateCloudAccountEmailAsync(ResendCreateCloudAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendCreateCloudAccountEmailWithOptionsAsync(request, runtime);
        }

        public GetPayerForAccountResponse GetPayerForAccountWithOptions(GetPayerForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPayerForAccountResponse>(DoRequest("GetPayerForAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPayerForAccountResponse> GetPayerForAccountWithOptionsAsync(GetPayerForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPayerForAccountResponse>(await DoRequestAsync("GetPayerForAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public GetPayerForAccountResponse GetPayerForAccount(GetPayerForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPayerForAccountWithOptions(request, runtime);
        }

        public async Task<GetPayerForAccountResponse> GetPayerForAccountAsync(GetPayerForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPayerForAccountWithOptionsAsync(request, runtime);
        }

        public ResendPromoteResourceAccountEmailResponse ResendPromoteResourceAccountEmailWithOptions(ResendPromoteResourceAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResendPromoteResourceAccountEmailResponse>(DoRequest("ResendPromoteResourceAccountEmail", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResendPromoteResourceAccountEmailResponse> ResendPromoteResourceAccountEmailWithOptionsAsync(ResendPromoteResourceAccountEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResendPromoteResourceAccountEmailResponse>(await DoRequestAsync("ResendPromoteResourceAccountEmail", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ResendPromoteResourceAccountEmailResponse ResendPromoteResourceAccountEmail(ResendPromoteResourceAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendPromoteResourceAccountEmailWithOptions(request, runtime);
        }

        public async Task<ResendPromoteResourceAccountEmailResponse> ResendPromoteResourceAccountEmailAsync(ResendPromoteResourceAccountEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendPromoteResourceAccountEmailWithOptionsAsync(request, runtime);
        }

        public ListFoldersForParentResponse ListFoldersForParentWithOptions(ListFoldersForParentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFoldersForParentResponse>(DoRequest("ListFoldersForParent", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListFoldersForParentResponse> ListFoldersForParentWithOptionsAsync(ListFoldersForParentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFoldersForParentResponse>(await DoRequestAsync("ListFoldersForParent", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public ListFoldersForParentResponse ListFoldersForParent(ListFoldersForParentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFoldersForParentWithOptions(request, runtime);
        }

        public async Task<ListFoldersForParentResponse> ListFoldersForParentAsync(ListFoldersForParentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFoldersForParentWithOptionsAsync(request, runtime);
        }

        public RemoveCloudAccountResponse RemoveCloudAccountWithOptions(RemoveCloudAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveCloudAccountResponse>(DoRequest("RemoveCloudAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RemoveCloudAccountResponse> RemoveCloudAccountWithOptionsAsync(RemoveCloudAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveCloudAccountResponse>(await DoRequestAsync("RemoveCloudAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public RemoveCloudAccountResponse RemoveCloudAccount(RemoveCloudAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveCloudAccountWithOptions(request, runtime);
        }

        public async Task<RemoveCloudAccountResponse> RemoveCloudAccountAsync(RemoveCloudAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveCloudAccountWithOptionsAsync(request, runtime);
        }

        public CancelCreateCloudAccountResponse CancelCreateCloudAccountWithOptions(CancelCreateCloudAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelCreateCloudAccountResponse>(DoRequest("CancelCreateCloudAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelCreateCloudAccountResponse> CancelCreateCloudAccountWithOptionsAsync(CancelCreateCloudAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelCreateCloudAccountResponse>(await DoRequestAsync("CancelCreateCloudAccount", "HTTPS", "POST", "2020-03-31", "AK", null, request.ToMap(), runtime));
        }

        public CancelCreateCloudAccountResponse CancelCreateCloudAccount(CancelCreateCloudAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelCreateCloudAccountWithOptions(request, runtime);
        }

        public async Task<CancelCreateCloudAccountResponse> CancelCreateCloudAccountAsync(CancelCreateCloudAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelCreateCloudAccountWithOptionsAsync(request, runtime);
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

    }
}
