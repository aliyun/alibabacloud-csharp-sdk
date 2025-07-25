// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.VpcIpam20230228.Models;

namespace AlibabaCloud.SDK.VpcIpam20230228
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vpcipam", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provisions a CIDR block to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you provision a CIDR block, make sure that an IPAM pool is created. You can call the <b>CreateIpamPool</b> operation to create an IPAM pool.</para>
        /// <list type="bullet">
        /// <item><description>If no CIDR block is provisioned to a parent pool, you cannot provision CIDR blocks to its subpools.</description></item>
        /// <item><description>If a CIDR block is provisioned to a parent pool, you can provision CIDR blocks to its subpools and the CIDR blocks must be subsets of the CIDR block provisioned to the parent pool.</description></item>
        /// <item><description>If a CIDR block is provisioned to a parent pool and allocations are created, CIDR blocks provisioned to its subpools cannot overlap with existing allocated CIDR blocks.</description></item>
        /// <item><description>You can provision CIDR blocks to a pool only in the region where the IPAM is hosted.</description></item>
        /// <item><description>CIDR blocks provisioned to an IPAM pool cannot overlap with the CIDR blocks provisioned to other pools in the same scope.</description></item>
        /// <item><description>You can provision at most 50 CIDR blocks to each pool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddIpamPoolCidrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddIpamPoolCidrResponse
        /// </returns>
        public AddIpamPoolCidrResponse AddIpamPoolCidrWithOptions(AddIpamPoolCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetmaskLength))
            {
                query["NetmaskLength"] = request.NetmaskLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddIpamPoolCidr",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddIpamPoolCidrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provisions a CIDR block to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you provision a CIDR block, make sure that an IPAM pool is created. You can call the <b>CreateIpamPool</b> operation to create an IPAM pool.</para>
        /// <list type="bullet">
        /// <item><description>If no CIDR block is provisioned to a parent pool, you cannot provision CIDR blocks to its subpools.</description></item>
        /// <item><description>If a CIDR block is provisioned to a parent pool, you can provision CIDR blocks to its subpools and the CIDR blocks must be subsets of the CIDR block provisioned to the parent pool.</description></item>
        /// <item><description>If a CIDR block is provisioned to a parent pool and allocations are created, CIDR blocks provisioned to its subpools cannot overlap with existing allocated CIDR blocks.</description></item>
        /// <item><description>You can provision CIDR blocks to a pool only in the region where the IPAM is hosted.</description></item>
        /// <item><description>CIDR blocks provisioned to an IPAM pool cannot overlap with the CIDR blocks provisioned to other pools in the same scope.</description></item>
        /// <item><description>You can provision at most 50 CIDR blocks to each pool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddIpamPoolCidrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddIpamPoolCidrResponse
        /// </returns>
        public async Task<AddIpamPoolCidrResponse> AddIpamPoolCidrWithOptionsAsync(AddIpamPoolCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetmaskLength))
            {
                query["NetmaskLength"] = request.NetmaskLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddIpamPoolCidr",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddIpamPoolCidrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provisions a CIDR block to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you provision a CIDR block, make sure that an IPAM pool is created. You can call the <b>CreateIpamPool</b> operation to create an IPAM pool.</para>
        /// <list type="bullet">
        /// <item><description>If no CIDR block is provisioned to a parent pool, you cannot provision CIDR blocks to its subpools.</description></item>
        /// <item><description>If a CIDR block is provisioned to a parent pool, you can provision CIDR blocks to its subpools and the CIDR blocks must be subsets of the CIDR block provisioned to the parent pool.</description></item>
        /// <item><description>If a CIDR block is provisioned to a parent pool and allocations are created, CIDR blocks provisioned to its subpools cannot overlap with existing allocated CIDR blocks.</description></item>
        /// <item><description>You can provision CIDR blocks to a pool only in the region where the IPAM is hosted.</description></item>
        /// <item><description>CIDR blocks provisioned to an IPAM pool cannot overlap with the CIDR blocks provisioned to other pools in the same scope.</description></item>
        /// <item><description>You can provision at most 50 CIDR blocks to each pool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddIpamPoolCidrRequest
        /// </param>
        /// 
        /// <returns>
        /// AddIpamPoolCidrResponse
        /// </returns>
        public AddIpamPoolCidrResponse AddIpamPoolCidr(AddIpamPoolCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIpamPoolCidrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provisions a CIDR block to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you provision a CIDR block, make sure that an IPAM pool is created. You can call the <b>CreateIpamPool</b> operation to create an IPAM pool.</para>
        /// <list type="bullet">
        /// <item><description>If no CIDR block is provisioned to a parent pool, you cannot provision CIDR blocks to its subpools.</description></item>
        /// <item><description>If a CIDR block is provisioned to a parent pool, you can provision CIDR blocks to its subpools and the CIDR blocks must be subsets of the CIDR block provisioned to the parent pool.</description></item>
        /// <item><description>If a CIDR block is provisioned to a parent pool and allocations are created, CIDR blocks provisioned to its subpools cannot overlap with existing allocated CIDR blocks.</description></item>
        /// <item><description>You can provision CIDR blocks to a pool only in the region where the IPAM is hosted.</description></item>
        /// <item><description>CIDR blocks provisioned to an IPAM pool cannot overlap with the CIDR blocks provisioned to other pools in the same scope.</description></item>
        /// <item><description>You can provision at most 50 CIDR blocks to each pool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddIpamPoolCidrRequest
        /// </param>
        /// 
        /// <returns>
        /// AddIpamPoolCidrResponse
        /// </returns>
        public async Task<AddIpamPoolCidrResponse> AddIpamPoolCidrAsync(AddIpamPoolCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIpamPoolCidrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resource discovery with an IPAM instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The specified resource discovery instance can only be associated with one IPAM instance and associations cannot be duplicated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateIpamResourceDiscoveryResponse
        /// </returns>
        public AssociateIpamResourceDiscoveryResponse AssociateIpamResourceDiscoveryWithOptions(AssociateIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateIpamResourceDiscoveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resource discovery with an IPAM instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The specified resource discovery instance can only be associated with one IPAM instance and associations cannot be duplicated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<AssociateIpamResourceDiscoveryResponse> AssociateIpamResourceDiscoveryWithOptionsAsync(AssociateIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateIpamResourceDiscoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resource discovery with an IPAM instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The specified resource discovery instance can only be associated with one IPAM instance and associations cannot be duplicated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateIpamResourceDiscoveryResponse
        /// </returns>
        public AssociateIpamResourceDiscoveryResponse AssociateIpamResourceDiscovery(AssociateIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateIpamResourceDiscoveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resource discovery with an IPAM instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The specified resource discovery instance can only be associated with one IPAM instance and associations cannot be duplicated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<AssociateIpamResourceDiscoveryResponse> AssociateIpamResourceDiscoveryAsync(AssociateIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateIpamResourceDiscoveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group of an IPAM resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group of an IPAM resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group of an IPAM resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group of an IPAM resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can create only one IPAM with each Alibaba Cloud account in each region.</description></item>
        /// <item><description>Only IPv4 IP addresses can be allocated.</description></item>
        /// <item><description>When you create an IPAM instance:<list type="bullet">
        /// <item><description>If there is no custom resource discovery in the region, the system creates a default resource discovery associated with the IPAM instance.</description></item>
        /// <item><description>If there is a custom resource discovery in the region, the system converts it to a default resource discovery and associates it with the IPAM instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamResponse
        /// </returns>
        public CreateIpamResponse CreateIpamWithOptions(CreateIpamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamDescription))
            {
                query["IpamDescription"] = request.IpamDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamName))
            {
                query["IpamName"] = request.IpamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingRegionList))
            {
                query["OperatingRegionList"] = request.OperatingRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpam",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can create only one IPAM with each Alibaba Cloud account in each region.</description></item>
        /// <item><description>Only IPv4 IP addresses can be allocated.</description></item>
        /// <item><description>When you create an IPAM instance:<list type="bullet">
        /// <item><description>If there is no custom resource discovery in the region, the system creates a default resource discovery associated with the IPAM instance.</description></item>
        /// <item><description>If there is a custom resource discovery in the region, the system converts it to a default resource discovery and associates it with the IPAM instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamResponse
        /// </returns>
        public async Task<CreateIpamResponse> CreateIpamWithOptionsAsync(CreateIpamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamDescription))
            {
                query["IpamDescription"] = request.IpamDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamName))
            {
                query["IpamName"] = request.IpamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingRegionList))
            {
                query["OperatingRegionList"] = request.OperatingRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpam",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can create only one IPAM with each Alibaba Cloud account in each region.</description></item>
        /// <item><description>Only IPv4 IP addresses can be allocated.</description></item>
        /// <item><description>When you create an IPAM instance:<list type="bullet">
        /// <item><description>If there is no custom resource discovery in the region, the system creates a default resource discovery associated with the IPAM instance.</description></item>
        /// <item><description>If there is a custom resource discovery in the region, the system converts it to a default resource discovery and associates it with the IPAM instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamResponse
        /// </returns>
        public CreateIpamResponse CreateIpam(CreateIpamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can create only one IPAM with each Alibaba Cloud account in each region.</description></item>
        /// <item><description>Only IPv4 IP addresses can be allocated.</description></item>
        /// <item><description>When you create an IPAM instance:<list type="bullet">
        /// <item><description>If there is no custom resource discovery in the region, the system creates a default resource discovery associated with the IPAM instance.</description></item>
        /// <item><description>If there is a custom resource discovery in the region, the system converts it to a default resource discovery and associates it with the IPAM instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamResponse
        /// </returns>
        public async Task<CreateIpamResponse> CreateIpamAsync(CreateIpamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIpamPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamPoolResponse
        /// </returns>
        public CreateIpamPoolResponse CreateIpamPoolWithOptions(CreateIpamPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationDefaultCidrMask))
            {
                query["AllocationDefaultCidrMask"] = request.AllocationDefaultCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationMaxCidrMask))
            {
                query["AllocationMaxCidrMask"] = request.AllocationMaxCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationMinCidrMask))
            {
                query["AllocationMinCidrMask"] = request.AllocationMinCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoImport))
            {
                query["AutoImport"] = request.AutoImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolDescription))
            {
                query["IpamPoolDescription"] = request.IpamPoolDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolName))
            {
                query["IpamPoolName"] = request.IpamPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Isp))
            {
                query["Ipv6Isp"] = request.Ipv6Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolRegionId))
            {
                query["PoolRegionId"] = request.PoolRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIpamPoolId))
            {
                query["SourceIpamPoolId"] = request.SourceIpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpamPool",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIpamPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamPoolResponse
        /// </returns>
        public async Task<CreateIpamPoolResponse> CreateIpamPoolWithOptionsAsync(CreateIpamPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationDefaultCidrMask))
            {
                query["AllocationDefaultCidrMask"] = request.AllocationDefaultCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationMaxCidrMask))
            {
                query["AllocationMaxCidrMask"] = request.AllocationMaxCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationMinCidrMask))
            {
                query["AllocationMinCidrMask"] = request.AllocationMinCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoImport))
            {
                query["AutoImport"] = request.AutoImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolDescription))
            {
                query["IpamPoolDescription"] = request.IpamPoolDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolName))
            {
                query["IpamPoolName"] = request.IpamPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Isp))
            {
                query["Ipv6Isp"] = request.Ipv6Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolRegionId))
            {
                query["PoolRegionId"] = request.PoolRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIpamPoolId))
            {
                query["SourceIpamPoolId"] = request.SourceIpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpamPool",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIpamPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamPoolResponse
        /// </returns>
        public CreateIpamPoolResponse CreateIpamPool(CreateIpamPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpamPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIpamPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamPoolResponse
        /// </returns>
        public async Task<CreateIpamPoolResponse> CreateIpamPoolAsync(CreateIpamPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpamPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reserves a custom CIDR block from an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you reserve a custom CIDR block, make sure that an IPAM pool is created and CIDR blocks are added to the pool. You can call <b>CreateIpamPool</b> to create an IPAM pool and call <b>AddIpamPoolCidr</b> to add CIDR blocks to the pool.</para>
        /// <list type="bullet">
        /// <item><description>When you specify Cidr or CidrMask to reserve a custom CIDR block, the mask must fall within the range specified by the IPAM pool.</description></item>
        /// <item><description>If the IPAM pool has the region attribute, you must reserve a custom CIDR block in the region to which the IPAM pool belongs.</description></item>
        /// <item><description>The custom CIDR block that you want to reserve cannot overlap with existing CIDR blocks created from the IPAM pool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamPoolAllocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamPoolAllocationResponse
        /// </returns>
        public CreateIpamPoolAllocationResponse CreateIpamPoolAllocationWithOptions(CreateIpamPoolAllocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CidrMask))
            {
                query["CidrMask"] = request.CidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationDescription))
            {
                query["IpamPoolAllocationDescription"] = request.IpamPoolAllocationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationName))
            {
                query["IpamPoolAllocationName"] = request.IpamPoolAllocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpamPoolAllocation",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamPoolAllocationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reserves a custom CIDR block from an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you reserve a custom CIDR block, make sure that an IPAM pool is created and CIDR blocks are added to the pool. You can call <b>CreateIpamPool</b> to create an IPAM pool and call <b>AddIpamPoolCidr</b> to add CIDR blocks to the pool.</para>
        /// <list type="bullet">
        /// <item><description>When you specify Cidr or CidrMask to reserve a custom CIDR block, the mask must fall within the range specified by the IPAM pool.</description></item>
        /// <item><description>If the IPAM pool has the region attribute, you must reserve a custom CIDR block in the region to which the IPAM pool belongs.</description></item>
        /// <item><description>The custom CIDR block that you want to reserve cannot overlap with existing CIDR blocks created from the IPAM pool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamPoolAllocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamPoolAllocationResponse
        /// </returns>
        public async Task<CreateIpamPoolAllocationResponse> CreateIpamPoolAllocationWithOptionsAsync(CreateIpamPoolAllocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CidrMask))
            {
                query["CidrMask"] = request.CidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationDescription))
            {
                query["IpamPoolAllocationDescription"] = request.IpamPoolAllocationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationName))
            {
                query["IpamPoolAllocationName"] = request.IpamPoolAllocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpamPoolAllocation",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamPoolAllocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reserves a custom CIDR block from an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you reserve a custom CIDR block, make sure that an IPAM pool is created and CIDR blocks are added to the pool. You can call <b>CreateIpamPool</b> to create an IPAM pool and call <b>AddIpamPoolCidr</b> to add CIDR blocks to the pool.</para>
        /// <list type="bullet">
        /// <item><description>When you specify Cidr or CidrMask to reserve a custom CIDR block, the mask must fall within the range specified by the IPAM pool.</description></item>
        /// <item><description>If the IPAM pool has the region attribute, you must reserve a custom CIDR block in the region to which the IPAM pool belongs.</description></item>
        /// <item><description>The custom CIDR block that you want to reserve cannot overlap with existing CIDR blocks created from the IPAM pool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamPoolAllocationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamPoolAllocationResponse
        /// </returns>
        public CreateIpamPoolAllocationResponse CreateIpamPoolAllocation(CreateIpamPoolAllocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpamPoolAllocationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reserves a custom CIDR block from an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you reserve a custom CIDR block, make sure that an IPAM pool is created and CIDR blocks are added to the pool. You can call <b>CreateIpamPool</b> to create an IPAM pool and call <b>AddIpamPoolCidr</b> to add CIDR blocks to the pool.</para>
        /// <list type="bullet">
        /// <item><description>When you specify Cidr or CidrMask to reserve a custom CIDR block, the mask must fall within the range specified by the IPAM pool.</description></item>
        /// <item><description>If the IPAM pool has the region attribute, you must reserve a custom CIDR block in the region to which the IPAM pool belongs.</description></item>
        /// <item><description>The custom CIDR block that you want to reserve cannot overlap with existing CIDR blocks created from the IPAM pool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamPoolAllocationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamPoolAllocationResponse
        /// </returns>
        public async Task<CreateIpamPoolAllocationResponse> CreateIpamPoolAllocationAsync(CreateIpamPoolAllocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpamPoolAllocationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each Alibaba Cloud account can create only one resource discovery instance in each region.</para>
        /// <list type="bullet">
        /// <item><description>You can create only custom resource discovery instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamResourceDiscoveryResponse
        /// </returns>
        public CreateIpamResourceDiscoveryResponse CreateIpamResourceDiscoveryWithOptions(CreateIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryDescription))
            {
                query["IpamResourceDiscoveryDescription"] = request.IpamResourceDiscoveryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryName))
            {
                query["IpamResourceDiscoveryName"] = request.IpamResourceDiscoveryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingRegionList))
            {
                query["OperatingRegionList"] = request.OperatingRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamResourceDiscoveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each Alibaba Cloud account can create only one resource discovery instance in each region.</para>
        /// <list type="bullet">
        /// <item><description>You can create only custom resource discovery instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<CreateIpamResourceDiscoveryResponse> CreateIpamResourceDiscoveryWithOptionsAsync(CreateIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryDescription))
            {
                query["IpamResourceDiscoveryDescription"] = request.IpamResourceDiscoveryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryName))
            {
                query["IpamResourceDiscoveryName"] = request.IpamResourceDiscoveryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingRegionList))
            {
                query["OperatingRegionList"] = request.OperatingRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamResourceDiscoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each Alibaba Cloud account can create only one resource discovery instance in each region.</para>
        /// <list type="bullet">
        /// <item><description>You can create only custom resource discovery instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamResourceDiscoveryResponse
        /// </returns>
        public CreateIpamResourceDiscoveryResponse CreateIpamResourceDiscovery(CreateIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpamResourceDiscoveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each Alibaba Cloud account can create only one resource discovery instance in each region.</para>
        /// <list type="bullet">
        /// <item><description>You can create only custom resource discovery instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<CreateIpamResourceDiscoveryResponse> CreateIpamResourceDiscoveryAsync(CreateIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpamResourceDiscoveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a public scope and private scope to respectively manage public and private IP addresses.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIpamScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamScopeResponse
        /// </returns>
        public CreateIpamScopeResponse CreateIpamScopeWithOptions(CreateIpamScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeDescription))
            {
                query["IpamScopeDescription"] = request.IpamScopeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeName))
            {
                query["IpamScopeName"] = request.IpamScopeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeType))
            {
                query["IpamScopeType"] = request.IpamScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpamScope",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamScopeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a public scope and private scope to respectively manage public and private IP addresses.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIpamScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamScopeResponse
        /// </returns>
        public async Task<CreateIpamScopeResponse> CreateIpamScopeWithOptionsAsync(CreateIpamScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeDescription))
            {
                query["IpamScopeDescription"] = request.IpamScopeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeName))
            {
                query["IpamScopeName"] = request.IpamScopeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeType))
            {
                query["IpamScopeType"] = request.IpamScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpamScope",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpamScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a public scope and private scope to respectively manage public and private IP addresses.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIpamScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamScopeResponse
        /// </returns>
        public CreateIpamScopeResponse CreateIpamScope(CreateIpamScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpamScopeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a public scope and private scope to respectively manage public and private IP addresses.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIpamScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIpamScopeResponse
        /// </returns>
        public async Task<CreateIpamScopeResponse> CreateIpamScopeAsync(CreateIpamScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpamScopeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>Before you delete an IPAM, make sure that all IPAM pools of the IPAM are deleted. You can call <b>DeleteIpamPool</b> to delete IPAM pools.</description></item>
        /// <item><description>Before you delete an IPAM, make sure that all IPAM scopes of the IPAM are deleted. You can call <b>DeleteIpamScope</b> to delete IPAM scopes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamResponse
        /// </returns>
        public DeleteIpamResponse DeleteIpamWithOptions(DeleteIpamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpam",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>Before you delete an IPAM, make sure that all IPAM pools of the IPAM are deleted. You can call <b>DeleteIpamPool</b> to delete IPAM pools.</description></item>
        /// <item><description>Before you delete an IPAM, make sure that all IPAM scopes of the IPAM are deleted. You can call <b>DeleteIpamScope</b> to delete IPAM scopes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamResponse
        /// </returns>
        public async Task<DeleteIpamResponse> DeleteIpamWithOptionsAsync(DeleteIpamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpam",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>Before you delete an IPAM, make sure that all IPAM pools of the IPAM are deleted. You can call <b>DeleteIpamPool</b> to delete IPAM pools.</description></item>
        /// <item><description>Before you delete an IPAM, make sure that all IPAM scopes of the IPAM are deleted. You can call <b>DeleteIpamScope</b> to delete IPAM scopes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamResponse
        /// </returns>
        public DeleteIpamResponse DeleteIpam(DeleteIpamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>Before you delete an IPAM, make sure that all IPAM pools of the IPAM are deleted. You can call <b>DeleteIpamPool</b> to delete IPAM pools.</description></item>
        /// <item><description>Before you delete an IPAM, make sure that all IPAM scopes of the IPAM are deleted. You can call <b>DeleteIpamScope</b> to delete IPAM scopes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamResponse
        /// </returns>
        public async Task<DeleteIpamResponse> DeleteIpamAsync(DeleteIpamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>Before you delete a parent pool, make sure that all subpools of the parent pool are deleted.</description></item>
        /// <item><description>If an effective region is specified for a parent pool and IP addresses are allocated from the parent pool, you cannot delete the parent pool.</description></item>
        /// <item><description>If an effective region is specified for a subpool and IP addresses are allocated from the subpool, you cannot delete the subpool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolResponse
        /// </returns>
        public DeleteIpamPoolResponse DeleteIpamPoolWithOptions(DeleteIpamPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamPool",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>Before you delete a parent pool, make sure that all subpools of the parent pool are deleted.</description></item>
        /// <item><description>If an effective region is specified for a parent pool and IP addresses are allocated from the parent pool, you cannot delete the parent pool.</description></item>
        /// <item><description>If an effective region is specified for a subpool and IP addresses are allocated from the subpool, you cannot delete the subpool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolResponse
        /// </returns>
        public async Task<DeleteIpamPoolResponse> DeleteIpamPoolWithOptionsAsync(DeleteIpamPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamPool",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>Before you delete a parent pool, make sure that all subpools of the parent pool are deleted.</description></item>
        /// <item><description>If an effective region is specified for a parent pool and IP addresses are allocated from the parent pool, you cannot delete the parent pool.</description></item>
        /// <item><description>If an effective region is specified for a subpool and IP addresses are allocated from the subpool, you cannot delete the subpool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolResponse
        /// </returns>
        public DeleteIpamPoolResponse DeleteIpamPool(DeleteIpamPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpamPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>Before you delete a parent pool, make sure that all subpools of the parent pool are deleted.</description></item>
        /// <item><description>If an effective region is specified for a parent pool and IP addresses are allocated from the parent pool, you cannot delete the parent pool.</description></item>
        /// <item><description>If an effective region is specified for a subpool and IP addresses are allocated from the subpool, you cannot delete the subpool.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolResponse
        /// </returns>
        public async Task<DeleteIpamPoolResponse> DeleteIpamPoolAsync(DeleteIpamPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpamPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom reserved CIDR block from an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolAllocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolAllocationResponse
        /// </returns>
        public DeleteIpamPoolAllocationResponse DeleteIpamPoolAllocationWithOptions(DeleteIpamPoolAllocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationId))
            {
                query["IpamPoolAllocationId"] = request.IpamPoolAllocationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamPoolAllocation",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamPoolAllocationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom reserved CIDR block from an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolAllocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolAllocationResponse
        /// </returns>
        public async Task<DeleteIpamPoolAllocationResponse> DeleteIpamPoolAllocationWithOptionsAsync(DeleteIpamPoolAllocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationId))
            {
                query["IpamPoolAllocationId"] = request.IpamPoolAllocationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamPoolAllocation",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamPoolAllocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom reserved CIDR block from an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolAllocationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolAllocationResponse
        /// </returns>
        public DeleteIpamPoolAllocationResponse DeleteIpamPoolAllocation(DeleteIpamPoolAllocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpamPoolAllocationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom reserved CIDR block from an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolAllocationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolAllocationResponse
        /// </returns>
        public async Task<DeleteIpamPoolAllocationResponse> DeleteIpamPoolAllocationAsync(DeleteIpamPoolAllocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpamPoolAllocationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a CIDR block provisioned to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If CIDR blocks are provisioned to a parent pool and its subpools, you must first delete the CIDR blocks provisioned to the subpools before you delete the ones provisioned to the parent pool.</para>
        /// <list type="bullet">
        /// <item><description>If CIDR blocks are provisioned only to the parent pool, directly delete them.</description></item>
        /// <item><description>If CIDR blocks are allocated from provisioned ones, you must first delete the allocated CIDR blocks before you delete the provisioned ones.</description></item>
        /// <item><description>You can delete CIDR blocks provisioned to an IPAM pool only in the region where the IPAM is hosted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolCidrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolCidrResponse
        /// </returns>
        public DeleteIpamPoolCidrResponse DeleteIpamPoolCidrWithOptions(DeleteIpamPoolCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamPoolCidr",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamPoolCidrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a CIDR block provisioned to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If CIDR blocks are provisioned to a parent pool and its subpools, you must first delete the CIDR blocks provisioned to the subpools before you delete the ones provisioned to the parent pool.</para>
        /// <list type="bullet">
        /// <item><description>If CIDR blocks are provisioned only to the parent pool, directly delete them.</description></item>
        /// <item><description>If CIDR blocks are allocated from provisioned ones, you must first delete the allocated CIDR blocks before you delete the provisioned ones.</description></item>
        /// <item><description>You can delete CIDR blocks provisioned to an IPAM pool only in the region where the IPAM is hosted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolCidrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolCidrResponse
        /// </returns>
        public async Task<DeleteIpamPoolCidrResponse> DeleteIpamPoolCidrWithOptionsAsync(DeleteIpamPoolCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamPoolCidr",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamPoolCidrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a CIDR block provisioned to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If CIDR blocks are provisioned to a parent pool and its subpools, you must first delete the CIDR blocks provisioned to the subpools before you delete the ones provisioned to the parent pool.</para>
        /// <list type="bullet">
        /// <item><description>If CIDR blocks are provisioned only to the parent pool, directly delete them.</description></item>
        /// <item><description>If CIDR blocks are allocated from provisioned ones, you must first delete the allocated CIDR blocks before you delete the provisioned ones.</description></item>
        /// <item><description>You can delete CIDR blocks provisioned to an IPAM pool only in the region where the IPAM is hosted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolCidrRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolCidrResponse
        /// </returns>
        public DeleteIpamPoolCidrResponse DeleteIpamPoolCidr(DeleteIpamPoolCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpamPoolCidrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a CIDR block provisioned to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If CIDR blocks are provisioned to a parent pool and its subpools, you must first delete the CIDR blocks provisioned to the subpools before you delete the ones provisioned to the parent pool.</para>
        /// <list type="bullet">
        /// <item><description>If CIDR blocks are provisioned only to the parent pool, directly delete them.</description></item>
        /// <item><description>If CIDR blocks are allocated from provisioned ones, you must first delete the allocated CIDR blocks before you delete the provisioned ones.</description></item>
        /// <item><description>You can delete CIDR blocks provisioned to an IPAM pool only in the region where the IPAM is hosted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamPoolCidrRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamPoolCidrResponse
        /// </returns>
        public async Task<DeleteIpamPoolCidrResponse> DeleteIpamPoolCidrAsync(DeleteIpamPoolCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpamPoolCidrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If a resource discovery instance is shared, it cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamResourceDiscoveryResponse
        /// </returns>
        public DeleteIpamResourceDiscoveryResponse DeleteIpamResourceDiscoveryWithOptions(DeleteIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamResourceDiscoveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If a resource discovery instance is shared, it cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<DeleteIpamResourceDiscoveryResponse> DeleteIpamResourceDiscoveryWithOptionsAsync(DeleteIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamResourceDiscoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If a resource discovery instance is shared, it cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamResourceDiscoveryResponse
        /// </returns>
        public DeleteIpamResourceDiscoveryResponse DeleteIpamResourceDiscovery(DeleteIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpamResourceDiscoveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If a resource discovery instance is shared, it cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<DeleteIpamResourceDiscoveryResponse> DeleteIpamResourceDiscoveryAsync(DeleteIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpamResourceDiscoveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>You cannot delete the private scope and public scope created by the system.</description></item>
        /// <item><description>Before you delete an IPAM scope, make sure that all pools within the scope are deleted. You can call <b>DeleteIpamPool</b> to delete IPAM pools.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamScopeResponse
        /// </returns>
        public DeleteIpamScopeResponse DeleteIpamScopeWithOptions(DeleteIpamScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamScope",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamScopeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>You cannot delete the private scope and public scope created by the system.</description></item>
        /// <item><description>Before you delete an IPAM scope, make sure that all pools within the scope are deleted. You can call <b>DeleteIpamPool</b> to delete IPAM pools.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamScopeResponse
        /// </returns>
        public async Task<DeleteIpamScopeResponse> DeleteIpamScopeWithOptionsAsync(DeleteIpamScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpamScope",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpamScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>You cannot delete the private scope and public scope created by the system.</description></item>
        /// <item><description>Before you delete an IPAM scope, make sure that all pools within the scope are deleted. You can call <b>DeleteIpamPool</b> to delete IPAM pools.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamScopeResponse
        /// </returns>
        public DeleteIpamScopeResponse DeleteIpamScope(DeleteIpamScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpamScopeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>You cannot delete the private scope and public scope created by the system.</description></item>
        /// <item><description>Before you delete an IPAM scope, make sure that all pools within the scope are deleted. You can call <b>DeleteIpamPool</b> to delete IPAM pools.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIpamScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIpamScopeResponse
        /// </returns>
        public async Task<DeleteIpamScopeResponse> DeleteIpamScopeAsync(DeleteIpamScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpamScopeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates resource discovery and IPAM instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateIpamResourceDiscoveryResponse
        /// </returns>
        public DissociateIpamResourceDiscoveryResponse DissociateIpamResourceDiscoveryWithOptions(DissociateIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateIpamResourceDiscoveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates resource discovery and IPAM instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<DissociateIpamResourceDiscoveryResponse> DissociateIpamResourceDiscoveryWithOptionsAsync(DissociateIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateIpamResourceDiscoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates resource discovery and IPAM instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateIpamResourceDiscoveryResponse
        /// </returns>
        public DissociateIpamResourceDiscoveryResponse DissociateIpamResourceDiscovery(DissociateIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateIpamResourceDiscoveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates resource discovery and IPAM instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<DissociateIpamResourceDiscoveryResponse> DissociateIpamResourceDiscoveryAsync(DissociateIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateIpamResourceDiscoveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIpamPoolAllocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIpamPoolAllocationResponse
        /// </returns>
        public GetIpamPoolAllocationResponse GetIpamPoolAllocationWithOptions(GetIpamPoolAllocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIpamPoolAllocation",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIpamPoolAllocationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIpamPoolAllocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIpamPoolAllocationResponse
        /// </returns>
        public async Task<GetIpamPoolAllocationResponse> GetIpamPoolAllocationWithOptionsAsync(GetIpamPoolAllocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIpamPoolAllocation",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIpamPoolAllocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIpamPoolAllocationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIpamPoolAllocationResponse
        /// </returns>
        public GetIpamPoolAllocationResponse GetIpamPoolAllocation(GetIpamPoolAllocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIpamPoolAllocationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIpamPoolAllocationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIpamPoolAllocationResponse
        /// </returns>
        public async Task<GetIpamPoolAllocationResponse> GetIpamPoolAllocationAsync(GetIpamPoolAllocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIpamPoolAllocationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the available CIDR blocks of the IPAM pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIpamPoolNextAvailableCidrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIpamPoolNextAvailableCidrResponse
        /// </returns>
        public GetIpamPoolNextAvailableCidrResponse GetIpamPoolNextAvailableCidrWithOptions(GetIpamPoolNextAvailableCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIpamPoolNextAvailableCidr",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIpamPoolNextAvailableCidrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the available CIDR blocks of the IPAM pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIpamPoolNextAvailableCidrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIpamPoolNextAvailableCidrResponse
        /// </returns>
        public async Task<GetIpamPoolNextAvailableCidrResponse> GetIpamPoolNextAvailableCidrWithOptionsAsync(GetIpamPoolNextAvailableCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIpamPoolNextAvailableCidr",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIpamPoolNextAvailableCidrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the available CIDR blocks of the IPAM pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIpamPoolNextAvailableCidrRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIpamPoolNextAvailableCidrResponse
        /// </returns>
        public GetIpamPoolNextAvailableCidrResponse GetIpamPoolNextAvailableCidr(GetIpamPoolNextAvailableCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIpamPoolNextAvailableCidrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the available CIDR blocks of the IPAM pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIpamPoolNextAvailableCidrRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIpamPoolNextAvailableCidrResponse
        /// </returns>
        public async Task<GetIpamPoolNextAvailableCidrResponse> GetIpamPoolNextAvailableCidrAsync(GetIpamPoolNextAvailableCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIpamPoolNextAvailableCidrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether IP Address Manager (IPAM) is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcIpamServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcIpamServiceStatusResponse
        /// </returns>
        public GetVpcIpamServiceStatusResponse GetVpcIpamServiceStatusWithOptions(GetVpcIpamServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpcIpamServiceStatus",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcIpamServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether IP Address Manager (IPAM) is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcIpamServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcIpamServiceStatusResponse
        /// </returns>
        public async Task<GetVpcIpamServiceStatusResponse> GetVpcIpamServiceStatusWithOptionsAsync(GetVpcIpamServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpcIpamServiceStatus",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcIpamServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether IP Address Manager (IPAM) is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcIpamServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcIpamServiceStatusResponse
        /// </returns>
        public GetVpcIpamServiceStatusResponse GetVpcIpamServiceStatus(GetVpcIpamServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVpcIpamServiceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether IP Address Manager (IPAM) is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcIpamServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcIpamServiceStatusResponse
        /// </returns>
        public async Task<GetVpcIpamServiceStatusResponse> GetVpcIpamServiceStatusAsync(GetVpcIpamServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVpcIpamServiceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries discovered resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamDiscoveredResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamDiscoveredResourceResponse
        /// </returns>
        public ListIpamDiscoveredResourceResponse ListIpamDiscoveredResourceWithOptions(ListIpamDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamDiscoveredResource",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamDiscoveredResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries discovered resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamDiscoveredResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamDiscoveredResourceResponse
        /// </returns>
        public async Task<ListIpamDiscoveredResourceResponse> ListIpamDiscoveredResourceWithOptionsAsync(ListIpamDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamDiscoveredResource",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamDiscoveredResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries discovered resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamDiscoveredResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamDiscoveredResourceResponse
        /// </returns>
        public ListIpamDiscoveredResourceResponse ListIpamDiscoveredResource(ListIpamDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamDiscoveredResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries discovered resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamDiscoveredResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamDiscoveredResourceResponse
        /// </returns>
        public async Task<ListIpamDiscoveredResourceResponse> ListIpamDiscoveredResourceAsync(ListIpamDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamDiscoveredResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolAllocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolAllocationsResponse
        /// </returns>
        public ListIpamPoolAllocationsResponse ListIpamPoolAllocationsWithOptions(ListIpamPoolAllocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationIds))
            {
                query["IpamPoolAllocationIds"] = request.IpamPoolAllocationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationName))
            {
                query["IpamPoolAllocationName"] = request.IpamPoolAllocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamPoolAllocations",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamPoolAllocationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolAllocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolAllocationsResponse
        /// </returns>
        public async Task<ListIpamPoolAllocationsResponse> ListIpamPoolAllocationsWithOptionsAsync(ListIpamPoolAllocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationIds))
            {
                query["IpamPoolAllocationIds"] = request.IpamPoolAllocationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationName))
            {
                query["IpamPoolAllocationName"] = request.IpamPoolAllocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamPoolAllocations",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamPoolAllocationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolAllocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolAllocationsResponse
        /// </returns>
        public ListIpamPoolAllocationsResponse ListIpamPoolAllocations(ListIpamPoolAllocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamPoolAllocationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolAllocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolAllocationsResponse
        /// </returns>
        public async Task<ListIpamPoolAllocationsResponse> ListIpamPoolAllocationsAsync(ListIpamPoolAllocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamPoolAllocationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR blocks provisioned to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolCidrsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolCidrsResponse
        /// </returns>
        public ListIpamPoolCidrsResponse ListIpamPoolCidrsWithOptions(ListIpamPoolCidrsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamPoolCidrs",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamPoolCidrsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR blocks provisioned to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolCidrsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolCidrsResponse
        /// </returns>
        public async Task<ListIpamPoolCidrsResponse> ListIpamPoolCidrsWithOptionsAsync(ListIpamPoolCidrsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                query["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamPoolCidrs",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamPoolCidrsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR blocks provisioned to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolCidrsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolCidrsResponse
        /// </returns>
        public ListIpamPoolCidrsResponse ListIpamPoolCidrs(ListIpamPoolCidrsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamPoolCidrsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries CIDR blocks provisioned to an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolCidrsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolCidrsResponse
        /// </returns>
        public async Task<ListIpamPoolCidrsResponse> ListIpamPoolCidrsAsync(ListIpamPoolCidrsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamPoolCidrsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Manager (IPAM) pools.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolsResponse
        /// </returns>
        public ListIpamPoolsResponse ListIpamPoolsWithOptions(ListIpamPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolIds))
            {
                query["IpamPoolIds"] = request.IpamPoolIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolName))
            {
                query["IpamPoolName"] = request.IpamPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Isp))
            {
                query["Ipv6Isp"] = request.Ipv6Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShared))
            {
                query["IsShared"] = request.IsShared;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolRegionId))
            {
                query["PoolRegionId"] = request.PoolRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIpamPoolId))
            {
                query["SourceIpamPoolId"] = request.SourceIpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamPools",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamPoolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Manager (IPAM) pools.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolsResponse
        /// </returns>
        public async Task<ListIpamPoolsResponse> ListIpamPoolsWithOptionsAsync(ListIpamPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolIds))
            {
                query["IpamPoolIds"] = request.IpamPoolIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolName))
            {
                query["IpamPoolName"] = request.IpamPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Isp))
            {
                query["Ipv6Isp"] = request.Ipv6Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShared))
            {
                query["IsShared"] = request.IsShared;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolRegionId))
            {
                query["PoolRegionId"] = request.PoolRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIpamPoolId))
            {
                query["SourceIpamPoolId"] = request.SourceIpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamPools",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamPoolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Manager (IPAM) pools.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolsResponse
        /// </returns>
        public ListIpamPoolsResponse ListIpamPools(ListIpamPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamPoolsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Manager (IPAM) pools.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamPoolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamPoolsResponse
        /// </returns>
        public async Task<ListIpamPoolsResponse> ListIpamPoolsAsync(ListIpamPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamPoolsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resources in an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceCidrsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceCidrsResponse
        /// </returns>
        public ListIpamResourceCidrsResponse ListIpamResourceCidrsWithOptions(ListIpamResourceCidrsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamResourceCidrs",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamResourceCidrsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resources in an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceCidrsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceCidrsResponse
        /// </returns>
        public async Task<ListIpamResourceCidrsResponse> ListIpamResourceCidrsWithOptionsAsync(ListIpamResourceCidrsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamResourceCidrs",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamResourceCidrsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resources in an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceCidrsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceCidrsResponse
        /// </returns>
        public ListIpamResourceCidrsResponse ListIpamResourceCidrs(ListIpamResourceCidrsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamResourceCidrsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resources in an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceCidrsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceCidrsResponse
        /// </returns>
        public async Task<ListIpamResourceCidrsResponse> ListIpamResourceCidrsAsync(ListIpamResourceCidrsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamResourceCidrsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IPAM resource discovery instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceDiscoveriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceDiscoveriesResponse
        /// </returns>
        public ListIpamResourceDiscoveriesResponse ListIpamResourceDiscoveriesWithOptions(ListIpamResourceDiscoveriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryIds))
            {
                query["IpamResourceDiscoveryIds"] = request.IpamResourceDiscoveryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryName))
            {
                query["IpamResourceDiscoveryName"] = request.IpamResourceDiscoveryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShared))
            {
                query["IsShared"] = request.IsShared;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamResourceDiscoveries",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamResourceDiscoveriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IPAM resource discovery instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceDiscoveriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceDiscoveriesResponse
        /// </returns>
        public async Task<ListIpamResourceDiscoveriesResponse> ListIpamResourceDiscoveriesWithOptionsAsync(ListIpamResourceDiscoveriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryIds))
            {
                query["IpamResourceDiscoveryIds"] = request.IpamResourceDiscoveryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryName))
            {
                query["IpamResourceDiscoveryName"] = request.IpamResourceDiscoveryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShared))
            {
                query["IsShared"] = request.IsShared;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamResourceDiscoveries",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamResourceDiscoveriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IPAM resource discovery instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceDiscoveriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceDiscoveriesResponse
        /// </returns>
        public ListIpamResourceDiscoveriesResponse ListIpamResourceDiscoveries(ListIpamResourceDiscoveriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamResourceDiscoveriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IPAM resource discovery instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceDiscoveriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceDiscoveriesResponse
        /// </returns>
        public async Task<ListIpamResourceDiscoveriesResponse> ListIpamResourceDiscoveriesAsync(ListIpamResourceDiscoveriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamResourceDiscoveriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the association between resource discovery and IPAM.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceDiscoveryAssociationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceDiscoveryAssociationsResponse
        /// </returns>
        public ListIpamResourceDiscoveryAssociationsResponse ListIpamResourceDiscoveryAssociationsWithOptions(ListIpamResourceDiscoveryAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamResourceDiscoveryAssociations",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamResourceDiscoveryAssociationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the association between resource discovery and IPAM.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceDiscoveryAssociationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceDiscoveryAssociationsResponse
        /// </returns>
        public async Task<ListIpamResourceDiscoveryAssociationsResponse> ListIpamResourceDiscoveryAssociationsWithOptionsAsync(ListIpamResourceDiscoveryAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamResourceDiscoveryAssociations",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamResourceDiscoveryAssociationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the association between resource discovery and IPAM.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceDiscoveryAssociationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceDiscoveryAssociationsResponse
        /// </returns>
        public ListIpamResourceDiscoveryAssociationsResponse ListIpamResourceDiscoveryAssociations(ListIpamResourceDiscoveryAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamResourceDiscoveryAssociationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the association between resource discovery and IPAM.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamResourceDiscoveryAssociationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamResourceDiscoveryAssociationsResponse
        /// </returns>
        public async Task<ListIpamResourceDiscoveryAssociationsResponse> ListIpamResourceDiscoveryAssociationsAsync(ListIpamResourceDiscoveryAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamResourceDiscoveryAssociationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Manager (IPAM) scopes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamScopesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamScopesResponse
        /// </returns>
        public ListIpamScopesResponse ListIpamScopesWithOptions(ListIpamScopesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeIds))
            {
                query["IpamScopeIds"] = request.IpamScopeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeName))
            {
                query["IpamScopeName"] = request.IpamScopeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeType))
            {
                query["IpamScopeType"] = request.IpamScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamScopes",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamScopesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Manager (IPAM) scopes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamScopesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamScopesResponse
        /// </returns>
        public async Task<ListIpamScopesResponse> ListIpamScopesWithOptionsAsync(ListIpamScopesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeIds))
            {
                query["IpamScopeIds"] = request.IpamScopeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeName))
            {
                query["IpamScopeName"] = request.IpamScopeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeType))
            {
                query["IpamScopeType"] = request.IpamScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpamScopes",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamScopesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Manager (IPAM) scopes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamScopesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamScopesResponse
        /// </returns>
        public ListIpamScopesResponse ListIpamScopes(ListIpamScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamScopesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Manager (IPAM) scopes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamScopesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamScopesResponse
        /// </returns>
        public async Task<ListIpamScopesResponse> ListIpamScopesAsync(ListIpamScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamScopesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Managers (IPAMs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamsResponse
        /// </returns>
        public ListIpamsResponse ListIpamsWithOptions(ListIpamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamIds))
            {
                query["IpamIds"] = request.IpamIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamName))
            {
                query["IpamName"] = request.IpamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpams",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Managers (IPAMs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIpamsResponse
        /// </returns>
        public async Task<ListIpamsResponse> ListIpamsWithOptionsAsync(ListIpamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamIds))
            {
                query["IpamIds"] = request.IpamIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamName))
            {
                query["IpamName"] = request.IpamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpams",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Managers (IPAMs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamsResponse
        /// </returns>
        public ListIpamsResponse ListIpams(ListIpamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpamsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries IP Address Managers (IPAMs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIpamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIpamsResponse
        /// </returns>
        public async Task<ListIpamsResponse> ListIpamsAsync(ListIpamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpamsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>You must specify <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object that you want to query.</description></item>
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you specify only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you specify only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you specify <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2023-02-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>You must specify <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object that you want to query.</description></item>
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you specify only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you specify only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you specify <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2023-02-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>You must specify <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object that you want to query.</description></item>
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you specify only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you specify only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you specify <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>You must specify <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object that you want to query.</description></item>
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you specify only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you specify only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you specify <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenVpcIpamServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenVpcIpamServiceResponse
        /// </returns>
        public OpenVpcIpamServiceResponse OpenVpcIpamServiceWithOptions(OpenVpcIpamServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenVpcIpamService",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenVpcIpamServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenVpcIpamServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenVpcIpamServiceResponse
        /// </returns>
        public async Task<OpenVpcIpamServiceResponse> OpenVpcIpamServiceWithOptionsAsync(OpenVpcIpamServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenVpcIpamService",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenVpcIpamServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenVpcIpamServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenVpcIpamServiceResponse
        /// </returns>
        public OpenVpcIpamServiceResponse OpenVpcIpamService(OpenVpcIpamServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenVpcIpamServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenVpcIpamServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenVpcIpamServiceResponse
        /// </returns>
        public async Task<OpenVpcIpamServiceResponse> OpenVpcIpamServiceAsync(OpenVpcIpamServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenVpcIpamServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a resource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>Tags are used to classify instances. Each tag consists of a key-value pair. Before you use tags, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Each tag key that is added to an instance must be unique.</description></item>
        /// <item><description>You cannot create tags without adding them to instances. All tags must be added to instances.</description></item>
        /// <item><description>You can add at most 20 tags to each instance. Before you add a tag to an instance, the system automatically checks the number of existing tags. An error message is returned if the maximum number of tags is reached.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2023-02-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a resource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>Tags are used to classify instances. Each tag consists of a key-value pair. Before you use tags, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Each tag key that is added to an instance must be unique.</description></item>
        /// <item><description>You cannot create tags without adding them to instances. All tags must be added to instances.</description></item>
        /// <item><description>You can add at most 20 tags to each instance. Before you add a tag to an instance, the system automatically checks the number of existing tags. An error message is returned if the maximum number of tags is reached.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2023-02-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a resource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>Tags are used to classify instances. Each tag consists of a key-value pair. Before you use tags, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Each tag key that is added to an instance must be unique.</description></item>
        /// <item><description>You cannot create tags without adding them to instances. All tags must be added to instances.</description></item>
        /// <item><description>You can add at most 20 tags to each instance. Before you add a tag to an instance, the system automatically checks the number of existing tags. An error message is returned if the maximum number of tags is reached.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a resource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>Tags are used to classify instances. Each tag consists of a key-value pair. Before you use tags, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Each tag key that is added to an instance must be unique.</description></item>
        /// <item><description>You cannot create tags without adding them to instances. All tags must be added to instances.</description></item>
        /// <item><description>You can add at most 20 tags to each instance. Before you add a tag to an instance, the system automatically checks the number of existing tags. An error message is returned if the maximum number of tags is reached.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a tag from a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2023-02-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a tag from a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2023-02-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a tag from a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a tag from a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamResponse
        /// </returns>
        public UpdateIpamResponse UpdateIpamWithOptions(UpdateIpamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddOperatingRegion))
            {
                query["AddOperatingRegion"] = request.AddOperatingRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamDescription))
            {
                query["IpamDescription"] = request.IpamDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamName))
            {
                query["IpamName"] = request.IpamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveOperatingRegion))
            {
                query["RemoveOperatingRegion"] = request.RemoveOperatingRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpam",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamResponse
        /// </returns>
        public async Task<UpdateIpamResponse> UpdateIpamWithOptionsAsync(UpdateIpamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddOperatingRegion))
            {
                query["AddOperatingRegion"] = request.AddOperatingRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamDescription))
            {
                query["IpamDescription"] = request.IpamDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamId))
            {
                query["IpamId"] = request.IpamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamName))
            {
                query["IpamName"] = request.IpamName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveOperatingRegion))
            {
                query["RemoveOperatingRegion"] = request.RemoveOperatingRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpam",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamResponse
        /// </returns>
        public UpdateIpamResponse UpdateIpam(UpdateIpamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an IP Address Manager (IPAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamResponse
        /// </returns>
        public async Task<UpdateIpamResponse> UpdateIpamAsync(UpdateIpamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information about an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamPoolResponse
        /// </returns>
        public UpdateIpamPoolResponse UpdateIpamPoolWithOptions(UpdateIpamPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationDefaultCidrMask))
            {
                query["AllocationDefaultCidrMask"] = request.AllocationDefaultCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationMaxCidrMask))
            {
                query["AllocationMaxCidrMask"] = request.AllocationMaxCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationMinCidrMask))
            {
                query["AllocationMinCidrMask"] = request.AllocationMinCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoImport))
            {
                query["AutoImport"] = request.AutoImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClearAllocationDefaultCidrMask))
            {
                query["ClearAllocationDefaultCidrMask"] = request.ClearAllocationDefaultCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolDescription))
            {
                query["IpamPoolDescription"] = request.IpamPoolDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolName))
            {
                query["IpamPoolName"] = request.IpamPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpamPool",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information about an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamPoolResponse
        /// </returns>
        public async Task<UpdateIpamPoolResponse> UpdateIpamPoolWithOptionsAsync(UpdateIpamPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationDefaultCidrMask))
            {
                query["AllocationDefaultCidrMask"] = request.AllocationDefaultCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationMaxCidrMask))
            {
                query["AllocationMaxCidrMask"] = request.AllocationMaxCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationMinCidrMask))
            {
                query["AllocationMinCidrMask"] = request.AllocationMinCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoImport))
            {
                query["AutoImport"] = request.AutoImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClearAllocationDefaultCidrMask))
            {
                query["ClearAllocationDefaultCidrMask"] = request.ClearAllocationDefaultCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolDescription))
            {
                query["IpamPoolDescription"] = request.IpamPoolDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolId))
            {
                query["IpamPoolId"] = request.IpamPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolName))
            {
                query["IpamPoolName"] = request.IpamPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpamPool",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information about an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamPoolResponse
        /// </returns>
        public UpdateIpamPoolResponse UpdateIpamPool(UpdateIpamPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpamPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information about an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamPoolResponse
        /// </returns>
        public async Task<UpdateIpamPoolResponse> UpdateIpamPoolAsync(UpdateIpamPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpamPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamPoolAllocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamPoolAllocationResponse
        /// </returns>
        public UpdateIpamPoolAllocationResponse UpdateIpamPoolAllocationWithOptions(UpdateIpamPoolAllocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationDescription))
            {
                query["IpamPoolAllocationDescription"] = request.IpamPoolAllocationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationId))
            {
                query["IpamPoolAllocationId"] = request.IpamPoolAllocationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationName))
            {
                query["IpamPoolAllocationName"] = request.IpamPoolAllocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpamPoolAllocation",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamPoolAllocationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamPoolAllocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamPoolAllocationResponse
        /// </returns>
        public async Task<UpdateIpamPoolAllocationResponse> UpdateIpamPoolAllocationWithOptionsAsync(UpdateIpamPoolAllocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationDescription))
            {
                query["IpamPoolAllocationDescription"] = request.IpamPoolAllocationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationId))
            {
                query["IpamPoolAllocationId"] = request.IpamPoolAllocationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamPoolAllocationName))
            {
                query["IpamPoolAllocationName"] = request.IpamPoolAllocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpamPoolAllocation",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamPoolAllocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamPoolAllocationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamPoolAllocationResponse
        /// </returns>
        public UpdateIpamPoolAllocationResponse UpdateIpamPoolAllocation(UpdateIpamPoolAllocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpamPoolAllocationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies CIDR block allocations of an IP Address Manager (IPAM) pool.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamPoolAllocationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamPoolAllocationResponse
        /// </returns>
        public async Task<UpdateIpamPoolAllocationResponse> UpdateIpamPoolAllocationAsync(UpdateIpamPoolAllocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpamPoolAllocationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can add or remove effective regions only for custom resource discovery instances.</para>
        /// <list type="bullet">
        /// <item><description>When removing effective regions from a resource discovery instance, the hosted region cannot be included.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamResourceDiscoveryResponse
        /// </returns>
        public UpdateIpamResourceDiscoveryResponse UpdateIpamResourceDiscoveryWithOptions(UpdateIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddOperatingRegion))
            {
                query["AddOperatingRegion"] = request.AddOperatingRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryDescription))
            {
                query["IpamResourceDiscoveryDescription"] = request.IpamResourceDiscoveryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryName))
            {
                query["IpamResourceDiscoveryName"] = request.IpamResourceDiscoveryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveOperatingRegion))
            {
                query["RemoveOperatingRegion"] = request.RemoveOperatingRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamResourceDiscoveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can add or remove effective regions only for custom resource discovery instances.</para>
        /// <list type="bullet">
        /// <item><description>When removing effective regions from a resource discovery instance, the hosted region cannot be included.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIpamResourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<UpdateIpamResourceDiscoveryResponse> UpdateIpamResourceDiscoveryWithOptionsAsync(UpdateIpamResourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddOperatingRegion))
            {
                query["AddOperatingRegion"] = request.AddOperatingRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryDescription))
            {
                query["IpamResourceDiscoveryDescription"] = request.IpamResourceDiscoveryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryId))
            {
                query["IpamResourceDiscoveryId"] = request.IpamResourceDiscoveryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamResourceDiscoveryName))
            {
                query["IpamResourceDiscoveryName"] = request.IpamResourceDiscoveryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveOperatingRegion))
            {
                query["RemoveOperatingRegion"] = request.RemoveOperatingRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpamResourceDiscovery",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamResourceDiscoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can add or remove effective regions only for custom resource discovery instances.</para>
        /// <list type="bullet">
        /// <item><description>When removing effective regions from a resource discovery instance, the hosted region cannot be included.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamResourceDiscoveryResponse
        /// </returns>
        public UpdateIpamResourceDiscoveryResponse UpdateIpamResourceDiscovery(UpdateIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpamResourceDiscoveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a resource discovery instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can add or remove effective regions only for custom resource discovery instances.</para>
        /// <list type="bullet">
        /// <item><description>When removing effective regions from a resource discovery instance, the hosted region cannot be included.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIpamResourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamResourceDiscoveryResponse
        /// </returns>
        public async Task<UpdateIpamResourceDiscoveryResponse> UpdateIpamResourceDiscoveryAsync(UpdateIpamResourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpamResourceDiscoveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information about an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamScopeResponse
        /// </returns>
        public UpdateIpamScopeResponse UpdateIpamScopeWithOptions(UpdateIpamScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeDescription))
            {
                query["IpamScopeDescription"] = request.IpamScopeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeName))
            {
                query["IpamScopeName"] = request.IpamScopeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpamScope",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamScopeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information about an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamScopeResponse
        /// </returns>
        public async Task<UpdateIpamScopeResponse> UpdateIpamScopeWithOptionsAsync(UpdateIpamScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeDescription))
            {
                query["IpamScopeDescription"] = request.IpamScopeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeId))
            {
                query["IpamScopeId"] = request.IpamScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpamScopeName))
            {
                query["IpamScopeName"] = request.IpamScopeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpamScope",
                Version = "2023-02-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpamScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information about an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamScopeResponse
        /// </returns>
        public UpdateIpamScopeResponse UpdateIpamScope(UpdateIpamScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpamScopeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information about an IP Address Manager (IPAM) scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIpamScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIpamScopeResponse
        /// </returns>
        public async Task<UpdateIpamScopeResponse> UpdateIpamScopeAsync(UpdateIpamScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpamScopeWithOptionsAsync(request, runtime);
        }

    }
}
