// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ecd20200930.Models;

namespace AlibabaCloud.SDK.Ecd20200930
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecd", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public ModifyPolicyGroupResponse ModifyPolicyGroupWithOptions(ModifyPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(DoRequest("ModifyPolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupWithOptionsAsync(ModifyPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(await DoRequestAsync("ModifyPolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyPolicyGroupResponse ModifyPolicyGroup(ModifyPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyGroupWithOptions(request, runtime);
        }

        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupAsync(ModifyPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyGroupWithOptionsAsync(request, runtime);
        }

        public PayOrderCallbackResponse PayOrderCallbackWithOptions(PayOrderCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PayOrderCallbackResponse>(DoRequest("PayOrderCallback", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PayOrderCallbackResponse> PayOrderCallbackWithOptionsAsync(PayOrderCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PayOrderCallbackResponse>(await DoRequestAsync("PayOrderCallback", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public PayOrderCallbackResponse PayOrderCallback(PayOrderCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PayOrderCallbackWithOptions(request, runtime);
        }

        public async Task<PayOrderCallbackResponse> PayOrderCallbackAsync(PayOrderCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PayOrderCallbackWithOptionsAsync(request, runtime);
        }

        public DescribeDesktopTypesResponse DescribeDesktopTypesWithOptions(DescribeDesktopTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopTypesResponse>(DoRequest("DescribeDesktopTypes", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDesktopTypesResponse> DescribeDesktopTypesWithOptionsAsync(DescribeDesktopTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopTypesResponse>(await DoRequestAsync("DescribeDesktopTypes", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDesktopTypesResponse DescribeDesktopTypes(DescribeDesktopTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopTypesWithOptions(request, runtime);
        }

        public async Task<DescribeDesktopTypesResponse> DescribeDesktopTypesAsync(DescribeDesktopTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopTypesWithOptionsAsync(request, runtime);
        }

        public DescribeDirectoriesResponse DescribeDirectoriesWithOptions(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDirectoriesResponse>(DoRequest("DescribeDirectories", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesWithOptionsAsync(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDirectoriesResponse>(await DoRequestAsync("DescribeDirectories", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDirectoriesWithOptions(request, runtime);
        }

        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(DescribeDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDirectoriesWithOptionsAsync(request, runtime);
        }

        public DeleteDirectoriesResponse DeleteDirectoriesWithOptions(DeleteDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDirectoriesResponse>(DoRequest("DeleteDirectories", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDirectoriesResponse> DeleteDirectoriesWithOptionsAsync(DeleteDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDirectoriesResponse>(await DoRequestAsync("DeleteDirectories", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDirectoriesResponse DeleteDirectories(DeleteDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDirectoriesWithOptions(request, runtime);
        }

        public async Task<DeleteDirectoriesResponse> DeleteDirectoriesAsync(DeleteDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDirectoriesWithOptionsAsync(request, runtime);
        }

        public ListDirectoryUsersResponse ListDirectoryUsersWithOptions(ListDirectoryUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDirectoryUsersResponse>(DoRequest("ListDirectoryUsers", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDirectoryUsersResponse> ListDirectoryUsersWithOptionsAsync(ListDirectoryUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDirectoryUsersResponse>(await DoRequestAsync("ListDirectoryUsers", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ListDirectoryUsersResponse ListDirectoryUsers(ListDirectoryUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDirectoryUsersWithOptions(request, runtime);
        }

        public async Task<ListDirectoryUsersResponse> ListDirectoryUsersAsync(ListDirectoryUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDirectoryUsersWithOptionsAsync(request, runtime);
        }

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageResponse>(DoRequest("CreateImage", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageResponse>(await DoRequestAsync("CreateImage", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageWithOptions(request, runtime);
        }

        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageWithOptionsAsync(request, runtime);
        }

        public CreateRAMDirectoryResponse CreateRAMDirectoryWithOptions(CreateRAMDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRAMDirectoryResponse>(DoRequest("CreateRAMDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRAMDirectoryResponse> CreateRAMDirectoryWithOptionsAsync(CreateRAMDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRAMDirectoryResponse>(await DoRequestAsync("CreateRAMDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateRAMDirectoryResponse CreateRAMDirectory(CreateRAMDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRAMDirectoryWithOptions(request, runtime);
        }

        public async Task<CreateRAMDirectoryResponse> CreateRAMDirectoryAsync(CreateRAMDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRAMDirectoryWithOptionsAsync(request, runtime);
        }

        public DeletePolicyGroupsResponse DeletePolicyGroupsWithOptions(DeletePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePolicyGroupsResponse>(DoRequest("DeletePolicyGroups", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePolicyGroupsResponse> DeletePolicyGroupsWithOptionsAsync(DeletePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePolicyGroupsResponse>(await DoRequestAsync("DeletePolicyGroups", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeletePolicyGroupsResponse DeletePolicyGroups(DeletePolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyGroupsWithOptions(request, runtime);
        }

        public async Task<DeletePolicyGroupsResponse> DeletePolicyGroupsAsync(DeletePolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyGroupsWithOptionsAsync(request, runtime);
        }

        public DescribePolicyGroupsResponse DescribePolicyGroupsWithOptions(DescribePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePolicyGroupsResponse>(DoRequest("DescribePolicyGroups", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePolicyGroupsResponse> DescribePolicyGroupsWithOptionsAsync(DescribePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePolicyGroupsResponse>(await DoRequestAsync("DescribePolicyGroups", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribePolicyGroupsResponse DescribePolicyGroups(DescribePolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyGroupsWithOptions(request, runtime);
        }

        public async Task<DescribePolicyGroupsResponse> DescribePolicyGroupsAsync(DescribePolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyGroupsWithOptionsAsync(request, runtime);
        }

        public DeleteDesktopsResponse DeleteDesktopsWithOptions(DeleteDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDesktopsResponse>(DoRequest("DeleteDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDesktopsResponse> DeleteDesktopsWithOptionsAsync(DeleteDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDesktopsResponse>(await DoRequestAsync("DeleteDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDesktopsResponse DeleteDesktops(DeleteDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDesktopsWithOptions(request, runtime);
        }

        public async Task<DeleteDesktopsResponse> DeleteDesktopsAsync(DeleteDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDesktopsWithOptionsAsync(request, runtime);
        }

        public ModifyImageAttributeResponse ModifyImageAttributeWithOptions(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyImageAttributeResponse>(DoRequest("ModifyImageAttribute", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeWithOptionsAsync(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyImageAttributeResponse>(await DoRequestAsync("ModifyImageAttribute", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageAttributeWithOptionsAsync(request, runtime);
        }

        public DoLogicalDeleteResourceResponse DoLogicalDeleteResourceWithOptions(DoLogicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DoLogicalDeleteResourceResponse>(DoRequest("DoLogicalDeleteResource", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DoLogicalDeleteResourceResponse> DoLogicalDeleteResourceWithOptionsAsync(DoLogicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DoLogicalDeleteResourceResponse>(await DoRequestAsync("DoLogicalDeleteResource", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DoLogicalDeleteResourceResponse DoLogicalDeleteResource(DoLogicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoLogicalDeleteResourceWithOptions(request, runtime);
        }

        public async Task<DoLogicalDeleteResourceResponse> DoLogicalDeleteResourceAsync(DoLogicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoLogicalDeleteResourceWithOptionsAsync(request, runtime);
        }

        public ModifyEntitlementResponse ModifyEntitlementWithOptions(ModifyEntitlementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyEntitlementResponse>(DoRequest("ModifyEntitlement", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyEntitlementResponse> ModifyEntitlementWithOptionsAsync(ModifyEntitlementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyEntitlementResponse>(await DoRequestAsync("ModifyEntitlement", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyEntitlementResponse ModifyEntitlement(ModifyEntitlementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEntitlementWithOptions(request, runtime);
        }

        public async Task<ModifyEntitlementResponse> ModifyEntitlementAsync(ModifyEntitlementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEntitlementWithOptionsAsync(request, runtime);
        }

        public DeleteBundlesResponse DeleteBundlesWithOptions(DeleteBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBundlesResponse>(DoRequest("DeleteBundles", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteBundlesResponse> DeleteBundlesWithOptionsAsync(DeleteBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBundlesResponse>(await DoRequestAsync("DeleteBundles", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteBundlesResponse DeleteBundles(DeleteBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBundlesWithOptions(request, runtime);
        }

        public async Task<DeleteBundlesResponse> DeleteBundlesAsync(DeleteBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBundlesWithOptionsAsync(request, runtime);
        }

        public DescribeDesktopsResponse DescribeDesktopsWithOptions(DescribeDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopsResponse>(DoRequest("DescribeDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDesktopsResponse> DescribeDesktopsWithOptionsAsync(DescribeDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopsResponse>(await DoRequestAsync("DescribeDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDesktopsResponse DescribeDesktops(DescribeDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopsWithOptions(request, runtime);
        }

        public async Task<DescribeDesktopsResponse> DescribeDesktopsAsync(DescribeDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopsWithOptionsAsync(request, runtime);
        }

        public RebootDesktopsResponse RebootDesktopsWithOptions(RebootDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RebootDesktopsResponse>(DoRequest("RebootDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RebootDesktopsResponse> RebootDesktopsWithOptionsAsync(RebootDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RebootDesktopsResponse>(await DoRequestAsync("RebootDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public RebootDesktopsResponse RebootDesktops(RebootDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootDesktopsWithOptions(request, runtime);
        }

        public async Task<RebootDesktopsResponse> RebootDesktopsAsync(RebootDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootDesktopsWithOptionsAsync(request, runtime);
        }

        public CreateBundleResponse CreateBundleWithOptions(CreateBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateBundleResponse>(DoRequest("CreateBundle", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateBundleResponse> CreateBundleWithOptionsAsync(CreateBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateBundleResponse>(await DoRequestAsync("CreateBundle", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateBundleResponse CreateBundle(CreateBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBundleWithOptions(request, runtime);
        }

        public async Task<CreateBundleResponse> CreateBundleAsync(CreateBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBundleWithOptionsAsync(request, runtime);
        }

        public ModifyDesktopsPolicyGroupResponse ModifyDesktopsPolicyGroupWithOptions(ModifyDesktopsPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDesktopsPolicyGroupResponse>(DoRequest("ModifyDesktopsPolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyDesktopsPolicyGroupResponse> ModifyDesktopsPolicyGroupWithOptionsAsync(ModifyDesktopsPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDesktopsPolicyGroupResponse>(await DoRequestAsync("ModifyDesktopsPolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyDesktopsPolicyGroupResponse ModifyDesktopsPolicyGroup(ModifyDesktopsPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDesktopsPolicyGroupWithOptions(request, runtime);
        }

        public async Task<ModifyDesktopsPolicyGroupResponse> ModifyDesktopsPolicyGroupAsync(ModifyDesktopsPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDesktopsPolicyGroupWithOptionsAsync(request, runtime);
        }

        public CreatePolicyGroupResponse CreatePolicyGroupWithOptions(CreatePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePolicyGroupResponse>(DoRequest("CreatePolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupWithOptionsAsync(CreatePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePolicyGroupResponse>(await DoRequestAsync("CreatePolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreatePolicyGroupResponse CreatePolicyGroup(CreatePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyGroupWithOptions(request, runtime);
        }

        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupAsync(CreatePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyGroupWithOptionsAsync(request, runtime);
        }

        public DoPhysicalDeleteResourceResponse DoPhysicalDeleteResourceWithOptions(DoPhysicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DoPhysicalDeleteResourceResponse>(DoRequest("DoPhysicalDeleteResource", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DoPhysicalDeleteResourceResponse> DoPhysicalDeleteResourceWithOptionsAsync(DoPhysicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DoPhysicalDeleteResourceResponse>(await DoRequestAsync("DoPhysicalDeleteResource", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DoPhysicalDeleteResourceResponse DoPhysicalDeleteResource(DoPhysicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoPhysicalDeleteResourceWithOptions(request, runtime);
        }

        public async Task<DoPhysicalDeleteResourceResponse> DoPhysicalDeleteResourceAsync(DoPhysicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoPhysicalDeleteResourceWithOptionsAsync(request, runtime);
        }

        public CreateADConnectorDirectoryResponse CreateADConnectorDirectoryWithOptions(CreateADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateADConnectorDirectoryResponse>(DoRequest("CreateADConnectorDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateADConnectorDirectoryResponse> CreateADConnectorDirectoryWithOptionsAsync(CreateADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateADConnectorDirectoryResponse>(await DoRequestAsync("CreateADConnectorDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateADConnectorDirectoryResponse CreateADConnectorDirectory(CreateADConnectorDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateADConnectorDirectoryWithOptions(request, runtime);
        }

        public async Task<CreateADConnectorDirectoryResponse> CreateADConnectorDirectoryAsync(CreateADConnectorDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateADConnectorDirectoryWithOptionsAsync(request, runtime);
        }

        public GetConnectionTicketResponse GetConnectionTicketWithOptions(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetConnectionTicketResponse>(DoRequest("GetConnectionTicket", "HTTP", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetConnectionTicketResponse> GetConnectionTicketWithOptionsAsync(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetConnectionTicketResponse>(await DoRequestAsync("GetConnectionTicket", "HTTP", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public GetConnectionTicketResponse GetConnectionTicket(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionTicketWithOptions(request, runtime);
        }

        public async Task<GetConnectionTicketResponse> GetConnectionTicketAsync(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionTicketWithOptionsAsync(request, runtime);
        }

        public ModifyDesktopPolicysResponse ModifyDesktopPolicysWithOptions(ModifyDesktopPolicysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDesktopPolicysResponse>(DoRequest("ModifyDesktopPolicys", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyDesktopPolicysResponse> ModifyDesktopPolicysWithOptionsAsync(ModifyDesktopPolicysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDesktopPolicysResponse>(await DoRequestAsync("ModifyDesktopPolicys", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyDesktopPolicysResponse ModifyDesktopPolicys(ModifyDesktopPolicysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDesktopPolicysWithOptions(request, runtime);
        }

        public async Task<ModifyDesktopPolicysResponse> ModifyDesktopPolicysAsync(ModifyDesktopPolicysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDesktopPolicysWithOptionsAsync(request, runtime);
        }

        public DescribeBundlesResponse DescribeBundlesWithOptions(DescribeBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBundlesResponse>(DoRequest("DescribeBundles", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBundlesResponse> DescribeBundlesWithOptionsAsync(DescribeBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBundlesResponse>(await DoRequestAsync("DescribeBundles", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeBundlesResponse DescribeBundles(DescribeBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBundlesWithOptions(request, runtime);
        }

        public async Task<DescribeBundlesResponse> DescribeBundlesAsync(DescribeBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBundlesWithOptionsAsync(request, runtime);
        }

        public DeleteImagesResponse DeleteImagesWithOptions(DeleteImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteImagesResponse>(DoRequest("DeleteImages", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteImagesResponse> DeleteImagesWithOptionsAsync(DeleteImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteImagesResponse>(await DoRequestAsync("DeleteImages", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteImagesResponse DeleteImages(DeleteImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImagesWithOptions(request, runtime);
        }

        public async Task<DeleteImagesResponse> DeleteImagesAsync(DeleteImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImagesWithOptionsAsync(request, runtime);
        }

        public DoCheckResourceResponse DoCheckResourceWithOptions(DoCheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DoCheckResourceResponse>(DoRequest("DoCheckResource", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DoCheckResourceResponse> DoCheckResourceWithOptionsAsync(DoCheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DoCheckResourceResponse>(await DoRequestAsync("DoCheckResource", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
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

        public DescribeDesktopPolicysResponse DescribeDesktopPolicysWithOptions(DescribeDesktopPolicysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopPolicysResponse>(DoRequest("DescribeDesktopPolicys", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDesktopPolicysResponse> DescribeDesktopPolicysWithOptionsAsync(DescribeDesktopPolicysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopPolicysResponse>(await DoRequestAsync("DescribeDesktopPolicys", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDesktopPolicysResponse DescribeDesktopPolicys(DescribeDesktopPolicysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopPolicysWithOptions(request, runtime);
        }

        public async Task<DescribeDesktopPolicysResponse> DescribeDesktopPolicysAsync(DescribeDesktopPolicysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopPolicysWithOptionsAsync(request, runtime);
        }

        public CreateDesktopsResponse CreateDesktopsWithOptions(CreateDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDesktopsResponse>(DoRequest("CreateDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDesktopsResponse> CreateDesktopsWithOptionsAsync(CreateDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDesktopsResponse>(await DoRequestAsync("CreateDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateDesktopsResponse CreateDesktops(CreateDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDesktopsWithOptions(request, runtime);
        }

        public async Task<CreateDesktopsResponse> CreateDesktopsAsync(CreateDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDesktopsWithOptionsAsync(request, runtime);
        }

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(DoRequest("DescribeImages", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRequestAsync("DescribeImages", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImagesWithOptions(request, runtime);
        }

        public async Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImagesWithOptionsAsync(request, runtime);
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
