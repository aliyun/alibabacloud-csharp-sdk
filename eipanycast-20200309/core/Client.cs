// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eipanycast20200309.Models;

namespace AlibabaCloud.SDK.Eipanycast20200309
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eipanycast", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllocateAnycastEipAddressResponse
        /// </returns>
        public AllocateAnycastEipAddressResponse AllocateAnycastEipAddressWithOptions(AllocateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
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
                Action = "AllocateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllocateAnycastEipAddressResponse
        /// </returns>
        public async Task<AllocateAnycastEipAddressResponse> AllocateAnycastEipAddressWithOptionsAsync(AllocateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
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
                Action = "AllocateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// AllocateAnycastEipAddressResponse
        /// </returns>
        public AllocateAnycastEipAddressResponse AllocateAnycastEipAddress(AllocateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateAnycastEipAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// AllocateAnycastEipAddressResponse
        /// </returns>
        public async Task<AllocateAnycastEipAddressResponse> AllocateAnycastEipAddressAsync(AllocateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an Anycast elastic IP address (Anycast EIP) with an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateAnycastEipAddressResponse
        /// </returns>
        public AssociateAnycastEipAddressResponse AssociateAnycastEipAddressWithOptions(AssociateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationMode))
            {
                query["AssociationMode"] = request.AssociationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceRegionId))
            {
                query["BindInstanceRegionId"] = request.BindInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceType))
            {
                query["BindInstanceType"] = request.BindInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocations))
            {
                query["PopLocations"] = request.PopLocations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an Anycast elastic IP address (Anycast EIP) with an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateAnycastEipAddressResponse
        /// </returns>
        public async Task<AssociateAnycastEipAddressResponse> AssociateAnycastEipAddressWithOptionsAsync(AssociateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationMode))
            {
                query["AssociationMode"] = request.AssociationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceRegionId))
            {
                query["BindInstanceRegionId"] = request.BindInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceType))
            {
                query["BindInstanceType"] = request.BindInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocations))
            {
                query["PopLocations"] = request.PopLocations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an Anycast elastic IP address (Anycast EIP) with an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateAnycastEipAddressResponse
        /// </returns>
        public AssociateAnycastEipAddressResponse AssociateAnycastEipAddress(AssociateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateAnycastEipAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an Anycast elastic IP address (Anycast EIP) with an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateAnycastEipAddressResponse
        /// </returns>
        public async Task<AssociateAnycastEipAddressResponse> AssociateAnycastEipAddressAsync(AssociateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改AnycastEIp实例资源组</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-03-09",
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
        /// <para>修改AnycastEIp实例资源组</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-03-09",
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
        /// <para>修改AnycastEIp实例资源组</para>
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
        /// <para>修改AnycastEIp实例资源组</para>
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
        /// <para>Queries Anycast elastic IP addresses (Anycast EIPs) associated with specified instance IP addresses or instance IDs, including instance status, maximum bandwidth, and associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastEipAddressResponse
        /// </returns>
        public DescribeAnycastEipAddressResponse DescribeAnycastEipAddressWithOptions(DescribeAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Anycast elastic IP addresses (Anycast EIPs) associated with specified instance IP addresses or instance IDs, including instance status, maximum bandwidth, and associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastEipAddressResponse
        /// </returns>
        public async Task<DescribeAnycastEipAddressResponse> DescribeAnycastEipAddressWithOptionsAsync(DescribeAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Anycast elastic IP addresses (Anycast EIPs) associated with specified instance IP addresses or instance IDs, including instance status, maximum bandwidth, and associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastEipAddressResponse
        /// </returns>
        public DescribeAnycastEipAddressResponse DescribeAnycastEipAddress(DescribeAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAnycastEipAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Anycast elastic IP addresses (Anycast EIPs) associated with specified instance IP addresses or instance IDs, including instance status, maximum bandwidth, and associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastEipAddressResponse
        /// </returns>
        public async Task<DescribeAnycastEipAddressResponse> DescribeAnycastEipAddressAsync(DescribeAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access points in an area.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastPopLocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastPopLocationsResponse
        /// </returns>
        public DescribeAnycastPopLocationsResponse DescribeAnycastPopLocationsWithOptions(DescribeAnycastPopLocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastPopLocations",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastPopLocationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access points in an area.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastPopLocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastPopLocationsResponse
        /// </returns>
        public async Task<DescribeAnycastPopLocationsResponse> DescribeAnycastPopLocationsWithOptionsAsync(DescribeAnycastPopLocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastPopLocations",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastPopLocationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access points in an area.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastPopLocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastPopLocationsResponse
        /// </returns>
        public DescribeAnycastPopLocationsResponse DescribeAnycastPopLocations(DescribeAnycastPopLocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAnycastPopLocationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access points in an area.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastPopLocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastPopLocationsResponse
        /// </returns>
        public async Task<DescribeAnycastPopLocationsResponse> DescribeAnycastPopLocationsAsync(DescribeAnycastPopLocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAnycastPopLocationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where you can associate Anycast elastic IP addresses (Anycast EIPs) with endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastServerRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastServerRegionsResponse
        /// </returns>
        public DescribeAnycastServerRegionsResponse DescribeAnycastServerRegionsWithOptions(DescribeAnycastServerRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastServerRegions",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastServerRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where you can associate Anycast elastic IP addresses (Anycast EIPs) with endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastServerRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastServerRegionsResponse
        /// </returns>
        public async Task<DescribeAnycastServerRegionsResponse> DescribeAnycastServerRegionsWithOptionsAsync(DescribeAnycastServerRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastServerRegions",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastServerRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where you can associate Anycast elastic IP addresses (Anycast EIPs) with endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastServerRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastServerRegionsResponse
        /// </returns>
        public DescribeAnycastServerRegionsResponse DescribeAnycastServerRegions(DescribeAnycastServerRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAnycastServerRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where you can associate Anycast elastic IP addresses (Anycast EIPs) with endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAnycastServerRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAnycastServerRegionsResponse
        /// </returns>
        public async Task<DescribeAnycastServerRegionsResponse> DescribeAnycastServerRegionsAsync(DescribeAnycastServerRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAnycastServerRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about Anycast elastic IP addresses (Anycast EIPs) in an access area, including instance status, maximum bandwidth, and associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnycastEipAddressesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnycastEipAddressesResponse
        /// </returns>
        public ListAnycastEipAddressesResponse ListAnycastEipAddressesWithOptions(ListAnycastEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastEipAddress))
            {
                query["AnycastEipAddress"] = request.AnycastEipAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastIds))
            {
                query["AnycastIds"] = request.AnycastIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceIds))
            {
                query["BindInstanceIds"] = request.BindInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessStatus))
            {
                query["BusinessStatus"] = request.BusinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListAnycastEipAddresses",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnycastEipAddressesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about Anycast elastic IP addresses (Anycast EIPs) in an access area, including instance status, maximum bandwidth, and associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnycastEipAddressesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnycastEipAddressesResponse
        /// </returns>
        public async Task<ListAnycastEipAddressesResponse> ListAnycastEipAddressesWithOptionsAsync(ListAnycastEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastEipAddress))
            {
                query["AnycastEipAddress"] = request.AnycastEipAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastIds))
            {
                query["AnycastIds"] = request.AnycastIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceIds))
            {
                query["BindInstanceIds"] = request.BindInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessStatus))
            {
                query["BusinessStatus"] = request.BusinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListAnycastEipAddresses",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnycastEipAddressesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about Anycast elastic IP addresses (Anycast EIPs) in an access area, including instance status, maximum bandwidth, and associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnycastEipAddressesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnycastEipAddressesResponse
        /// </returns>
        public ListAnycastEipAddressesResponse ListAnycastEipAddresses(ListAnycastEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnycastEipAddressesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about Anycast elastic IP addresses (Anycast EIPs) in an access area, including instance status, maximum bandwidth, and associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnycastEipAddressesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnycastEipAddressesResponse
        /// </returns>
        public async Task<ListAnycastEipAddressesResponse> ListAnycastEipAddressesAsync(ListAnycastEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnycastEipAddressesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-03-09",
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
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-03-09",
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
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
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
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
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
        /// <para>Modifies the name and description of an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAnycastEipAddressAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnycastEipAddressAttributeResponse
        /// </returns>
        public ModifyAnycastEipAddressAttributeResponse ModifyAnycastEipAddressAttributeWithOptions(ModifyAnycastEipAddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAnycastEipAddressAttribute",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnycastEipAddressAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name and description of an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAnycastEipAddressAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnycastEipAddressAttributeResponse
        /// </returns>
        public async Task<ModifyAnycastEipAddressAttributeResponse> ModifyAnycastEipAddressAttributeWithOptionsAsync(ModifyAnycastEipAddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAnycastEipAddressAttribute",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnycastEipAddressAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name and description of an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAnycastEipAddressAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnycastEipAddressAttributeResponse
        /// </returns>
        public ModifyAnycastEipAddressAttributeResponse ModifyAnycastEipAddressAttribute(ModifyAnycastEipAddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAnycastEipAddressAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name and description of an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAnycastEipAddressAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnycastEipAddressAttributeResponse
        /// </returns>
        public async Task<ModifyAnycastEipAddressAttributeResponse> ModifyAnycastEipAddressAttributeAsync(ModifyAnycastEipAddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAnycastEipAddressAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maximum bandwidth of an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAnycastEipAddressSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnycastEipAddressSpecResponse
        /// </returns>
        public ModifyAnycastEipAddressSpecResponse ModifyAnycastEipAddressSpecWithOptions(ModifyAnycastEipAddressSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAnycastEipAddressSpec",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnycastEipAddressSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maximum bandwidth of an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAnycastEipAddressSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnycastEipAddressSpecResponse
        /// </returns>
        public async Task<ModifyAnycastEipAddressSpecResponse> ModifyAnycastEipAddressSpecWithOptionsAsync(ModifyAnycastEipAddressSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAnycastEipAddressSpec",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnycastEipAddressSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maximum bandwidth of an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAnycastEipAddressSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnycastEipAddressSpecResponse
        /// </returns>
        public ModifyAnycastEipAddressSpecResponse ModifyAnycastEipAddressSpec(ModifyAnycastEipAddressSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAnycastEipAddressSpecWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maximum bandwidth of an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAnycastEipAddressSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAnycastEipAddressSpecResponse
        /// </returns>
        public async Task<ModifyAnycastEipAddressSpecResponse> ModifyAnycastEipAddressSpecAsync(ModifyAnycastEipAddressSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAnycastEipAddressSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseAnycastEipAddressResponse
        /// </returns>
        public ReleaseAnycastEipAddressResponse ReleaseAnycastEipAddressWithOptions(ReleaseAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseAnycastEipAddressResponse
        /// </returns>
        public async Task<ReleaseAnycastEipAddressResponse> ReleaseAnycastEipAddressWithOptionsAsync(ReleaseAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseAnycastEipAddressResponse
        /// </returns>
        public ReleaseAnycastEipAddressResponse ReleaseAnycastEipAddress(ReleaseAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseAnycastEipAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases an Anycast elastic IP address (Anycast EIP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseAnycastEipAddressResponse
        /// </returns>
        public async Task<ReleaseAnycastEipAddressResponse> ReleaseAnycastEipAddressAsync(ReleaseAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and adds tags to resources.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-03-09",
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
        /// <para>Creates and adds tags to resources.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-03-09",
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
        /// <para>Creates and adds tags to resources.</para>
        /// </summary>
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
        /// <para>Creates and adds tags to resources.</para>
        /// </summary>
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
        /// <para>Disassociates an Anycast elastic IP address (Anycast EIP) from an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassociateAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnassociateAnycastEipAddressResponse
        /// </returns>
        public UnassociateAnycastEipAddressResponse UnassociateAnycastEipAddressWithOptions(UnassociateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceRegionId))
            {
                query["BindInstanceRegionId"] = request.BindInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceType))
            {
                query["BindInstanceType"] = request.BindInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassociateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassociateAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an Anycast elastic IP address (Anycast EIP) from an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassociateAnycastEipAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnassociateAnycastEipAddressResponse
        /// </returns>
        public async Task<UnassociateAnycastEipAddressResponse> UnassociateAnycastEipAddressWithOptionsAsync(UnassociateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceRegionId))
            {
                query["BindInstanceRegionId"] = request.BindInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceType))
            {
                query["BindInstanceType"] = request.BindInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassociateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassociateAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an Anycast elastic IP address (Anycast EIP) from an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassociateAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// UnassociateAnycastEipAddressResponse
        /// </returns>
        public UnassociateAnycastEipAddressResponse UnassociateAnycastEipAddress(UnassociateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateAnycastEipAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an Anycast elastic IP address (Anycast EIP) from an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassociateAnycastEipAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// UnassociateAnycastEipAddressResponse
        /// </returns>
        public async Task<UnassociateAnycastEipAddressResponse> UnassociateAnycastEipAddressAsync(UnassociateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from Anycast EIPs.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-03-09",
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
        /// <para>Removes tags from Anycast EIPs.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-03-09",
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
        /// <para>Removes tags from Anycast EIPs.</para>
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
        /// <para>Removes tags from Anycast EIPs.</para>
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
        /// <para>If an Anycast EIP is associated with endpoints in different regions, you can change the access points that are mapped to an endpoint. You can call UpdateAnycastEipAddressAssociations to add or delete endpoints to modify the mappings between endpoints and access points.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAnycastEipAddressAssociationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAnycastEipAddressAssociationsResponse
        /// </returns>
        public UpdateAnycastEipAddressAssociationsResponse UpdateAnycastEipAddressAssociationsWithOptions(UpdateAnycastEipAddressAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationMode))
            {
                query["AssociationMode"] = request.AssociationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocationAddList))
            {
                query["PopLocationAddList"] = request.PopLocationAddList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocationDeleteList))
            {
                query["PopLocationDeleteList"] = request.PopLocationDeleteList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAnycastEipAddressAssociations",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAnycastEipAddressAssociationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If an Anycast EIP is associated with endpoints in different regions, you can change the access points that are mapped to an endpoint. You can call UpdateAnycastEipAddressAssociations to add or delete endpoints to modify the mappings between endpoints and access points.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAnycastEipAddressAssociationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAnycastEipAddressAssociationsResponse
        /// </returns>
        public async Task<UpdateAnycastEipAddressAssociationsResponse> UpdateAnycastEipAddressAssociationsWithOptionsAsync(UpdateAnycastEipAddressAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationMode))
            {
                query["AssociationMode"] = request.AssociationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocationAddList))
            {
                query["PopLocationAddList"] = request.PopLocationAddList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocationDeleteList))
            {
                query["PopLocationDeleteList"] = request.PopLocationDeleteList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAnycastEipAddressAssociations",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAnycastEipAddressAssociationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If an Anycast EIP is associated with endpoints in different regions, you can change the access points that are mapped to an endpoint. You can call UpdateAnycastEipAddressAssociations to add or delete endpoints to modify the mappings between endpoints and access points.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAnycastEipAddressAssociationsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAnycastEipAddressAssociationsResponse
        /// </returns>
        public UpdateAnycastEipAddressAssociationsResponse UpdateAnycastEipAddressAssociations(UpdateAnycastEipAddressAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAnycastEipAddressAssociationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If an Anycast EIP is associated with endpoints in different regions, you can change the access points that are mapped to an endpoint. You can call UpdateAnycastEipAddressAssociations to add or delete endpoints to modify the mappings between endpoints and access points.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAnycastEipAddressAssociationsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAnycastEipAddressAssociationsResponse
        /// </returns>
        public async Task<UpdateAnycastEipAddressAssociationsResponse> UpdateAnycastEipAddressAssociationsAsync(UpdateAnycastEipAddressAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAnycastEipAddressAssociationsWithOptionsAsync(request, runtime);
        }

    }
}
