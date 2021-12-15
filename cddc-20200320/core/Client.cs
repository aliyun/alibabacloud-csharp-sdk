// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cddc20200320.Models;

namespace AlibabaCloud.SDK.Cddc20200320
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cddc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateDedicatedHostResponse CreateDedicatedHostWithOptions(CreateDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoRenew"] = request.AutoRenew;
            query["ClientToken"] = request.ClientToken;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["HostClass"] = request.HostClass;
            query["HostName"] = request.HostName;
            query["ImageCategory"] = request.ImageCategory;
            query["OsPassword"] = request.OsPassword;
            query["OwnerId"] = request.OwnerId;
            query["PayType"] = request.PayType;
            query["Period"] = request.Period;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["UsedTime"] = request.UsedTime;
            query["VSwitchId"] = request.VSwitchId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHost",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDedicatedHostResponse> CreateDedicatedHostWithOptionsAsync(CreateDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoRenew"] = request.AutoRenew;
            query["ClientToken"] = request.ClientToken;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["HostClass"] = request.HostClass;
            query["HostName"] = request.HostName;
            query["ImageCategory"] = request.ImageCategory;
            query["OsPassword"] = request.OsPassword;
            query["OwnerId"] = request.OwnerId;
            query["PayType"] = request.PayType;
            query["Period"] = request.Period;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["UsedTime"] = request.UsedTime;
            query["VSwitchId"] = request.VSwitchId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHost",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDedicatedHostResponse CreateDedicatedHost(CreateDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostResponse> CreateDedicatedHostAsync(CreateDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostAccountResponse CreateDedicatedHostAccountWithOptions(CreateDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["AccountType"] = request.AccountType;
            query["BastionInstanceId"] = request.BastionInstanceId;
            query["ClientToken"] = request.ClientToken;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostAccount",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDedicatedHostAccountResponse> CreateDedicatedHostAccountWithOptionsAsync(CreateDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["AccountType"] = request.AccountType;
            query["BastionInstanceId"] = request.BastionInstanceId;
            query["ClientToken"] = request.ClientToken;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostAccount",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDedicatedHostAccountResponse CreateDedicatedHostAccount(CreateDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostAccountResponse> CreateDedicatedHostAccountAsync(CreateDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostGroupResponse CreateDedicatedHostGroupWithOptions(CreateDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllocationPolicy"] = request.AllocationPolicy;
            query["ClientToken"] = request.ClientToken;
            query["CpuAllocationRatio"] = request.CpuAllocationRatio;
            query["DedicatedHostGroupDesc"] = request.DedicatedHostGroupDesc;
            query["DiskAllocationRatio"] = request.DiskAllocationRatio;
            query["Engine"] = request.Engine;
            query["HostReplacePolicy"] = request.HostReplacePolicy;
            query["MemAllocationRatio"] = request.MemAllocationRatio;
            query["OpenPermission"] = request.OpenPermission;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VPCId"] = request.VPCId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostGroup",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDedicatedHostGroupResponse> CreateDedicatedHostGroupWithOptionsAsync(CreateDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllocationPolicy"] = request.AllocationPolicy;
            query["ClientToken"] = request.ClientToken;
            query["CpuAllocationRatio"] = request.CpuAllocationRatio;
            query["DedicatedHostGroupDesc"] = request.DedicatedHostGroupDesc;
            query["DiskAllocationRatio"] = request.DiskAllocationRatio;
            query["Engine"] = request.Engine;
            query["HostReplacePolicy"] = request.HostReplacePolicy;
            query["MemAllocationRatio"] = request.MemAllocationRatio;
            query["OpenPermission"] = request.OpenPermission;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VPCId"] = request.VPCId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostGroup",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDedicatedHostGroupResponse CreateDedicatedHostGroup(CreateDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostGroupWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostGroupResponse> CreateDedicatedHostGroupAsync(CreateDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostGroupWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostAccountResponse DeleteDedicatedHostAccountWithOptions(DeleteDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDedicatedHostAccount",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDedicatedHostAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDedicatedHostAccountResponse> DeleteDedicatedHostAccountWithOptionsAsync(DeleteDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDedicatedHostAccount",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDedicatedHostAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDedicatedHostAccountResponse DeleteDedicatedHostAccount(DeleteDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostAccountResponse> DeleteDedicatedHostAccountAsync(DeleteDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostGroupResponse DeleteDedicatedHostGroupWithOptions(DeleteDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDedicatedHostGroup",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDedicatedHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDedicatedHostGroupResponse> DeleteDedicatedHostGroupWithOptionsAsync(DeleteDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDedicatedHostGroup",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDedicatedHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDedicatedHostGroupResponse DeleteDedicatedHostGroup(DeleteDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostGroupResponse> DeleteDedicatedHostGroupAsync(DeleteDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostGroupWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostAttributeResponse DescribeDedicatedHostAttributeWithOptions(DescribeDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostAttribute",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedHostAttributeResponse> DescribeDedicatedHostAttributeWithOptionsAsync(DescribeDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostAttribute",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedHostAttributeResponse DescribeDedicatedHostAttribute(DescribeDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostAttributeResponse> DescribeDedicatedHostAttributeAsync(DescribeDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostDisksResponse DescribeDedicatedHostDisksWithOptions(DescribeDedicatedHostDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostDisks",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostDisksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedHostDisksResponse> DescribeDedicatedHostDisksWithOptionsAsync(DescribeDedicatedHostDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostDisks",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostDisksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedHostDisksResponse DescribeDedicatedHostDisks(DescribeDedicatedHostDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostDisksWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostDisksResponse> DescribeDedicatedHostDisksAsync(DescribeDedicatedHostDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostDisksWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostGroupsResponse DescribeDedicatedHostGroupsWithOptions(DescribeDedicatedHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["Engine"] = request.Engine;
            query["ImageCategory"] = request.ImageCategory;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostGroups",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedHostGroupsResponse> DescribeDedicatedHostGroupsWithOptionsAsync(DescribeDedicatedHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["Engine"] = request.Engine;
            query["ImageCategory"] = request.ImageCategory;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostGroups",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedHostGroupsResponse DescribeDedicatedHostGroups(DescribeDedicatedHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostGroupsResponse> DescribeDedicatedHostGroupsAsync(DescribeDedicatedHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHostsWithOptions(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllocationStatus"] = request.AllocationStatus;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["HostStatus"] = request.HostStatus;
            query["HostType"] = request.HostType;
            query["OrderId"] = request.OrderId;
            query["OwnerId"] = request.OwnerId;
            query["PageNumbers"] = request.PageNumbers;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Tags"] = request.Tags;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHosts",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsWithOptionsAsync(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllocationStatus"] = request.AllocationStatus;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["HostStatus"] = request.HostStatus;
            query["HostType"] = request.HostType;
            query["OrderId"] = request.OrderId;
            query["OwnerId"] = request.OwnerId;
            query["PageNumbers"] = request.PageNumbers;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Tags"] = request.Tags;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHosts",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHosts(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsAsync(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public DescribeHostEcsLevelInfoResponse DescribeHostEcsLevelInfoWithOptions(DescribeHostEcsLevelInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbType"] = request.DbType;
            query["ImageCategory"] = request.ImageCategory;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StorageType"] = request.StorageType;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHostEcsLevelInfo",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHostEcsLevelInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHostEcsLevelInfoResponse> DescribeHostEcsLevelInfoWithOptionsAsync(DescribeHostEcsLevelInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbType"] = request.DbType;
            query["ImageCategory"] = request.ImageCategory;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StorageType"] = request.StorageType;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHostEcsLevelInfo",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHostEcsLevelInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHostEcsLevelInfoResponse DescribeHostEcsLevelInfo(DescribeHostEcsLevelInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostEcsLevelInfoWithOptions(request, runtime);
        }

        public async Task<DescribeHostEcsLevelInfoResponse> DescribeHostEcsLevelInfoAsync(DescribeHostEcsLevelInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostEcsLevelInfoWithOptionsAsync(request, runtime);
        }

        public DescribeHostWebShellResponse DescribeHostWebShellWithOptions(DescribeHostWebShellRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHostWebShell",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHostWebShellResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHostWebShellResponse> DescribeHostWebShellWithOptionsAsync(DescribeHostWebShellRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHostWebShell",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHostWebShellResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHostWebShellResponse DescribeHostWebShell(DescribeHostWebShellRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostWebShellWithOptions(request, runtime);
        }

        public async Task<DescribeHostWebShellResponse> DescribeHostWebShellAsync(DescribeHostWebShellRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostWebShellWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAccountResponse ModifyDedicatedHostAccountWithOptions(ModifyDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostAccount",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostAccountResponse> ModifyDedicatedHostAccountWithOptionsAsync(ModifyDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostAccount",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostAccountResponse ModifyDedicatedHostAccount(ModifyDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAccountResponse> ModifyDedicatedHostAccountAsync(ModifyDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttributeWithOptions(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllocationStatus"] = request.AllocationStatus;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["HostName"] = request.HostName;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostAttribute",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeWithOptionsAsync(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllocationStatus"] = request.AllocationStatus;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["HostName"] = request.HostName;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostAttribute",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttribute(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeAsync(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostClassResponse ModifyDedicatedHostClassWithOptions(ModifyDedicatedHostClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SwitchTime"] = request.SwitchTime;
            query["SwitchTimeMode"] = request.SwitchTimeMode;
            query["TargetClassCode"] = request.TargetClassCode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostClass",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostClassResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostClassResponse> ModifyDedicatedHostClassWithOptionsAsync(ModifyDedicatedHostClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SwitchTime"] = request.SwitchTime;
            query["SwitchTimeMode"] = request.SwitchTimeMode;
            query["TargetClassCode"] = request.TargetClassCode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostClass",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostClassResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostClassResponse ModifyDedicatedHostClass(ModifyDedicatedHostClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostClassWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostClassResponse> ModifyDedicatedHostClassAsync(ModifyDedicatedHostClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostClassWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostGroupAttributeResponse ModifyDedicatedHostGroupAttributeWithOptions(ModifyDedicatedHostGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllocationPolicy"] = request.AllocationPolicy;
            query["CpuAllocationRatio"] = request.CpuAllocationRatio;
            query["DedicatedHostGroupDesc"] = request.DedicatedHostGroupDesc;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DiskAllocationRatio"] = request.DiskAllocationRatio;
            query["HostReplacePolicy"] = request.HostReplacePolicy;
            query["MemAllocationRatio"] = request.MemAllocationRatio;
            query["OpenPermission"] = request.OpenPermission;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostGroupAttribute",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostGroupAttributeResponse> ModifyDedicatedHostGroupAttributeWithOptionsAsync(ModifyDedicatedHostGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllocationPolicy"] = request.AllocationPolicy;
            query["CpuAllocationRatio"] = request.CpuAllocationRatio;
            query["DedicatedHostGroupDesc"] = request.DedicatedHostGroupDesc;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DiskAllocationRatio"] = request.DiskAllocationRatio;
            query["HostReplacePolicy"] = request.HostReplacePolicy;
            query["MemAllocationRatio"] = request.MemAllocationRatio;
            query["OpenPermission"] = request.OpenPermission;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostGroupAttribute",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostGroupAttributeResponse ModifyDedicatedHostGroupAttribute(ModifyDedicatedHostGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostGroupAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostGroupAttributeResponse> ModifyDedicatedHostGroupAttributeAsync(ModifyDedicatedHostGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostGroupAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostPasswordResponse ModifyDedicatedHostPasswordWithOptions(ModifyDedicatedHostPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["NewPassword"] = request.NewPassword;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostPassword",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostPasswordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostPasswordResponse> ModifyDedicatedHostPasswordWithOptionsAsync(ModifyDedicatedHostPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["NewPassword"] = request.NewPassword;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostPassword",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostPasswordResponse ModifyDedicatedHostPassword(ModifyDedicatedHostPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostPasswordWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostPasswordResponse> ModifyDedicatedHostPasswordAsync(ModifyDedicatedHostPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostPasswordWithOptionsAsync(request, runtime);
        }

        public QueryHostBaseInfoByInstanceResponse QueryHostBaseInfoByInstanceWithOptions(QueryHostBaseInfoByInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHostBaseInfoByInstance",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHostBaseInfoByInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryHostBaseInfoByInstanceResponse> QueryHostBaseInfoByInstanceWithOptionsAsync(QueryHostBaseInfoByInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHostBaseInfoByInstance",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHostBaseInfoByInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryHostBaseInfoByInstanceResponse QueryHostBaseInfoByInstance(QueryHostBaseInfoByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHostBaseInfoByInstanceWithOptions(request, runtime);
        }

        public async Task<QueryHostBaseInfoByInstanceResponse> QueryHostBaseInfoByInstanceAsync(QueryHostBaseInfoByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHostBaseInfoByInstanceWithOptionsAsync(request, runtime);
        }

        public QueryHostInstanceConsoleInfoResponse QueryHostInstanceConsoleInfoWithOptions(QueryHostInstanceConsoleInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHostInstanceConsoleInfo",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHostInstanceConsoleInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryHostInstanceConsoleInfoResponse> QueryHostInstanceConsoleInfoWithOptionsAsync(QueryHostInstanceConsoleInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHostInstanceConsoleInfo",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHostInstanceConsoleInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryHostInstanceConsoleInfoResponse QueryHostInstanceConsoleInfo(QueryHostInstanceConsoleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHostInstanceConsoleInfoWithOptions(request, runtime);
        }

        public async Task<QueryHostInstanceConsoleInfoResponse> QueryHostInstanceConsoleInfoAsync(QueryHostInstanceConsoleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHostInstanceConsoleInfoWithOptionsAsync(request, runtime);
        }

        public ReplaceDedicatedHostResponse ReplaceDedicatedHostWithOptions(ReplaceDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceDedicatedHost",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceDedicatedHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReplaceDedicatedHostResponse> ReplaceDedicatedHostWithOptionsAsync(ReplaceDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceDedicatedHost",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceDedicatedHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReplaceDedicatedHostResponse ReplaceDedicatedHost(ReplaceDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceDedicatedHostWithOptions(request, runtime);
        }

        public async Task<ReplaceDedicatedHostResponse> ReplaceDedicatedHostAsync(ReplaceDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceDedicatedHostWithOptionsAsync(request, runtime);
        }

        public RestartDedicatedHostResponse RestartDedicatedHostWithOptions(RestartDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            query["ForceStop"] = request.ForceStop;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDedicatedHost",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDedicatedHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartDedicatedHostResponse> RestartDedicatedHostWithOptionsAsync(RestartDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            query["ForceStop"] = request.ForceStop;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDedicatedHost",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDedicatedHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartDedicatedHostResponse RestartDedicatedHost(RestartDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDedicatedHostWithOptions(request, runtime);
        }

        public async Task<RestartDedicatedHostResponse> RestartDedicatedHostAsync(RestartDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDedicatedHostWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
