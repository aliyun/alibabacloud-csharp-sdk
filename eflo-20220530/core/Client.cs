// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eflo20220530.Models;

namespace AlibabaCloud.SDK.Eflo20220530
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eflo", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Apply for a secondary private IP address for the current Lingjun Elastic Network Interface. You can automatically assign a secondary private IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Apply for a secondary private IP address for the specified Lingjun Elastic Network Interface.</para>
        /// <list type="bullet">
        /// <item><description>If the PrivateIp field is empty, a secondary private IP address is automatically assigned and the unique identifier of the IP address is returned.</description></item>
        /// <item><description>You can use the GetLeniPrivateIpAddress or ListLeniPrivateIpAddresses interface to check whether the secondary private IP address is assigned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignLeniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignLeniPrivateIpAddressResponse
        /// </returns>
        public AssignLeniPrivateIpAddressResponse AssignLeniPrivateIpAddressWithOptions(AssignLeniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignLeniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignLeniPrivateIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Apply for a secondary private IP address for the current Lingjun Elastic Network Interface. You can automatically assign a secondary private IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Apply for a secondary private IP address for the specified Lingjun Elastic Network Interface.</para>
        /// <list type="bullet">
        /// <item><description>If the PrivateIp field is empty, a secondary private IP address is automatically assigned and the unique identifier of the IP address is returned.</description></item>
        /// <item><description>You can use the GetLeniPrivateIpAddress or ListLeniPrivateIpAddresses interface to check whether the secondary private IP address is assigned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignLeniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignLeniPrivateIpAddressResponse
        /// </returns>
        public async Task<AssignLeniPrivateIpAddressResponse> AssignLeniPrivateIpAddressWithOptionsAsync(AssignLeniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignLeniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignLeniPrivateIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Apply for a secondary private IP address for the current Lingjun Elastic Network Interface. You can automatically assign a secondary private IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Apply for a secondary private IP address for the specified Lingjun Elastic Network Interface.</para>
        /// <list type="bullet">
        /// <item><description>If the PrivateIp field is empty, a secondary private IP address is automatically assigned and the unique identifier of the IP address is returned.</description></item>
        /// <item><description>You can use the GetLeniPrivateIpAddress or ListLeniPrivateIpAddresses interface to check whether the secondary private IP address is assigned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignLeniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignLeniPrivateIpAddressResponse
        /// </returns>
        public AssignLeniPrivateIpAddressResponse AssignLeniPrivateIpAddress(AssignLeniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignLeniPrivateIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Apply for a secondary private IP address for the current Lingjun Elastic Network Interface. You can automatically assign a secondary private IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Apply for a secondary private IP address for the specified Lingjun Elastic Network Interface.</para>
        /// <list type="bullet">
        /// <item><description>If the PrivateIp field is empty, a secondary private IP address is automatically assigned and the unique identifier of the IP address is returned.</description></item>
        /// <item><description>You can use the GetLeniPrivateIpAddress or ListLeniPrivateIpAddresses interface to check whether the secondary private IP address is assigned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignLeniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignLeniPrivateIpAddressResponse
        /// </returns>
        public async Task<AssignLeniPrivateIpAddressResponse> AssignLeniPrivateIpAddressAsync(AssignLeniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignLeniPrivateIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a private secondary IP address for the current LNI. You can also call this operation to assign a secondary MAC address to the current LNI.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Apply for secondary private IP addresses</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>By default, each network interface controller can apply for three secondary private IP addresses. If the quota is exceeded, contact the administrator.</description></item>
        /// <item><description>The secondary private IP address is allocated from the Lingjun subnet to which the current network interface controller belongs. The first address and the last two addresses belong to reserved addresses and do not participate in the allocation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignPrivateIpAddressResponse
        /// </returns>
        public AssignPrivateIpAddressResponse AssignPrivateIpAddressWithOptions(AssignPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignMac))
            {
                body["AssignMac"] = request.AssignMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipConfig))
            {
                body["SkipConfig"] = request.SkipConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignPrivateIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a private secondary IP address for the current LNI. You can also call this operation to assign a secondary MAC address to the current LNI.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Apply for secondary private IP addresses</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>By default, each network interface controller can apply for three secondary private IP addresses. If the quota is exceeded, contact the administrator.</description></item>
        /// <item><description>The secondary private IP address is allocated from the Lingjun subnet to which the current network interface controller belongs. The first address and the last two addresses belong to reserved addresses and do not participate in the allocation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignPrivateIpAddressResponse
        /// </returns>
        public async Task<AssignPrivateIpAddressResponse> AssignPrivateIpAddressWithOptionsAsync(AssignPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignMac))
            {
                body["AssignMac"] = request.AssignMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipConfig))
            {
                body["SkipConfig"] = request.SkipConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignPrivateIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a private secondary IP address for the current LNI. You can also call this operation to assign a secondary MAC address to the current LNI.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Apply for secondary private IP addresses</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>By default, each network interface controller can apply for three secondary private IP addresses. If the quota is exceeded, contact the administrator.</description></item>
        /// <item><description>The secondary private IP address is allocated from the Lingjun subnet to which the current network interface controller belongs. The first address and the last two addresses belong to reserved addresses and do not participate in the allocation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignPrivateIpAddressResponse
        /// </returns>
        public AssignPrivateIpAddressResponse AssignPrivateIpAddress(AssignPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignPrivateIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a private secondary IP address for the current LNI. You can also call this operation to assign a secondary MAC address to the current LNI.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Apply for secondary private IP addresses</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>By default, each network interface controller can apply for three secondary private IP addresses. If the quota is exceeded, contact the administrator.</description></item>
        /// <item><description>The secondary private IP address is allocated from the Lingjun subnet to which the current network interface controller belongs. The first address and the last two addresses belong to reserved addresses and do not participate in the allocation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignPrivateIpAddressResponse
        /// </returns>
        public async Task<AssignPrivateIpAddressResponse> AssignPrivateIpAddressAsync(AssignPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignPrivateIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When the VPD primary network segment address is not enough to allocate, you can choose to create an additional network segment as the additional network segment of the VPD primary network segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> <b>Add a CIDR block</b></para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The CIDR block cannot start with 0. The subnet mask must be 8 to 28 bits in length.</description></item>
        /// <item><description>The secondary IPv4 CIDR block must not overlap with the primary IPv4 CIDR block of the Lingjun CIDR block and the added secondary IPv4 CIDR block.</description></item>
        /// <item><description>You cannot use 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, or 169.254.0.0/16 as the CIDR block of Lingjun. Example: In the Lingjun CIDR block whose primary IPv4 CIDR block is 192.168.0.0/16, you cannot add the following CIDR blocks as additional IPv4 CIDR blocks. The CIDR block that is in the same range as 192.168.0.0/16. A CIDR block that is larger than 192.168.0.0/16. Example: 192.168.0.0/8. A CIDR block that is smaller than 192.168.0.0/16. Example: 192.168.0.0/24.</description></item>
        /// <item><description>By default, each tenant can create three additional CIDR blocks in each region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateVpdCidrBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateVpdCidrBlockResponse
        /// </returns>
        public AssociateVpdCidrBlockResponse AssociateVpdCidrBlockWithOptions(AssociateVpdCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryCidrBlock))
            {
                body["SecondaryCidrBlock"] = request.SecondaryCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateVpdCidrBlock",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateVpdCidrBlockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When the VPD primary network segment address is not enough to allocate, you can choose to create an additional network segment as the additional network segment of the VPD primary network segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> <b>Add a CIDR block</b></para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The CIDR block cannot start with 0. The subnet mask must be 8 to 28 bits in length.</description></item>
        /// <item><description>The secondary IPv4 CIDR block must not overlap with the primary IPv4 CIDR block of the Lingjun CIDR block and the added secondary IPv4 CIDR block.</description></item>
        /// <item><description>You cannot use 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, or 169.254.0.0/16 as the CIDR block of Lingjun. Example: In the Lingjun CIDR block whose primary IPv4 CIDR block is 192.168.0.0/16, you cannot add the following CIDR blocks as additional IPv4 CIDR blocks. The CIDR block that is in the same range as 192.168.0.0/16. A CIDR block that is larger than 192.168.0.0/16. Example: 192.168.0.0/8. A CIDR block that is smaller than 192.168.0.0/16. Example: 192.168.0.0/24.</description></item>
        /// <item><description>By default, each tenant can create three additional CIDR blocks in each region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateVpdCidrBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateVpdCidrBlockResponse
        /// </returns>
        public async Task<AssociateVpdCidrBlockResponse> AssociateVpdCidrBlockWithOptionsAsync(AssociateVpdCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryCidrBlock))
            {
                body["SecondaryCidrBlock"] = request.SecondaryCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateVpdCidrBlock",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateVpdCidrBlockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When the VPD primary network segment address is not enough to allocate, you can choose to create an additional network segment as the additional network segment of the VPD primary network segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> <b>Add a CIDR block</b></para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The CIDR block cannot start with 0. The subnet mask must be 8 to 28 bits in length.</description></item>
        /// <item><description>The secondary IPv4 CIDR block must not overlap with the primary IPv4 CIDR block of the Lingjun CIDR block and the added secondary IPv4 CIDR block.</description></item>
        /// <item><description>You cannot use 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, or 169.254.0.0/16 as the CIDR block of Lingjun. Example: In the Lingjun CIDR block whose primary IPv4 CIDR block is 192.168.0.0/16, you cannot add the following CIDR blocks as additional IPv4 CIDR blocks. The CIDR block that is in the same range as 192.168.0.0/16. A CIDR block that is larger than 192.168.0.0/16. Example: 192.168.0.0/8. A CIDR block that is smaller than 192.168.0.0/16. Example: 192.168.0.0/24.</description></item>
        /// <item><description>By default, each tenant can create three additional CIDR blocks in each region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateVpdCidrBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateVpdCidrBlockResponse
        /// </returns>
        public AssociateVpdCidrBlockResponse AssociateVpdCidrBlock(AssociateVpdCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateVpdCidrBlockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When the VPD primary network segment address is not enough to allocate, you can choose to create an additional network segment as the additional network segment of the VPD primary network segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> <b>Add a CIDR block</b></para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The CIDR block cannot start with 0. The subnet mask must be 8 to 28 bits in length.</description></item>
        /// <item><description>The secondary IPv4 CIDR block must not overlap with the primary IPv4 CIDR block of the Lingjun CIDR block and the added secondary IPv4 CIDR block.</description></item>
        /// <item><description>You cannot use 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, or 169.254.0.0/16 as the CIDR block of Lingjun. Example: In the Lingjun CIDR block whose primary IPv4 CIDR block is 192.168.0.0/16, you cannot add the following CIDR blocks as additional IPv4 CIDR blocks. The CIDR block that is in the same range as 192.168.0.0/16. A CIDR block that is larger than 192.168.0.0/16. Example: 192.168.0.0/8. A CIDR block that is smaller than 192.168.0.0/16. Example: 192.168.0.0/24.</description></item>
        /// <item><description>By default, each tenant can create three additional CIDR blocks in each region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateVpdCidrBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateVpdCidrBlockResponse
        /// </returns>
        public async Task<AssociateVpdCidrBlockResponse> AssociateVpdCidrBlockAsync(AssociateVpdCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateVpdCidrBlockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lingjun ENI is bound to NC.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is an asynchronous interface. You need to use the query interface to wait for the Lingjun Elastic Network Interface to reach the available state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachElasticNetworkInterfaceResponse
        /// </returns>
        public AttachElasticNetworkInterfaceResponse AttachElasticNetworkInterfaceWithOptions(AttachElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachElasticNetworkInterfaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lingjun ENI is bound to NC.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is an asynchronous interface. You need to use the query interface to wait for the Lingjun Elastic Network Interface to reach the available state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<AttachElasticNetworkInterfaceResponse> AttachElasticNetworkInterfaceWithOptionsAsync(AttachElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachElasticNetworkInterfaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lingjun ENI is bound to NC.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is an asynchronous interface. You need to use the query interface to wait for the Lingjun Elastic Network Interface to reach the available state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachElasticNetworkInterfaceResponse
        /// </returns>
        public AttachElasticNetworkInterfaceResponse AttachElasticNetworkInterface(AttachElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachElasticNetworkInterfaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lingjun ENI is bound to NC.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is an asynchronous interface. You need to use the query interface to wait for the Lingjun Elastic Network Interface to reach the available state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<AttachElasticNetworkInterfaceResponse> AttachElasticNetworkInterfaceAsync(AttachElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachElasticNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an LENI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateElasticNetworkInterfaceResponse
        /// </returns>
        public CreateElasticNetworkInterfaceResponse CreateElasticNetworkInterfaceWithOptions(CreateElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableJumboFrame))
            {
                body["EnableJumboFrame"] = request.EnableJumboFrame;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateElasticNetworkInterfaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an LENI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<CreateElasticNetworkInterfaceResponse> CreateElasticNetworkInterfaceWithOptionsAsync(CreateElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableJumboFrame))
            {
                body["EnableJumboFrame"] = request.EnableJumboFrame;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateElasticNetworkInterfaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an LENI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateElasticNetworkInterfaceResponse
        /// </returns>
        public CreateElasticNetworkInterfaceResponse CreateElasticNetworkInterface(CreateElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateElasticNetworkInterfaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an LENI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<CreateElasticNetworkInterfaceResponse> CreateElasticNetworkInterfaceAsync(CreateElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateElasticNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have sufficient Lingjun HUB quota.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the system will return the ID of a Lingjun HUB. At this time, the Lingjun HUB instance may not be created yet, and the system background creation task is still in progress. You can call the ListErs or GetEr operation to query the status of the Lingjun HUB.<list type="bullet">
        /// <item><description>If the status of the Lingjun HUB is Executing, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the Lingjun HUB is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateErResponse
        /// </returns>
        public CreateErResponse CreateErWithOptions(CreateErRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErName))
            {
                body["ErName"] = request.ErName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                body["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateErResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have sufficient Lingjun HUB quota.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the system will return the ID of a Lingjun HUB. At this time, the Lingjun HUB instance may not be created yet, and the system background creation task is still in progress. You can call the ListErs or GetEr operation to query the status of the Lingjun HUB.<list type="bullet">
        /// <item><description>If the status of the Lingjun HUB is Executing, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the Lingjun HUB is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateErResponse
        /// </returns>
        public async Task<CreateErResponse> CreateErWithOptionsAsync(CreateErRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErName))
            {
                body["ErName"] = request.ErName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                body["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateErResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have sufficient Lingjun HUB quota.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the system will return the ID of a Lingjun HUB. At this time, the Lingjun HUB instance may not be created yet, and the system background creation task is still in progress. You can call the ListErs or GetEr operation to query the status of the Lingjun HUB.<list type="bullet">
        /// <item><description>If the status of the Lingjun HUB is Executing, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the Lingjun HUB is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateErResponse
        /// </returns>
        public CreateErResponse CreateEr(CreateErRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateErWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have sufficient Lingjun HUB quota.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the system will return the ID of a Lingjun HUB. At this time, the Lingjun HUB instance may not be created yet, and the system background creation task is still in progress. You can call the ListErs or GetEr operation to query the status of the Lingjun HUB.<list type="bullet">
        /// <item><description>If the status of the Lingjun HUB is Executing, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the Lingjun HUB is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateErResponse
        /// </returns>
        public async Task<CreateErResponse> CreateErAsync(CreateErRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateErWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a network instance connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a network instance connection, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a Lingjun HUB instance.</description></item>
        /// <item><description>Make sure that you have sufficient quota for network instance connections.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the system returns the ID of the network instance connection. In this case, the network instance connection may not be created yet, and the system is still creating the network instance in the background. You can query the connection status of a network instance by ListErAttachments or GetErAttachment:<list type="bullet">
        /// <item><description>If the connection status of the network instance is Executing, the network instance is being created.</description></item>
        /// <item><description>If the connection status of the network instance is Available, the network instance is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErAttachmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateErAttachmentResponse
        /// </returns>
        public CreateErAttachmentResponse CreateErAttachmentWithOptions(CreateErAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoReceiveAllRoute))
            {
                body["AutoReceiveAllRoute"] = request.AutoReceiveAllRoute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentName))
            {
                body["ErAttachmentName"] = request.ErAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTenantId))
            {
                body["ResourceTenantId"] = request.ResourceTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateErAttachment",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateErAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a network instance connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a network instance connection, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a Lingjun HUB instance.</description></item>
        /// <item><description>Make sure that you have sufficient quota for network instance connections.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the system returns the ID of the network instance connection. In this case, the network instance connection may not be created yet, and the system is still creating the network instance in the background. You can query the connection status of a network instance by ListErAttachments or GetErAttachment:<list type="bullet">
        /// <item><description>If the connection status of the network instance is Executing, the network instance is being created.</description></item>
        /// <item><description>If the connection status of the network instance is Available, the network instance is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErAttachmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateErAttachmentResponse
        /// </returns>
        public async Task<CreateErAttachmentResponse> CreateErAttachmentWithOptionsAsync(CreateErAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoReceiveAllRoute))
            {
                body["AutoReceiveAllRoute"] = request.AutoReceiveAllRoute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentName))
            {
                body["ErAttachmentName"] = request.ErAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTenantId))
            {
                body["ResourceTenantId"] = request.ResourceTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateErAttachment",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateErAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a network instance connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a network instance connection, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a Lingjun HUB instance.</description></item>
        /// <item><description>Make sure that you have sufficient quota for network instance connections.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the system returns the ID of the network instance connection. In this case, the network instance connection may not be created yet, and the system is still creating the network instance in the background. You can query the connection status of a network instance by ListErAttachments or GetErAttachment:<list type="bullet">
        /// <item><description>If the connection status of the network instance is Executing, the network instance is being created.</description></item>
        /// <item><description>If the connection status of the network instance is Available, the network instance is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateErAttachmentResponse
        /// </returns>
        public CreateErAttachmentResponse CreateErAttachment(CreateErAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateErAttachmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a network instance connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a network instance connection, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a Lingjun HUB instance.</description></item>
        /// <item><description>Make sure that you have sufficient quota for network instance connections.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the system returns the ID of the network instance connection. In this case, the network instance connection may not be created yet, and the system is still creating the network instance in the background. You can query the connection status of a network instance by ListErAttachments or GetErAttachment:<list type="bullet">
        /// <item><description>If the connection status of the network instance is Executing, the network instance is being created.</description></item>
        /// <item><description>If the connection status of the network instance is Available, the network instance is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateErAttachmentResponse
        /// </returns>
        public async Task<CreateErAttachmentResponse> CreateErAttachmentAsync(CreateErAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateErAttachmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to create routing policy by specifying the network instance connection under Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a routing policy, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a Lingjun HUB instance.</description></item>
        /// <item><description>Make sure that you have created a network instance connection.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the system returns the ID of the routing policy. In this case, the routing policy instance may not be created yet, and the system background creation task is still in progress. You can use ListErRouteMaps or GetErRouteMap to query the status of a routing policy.<list type="bullet">
        /// <item><description>If the status of the routing policy is Execute, the system is creating the instance.</description></item>
        /// <item><description>If the status of the routing policy is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErRouteMapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateErRouteMapResponse
        /// </returns>
        public CreateErRouteMapResponse CreateErRouteMapWithOptions(CreateErRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceId))
            {
                body["ReceptionInstanceId"] = request.ReceptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceOwner))
            {
                body["ReceptionInstanceOwner"] = request.ReceptionInstanceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceType))
            {
                body["ReceptionInstanceType"] = request.ReceptionInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapAction))
            {
                body["RouteMapAction"] = request.RouteMapAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapNum))
            {
                body["RouteMapNum"] = request.RouteMapNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceId))
            {
                body["TransmissionInstanceId"] = request.TransmissionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceOwner))
            {
                body["TransmissionInstanceOwner"] = request.TransmissionInstanceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceType))
            {
                body["TransmissionInstanceType"] = request.TransmissionInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateErRouteMap",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateErRouteMapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to create routing policy by specifying the network instance connection under Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a routing policy, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a Lingjun HUB instance.</description></item>
        /// <item><description>Make sure that you have created a network instance connection.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the system returns the ID of the routing policy. In this case, the routing policy instance may not be created yet, and the system background creation task is still in progress. You can use ListErRouteMaps or GetErRouteMap to query the status of a routing policy.<list type="bullet">
        /// <item><description>If the status of the routing policy is Execute, the system is creating the instance.</description></item>
        /// <item><description>If the status of the routing policy is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErRouteMapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateErRouteMapResponse
        /// </returns>
        public async Task<CreateErRouteMapResponse> CreateErRouteMapWithOptionsAsync(CreateErRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceId))
            {
                body["ReceptionInstanceId"] = request.ReceptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceOwner))
            {
                body["ReceptionInstanceOwner"] = request.ReceptionInstanceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceType))
            {
                body["ReceptionInstanceType"] = request.ReceptionInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapAction))
            {
                body["RouteMapAction"] = request.RouteMapAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapNum))
            {
                body["RouteMapNum"] = request.RouteMapNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceId))
            {
                body["TransmissionInstanceId"] = request.TransmissionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceOwner))
            {
                body["TransmissionInstanceOwner"] = request.TransmissionInstanceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceType))
            {
                body["TransmissionInstanceType"] = request.TransmissionInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateErRouteMap",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateErRouteMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to create routing policy by specifying the network instance connection under Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a routing policy, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a Lingjun HUB instance.</description></item>
        /// <item><description>Make sure that you have created a network instance connection.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the system returns the ID of the routing policy. In this case, the routing policy instance may not be created yet, and the system background creation task is still in progress. You can use ListErRouteMaps or GetErRouteMap to query the status of a routing policy.<list type="bullet">
        /// <item><description>If the status of the routing policy is Execute, the system is creating the instance.</description></item>
        /// <item><description>If the status of the routing policy is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErRouteMapRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateErRouteMapResponse
        /// </returns>
        public CreateErRouteMapResponse CreateErRouteMap(CreateErRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateErRouteMapWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to create routing policy by specifying the network instance connection under Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a routing policy, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a Lingjun HUB instance.</description></item>
        /// <item><description>Make sure that you have created a network instance connection.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the system returns the ID of the routing policy. In this case, the routing policy instance may not be created yet, and the system background creation task is still in progress. You can use ListErRouteMaps or GetErRouteMap to query the status of a routing policy.<list type="bullet">
        /// <item><description>If the status of the routing policy is Execute, the system is creating the instance.</description></item>
        /// <item><description>If the status of the routing policy is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateErRouteMapRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateErRouteMapResponse
        /// </returns>
        public async Task<CreateErRouteMapResponse> CreateErRouteMapAsync(CreateErRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateErRouteMapWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to create a Lingjun subnet under the Lingjun network segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun subnet, note that:</para>
        /// <list type="bullet">
        /// <item><description>You have created a Lingjun CIDR block.</description></item>
        /// <item><description>Only one network segment can be specified for a Lingjun subnet.</description></item>
        /// <item><description>The network segment cannot be modified after the Lingjun subnet is created.</description></item>
        /// <item><description>Make sure that you have sufficient Lingjun subnet quota.</description></item>
        /// <item><description>This interface is an asynchronous interface. After calling this interface, the system will return the ID of a Lingjun subnet. At this time, the Lingjun network segment may not be created yet, and the system background creation task is still in progress. You can call the ListSubnets or GetSubnet operation to query the status of the CIDR block of Lingjun.<list type="bullet">
        /// <item><description>If the status of the Lingjun subnet is Executed, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the Lingjun subnet is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSubnetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubnetResponse
        /// </returns>
        public CreateSubnetResponse CreateSubnetWithOptions(CreateSubnetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                body["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetName))
            {
                body["SubnetName"] = request.SubnetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubnet",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubnetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to create a Lingjun subnet under the Lingjun network segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun subnet, note that:</para>
        /// <list type="bullet">
        /// <item><description>You have created a Lingjun CIDR block.</description></item>
        /// <item><description>Only one network segment can be specified for a Lingjun subnet.</description></item>
        /// <item><description>The network segment cannot be modified after the Lingjun subnet is created.</description></item>
        /// <item><description>Make sure that you have sufficient Lingjun subnet quota.</description></item>
        /// <item><description>This interface is an asynchronous interface. After calling this interface, the system will return the ID of a Lingjun subnet. At this time, the Lingjun network segment may not be created yet, and the system background creation task is still in progress. You can call the ListSubnets or GetSubnet operation to query the status of the CIDR block of Lingjun.<list type="bullet">
        /// <item><description>If the status of the Lingjun subnet is Executed, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the Lingjun subnet is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSubnetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubnetResponse
        /// </returns>
        public async Task<CreateSubnetResponse> CreateSubnetWithOptionsAsync(CreateSubnetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                body["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetName))
            {
                body["SubnetName"] = request.SubnetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubnet",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubnetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to create a Lingjun subnet under the Lingjun network segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun subnet, note that:</para>
        /// <list type="bullet">
        /// <item><description>You have created a Lingjun CIDR block.</description></item>
        /// <item><description>Only one network segment can be specified for a Lingjun subnet.</description></item>
        /// <item><description>The network segment cannot be modified after the Lingjun subnet is created.</description></item>
        /// <item><description>Make sure that you have sufficient Lingjun subnet quota.</description></item>
        /// <item><description>This interface is an asynchronous interface. After calling this interface, the system will return the ID of a Lingjun subnet. At this time, the Lingjun network segment may not be created yet, and the system background creation task is still in progress. You can call the ListSubnets or GetSubnet operation to query the status of the CIDR block of Lingjun.<list type="bullet">
        /// <item><description>If the status of the Lingjun subnet is Executed, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the Lingjun subnet is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSubnetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubnetResponse
        /// </returns>
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubnetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to create a Lingjun subnet under the Lingjun network segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun subnet, note that:</para>
        /// <list type="bullet">
        /// <item><description>You have created a Lingjun CIDR block.</description></item>
        /// <item><description>Only one network segment can be specified for a Lingjun subnet.</description></item>
        /// <item><description>The network segment cannot be modified after the Lingjun subnet is created.</description></item>
        /// <item><description>Make sure that you have sufficient Lingjun subnet quota.</description></item>
        /// <item><description>This interface is an asynchronous interface. After calling this interface, the system will return the ID of a Lingjun subnet. At this time, the Lingjun network segment may not be created yet, and the system background creation task is still in progress. You can call the ListSubnets or GetSubnet operation to query the status of the CIDR block of Lingjun.<list type="bullet">
        /// <item><description>If the status of the Lingjun subnet is Executed, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the Lingjun subnet is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSubnetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubnetResponse
        /// </returns>
        public async Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubnetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can create a Lingjun connection to connect Lingjun network environment and Alibaba Cloud network environment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun connection, note that:</para>
        /// <list type="bullet">
        /// <item><description>When you specify the vccId parameter, the system will configure the purchased Lingjun connection for you. When the default vccId parameter is set, the system will automatically place an order and configure the Lingjun connection for you.</description></item>
        /// <item><description>Make sure that you have called the InitializeVcc operation to grant permissions.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the system will return the Lingjun connection ID, but the Lingjun connection instance may not be created yet, and the system background creation task is still in progress. You can call the ListVccs or GetVcc operation to query the status of the Lingjun connection.<list type="bullet">
        /// <item><description>If the status of the Lingjun connection is Executed, the Lingjun connection is being created.</description></item>
        /// <item><description>If the status of the Lingjun connection is Available, the Lingjun connection is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVccResponse
        /// </returns>
        public CreateVccResponse CreateVccWithOptions(CreateVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessCouldService))
            {
                body["AccessCouldService"] = request.AccessCouldService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgpAsn))
            {
                body["BgpAsn"] = request.BgpAsn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgpCidr))
            {
                body["BgpCidr"] = request.BgpCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                body["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenOwnerId))
            {
                body["CenOwnerId"] = request.CenOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionType))
            {
                body["ConnectionType"] = request.ConnectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccName))
            {
                body["VccName"] = request.VccName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVccResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can create a Lingjun connection to connect Lingjun network environment and Alibaba Cloud network environment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun connection, note that:</para>
        /// <list type="bullet">
        /// <item><description>When you specify the vccId parameter, the system will configure the purchased Lingjun connection for you. When the default vccId parameter is set, the system will automatically place an order and configure the Lingjun connection for you.</description></item>
        /// <item><description>Make sure that you have called the InitializeVcc operation to grant permissions.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the system will return the Lingjun connection ID, but the Lingjun connection instance may not be created yet, and the system background creation task is still in progress. You can call the ListVccs or GetVcc operation to query the status of the Lingjun connection.<list type="bullet">
        /// <item><description>If the status of the Lingjun connection is Executed, the Lingjun connection is being created.</description></item>
        /// <item><description>If the status of the Lingjun connection is Available, the Lingjun connection is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVccResponse
        /// </returns>
        public async Task<CreateVccResponse> CreateVccWithOptionsAsync(CreateVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessCouldService))
            {
                body["AccessCouldService"] = request.AccessCouldService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgpAsn))
            {
                body["BgpAsn"] = request.BgpAsn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgpCidr))
            {
                body["BgpCidr"] = request.BgpCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                body["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenOwnerId))
            {
                body["CenOwnerId"] = request.CenOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionType))
            {
                body["ConnectionType"] = request.ConnectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccName))
            {
                body["VccName"] = request.VccName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVccResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can create a Lingjun connection to connect Lingjun network environment and Alibaba Cloud network environment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun connection, note that:</para>
        /// <list type="bullet">
        /// <item><description>When you specify the vccId parameter, the system will configure the purchased Lingjun connection for you. When the default vccId parameter is set, the system will automatically place an order and configure the Lingjun connection for you.</description></item>
        /// <item><description>Make sure that you have called the InitializeVcc operation to grant permissions.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the system will return the Lingjun connection ID, but the Lingjun connection instance may not be created yet, and the system background creation task is still in progress. You can call the ListVccs or GetVcc operation to query the status of the Lingjun connection.<list type="bullet">
        /// <item><description>If the status of the Lingjun connection is Executed, the Lingjun connection is being created.</description></item>
        /// <item><description>If the status of the Lingjun connection is Available, the Lingjun connection is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVccResponse
        /// </returns>
        public CreateVccResponse CreateVcc(CreateVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVccWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can create a Lingjun connection to connect Lingjun network environment and Alibaba Cloud network environment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a Lingjun connection, note that:</para>
        /// <list type="bullet">
        /// <item><description>When you specify the vccId parameter, the system will configure the purchased Lingjun connection for you. When the default vccId parameter is set, the system will automatically place an order and configure the Lingjun connection for you.</description></item>
        /// <item><description>Make sure that you have called the InitializeVcc operation to grant permissions.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the system will return the Lingjun connection ID, but the Lingjun connection instance may not be created yet, and the system background creation task is still in progress. You can call the ListVccs or GetVcc operation to query the status of the Lingjun connection.<list type="bullet">
        /// <item><description>If the status of the Lingjun connection is Executed, the Lingjun connection is being created.</description></item>
        /// <item><description>If the status of the Lingjun connection is Available, the Lingjun connection is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVccResponse
        /// </returns>
        public async Task<CreateVccResponse> CreateVccAsync(CreateVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVccWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to connect Lingjun instance to the Lingjun HUB instance of the target account. After authorization, the target account can be associated with your Lingjun connection by using the authorized Lingjun HUB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create cross-account authorization for Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the Alibaba Cloud ID and Lingjun HUB instance that you want to authorize are correct.</description></item>
        /// <item><description>If you authorize the account of the other party, the account of the other party can load your local network instance to its Lingjun HUB, and the other party\&quot;s network will be connected to your network. Please proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVccGrantRuleResponse
        /// </returns>
        public CreateVccGrantRuleResponse CreateVccGrantRuleWithOptions(CreateVccGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVccGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVccGrantRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to connect Lingjun instance to the Lingjun HUB instance of the target account. After authorization, the target account can be associated with your Lingjun connection by using the authorized Lingjun HUB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create cross-account authorization for Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the Alibaba Cloud ID and Lingjun HUB instance that you want to authorize are correct.</description></item>
        /// <item><description>If you authorize the account of the other party, the account of the other party can load your local network instance to its Lingjun HUB, and the other party\&quot;s network will be connected to your network. Please proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVccGrantRuleResponse
        /// </returns>
        public async Task<CreateVccGrantRuleResponse> CreateVccGrantRuleWithOptionsAsync(CreateVccGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVccGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVccGrantRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to connect Lingjun instance to the Lingjun HUB instance of the target account. After authorization, the target account can be associated with your Lingjun connection by using the authorized Lingjun HUB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create cross-account authorization for Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the Alibaba Cloud ID and Lingjun HUB instance that you want to authorize are correct.</description></item>
        /// <item><description>If you authorize the account of the other party, the account of the other party can load your local network instance to its Lingjun HUB, and the other party\&quot;s network will be connected to your network. Please proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVccGrantRuleResponse
        /// </returns>
        public CreateVccGrantRuleResponse CreateVccGrantRule(CreateVccGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVccGrantRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to connect Lingjun instance to the Lingjun HUB instance of the target account. After authorization, the target account can be associated with your Lingjun connection by using the authorized Lingjun HUB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create cross-account authorization for Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the Alibaba Cloud ID and Lingjun HUB instance that you want to authorize are correct.</description></item>
        /// <item><description>If you authorize the account of the other party, the account of the other party can load your local network instance to its Lingjun HUB, and the other party\&quot;s network will be connected to your network. Please proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVccGrantRuleResponse
        /// </returns>
        public async Task<CreateVccGrantRuleResponse> CreateVccGrantRuleAsync(CreateVccGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVccGrantRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Lingjun connection route entry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a VBR route entry, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After you call this operation, static route entries and BGP network announcements are created on the VBR to which the Lingjun connection belongs.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the VBR static route entry may not be created yet, and the system still creates the static route entry in the background. You can query the status of VBR static route entries by ListVccRouteEntries or GetVccRouteEntry:<list type="bullet">
        /// <item><description>If the VBR static route entry is in the Executing state, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the VBR static route entry is Available, the VBR is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVccRouteEntryResponse
        /// </returns>
        public CreateVccRouteEntryResponse CreateVccRouteEntryWithOptions(CreateVccRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVccRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVccRouteEntryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Lingjun connection route entry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a VBR route entry, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After you call this operation, static route entries and BGP network announcements are created on the VBR to which the Lingjun connection belongs.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the VBR static route entry may not be created yet, and the system still creates the static route entry in the background. You can query the status of VBR static route entries by ListVccRouteEntries or GetVccRouteEntry:<list type="bullet">
        /// <item><description>If the VBR static route entry is in the Executing state, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the VBR static route entry is Available, the VBR is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVccRouteEntryResponse
        /// </returns>
        public async Task<CreateVccRouteEntryResponse> CreateVccRouteEntryWithOptionsAsync(CreateVccRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVccRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVccRouteEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Lingjun connection route entry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a VBR route entry, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After you call this operation, static route entries and BGP network announcements are created on the VBR to which the Lingjun connection belongs.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the VBR static route entry may not be created yet, and the system still creates the static route entry in the background. You can query the status of VBR static route entries by ListVccRouteEntries or GetVccRouteEntry:<list type="bullet">
        /// <item><description>If the VBR static route entry is in the Executing state, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the VBR static route entry is Available, the VBR is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVccRouteEntryResponse
        /// </returns>
        public CreateVccRouteEntryResponse CreateVccRouteEntry(CreateVccRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVccRouteEntryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a Lingjun connection route entry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a VBR route entry, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After you call this operation, static route entries and BGP network announcements are created on the VBR to which the Lingjun connection belongs.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the VBR static route entry may not be created yet, and the system still creates the static route entry in the background. You can query the status of VBR static route entries by ListVccRouteEntries or GetVccRouteEntry:<list type="bullet">
        /// <item><description>If the VBR static route entry is in the Executing state, it indicates that it is being created.</description></item>
        /// <item><description>If the status of the VBR static route entry is Available, the VBR is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVccRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVccRouteEntryResponse
        /// </returns>
        public async Task<CreateVccRouteEntryResponse> CreateVccRouteEntryAsync(CreateVccRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVccRouteEntryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a private Lingjun CIDR block. This CIDR block has an independent network environment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a CIDR block for Lingjun, take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>A Lingjun network segment can specify an additional network segment in addition to a main network segment.</description></item>
        /// <item><description>After the Lingjun network segment is created, the network segment cannot be modified.</description></item>
        /// <item><description>Make sure that you have a sufficient quota of Lingjun CIDR blocks.</description></item>
        /// <item><description>This interface is an asynchronous interface. After calling this interface, the system will return the ID of a Lingjun network segment. At this time, the Lingjun network segment may not be created yet, and the system background creation task is still in progress. You can call the ListVpds or GetVpd operation to query the status of the CIDR block of Lingjun.<list type="bullet">
        /// <item><description>If the status of the Lingjun CIDR block is Executed, the CIDR block is being created.</description></item>
        /// <item><description>If the status of the Lingjun CIDR block is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpdResponse
        /// </returns>
        public CreateVpdResponse CreateVpdWithOptions(CreateVpdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                body["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subnets))
            {
                body["Subnets"] = request.Subnets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdName))
            {
                body["VpdName"] = request.VpdName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a private Lingjun CIDR block. This CIDR block has an independent network environment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a CIDR block for Lingjun, take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>A Lingjun network segment can specify an additional network segment in addition to a main network segment.</description></item>
        /// <item><description>After the Lingjun network segment is created, the network segment cannot be modified.</description></item>
        /// <item><description>Make sure that you have a sufficient quota of Lingjun CIDR blocks.</description></item>
        /// <item><description>This interface is an asynchronous interface. After calling this interface, the system will return the ID of a Lingjun network segment. At this time, the Lingjun network segment may not be created yet, and the system background creation task is still in progress. You can call the ListVpds or GetVpd operation to query the status of the CIDR block of Lingjun.<list type="bullet">
        /// <item><description>If the status of the Lingjun CIDR block is Executed, the CIDR block is being created.</description></item>
        /// <item><description>If the status of the Lingjun CIDR block is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpdResponse
        /// </returns>
        public async Task<CreateVpdResponse> CreateVpdWithOptionsAsync(CreateVpdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidr))
            {
                body["Cidr"] = request.Cidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subnets))
            {
                body["Subnets"] = request.Subnets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdName))
            {
                body["VpdName"] = request.VpdName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a private Lingjun CIDR block. This CIDR block has an independent network environment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a CIDR block for Lingjun, take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>A Lingjun network segment can specify an additional network segment in addition to a main network segment.</description></item>
        /// <item><description>After the Lingjun network segment is created, the network segment cannot be modified.</description></item>
        /// <item><description>Make sure that you have a sufficient quota of Lingjun CIDR blocks.</description></item>
        /// <item><description>This interface is an asynchronous interface. After calling this interface, the system will return the ID of a Lingjun network segment. At this time, the Lingjun network segment may not be created yet, and the system background creation task is still in progress. You can call the ListVpds or GetVpd operation to query the status of the CIDR block of Lingjun.<list type="bullet">
        /// <item><description>If the status of the Lingjun CIDR block is Executed, the CIDR block is being created.</description></item>
        /// <item><description>If the status of the Lingjun CIDR block is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpdRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpdResponse
        /// </returns>
        public CreateVpdResponse CreateVpd(CreateVpdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a private Lingjun CIDR block. This CIDR block has an independent network environment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create a CIDR block for Lingjun, take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>A Lingjun network segment can specify an additional network segment in addition to a main network segment.</description></item>
        /// <item><description>After the Lingjun network segment is created, the network segment cannot be modified.</description></item>
        /// <item><description>Make sure that you have a sufficient quota of Lingjun CIDR blocks.</description></item>
        /// <item><description>This interface is an asynchronous interface. After calling this interface, the system will return the ID of a Lingjun network segment. At this time, the Lingjun network segment may not be created yet, and the system background creation task is still in progress. You can call the ListVpds or GetVpd operation to query the status of the CIDR block of Lingjun.<list type="bullet">
        /// <item><description>If the status of the Lingjun CIDR block is Executed, the CIDR block is being created.</description></item>
        /// <item><description>If the status of the Lingjun CIDR block is Available, the creation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpdRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpdResponse
        /// </returns>
        public async Task<CreateVpdResponse> CreateVpdAsync(CreateVpdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to authorize Lingjun HUB instances of the target account. After authorization, the target account can be associated with your Lingjun CIDR block by using the authorized Lingjun HUB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create cross-account authorization for Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the Alibaba Cloud ID and Lingjun HUB instance that you want to authorize are correct.</description></item>
        /// <item><description>If you authorize the account of the other party, the account of the other party can load your local network instance to its Lingjun HUB, and the other party\&quot;s network will be connected to your network. Please proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpdGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpdGrantRuleResponse
        /// </returns>
        public CreateVpdGrantRuleResponse CreateVpdGrantRuleWithOptions(CreateVpdGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpdGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpdGrantRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to authorize Lingjun HUB instances of the target account. After authorization, the target account can be associated with your Lingjun CIDR block by using the authorized Lingjun HUB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create cross-account authorization for Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the Alibaba Cloud ID and Lingjun HUB instance that you want to authorize are correct.</description></item>
        /// <item><description>If you authorize the account of the other party, the account of the other party can load your local network instance to its Lingjun HUB, and the other party\&quot;s network will be connected to your network. Please proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpdGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpdGrantRuleResponse
        /// </returns>
        public async Task<CreateVpdGrantRuleResponse> CreateVpdGrantRuleWithOptionsAsync(CreateVpdGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpdGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpdGrantRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to authorize Lingjun HUB instances of the target account. After authorization, the target account can be associated with your Lingjun CIDR block by using the authorized Lingjun HUB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create cross-account authorization for Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the Alibaba Cloud ID and Lingjun HUB instance that you want to authorize are correct.</description></item>
        /// <item><description>If you authorize the account of the other party, the account of the other party can load your local network instance to its Lingjun HUB, and the other party\&quot;s network will be connected to your network. Please proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpdGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpdGrantRuleResponse
        /// </returns>
        public CreateVpdGrantRuleResponse CreateVpdGrantRule(CreateVpdGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpdGrantRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to authorize Lingjun HUB instances of the target account. After authorization, the target account can be associated with your Lingjun CIDR block by using the authorized Lingjun HUB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create cross-account authorization for Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the Alibaba Cloud ID and Lingjun HUB instance that you want to authorize are correct.</description></item>
        /// <item><description>If you authorize the account of the other party, the account of the other party can load your local network instance to its Lingjun HUB, and the other party\&quot;s network will be connected to your network. Please proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpdGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpdGrantRuleResponse
        /// </returns>
        public async Task<CreateVpdGrantRuleResponse> CreateVpdGrantRuleAsync(CreateVpdGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpdGrantRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Lingjun Elastic Network Interface. After deletion, all relevant data will be lost and cannot be recovered. Please operate with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteElasticNetworkInterfaceResponse
        /// </returns>
        public DeleteElasticNetworkInterfaceResponse DeleteElasticNetworkInterfaceWithOptions(DeleteElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteElasticNetworkInterfaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Lingjun Elastic Network Interface. After deletion, all relevant data will be lost and cannot be recovered. Please operate with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<DeleteElasticNetworkInterfaceResponse> DeleteElasticNetworkInterfaceWithOptionsAsync(DeleteElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteElasticNetworkInterfaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Lingjun Elastic Network Interface. After deletion, all relevant data will be lost and cannot be recovered. Please operate with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteElasticNetworkInterfaceResponse
        /// </returns>
        public DeleteElasticNetworkInterfaceResponse DeleteElasticNetworkInterface(DeleteElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteElasticNetworkInterfaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Lingjun Elastic Network Interface. After deletion, all relevant data will be lost and cannot be recovered. Please operate with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<DeleteElasticNetworkInterfaceResponse> DeleteElasticNetworkInterfaceAsync(DeleteElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteElasticNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you delete a Lingjun HUB instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete the Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Before you delete the instance, make sure that no network instance is connected to the Lingjun HUB instance.</description></item>
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun HUB instance may not be deleted, and the system background deletion task is still in progress. You can call the ListErs or GetEr operation to query the deletion status of the Lingjun HUB.<list type="bullet">
        /// <item><description>If the status of the Lingjun HUB is Deleting, the Lingjun HUB instance is being deleted.</description></item>
        /// <item><description>If no Lingjun HUB instance is recorded, the Lingjun HUB instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteErResponse
        /// </returns>
        public DeleteErResponse DeleteErWithOptions(DeleteErRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteErResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you delete a Lingjun HUB instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete the Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Before you delete the instance, make sure that no network instance is connected to the Lingjun HUB instance.</description></item>
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun HUB instance may not be deleted, and the system background deletion task is still in progress. You can call the ListErs or GetEr operation to query the deletion status of the Lingjun HUB.<list type="bullet">
        /// <item><description>If the status of the Lingjun HUB is Deleting, the Lingjun HUB instance is being deleted.</description></item>
        /// <item><description>If no Lingjun HUB instance is recorded, the Lingjun HUB instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteErResponse
        /// </returns>
        public async Task<DeleteErResponse> DeleteErWithOptionsAsync(DeleteErRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteErResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you delete a Lingjun HUB instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete the Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Before you delete the instance, make sure that no network instance is connected to the Lingjun HUB instance.</description></item>
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun HUB instance may not be deleted, and the system background deletion task is still in progress. You can call the ListErs or GetEr operation to query the deletion status of the Lingjun HUB.<list type="bullet">
        /// <item><description>If the status of the Lingjun HUB is Deleting, the Lingjun HUB instance is being deleted.</description></item>
        /// <item><description>If no Lingjun HUB instance is recorded, the Lingjun HUB instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteErResponse
        /// </returns>
        public DeleteErResponse DeleteEr(DeleteErRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteErWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you delete a Lingjun HUB instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete the Lingjun HUB, note that:</para>
        /// <list type="bullet">
        /// <item><description>Before you delete the instance, make sure that no network instance is connected to the Lingjun HUB instance.</description></item>
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun HUB instance may not be deleted, and the system background deletion task is still in progress. You can call the ListErs or GetEr operation to query the deletion status of the Lingjun HUB.<list type="bullet">
        /// <item><description>If the status of the Lingjun HUB is Deleting, the Lingjun HUB instance is being deleted.</description></item>
        /// <item><description>If no Lingjun HUB instance is recorded, the Lingjun HUB instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteErResponse
        /// </returns>
        public async Task<DeleteErResponse> DeleteErAsync(DeleteErRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteErWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a network instance that is connected to an instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a network instance connection, take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>Before you delete the instance, make sure that no routing policy exists under the network instance connection instance.</description></item>
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the network instance that is connected to the instance may not be deleted. The system still deletes the instance in the background. You can call the ListErAttachments or GetErAttachment to query the deletion status of network instance connections:<list type="bullet">
        /// <item><description>If the status of the network instance connection is Deleting, the network instance connection is being deleted.</description></item>
        /// <item><description>If there is no connection record for the network instance, the connection to the network instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErAttachmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteErAttachmentResponse
        /// </returns>
        public DeleteErAttachmentResponse DeleteErAttachmentWithOptions(DeleteErAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentId))
            {
                body["ErAttachmentId"] = request.ErAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteErAttachment",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteErAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a network instance that is connected to an instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a network instance connection, take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>Before you delete the instance, make sure that no routing policy exists under the network instance connection instance.</description></item>
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the network instance that is connected to the instance may not be deleted. The system still deletes the instance in the background. You can call the ListErAttachments or GetErAttachment to query the deletion status of network instance connections:<list type="bullet">
        /// <item><description>If the status of the network instance connection is Deleting, the network instance connection is being deleted.</description></item>
        /// <item><description>If there is no connection record for the network instance, the connection to the network instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErAttachmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteErAttachmentResponse
        /// </returns>
        public async Task<DeleteErAttachmentResponse> DeleteErAttachmentWithOptionsAsync(DeleteErAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentId))
            {
                body["ErAttachmentId"] = request.ErAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteErAttachment",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteErAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a network instance that is connected to an instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a network instance connection, take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>Before you delete the instance, make sure that no routing policy exists under the network instance connection instance.</description></item>
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the network instance that is connected to the instance may not be deleted. The system still deletes the instance in the background. You can call the ListErAttachments or GetErAttachment to query the deletion status of network instance connections:<list type="bullet">
        /// <item><description>If the status of the network instance connection is Deleting, the network instance connection is being deleted.</description></item>
        /// <item><description>If there is no connection record for the network instance, the connection to the network instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteErAttachmentResponse
        /// </returns>
        public DeleteErAttachmentResponse DeleteErAttachment(DeleteErAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteErAttachmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a network instance that is connected to an instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a network instance connection, take note of the following:</para>
        /// <list type="bullet">
        /// <item><description>Before you delete the instance, make sure that no routing policy exists under the network instance connection instance.</description></item>
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the network instance that is connected to the instance may not be deleted. The system still deletes the instance in the background. You can call the ListErAttachments or GetErAttachment to query the deletion status of network instance connections:<list type="bullet">
        /// <item><description>If the status of the network instance connection is Deleting, the network instance connection is being deleted.</description></item>
        /// <item><description>If there is no connection record for the network instance, the connection to the network instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteErAttachmentResponse
        /// </returns>
        public async Task<DeleteErAttachmentResponse> DeleteErAttachmentAsync(DeleteErAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteErAttachmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a routing policy instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a routing policy, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the routing policy instance may not be deleted yet, and the system background deletion task is still in progress. You can call the ListErRouteMaps or GetErRouteMap operation to query the deletion status of a routing policy.<list type="bullet">
        /// <item><description>If the routing policy is in the Deleting state, the routing policy instance is being deleted.</description></item>
        /// <item><description>If no routing policy instance is recorded, the routing policy instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErRouteMapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteErRouteMapResponse
        /// </returns>
        public DeleteErRouteMapResponse DeleteErRouteMapWithOptions(DeleteErRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapIds))
            {
                body["ErRouteMapIds"] = request.ErRouteMapIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteErRouteMap",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteErRouteMapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a routing policy instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a routing policy, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the routing policy instance may not be deleted yet, and the system background deletion task is still in progress. You can call the ListErRouteMaps or GetErRouteMap operation to query the deletion status of a routing policy.<list type="bullet">
        /// <item><description>If the routing policy is in the Deleting state, the routing policy instance is being deleted.</description></item>
        /// <item><description>If no routing policy instance is recorded, the routing policy instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErRouteMapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteErRouteMapResponse
        /// </returns>
        public async Task<DeleteErRouteMapResponse> DeleteErRouteMapWithOptionsAsync(DeleteErRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapIds))
            {
                body["ErRouteMapIds"] = request.ErRouteMapIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteErRouteMap",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteErRouteMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a routing policy instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a routing policy, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the routing policy instance may not be deleted yet, and the system background deletion task is still in progress. You can call the ListErRouteMaps or GetErRouteMap operation to query the deletion status of a routing policy.<list type="bullet">
        /// <item><description>If the routing policy is in the Deleting state, the routing policy instance is being deleted.</description></item>
        /// <item><description>If no routing policy instance is recorded, the routing policy instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErRouteMapRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteErRouteMapResponse
        /// </returns>
        public DeleteErRouteMapResponse DeleteErRouteMap(DeleteErRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteErRouteMapWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a routing policy instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a routing policy, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the routing policy instance may not be deleted yet, and the system background deletion task is still in progress. You can call the ListErRouteMaps or GetErRouteMap operation to query the deletion status of a routing policy.<list type="bullet">
        /// <item><description>If the routing policy is in the Deleting state, the routing policy instance is being deleted.</description></item>
        /// <item><description>If no routing policy instance is recorded, the routing policy instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteErRouteMapRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteErRouteMapResponse
        /// </returns>
        public async Task<DeleteErRouteMapResponse> DeleteErRouteMapAsync(DeleteErRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteErRouteMapWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a Lingjun subnet instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a Lingjun subnet, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun subnet instance may not be deleted, and the system background deletion task is still in progress. You can call the ListSubnets or GetSubnet operation to query the deletion status of the subnet.<list type="bullet">
        /// <item><description>If the status of the Lingjun subnet is Deleting, the Lingjun subnet instance is being deleted.</description></item>
        /// <item><description>If there is no record of the Lingjun subnet instance, the Lingjun subnet instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSubnetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubnetResponse
        /// </returns>
        public DeleteSubnetResponse DeleteSubnetWithOptions(DeleteSubnetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubnet",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubnetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a Lingjun subnet instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a Lingjun subnet, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun subnet instance may not be deleted, and the system background deletion task is still in progress. You can call the ListSubnets or GetSubnet operation to query the deletion status of the subnet.<list type="bullet">
        /// <item><description>If the status of the Lingjun subnet is Deleting, the Lingjun subnet instance is being deleted.</description></item>
        /// <item><description>If there is no record of the Lingjun subnet instance, the Lingjun subnet instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSubnetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubnetResponse
        /// </returns>
        public async Task<DeleteSubnetResponse> DeleteSubnetWithOptionsAsync(DeleteSubnetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubnet",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubnetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a Lingjun subnet instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a Lingjun subnet, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun subnet instance may not be deleted, and the system background deletion task is still in progress. You can call the ListSubnets or GetSubnet operation to query the deletion status of the subnet.<list type="bullet">
        /// <item><description>If the status of the Lingjun subnet is Deleting, the Lingjun subnet instance is being deleted.</description></item>
        /// <item><description>If there is no record of the Lingjun subnet instance, the Lingjun subnet instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSubnetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubnetResponse
        /// </returns>
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubnetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a Lingjun subnet instance, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a Lingjun subnet, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun subnet instance may not be deleted, and the system background deletion task is still in progress. You can call the ListSubnets or GetSubnet operation to query the deletion status of the subnet.<list type="bullet">
        /// <item><description>If the status of the Lingjun subnet is Deleting, the Lingjun subnet instance is being deleted.</description></item>
        /// <item><description>If there is no record of the Lingjun subnet instance, the Lingjun subnet instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSubnetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubnetResponse
        /// </returns>
        public async Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubnetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a Lingjun HUB cross-account authorization that is connected to Lingjun, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVccGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVccGrantRuleResponse
        /// </returns>
        public DeleteVccGrantRuleResponse DeleteVccGrantRuleWithOptions(DeleteVccGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVccGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVccGrantRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a Lingjun HUB cross-account authorization that is connected to Lingjun, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVccGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVccGrantRuleResponse
        /// </returns>
        public async Task<DeleteVccGrantRuleResponse> DeleteVccGrantRuleWithOptionsAsync(DeleteVccGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVccGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVccGrantRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a Lingjun HUB cross-account authorization that is connected to Lingjun, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVccGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVccGrantRuleResponse
        /// </returns>
        public DeleteVccGrantRuleResponse DeleteVccGrantRule(DeleteVccGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVccGrantRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you delete a Lingjun HUB cross-account authorization that is connected to Lingjun, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVccGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVccGrantRuleResponse
        /// </returns>
        public async Task<DeleteVccGrantRuleResponse> DeleteVccGrantRuleAsync(DeleteVccGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVccGrantRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a Lingjun connection route entry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a VBR static route entry, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the VBR static route entries may not be deleted. The system still deletes the VBR static route entries in the background. You can call the ListVccRouteEntries or GetVccRouteEntry to query the deletion status of VBR static route entries:<list type="bullet">
        /// <item><description>If the VBR static route entry is in the Deleting state, the VBR static route entry is being deleted.</description></item>
        /// <item><description>If no VBR static route entry instance is recorded, the VBR static route entry instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVccRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVccRouteEntryResponse
        /// </returns>
        public DeleteVccRouteEntryResponse DeleteVccRouteEntryWithOptions(DeleteVccRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccRouteEntryId))
            {
                body["VccRouteEntryId"] = request.VccRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVccRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVccRouteEntryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a Lingjun connection route entry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a VBR static route entry, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the VBR static route entries may not be deleted. The system still deletes the VBR static route entries in the background. You can call the ListVccRouteEntries or GetVccRouteEntry to query the deletion status of VBR static route entries:<list type="bullet">
        /// <item><description>If the VBR static route entry is in the Deleting state, the VBR static route entry is being deleted.</description></item>
        /// <item><description>If no VBR static route entry instance is recorded, the VBR static route entry instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVccRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVccRouteEntryResponse
        /// </returns>
        public async Task<DeleteVccRouteEntryResponse> DeleteVccRouteEntryWithOptionsAsync(DeleteVccRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccRouteEntryId))
            {
                body["VccRouteEntryId"] = request.VccRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVccRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVccRouteEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a Lingjun connection route entry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a VBR static route entry, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the VBR static route entries may not be deleted. The system still deletes the VBR static route entries in the background. You can call the ListVccRouteEntries or GetVccRouteEntry to query the deletion status of VBR static route entries:<list type="bullet">
        /// <item><description>If the VBR static route entry is in the Deleting state, the VBR static route entry is being deleted.</description></item>
        /// <item><description>If no VBR static route entry instance is recorded, the VBR static route entry instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVccRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVccRouteEntryResponse
        /// </returns>
        public DeleteVccRouteEntryResponse DeleteVccRouteEntry(DeleteVccRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVccRouteEntryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a Lingjun connection route entry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a VBR static route entry, note that:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>This operation is an asynchronous operation. After you call this operation, the VBR static route entries may not be deleted. The system still deletes the VBR static route entries in the background. You can call the ListVccRouteEntries or GetVccRouteEntry to query the deletion status of VBR static route entries:<list type="bullet">
        /// <item><description>If the VBR static route entry is in the Deleting state, the VBR static route entry is being deleted.</description></item>
        /// <item><description>If no VBR static route entry instance is recorded, the VBR static route entry instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVccRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVccRouteEntryResponse
        /// </returns>
        public async Task<DeleteVccRouteEntryResponse> DeleteVccRouteEntryAsync(DeleteVccRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVccRouteEntryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you delete a Lingjun CIDR block, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a Lingjun CIDR block, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>Before deleting, make sure that all Lingjun subnet instances under the Lingjun CIDR block have been deleted.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun network segment instance may not be deleted, and the system background deletion task is still in progress. You can call the ListVpds or GetVpd operation to query the deletion status of the CIDR block.<list type="bullet">
        /// <item><description>If the status of the Lingjun CIDR block is Deleting, the Lingjun CIDR block is being deleted.</description></item>
        /// <item><description>If there is no record of the Lingjun CIDR block instance, the Lingjun CIDR block instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpdResponse
        /// </returns>
        public DeleteVpdResponse DeleteVpdWithOptions(DeleteVpdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you delete a Lingjun CIDR block, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a Lingjun CIDR block, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>Before deleting, make sure that all Lingjun subnet instances under the Lingjun CIDR block have been deleted.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun network segment instance may not be deleted, and the system background deletion task is still in progress. You can call the ListVpds or GetVpd operation to query the deletion status of the CIDR block.<list type="bullet">
        /// <item><description>If the status of the Lingjun CIDR block is Deleting, the Lingjun CIDR block is being deleted.</description></item>
        /// <item><description>If there is no record of the Lingjun CIDR block instance, the Lingjun CIDR block instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpdResponse
        /// </returns>
        public async Task<DeleteVpdResponse> DeleteVpdWithOptionsAsync(DeleteVpdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you delete a Lingjun CIDR block, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a Lingjun CIDR block, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>Before deleting, make sure that all Lingjun subnet instances under the Lingjun CIDR block have been deleted.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun network segment instance may not be deleted, and the system background deletion task is still in progress. You can call the ListVpds or GetVpd operation to query the deletion status of the CIDR block.<list type="bullet">
        /// <item><description>If the status of the Lingjun CIDR block is Deleting, the Lingjun CIDR block is being deleted.</description></item>
        /// <item><description>If there is no record of the Lingjun CIDR block instance, the Lingjun CIDR block instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpdResponse
        /// </returns>
        public DeleteVpdResponse DeleteVpd(DeleteVpdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you delete a Lingjun CIDR block, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to delete a Lingjun CIDR block, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After deletion, all related data is lost and cannot be recovered. Exercise caution when performing this operation.</description></item>
        /// <item><description>Before deleting, make sure that all Lingjun subnet instances under the Lingjun CIDR block have been deleted.</description></item>
        /// <item><description>This interface is an asynchronous interface. After this interface is called, the Lingjun network segment instance may not be deleted, and the system background deletion task is still in progress. You can call the ListVpds or GetVpd operation to query the deletion status of the CIDR block.<list type="bullet">
        /// <item><description>If the status of the Lingjun CIDR block is Deleting, the Lingjun CIDR block is being deleted.</description></item>
        /// <item><description>If there is no record of the Lingjun CIDR block instance, the Lingjun CIDR block instance has been deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpdResponse
        /// </returns>
        public async Task<DeleteVpdResponse> DeleteVpdAsync(DeleteVpdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the Lingjun HUB cross-account authorization for a Lingjun CIDR block. After the deletion, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVpdGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpdGrantRuleResponse
        /// </returns>
        public DeleteVpdGrantRuleResponse DeleteVpdGrantRuleWithOptions(DeleteVpdGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpdGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpdGrantRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the Lingjun HUB cross-account authorization for a Lingjun CIDR block. After the deletion, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVpdGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpdGrantRuleResponse
        /// </returns>
        public async Task<DeleteVpdGrantRuleResponse> DeleteVpdGrantRuleWithOptionsAsync(DeleteVpdGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpdGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpdGrantRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the Lingjun HUB cross-account authorization for a Lingjun CIDR block. After the deletion, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVpdGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpdGrantRuleResponse
        /// </returns>
        public DeleteVpdGrantRuleResponse DeleteVpdGrantRule(DeleteVpdGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpdGrantRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the Lingjun HUB cross-account authorization for a Lingjun CIDR block. After the deletion, the related data is lost and cannot be recovered.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVpdGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpdGrantRuleResponse
        /// </returns>
        public async Task<DeleteVpdGrantRuleResponse> DeleteVpdGrantRuleAsync(DeleteVpdGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpdGrantRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query whether the user has the SLR role-AliyunServiceRoleForEfloVcc required for Lingjun connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query whether a user account has a <b>AliyunServiceRoleForEfloVcc</b> role.</para>
        /// <remarks>
        /// <para> If you do not have a <b>AliyunServiceRoleForEfloVcc</b> role, you need to use the initializeVcc interface to complete authorization, otherwise users will not be able to use Lingjun to connect to the product.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSlrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlrResponse
        /// </returns>
        public DescribeSlrResponse DescribeSlrWithOptions(DescribeSlrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query whether the user has the SLR role-AliyunServiceRoleForEfloVcc required for Lingjun connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query whether a user account has a <b>AliyunServiceRoleForEfloVcc</b> role.</para>
        /// <remarks>
        /// <para> If you do not have a <b>AliyunServiceRoleForEfloVcc</b> role, you need to use the initializeVcc interface to complete authorization, otherwise users will not be able to use Lingjun to connect to the product.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSlrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlrResponse
        /// </returns>
        public async Task<DescribeSlrResponse> DescribeSlrWithOptionsAsync(DescribeSlrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query whether the user has the SLR role-AliyunServiceRoleForEfloVcc required for Lingjun connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query whether a user account has a <b>AliyunServiceRoleForEfloVcc</b> role.</para>
        /// <remarks>
        /// <para> If you do not have a <b>AliyunServiceRoleForEfloVcc</b> role, you need to use the initializeVcc interface to complete authorization, otherwise users will not be able to use Lingjun to connect to the product.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSlrRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlrResponse
        /// </returns>
        public DescribeSlrResponse DescribeSlr(DescribeSlrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query whether the user has the SLR role-AliyunServiceRoleForEfloVcc required for Lingjun connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query whether a user account has a <b>AliyunServiceRoleForEfloVcc</b> role.</para>
        /// <remarks>
        /// <para> If you do not have a <b>AliyunServiceRoleForEfloVcc</b> role, you need to use the initializeVcc interface to complete authorization, otherwise users will not be able to use Lingjun to connect to the product.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSlrRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlrResponse
        /// </returns>
        public async Task<DescribeSlrResponse> DescribeSlrAsync(DescribeSlrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind Lingjun ENI from NC.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is an asynchronous interface, and you need to use the query interface to wait for the Lingjun Elastic Network Interface to reach the unbound state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachElasticNetworkInterfaceResponse
        /// </returns>
        public DetachElasticNetworkInterfaceResponse DetachElasticNetworkInterfaceWithOptions(DetachElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachElasticNetworkInterfaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind Lingjun ENI from NC.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is an asynchronous interface, and you need to use the query interface to wait for the Lingjun Elastic Network Interface to reach the unbound state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<DetachElasticNetworkInterfaceResponse> DetachElasticNetworkInterfaceWithOptionsAsync(DetachElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachElasticNetworkInterfaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind Lingjun ENI from NC.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is an asynchronous interface, and you need to use the query interface to wait for the Lingjun Elastic Network Interface to reach the unbound state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachElasticNetworkInterfaceResponse
        /// </returns>
        public DetachElasticNetworkInterfaceResponse DetachElasticNetworkInterface(DetachElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachElasticNetworkInterfaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind Lingjun ENI from NC.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is an asynchronous interface, and you need to use the query interface to wait for the Lingjun Elastic Network Interface to reach the unbound state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<DetachElasticNetworkInterfaceResponse> DetachElasticNetworkInterfaceAsync(DetachElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachElasticNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to query the destination CIDR block of the source policy instance when creating a routing strategy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDestinationCidrBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDestinationCidrBlockResponse
        /// </returns>
        public GetDestinationCidrBlockResponse GetDestinationCidrBlockWithOptions(GetDestinationCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDestinationCidrBlock",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDestinationCidrBlockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to query the destination CIDR block of the source policy instance when creating a routing strategy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDestinationCidrBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDestinationCidrBlockResponse
        /// </returns>
        public async Task<GetDestinationCidrBlockResponse> GetDestinationCidrBlockWithOptionsAsync(GetDestinationCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDestinationCidrBlock",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDestinationCidrBlockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to query the destination CIDR block of the source policy instance when creating a routing strategy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDestinationCidrBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDestinationCidrBlockResponse
        /// </returns>
        public GetDestinationCidrBlockResponse GetDestinationCidrBlock(GetDestinationCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDestinationCidrBlockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Users can use this API to query the destination CIDR block of the source policy instance when creating a routing strategy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDestinationCidrBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDestinationCidrBlockResponse
        /// </returns>
        public async Task<GetDestinationCidrBlockResponse> GetDestinationCidrBlockAsync(GetDestinationCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDestinationCidrBlockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an LENI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetElasticNetworkInterfaceResponse
        /// </returns>
        public GetElasticNetworkInterfaceResponse GetElasticNetworkInterfaceWithOptions(GetElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElasticNetworkInterfaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an LENI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<GetElasticNetworkInterfaceResponse> GetElasticNetworkInterfaceWithOptionsAsync(GetElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElasticNetworkInterfaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an LENI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetElasticNetworkInterfaceResponse
        /// </returns>
        public GetElasticNetworkInterfaceResponse GetElasticNetworkInterface(GetElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetElasticNetworkInterfaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an LENI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<GetElasticNetworkInterfaceResponse> GetElasticNetworkInterfaceAsync(GetElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetElasticNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErResponse
        /// </returns>
        public GetErResponse GetErWithOptions(GetErRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErResponse
        /// </returns>
        public async Task<GetErResponse> GetErWithOptionsAsync(GetErRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErResponse
        /// </returns>
        public GetErResponse GetEr(GetErRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetErWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErResponse
        /// </returns>
        public async Task<GetErResponse> GetErAsync(GetErRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetErWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries network instance connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErAttachmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErAttachmentResponse
        /// </returns>
        public GetErAttachmentResponse GetErAttachmentWithOptions(GetErAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentId))
            {
                body["ErAttachmentId"] = request.ErAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErAttachment",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries network instance connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErAttachmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErAttachmentResponse
        /// </returns>
        public async Task<GetErAttachmentResponse> GetErAttachmentWithOptionsAsync(GetErAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentId))
            {
                body["ErAttachmentId"] = request.ErAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErAttachment",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries network instance connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErAttachmentResponse
        /// </returns>
        public GetErAttachmentResponse GetErAttachment(GetErAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetErAttachmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries network instance connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErAttachmentResponse
        /// </returns>
        public async Task<GetErAttachmentResponse> GetErAttachmentAsync(GetErAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetErAttachmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of Lingjun HUB route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErRouteEntryResponse
        /// </returns>
        public GetErRouteEntryResponse GetErRouteEntryWithOptions(GetErRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteEntryId))
            {
                body["ErRouteEntryId"] = request.ErRouteEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErRouteEntryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of Lingjun HUB route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErRouteEntryResponse
        /// </returns>
        public async Task<GetErRouteEntryResponse> GetErRouteEntryWithOptionsAsync(GetErRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteEntryId))
            {
                body["ErRouteEntryId"] = request.ErRouteEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErRouteEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of Lingjun HUB route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErRouteEntryResponse
        /// </returns>
        public GetErRouteEntryResponse GetErRouteEntry(GetErRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetErRouteEntryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of Lingjun HUB route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErRouteEntryResponse
        /// </returns>
        public async Task<GetErRouteEntryResponse> GetErRouteEntryAsync(GetErRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetErRouteEntryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>query lingjun hub routing policy details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRouteMapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErRouteMapResponse
        /// </returns>
        public GetErRouteMapResponse GetErRouteMapWithOptions(GetErRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapId))
            {
                body["ErRouteMapId"] = request.ErRouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErRouteMap",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErRouteMapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>query lingjun hub routing policy details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRouteMapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErRouteMapResponse
        /// </returns>
        public async Task<GetErRouteMapResponse> GetErRouteMapWithOptionsAsync(GetErRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapId))
            {
                body["ErRouteMapId"] = request.ErRouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErRouteMap",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErRouteMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>query lingjun hub routing policy details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRouteMapRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErRouteMapResponse
        /// </returns>
        public GetErRouteMapResponse GetErRouteMap(GetErRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetErRouteMapWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>query lingjun hub routing policy details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetErRouteMapRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErRouteMapResponse
        /// </returns>
        public async Task<GetErRouteMapResponse> GetErRouteMapAsync(GetErRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetErRouteMapWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the physical topology information of Lingjun network interface controller and Lingjun nodes under VPD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFabricTopologyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFabricTopologyResponse
        /// </returns>
        public GetFabricTopologyResponse GetFabricTopologyWithOptions(GetFabricTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LniIds))
            {
                body["LniIds"] = request.LniIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFabricTopology",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFabricTopologyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the physical topology information of Lingjun network interface controller and Lingjun nodes under VPD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFabricTopologyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFabricTopologyResponse
        /// </returns>
        public async Task<GetFabricTopologyResponse> GetFabricTopologyWithOptionsAsync(GetFabricTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LniIds))
            {
                body["LniIds"] = request.LniIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFabricTopology",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFabricTopologyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the physical topology information of Lingjun network interface controller and Lingjun nodes under VPD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFabricTopologyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFabricTopologyResponse
        /// </returns>
        public GetFabricTopologyResponse GetFabricTopology(GetFabricTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFabricTopologyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the physical topology information of Lingjun network interface controller and Lingjun nodes under VPD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFabricTopologyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFabricTopologyResponse
        /// </returns>
        public async Task<GetFabricTopologyResponse> GetFabricTopologyAsync(GetFabricTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFabricTopologyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the secondary private IP address of a specified Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLeniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLeniPrivateIpAddressResponse
        /// </returns>
        public GetLeniPrivateIpAddressResponse GetLeniPrivateIpAddressWithOptions(GetLeniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLeniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLeniPrivateIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the secondary private IP address of a specified Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLeniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLeniPrivateIpAddressResponse
        /// </returns>
        public async Task<GetLeniPrivateIpAddressResponse> GetLeniPrivateIpAddressWithOptionsAsync(GetLeniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLeniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLeniPrivateIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the secondary private IP address of a specified Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLeniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLeniPrivateIpAddressResponse
        /// </returns>
        public GetLeniPrivateIpAddressResponse GetLeniPrivateIpAddress(GetLeniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLeniPrivateIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the secondary private IP address of a specified Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLeniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLeniPrivateIpAddressResponse
        /// </returns>
        public async Task<GetLeniPrivateIpAddressResponse> GetLeniPrivateIpAddressAsync(GetLeniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLeniPrivateIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details about the secondary private IP address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLniPrivateIpAddressResponse
        /// </returns>
        public GetLniPrivateIpAddressResponse GetLniPrivateIpAddressWithOptions(GetLniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLniPrivateIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details about the secondary private IP address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLniPrivateIpAddressResponse
        /// </returns>
        public async Task<GetLniPrivateIpAddressResponse> GetLniPrivateIpAddressWithOptionsAsync(GetLniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLniPrivateIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details about the secondary private IP address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLniPrivateIpAddressResponse
        /// </returns>
        public GetLniPrivateIpAddressResponse GetLniPrivateIpAddress(GetLniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLniPrivateIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details about the secondary private IP address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLniPrivateIpAddressResponse
        /// </returns>
        public async Task<GetLniPrivateIpAddressResponse> GetLniPrivateIpAddressAsync(GetLniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLniPrivateIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an LNI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNetworkInterfaceResponse
        /// </returns>
        public GetNetworkInterfaceResponse GetNetworkInterfaceWithOptions(GetNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetworkInterfaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an LNI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNetworkInterfaceResponse
        /// </returns>
        public async Task<GetNetworkInterfaceResponse> GetNetworkInterfaceWithOptionsAsync(GetNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetworkInterfaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an LNI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNetworkInterfaceResponse
        /// </returns>
        public GetNetworkInterfaceResponse GetNetworkInterface(GetNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNetworkInterfaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an LNI.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNetworkInterfaceResponse
        /// </returns>
        public async Task<GetNetworkInterfaceResponse> GetNetworkInterfaceAsync(GetNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network information of a node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeInfoForPodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeInfoForPodResponse
        /// </returns>
        public GetNodeInfoForPodResponse GetNodeInfoForPodWithOptions(GetNodeInfoForPodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeInfoForPod",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeInfoForPodResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network information of a node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeInfoForPodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeInfoForPodResponse
        /// </returns>
        public async Task<GetNodeInfoForPodResponse> GetNodeInfoForPodWithOptionsAsync(GetNodeInfoForPodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeInfoForPod",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeInfoForPodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network information of a node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeInfoForPodRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeInfoForPodResponse
        /// </returns>
        public GetNodeInfoForPodResponse GetNodeInfoForPod(GetNodeInfoForPodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeInfoForPodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network information of a node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeInfoForPodRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeInfoForPodResponse
        /// </returns>
        public async Task<GetNodeInfoForPodResponse> GetNodeInfoForPodAsync(GetNodeInfoForPodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeInfoForPodWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun subnet, including the type, CIDR block, instance ID, instance status, and number of NCs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubnetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubnetResponse
        /// </returns>
        public GetSubnetResponse GetSubnetWithOptions(GetSubnetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubnet",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubnetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun subnet, including the type, CIDR block, instance ID, instance status, and number of NCs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubnetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubnetResponse
        /// </returns>
        public async Task<GetSubnetResponse> GetSubnetWithOptionsAsync(GetSubnetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubnet",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubnetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun subnet, including the type, CIDR block, instance ID, instance status, and number of NCs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubnetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubnetResponse
        /// </returns>
        public GetSubnetResponse GetSubnet(GetSubnetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubnetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun subnet, including the type, CIDR block, instance ID, instance status, and number of NCs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubnetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubnetResponse
        /// </returns>
        public async Task<GetSubnetResponse> GetSubnetAsync(GetSubnetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubnetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun connection, including the specification, Express Connect circuit access port type, instance status, bandwidth, and BGP CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVccResponse
        /// </returns>
        public GetVccResponse GetVccWithOptions(GetVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVccResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun connection, including the specification, Express Connect circuit access port type, instance status, bandwidth, and BGP CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVccResponse
        /// </returns>
        public async Task<GetVccResponse> GetVccWithOptionsAsync(GetVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVccResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun connection, including the specification, Express Connect circuit access port type, instance status, bandwidth, and BGP CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVccResponse
        /// </returns>
        public GetVccResponse GetVcc(GetVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVccWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun connection, including the specification, Express Connect circuit access port type, instance status, bandwidth, and BGP CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVccResponse
        /// </returns>
        public async Task<GetVccResponse> GetVccAsync(GetVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVccWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of cross-account resource authorization for a Lingjun connection, including the authorized tenant ID, Lingjun HUB instance ID, and network instance ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVccGrantRuleResponse
        /// </returns>
        public GetVccGrantRuleResponse GetVccGrantRuleWithOptions(GetVccGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVccGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVccGrantRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of cross-account resource authorization for a Lingjun connection, including the authorized tenant ID, Lingjun HUB instance ID, and network instance ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVccGrantRuleResponse
        /// </returns>
        public async Task<GetVccGrantRuleResponse> GetVccGrantRuleWithOptionsAsync(GetVccGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVccGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVccGrantRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of cross-account resource authorization for a Lingjun connection, including the authorized tenant ID, Lingjun HUB instance ID, and network instance ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVccGrantRuleResponse
        /// </returns>
        public GetVccGrantRuleResponse GetVccGrantRule(GetVccGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVccGrantRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of cross-account resource authorization for a Lingjun connection, including the authorized tenant ID, Lingjun HUB instance ID, and network instance ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVccGrantRuleResponse
        /// </returns>
        public async Task<GetVccGrantRuleResponse> GetVccGrantRuleAsync(GetVccGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVccGrantRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVccRouteEntryResponse
        /// </returns>
        public GetVccRouteEntryResponse GetVccRouteEntryWithOptions(GetVccRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccRouteEntryId))
            {
                body["VccRouteEntryId"] = request.VccRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVccRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVccRouteEntryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVccRouteEntryResponse
        /// </returns>
        public async Task<GetVccRouteEntryResponse> GetVccRouteEntryWithOptionsAsync(GetVccRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccRouteEntryId))
            {
                body["VccRouteEntryId"] = request.VccRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVccRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVccRouteEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVccRouteEntryResponse
        /// </returns>
        public GetVccRouteEntryResponse GetVccRouteEntry(GetVccRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVccRouteEntryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVccRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVccRouteEntryResponse
        /// </returns>
        public async Task<GetVccRouteEntryResponse> GetVccRouteEntryAsync(GetVccRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVccRouteEntryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun CIDR block, including the status of the Lingjun CIDR block, the CIDR block, the number of subnets and NCs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpdResponse
        /// </returns>
        public GetVpdResponse GetVpdWithOptions(GetVpdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun CIDR block, including the status of the Lingjun CIDR block, the CIDR block, the number of subnets and NCs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpdResponse
        /// </returns>
        public async Task<GetVpdResponse> GetVpdWithOptionsAsync(GetVpdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun CIDR block, including the status of the Lingjun CIDR block, the CIDR block, the number of subnets and NCs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpdResponse
        /// </returns>
        public GetVpdResponse GetVpd(GetVpdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVpdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun CIDR block, including the status of the Lingjun CIDR block, the CIDR block, the number of subnets and NCs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpdResponse
        /// </returns>
        public async Task<GetVpdResponse> GetVpdAsync(GetVpdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVpdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of cross-account resource authorization for a Lingjun CIDR block, including the authorized tenant ID, Lingjun HUB instance ID, and network instance ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpdGrantRuleResponse
        /// </returns>
        public GetVpdGrantRuleResponse GetVpdGrantRuleWithOptions(GetVpdGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpdGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpdGrantRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of cross-account resource authorization for a Lingjun CIDR block, including the authorized tenant ID, Lingjun HUB instance ID, and network instance ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdGrantRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpdGrantRuleResponse
        /// </returns>
        public async Task<GetVpdGrantRuleResponse> GetVpdGrantRuleWithOptionsAsync(GetVpdGrantRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpdGrantRule",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpdGrantRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of cross-account resource authorization for a Lingjun CIDR block, including the authorized tenant ID, Lingjun HUB instance ID, and network instance ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpdGrantRuleResponse
        /// </returns>
        public GetVpdGrantRuleResponse GetVpdGrantRule(GetVpdGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVpdGrantRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of cross-account resource authorization for a Lingjun CIDR block, including the authorized tenant ID, Lingjun HUB instance ID, and network instance ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdGrantRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpdGrantRuleResponse
        /// </returns>
        public async Task<GetVpdGrantRuleResponse> GetVpdGrantRuleAsync(GetVpdGrantRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVpdGrantRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpdRouteEntryResponse
        /// </returns>
        public GetVpdRouteEntryResponse GetVpdRouteEntryWithOptions(GetVpdRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdRouteEntryId))
            {
                body["VpdRouteEntryId"] = request.VpdRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpdRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpdRouteEntryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdRouteEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpdRouteEntryResponse
        /// </returns>
        public async Task<GetVpdRouteEntryResponse> GetVpdRouteEntryWithOptionsAsync(GetVpdRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdRouteEntryId))
            {
                body["VpdRouteEntryId"] = request.VpdRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpdRouteEntry",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpdRouteEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpdRouteEntryResponse
        /// </returns>
        public GetVpdRouteEntryResponse GetVpdRouteEntry(GetVpdRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVpdRouteEntryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpdRouteEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpdRouteEntryResponse
        /// </returns>
        public async Task<GetVpdRouteEntryResponse> GetVpdRouteEntryAsync(GetVpdRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVpdRouteEntryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initialize the Lingjun connection and authorize Intelligent Computing Lingjun to create an SLR in your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitializeVccResponse
        /// </returns>
        public InitializeVccResponse InitializeVccWithOptions(InitializeVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitializeVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeVccResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initialize the Lingjun connection and authorize Intelligent Computing Lingjun to create an SLR in your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitializeVccResponse
        /// </returns>
        public async Task<InitializeVccResponse> InitializeVccWithOptionsAsync(InitializeVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitializeVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeVccResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initialize the Lingjun connection and authorize Intelligent Computing Lingjun to create an SLR in your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeVccRequest
        /// </param>
        /// 
        /// <returns>
        /// InitializeVccResponse
        /// </returns>
        public InitializeVccResponse InitializeVcc(InitializeVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeVccWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initialize the Lingjun connection and authorize Intelligent Computing Lingjun to create an SLR in your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeVccRequest
        /// </param>
        /// 
        /// <returns>
        /// InitializeVccResponse
        /// </returns>
        public async Task<InitializeVccResponse> InitializeVccAsync(InitializeVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeVccWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the LENIs that are associated with a Lingjun node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListElasticNetworkInterfacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListElasticNetworkInterfacesResponse
        /// </returns>
        public ListElasticNetworkInterfacesResponse ListElasticNetworkInterfacesWithOptions(ListElasticNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListElasticNetworkInterfaces",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListElasticNetworkInterfacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the LENIs that are associated with a Lingjun node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListElasticNetworkInterfacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListElasticNetworkInterfacesResponse
        /// </returns>
        public async Task<ListElasticNetworkInterfacesResponse> ListElasticNetworkInterfacesWithOptionsAsync(ListElasticNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListElasticNetworkInterfaces",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListElasticNetworkInterfacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the LENIs that are associated with a Lingjun node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListElasticNetworkInterfacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListElasticNetworkInterfacesResponse
        /// </returns>
        public ListElasticNetworkInterfacesResponse ListElasticNetworkInterfaces(ListElasticNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListElasticNetworkInterfacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the LENIs that are associated with a Lingjun node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListElasticNetworkInterfacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListElasticNetworkInterfacesResponse
        /// </returns>
        public async Task<ListElasticNetworkInterfacesResponse> ListElasticNetworkInterfacesAsync(ListElasticNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListElasticNetworkInterfacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries network instance connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErAttachmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListErAttachmentsResponse
        /// </returns>
        public ListErAttachmentsResponse ListErAttachmentsWithOptions(ListErAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoReceiveAllRoute))
            {
                body["AutoReceiveAllRoute"] = request.AutoReceiveAllRoute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentId))
            {
                body["ErAttachmentId"] = request.ErAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentName))
            {
                body["ErAttachmentName"] = request.ErAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTenantId))
            {
                body["ResourceTenantId"] = request.ResourceTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListErAttachments",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListErAttachmentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries network instance connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErAttachmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListErAttachmentsResponse
        /// </returns>
        public async Task<ListErAttachmentsResponse> ListErAttachmentsWithOptionsAsync(ListErAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoReceiveAllRoute))
            {
                body["AutoReceiveAllRoute"] = request.AutoReceiveAllRoute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentId))
            {
                body["ErAttachmentId"] = request.ErAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentName))
            {
                body["ErAttachmentName"] = request.ErAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTenantId))
            {
                body["ResourceTenantId"] = request.ResourceTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListErAttachments",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListErAttachmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries network instance connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErAttachmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListErAttachmentsResponse
        /// </returns>
        public ListErAttachmentsResponse ListErAttachments(ListErAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListErAttachmentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries network instance connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErAttachmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListErAttachmentsResponse
        /// </returns>
        public async Task<ListErAttachmentsResponse> ListErAttachmentsAsync(ListErAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListErAttachmentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListErRouteEntriesResponse
        /// </returns>
        public ListErRouteEntriesResponse ListErRouteEntriesWithOptions(ListErRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDetailedRouteEntry))
            {
                body["IgnoreDetailedRouteEntry"] = request.IgnoreDetailedRouteEntry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopId))
            {
                body["NextHopId"] = request.NextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                body["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["RouteType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListErRouteEntries",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListErRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListErRouteEntriesResponse
        /// </returns>
        public async Task<ListErRouteEntriesResponse> ListErRouteEntriesWithOptionsAsync(ListErRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDetailedRouteEntry))
            {
                body["IgnoreDetailedRouteEntry"] = request.IgnoreDetailedRouteEntry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopId))
            {
                body["NextHopId"] = request.NextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                body["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["RouteType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListErRouteEntries",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListErRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListErRouteEntriesResponse
        /// </returns>
        public ListErRouteEntriesResponse ListErRouteEntries(ListErRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListErRouteEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListErRouteEntriesResponse
        /// </returns>
        public async Task<ListErRouteEntriesResponse> ListErRouteEntriesAsync(ListErRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListErRouteEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Routing policies are queried.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErRouteMapsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListErRouteMapsResponse
        /// </returns>
        public ListErRouteMapsResponse ListErRouteMapsWithOptions(ListErRouteMapsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapId))
            {
                body["ErRouteMapId"] = request.ErRouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapNum))
            {
                body["ErRouteMapNum"] = request.ErRouteMapNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceId))
            {
                body["ReceptionInstanceId"] = request.ReceptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceName))
            {
                body["ReceptionInstanceName"] = request.ReceptionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceType))
            {
                body["ReceptionInstanceType"] = request.ReceptionInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapAction))
            {
                body["RouteMapAction"] = request.RouteMapAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceId))
            {
                body["TransmissionInstanceId"] = request.TransmissionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceName))
            {
                body["TransmissionInstanceName"] = request.TransmissionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceType))
            {
                body["TransmissionInstanceType"] = request.TransmissionInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListErRouteMaps",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListErRouteMapsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Routing policies are queried.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErRouteMapsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListErRouteMapsResponse
        /// </returns>
        public async Task<ListErRouteMapsResponse> ListErRouteMapsWithOptionsAsync(ListErRouteMapsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapId))
            {
                body["ErRouteMapId"] = request.ErRouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapNum))
            {
                body["ErRouteMapNum"] = request.ErRouteMapNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceId))
            {
                body["ReceptionInstanceId"] = request.ReceptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceName))
            {
                body["ReceptionInstanceName"] = request.ReceptionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceptionInstanceType))
            {
                body["ReceptionInstanceType"] = request.ReceptionInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapAction))
            {
                body["RouteMapAction"] = request.RouteMapAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceId))
            {
                body["TransmissionInstanceId"] = request.TransmissionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceName))
            {
                body["TransmissionInstanceName"] = request.TransmissionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmissionInstanceType))
            {
                body["TransmissionInstanceType"] = request.TransmissionInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListErRouteMaps",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListErRouteMapsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Routing policies are queried.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErRouteMapsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListErRouteMapsResponse
        /// </returns>
        public ListErRouteMapsResponse ListErRouteMaps(ListErRouteMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListErRouteMapsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Routing policies are queried.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErRouteMapsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListErRouteMapsResponse
        /// </returns>
        public async Task<ListErRouteMapsResponse> ListErRouteMapsAsync(ListErRouteMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListErRouteMapsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListErsResponse
        /// </returns>
        public ListErsResponse ListErsWithOptions(ListErsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErName))
            {
                body["ErName"] = request.ErName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                body["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListErs",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListErsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListErsResponse
        /// </returns>
        public async Task<ListErsResponse> ListErsWithOptionsAsync(ListErsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErName))
            {
                body["ErName"] = request.ErName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                body["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListErs",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListErsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListErsResponse
        /// </returns>
        public ListErsResponse ListErs(ListErsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListErsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListErsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListErsResponse
        /// </returns>
        public async Task<ListErsResponse> ListErsAsync(ListErsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListErsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the GPU node list of a specified GPU node whose communication distance does not exceed the specified NCD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesByNcdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesByNcdResponse
        /// </returns>
        public ListInstancesByNcdResponse ListInstancesByNcdWithOptions(ListInstancesByNcdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxNcd))
            {
                body["MaxNcd"] = request.MaxNcd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesByNcd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesByNcdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the GPU node list of a specified GPU node whose communication distance does not exceed the specified NCD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesByNcdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesByNcdResponse
        /// </returns>
        public async Task<ListInstancesByNcdResponse> ListInstancesByNcdWithOptionsAsync(ListInstancesByNcdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxNcd))
            {
                body["MaxNcd"] = request.MaxNcd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesByNcd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesByNcdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the GPU node list of a specified GPU node whose communication distance does not exceed the specified NCD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesByNcdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesByNcdResponse
        /// </returns>
        public ListInstancesByNcdResponse ListInstancesByNcd(ListInstancesByNcdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesByNcdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the GPU node list of a specified GPU node whose communication distance does not exceed the specified NCD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesByNcdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesByNcdResponse
        /// </returns>
        public async Task<ListInstancesByNcdResponse> ListInstancesByNcdAsync(ListInstancesByNcdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesByNcdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of secondary private IP addresses of Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLeniPrivateIpAddressesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLeniPrivateIpAddressesResponse
        /// </returns>
        public ListLeniPrivateIpAddressesResponse ListLeniPrivateIpAddressesWithOptions(ListLeniPrivateIpAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLeniPrivateIpAddresses",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLeniPrivateIpAddressesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of secondary private IP addresses of Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLeniPrivateIpAddressesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLeniPrivateIpAddressesResponse
        /// </returns>
        public async Task<ListLeniPrivateIpAddressesResponse> ListLeniPrivateIpAddressesWithOptionsAsync(ListLeniPrivateIpAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLeniPrivateIpAddresses",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLeniPrivateIpAddressesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of secondary private IP addresses of Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLeniPrivateIpAddressesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLeniPrivateIpAddressesResponse
        /// </returns>
        public ListLeniPrivateIpAddressesResponse ListLeniPrivateIpAddresses(ListLeniPrivateIpAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLeniPrivateIpAddressesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of secondary private IP addresses of Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLeniPrivateIpAddressesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLeniPrivateIpAddressesResponse
        /// </returns>
        public async Task<ListLeniPrivateIpAddressesResponse> ListLeniPrivateIpAddressesAsync(ListLeniPrivateIpAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLeniPrivateIpAddressesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of secondary private IP addresses of Lingjun network interface controller.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLniPrivateIpAddressResponse
        /// </returns>
        public ListLniPrivateIpAddressResponse ListLniPrivateIpAddressWithOptions(ListLniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLniPrivateIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of secondary private IP addresses of Lingjun network interface controller.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLniPrivateIpAddressResponse
        /// </returns>
        public async Task<ListLniPrivateIpAddressResponse> ListLniPrivateIpAddressWithOptionsAsync(ListLniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLniPrivateIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of secondary private IP addresses of Lingjun network interface controller.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLniPrivateIpAddressResponse
        /// </returns>
        public ListLniPrivateIpAddressResponse ListLniPrivateIpAddress(ListLniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLniPrivateIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of secondary private IP addresses of Lingjun network interface controller.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLniPrivateIpAddressResponse
        /// </returns>
        public async Task<ListLniPrivateIpAddressResponse> ListLniPrivateIpAddressAsync(ListLniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLniPrivateIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Lingjun network interfaces (LNIs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNetworkInterfacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNetworkInterfacesResponse
        /// </returns>
        public ListNetworkInterfacesResponse ListNetworkInterfacesWithOptions(ListNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkInterfaces",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkInterfacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Lingjun network interfaces (LNIs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNetworkInterfacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNetworkInterfacesResponse
        /// </returns>
        public async Task<ListNetworkInterfacesResponse> ListNetworkInterfacesWithOptionsAsync(ListNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkInterfaces",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkInterfacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Lingjun network interfaces (LNIs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNetworkInterfacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNetworkInterfacesResponse
        /// </returns>
        public ListNetworkInterfacesResponse ListNetworkInterfaces(ListNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNetworkInterfacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Lingjun network interfaces (LNIs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNetworkInterfacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNetworkInterfacesResponse
        /// </returns>
        public async Task<ListNetworkInterfacesResponse> ListNetworkInterfacesAsync(ListNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNetworkInterfacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries node network information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInfosForPodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInfosForPodResponse
        /// </returns>
        public ListNodeInfosForPodResponse ListNodeInfosForPodWithOptions(ListNodeInfosForPodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeInfosForPod",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeInfosForPodResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries node network information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInfosForPodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInfosForPodResponse
        /// </returns>
        public async Task<ListNodeInfosForPodResponse> ListNodeInfosForPodWithOptionsAsync(ListNodeInfosForPodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeInfosForPod",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeInfosForPodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries node network information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInfosForPodRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInfosForPodResponse
        /// </returns>
        public ListNodeInfosForPodResponse ListNodeInfosForPod(ListNodeInfosForPodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeInfosForPodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries node network information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInfosForPodRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInfosForPodResponse
        /// </returns>
        public async Task<ListNodeInfosForPodResponse> ListNodeInfosForPodAsync(ListNodeInfosForPodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeInfosForPodWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query the details of one or more Lingjun subnets, including the Lingjun subnet type, network address segment, and instance ID of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubnetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubnetsResponse
        /// </returns>
        public ListSubnetsResponse ListSubnetsWithOptions(ListSubnetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetName))
            {
                body["SubnetName"] = request.SubnetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubnets",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubnetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query the details of one or more Lingjun subnets, including the Lingjun subnet type, network address segment, and instance ID of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubnetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubnetsResponse
        /// </returns>
        public async Task<ListSubnetsResponse> ListSubnetsWithOptionsAsync(ListSubnetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetName))
            {
                body["SubnetName"] = request.SubnetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubnets",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubnetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query the details of one or more Lingjun subnets, including the Lingjun subnet type, network address segment, and instance ID of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubnetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubnetsResponse
        /// </returns>
        public ListSubnetsResponse ListSubnets(ListSubnetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubnetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query the details of one or more Lingjun subnets, including the Lingjun subnet type, network address segment, and instance ID of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubnetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubnetsResponse
        /// </returns>
        public async Task<ListSubnetsResponse> ListSubnetsAsync(ListSubnetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubnetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the traffic rate of a Lingjun connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccFlowInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVccFlowInfosResponse
        /// </returns>
        public ListVccFlowInfosResponse ListVccFlowInfosWithOptions(ListVccFlowInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                body["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                body["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVccFlowInfos",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVccFlowInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the traffic rate of a Lingjun connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccFlowInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVccFlowInfosResponse
        /// </returns>
        public async Task<ListVccFlowInfosResponse> ListVccFlowInfosWithOptionsAsync(ListVccFlowInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                body["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                body["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVccFlowInfos",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVccFlowInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the traffic rate of a Lingjun connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccFlowInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVccFlowInfosResponse
        /// </returns>
        public ListVccFlowInfosResponse ListVccFlowInfos(ListVccFlowInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVccFlowInfosWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the traffic rate of a Lingjun connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccFlowInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVccFlowInfosResponse
        /// </returns>
        public async Task<ListVccFlowInfosResponse> ListVccFlowInfosAsync(ListVccFlowInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVccFlowInfosWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun connection authorization, including the authorized tenant ID, region, and Lingjun HUB instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccGrantRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVccGrantRulesResponse
        /// </returns>
        public ListVccGrantRulesResponse ListVccGrantRulesWithOptions(ListVccGrantRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForSelect))
            {
                body["ForSelect"] = request.ForSelect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVccGrantRules",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVccGrantRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun connection authorization, including the authorized tenant ID, region, and Lingjun HUB instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccGrantRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVccGrantRulesResponse
        /// </returns>
        public async Task<ListVccGrantRulesResponse> ListVccGrantRulesWithOptionsAsync(ListVccGrantRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForSelect))
            {
                body["ForSelect"] = request.ForSelect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVccGrantRules",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVccGrantRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun connection authorization, including the authorized tenant ID, region, and Lingjun HUB instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccGrantRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVccGrantRulesResponse
        /// </returns>
        public ListVccGrantRulesResponse ListVccGrantRules(ListVccGrantRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVccGrantRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Lingjun connection authorization, including the authorized tenant ID, region, and Lingjun HUB instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccGrantRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVccGrantRulesResponse
        /// </returns>
        public async Task<ListVccGrantRulesResponse> ListVccGrantRulesAsync(ListVccGrantRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVccGrantRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Lingjun connection route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVccRouteEntriesResponse
        /// </returns>
        public ListVccRouteEntriesResponse ListVccRouteEntriesWithOptions(ListVccRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDetailedRouteEntry))
            {
                body["IgnoreDetailedRouteEntry"] = request.IgnoreDetailedRouteEntry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopId))
            {
                body["NextHopId"] = request.NextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                body["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["RouteType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdRouteEntryId))
            {
                body["VpdRouteEntryId"] = request.VpdRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVccRouteEntries",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVccRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Lingjun connection route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVccRouteEntriesResponse
        /// </returns>
        public async Task<ListVccRouteEntriesResponse> ListVccRouteEntriesWithOptionsAsync(ListVccRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDetailedRouteEntry))
            {
                body["IgnoreDetailedRouteEntry"] = request.IgnoreDetailedRouteEntry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopId))
            {
                body["NextHopId"] = request.NextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                body["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["RouteType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdRouteEntryId))
            {
                body["VpdRouteEntryId"] = request.VpdRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVccRouteEntries",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVccRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Lingjun connection route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVccRouteEntriesResponse
        /// </returns>
        public ListVccRouteEntriesResponse ListVccRouteEntries(ListVccRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVccRouteEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Lingjun connection route entries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVccRouteEntriesResponse
        /// </returns>
        public async Task<ListVccRouteEntriesResponse> ListVccRouteEntriesAsync(ListVccRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVccRouteEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>query the details of one or more lingjun connections, including the specification, Express Connect circuit access port type, instance status, bandwidth, and bgp network segment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVccsResponse
        /// </returns>
        public ListVccsResponse ListVccsWithOptions(ListVccsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                body["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExStatus))
            {
                body["ExStatus"] = request.ExStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterErId))
            {
                body["FilterErId"] = request.FilterErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVccs",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVccsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>query the details of one or more lingjun connections, including the specification, Express Connect circuit access port type, instance status, bandwidth, and bgp network segment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVccsResponse
        /// </returns>
        public async Task<ListVccsResponse> ListVccsWithOptionsAsync(ListVccsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                body["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExStatus))
            {
                body["ExStatus"] = request.ExStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterErId))
            {
                body["FilterErId"] = request.FilterErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVccs",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVccsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>query the details of one or more lingjun connections, including the specification, Express Connect circuit access port type, instance status, bandwidth, and bgp network segment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVccsResponse
        /// </returns>
        public ListVccsResponse ListVccs(ListVccsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVccsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>query the details of one or more lingjun connections, including the specification, Express Connect circuit access port type, instance status, bandwidth, and bgp network segment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVccsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVccsResponse
        /// </returns>
        public async Task<ListVccsResponse> ListVccsAsync(ListVccsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVccsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more route entries in the CIDR block of Lingjun, including the route type, route entry status, destination CIDR block, and instance information of the next route entry.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdGrantRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpdGrantRulesResponse
        /// </returns>
        public ListVpdGrantRulesResponse ListVpdGrantRulesWithOptions(ListVpdGrantRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForSelect))
            {
                body["ForSelect"] = request.ForSelect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpdGrantRules",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpdGrantRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more route entries in the CIDR block of Lingjun, including the route type, route entry status, destination CIDR block, and instance information of the next route entry.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdGrantRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpdGrantRulesResponse
        /// </returns>
        public async Task<ListVpdGrantRulesResponse> ListVpdGrantRulesWithOptionsAsync(ListVpdGrantRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForSelect))
            {
                body["ForSelect"] = request.ForSelect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRuleId))
            {
                body["GrantRuleId"] = request.GrantRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantTenantId))
            {
                body["GrantTenantId"] = request.GrantTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpdGrantRules",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpdGrantRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more route entries in the CIDR block of Lingjun, including the route type, route entry status, destination CIDR block, and instance information of the next route entry.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdGrantRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpdGrantRulesResponse
        /// </returns>
        public ListVpdGrantRulesResponse ListVpdGrantRules(ListVpdGrantRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpdGrantRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more route entries in the CIDR block of Lingjun, including the route type, route entry status, destination CIDR block, and instance information of the next route entry.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdGrantRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpdGrantRulesResponse
        /// </returns>
        public async Task<ListVpdGrantRulesResponse> ListVpdGrantRulesAsync(ListVpdGrantRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpdGrantRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpdRouteEntriesResponse
        /// </returns>
        public ListVpdRouteEntriesResponse ListVpdRouteEntriesWithOptions(ListVpdRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDetailedRouteEntry))
            {
                body["IgnoreDetailedRouteEntry"] = request.IgnoreDetailedRouteEntry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopId))
            {
                body["NextHopId"] = request.NextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                body["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["RouteType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdRouteEntryId))
            {
                body["VpdRouteEntryId"] = request.VpdRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpdRouteEntries",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpdRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpdRouteEntriesResponse
        /// </returns>
        public async Task<ListVpdRouteEntriesResponse> ListVpdRouteEntriesWithOptionsAsync(ListVpdRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreDetailedRouteEntry))
            {
                body["IgnoreDetailedRouteEntry"] = request.IgnoreDetailedRouteEntry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopId))
            {
                body["NextHopId"] = request.NextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                body["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                body["RouteType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdRouteEntryId))
            {
                body["VpdRouteEntryId"] = request.VpdRouteEntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpdRouteEntries",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpdRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpdRouteEntriesResponse
        /// </returns>
        public ListVpdRouteEntriesResponse ListVpdRouteEntries(ListVpdRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpdRouteEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpdRouteEntriesResponse
        /// </returns>
        public async Task<ListVpdRouteEntriesResponse> ListVpdRouteEntriesAsync(ListVpdRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpdRouteEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more Lingjun CIDR blocks, including the status of Lingjun CIDR blocks, Cidr addresses, service CIDR blocks, and Subnet.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpdsResponse
        /// </returns>
        public ListVpdsResponse ListVpdsWithOptions(ListVpdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterErId))
            {
                body["FilterErId"] = request.FilterErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForSelect))
            {
                body["ForSelect"] = request.ForSelect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdName))
            {
                body["VpdName"] = request.VpdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDependence))
            {
                body["WithDependence"] = request.WithDependence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutVcc))
            {
                body["WithoutVcc"] = request.WithoutVcc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpds",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpdsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more Lingjun CIDR blocks, including the status of Lingjun CIDR blocks, Cidr addresses, service CIDR blocks, and Subnet.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpdsResponse
        /// </returns>
        public async Task<ListVpdsResponse> ListVpdsWithOptionsAsync(ListVpdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePage))
            {
                body["EnablePage"] = request.EnablePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterErId))
            {
                body["FilterErId"] = request.FilterErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForSelect))
            {
                body["ForSelect"] = request.ForSelect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdName))
            {
                body["VpdName"] = request.VpdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDependence))
            {
                body["WithDependence"] = request.WithDependence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutVcc))
            {
                body["WithoutVcc"] = request.WithoutVcc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpds",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more Lingjun CIDR blocks, including the status of Lingjun CIDR blocks, Cidr addresses, service CIDR blocks, and Subnet.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpdsResponse
        /// </returns>
        public ListVpdsResponse ListVpds(ListVpdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpdsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more Lingjun CIDR blocks, including the status of Lingjun CIDR blocks, Cidr addresses, service CIDR blocks, and Subnet.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpdsResponse
        /// </returns>
        public async Task<ListVpdsResponse> ListVpdsAsync(ListVpdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpdsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the network communication distance (Network Communication Distance,NCD) between instances (Lingjun node, Lingjun network interface controller).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceNcdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceNcdResponse
        /// </returns>
        public QueryInstanceNcdResponse QueryInstanceNcdWithOptions(QueryInstanceNcdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId1))
            {
                body["InstanceId1"] = request.InstanceId1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId2))
            {
                body["InstanceId2"] = request.InstanceId2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceNcd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceNcdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the network communication distance (Network Communication Distance,NCD) between instances (Lingjun node, Lingjun network interface controller).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceNcdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceNcdResponse
        /// </returns>
        public async Task<QueryInstanceNcdResponse> QueryInstanceNcdWithOptionsAsync(QueryInstanceNcdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId1))
            {
                body["InstanceId1"] = request.InstanceId1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId2))
            {
                body["InstanceId2"] = request.InstanceId2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceNcd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceNcdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the network communication distance (Network Communication Distance,NCD) between instances (Lingjun node, Lingjun network interface controller).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceNcdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceNcdResponse
        /// </returns>
        public QueryInstanceNcdResponse QueryInstanceNcd(QueryInstanceNcdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceNcdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the network communication distance (Network Communication Distance,NCD) between instances (Lingjun node, Lingjun network interface controller).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceNcdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceNcdResponse
        /// </returns>
        public async Task<QueryInstanceNcdResponse> QueryInstanceNcdAsync(QueryInstanceNcdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceNcdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unsubscribe inactive Lingjun connection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only unsubscribable for Lingjun connections in the prepayment status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RefundVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundVccResponse
        /// </returns>
        public RefundVccResponse RefundVccWithOptions(RefundVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundVccResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unsubscribe inactive Lingjun connection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only unsubscribable for Lingjun connections in the prepayment status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RefundVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundVccResponse
        /// </returns>
        public async Task<RefundVccResponse> RefundVccWithOptionsAsync(RefundVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundVccResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unsubscribe inactive Lingjun connection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only unsubscribable for Lingjun connections in the prepayment status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RefundVccRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundVccResponse
        /// </returns>
        public RefundVccResponse RefundVcc(RefundVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefundVccWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unsubscribe inactive Lingjun connection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only unsubscribable for Lingjun connections in the prepayment status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RefundVccRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundVccResponse
        /// </returns>
        public async Task<RefundVccResponse> RefundVccAsync(RefundVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefundVccWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retry trying to create /delete a Lingjun connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation allows the user to retry the operation if the Lingjun connection creation and deletion processes fail. Only the Lingjun connection in the creation failure and deletion failure state can be retried</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryVccResponse
        /// </returns>
        public RetryVccResponse RetryVccWithOptions(RetryVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryVccResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retry trying to create /delete a Lingjun connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation allows the user to retry the operation if the Lingjun connection creation and deletion processes fail. Only the Lingjun connection in the creation failure and deletion failure state can be retried</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryVccResponse
        /// </returns>
        public async Task<RetryVccResponse> RetryVccWithOptionsAsync(RetryVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryVccResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retry trying to create /delete a Lingjun connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation allows the user to retry the operation if the Lingjun connection creation and deletion processes fail. Only the Lingjun connection in the creation failure and deletion failure state can be retried</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryVccRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryVccResponse
        /// </returns>
        public RetryVccResponse RetryVcc(RetryVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryVccWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retry trying to create /delete a Lingjun connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation allows the user to retry the operation if the Lingjun connection creation and deletion processes fail. Only the Lingjun connection in the creation failure and deletion failure state can be retried</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryVccRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryVccResponse
        /// </returns>
        public async Task<RetryVccResponse> RetryVccAsync(RetryVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryVccWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an assigned secondary private IP address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnAssignPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnAssignPrivateIpAddressResponse
        /// </returns>
        public UnAssignPrivateIpAddressResponse UnAssignPrivateIpAddressWithOptions(UnAssignPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAssignPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAssignPrivateIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an assigned secondary private IP address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnAssignPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnAssignPrivateIpAddressResponse
        /// </returns>
        public async Task<UnAssignPrivateIpAddressResponse> UnAssignPrivateIpAddressWithOptionsAsync(UnAssignPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceId))
            {
                body["NetworkInterfaceId"] = request.NetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAssignPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAssignPrivateIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an assigned secondary private IP address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnAssignPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// UnAssignPrivateIpAddressResponse
        /// </returns>
        public UnAssignPrivateIpAddressResponse UnAssignPrivateIpAddress(UnAssignPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnAssignPrivateIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an assigned secondary private IP address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnAssignPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// UnAssignPrivateIpAddressResponse
        /// </returns>
        public async Task<UnAssignPrivateIpAddressResponse> UnAssignPrivateIpAddressAsync(UnAssignPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnAssignPrivateIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function can be used to delete the additional network segment of VPD.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning</b> If the attached CIDR block has Lingjun subnet resources, you must delete the dependent resources before you can delete the attached CIDR block.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnAssociateVpdCidrBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnAssociateVpdCidrBlockResponse
        /// </returns>
        public UnAssociateVpdCidrBlockResponse UnAssociateVpdCidrBlockWithOptions(UnAssociateVpdCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryCidrBlock))
            {
                body["SecondaryCidrBlock"] = request.SecondaryCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAssociateVpdCidrBlock",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAssociateVpdCidrBlockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function can be used to delete the additional network segment of VPD.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning</b> If the attached CIDR block has Lingjun subnet resources, you must delete the dependent resources before you can delete the attached CIDR block.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnAssociateVpdCidrBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnAssociateVpdCidrBlockResponse
        /// </returns>
        public async Task<UnAssociateVpdCidrBlockResponse> UnAssociateVpdCidrBlockWithOptionsAsync(UnAssociateVpdCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryCidrBlock))
            {
                body["SecondaryCidrBlock"] = request.SecondaryCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAssociateVpdCidrBlock",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAssociateVpdCidrBlockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function can be used to delete the additional network segment of VPD.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning</b> If the attached CIDR block has Lingjun subnet resources, you must delete the dependent resources before you can delete the attached CIDR block.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnAssociateVpdCidrBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// UnAssociateVpdCidrBlockResponse
        /// </returns>
        public UnAssociateVpdCidrBlockResponse UnAssociateVpdCidrBlock(UnAssociateVpdCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnAssociateVpdCidrBlockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function can be used to delete the additional network segment of VPD.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning</b> If the attached CIDR block has Lingjun subnet resources, you must delete the dependent resources before you can delete the attached CIDR block.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnAssociateVpdCidrBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// UnAssociateVpdCidrBlockResponse
        /// </returns>
        public async Task<UnAssociateVpdCidrBlockResponse> UnAssociateVpdCidrBlockAsync(UnAssociateVpdCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnAssociateVpdCidrBlockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the assigned secondary private IP address of Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassignLeniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnassignLeniPrivateIpAddressResponse
        /// </returns>
        public UnassignLeniPrivateIpAddressResponse UnassignLeniPrivateIpAddressWithOptions(UnassignLeniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassignLeniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassignLeniPrivateIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the assigned secondary private IP address of Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassignLeniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnassignLeniPrivateIpAddressResponse
        /// </returns>
        public async Task<UnassignLeniPrivateIpAddressResponse> UnassignLeniPrivateIpAddressWithOptionsAsync(UnassignLeniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassignLeniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassignLeniPrivateIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the assigned secondary private IP address of Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassignLeniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// UnassignLeniPrivateIpAddressResponse
        /// </returns>
        public UnassignLeniPrivateIpAddressResponse UnassignLeniPrivateIpAddress(UnassignLeniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassignLeniPrivateIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the assigned secondary private IP address of Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassignLeniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// UnassignLeniPrivateIpAddressResponse
        /// </returns>
        public async Task<UnassignLeniPrivateIpAddressResponse> UnassignLeniPrivateIpAddressAsync(UnassignLeniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassignLeniPrivateIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Lingjun Elastic Network Interface information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateElasticNetworkInterfaceResponse
        /// </returns>
        public UpdateElasticNetworkInterfaceResponse UpdateElasticNetworkInterfaceWithOptions(UpdateElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateElasticNetworkInterfaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Lingjun Elastic Network Interface information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateElasticNetworkInterfaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<UpdateElasticNetworkInterfaceResponse> UpdateElasticNetworkInterfaceWithOptionsAsync(UpdateElasticNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateElasticNetworkInterface",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateElasticNetworkInterfaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Lingjun Elastic Network Interface information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateElasticNetworkInterfaceResponse
        /// </returns>
        public UpdateElasticNetworkInterfaceResponse UpdateElasticNetworkInterface(UpdateElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateElasticNetworkInterfaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Lingjun Elastic Network Interface information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateElasticNetworkInterfaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateElasticNetworkInterfaceResponse
        /// </returns>
        public async Task<UpdateElasticNetworkInterfaceResponse> UpdateElasticNetworkInterfaceAsync(UpdateElasticNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateElasticNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updated Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateErResponse
        /// </returns>
        public UpdateErResponse UpdateErWithOptions(UpdateErRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErName))
            {
                body["ErName"] = request.ErName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateErResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updated Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateErResponse
        /// </returns>
        public async Task<UpdateErResponse> UpdateErWithOptionsAsync(UpdateErRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErName))
            {
                body["ErName"] = request.ErName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEr",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateErResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updated Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateErResponse
        /// </returns>
        public UpdateErResponse UpdateEr(UpdateErRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateErWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updated Lingjun HUB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateErResponse
        /// </returns>
        public async Task<UpdateErResponse> UpdateErAsync(UpdateErRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateErWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a network instance connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErAttachmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateErAttachmentResponse
        /// </returns>
        public UpdateErAttachmentResponse UpdateErAttachmentWithOptions(UpdateErAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentId))
            {
                body["ErAttachmentId"] = request.ErAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentName))
            {
                body["ErAttachmentName"] = request.ErAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateErAttachment",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateErAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a network instance connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErAttachmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateErAttachmentResponse
        /// </returns>
        public async Task<UpdateErAttachmentResponse> UpdateErAttachmentWithOptionsAsync(UpdateErAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentId))
            {
                body["ErAttachmentId"] = request.ErAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErAttachmentName))
            {
                body["ErAttachmentName"] = request.ErAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateErAttachment",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateErAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a network instance connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateErAttachmentResponse
        /// </returns>
        public UpdateErAttachmentResponse UpdateErAttachment(UpdateErAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateErAttachmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a network instance connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateErAttachmentResponse
        /// </returns>
        public async Task<UpdateErAttachmentResponse> UpdateErAttachmentAsync(UpdateErAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateErAttachmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update some information about the routing policy, including the description and name of the routing policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErRouteMapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateErRouteMapResponse
        /// </returns>
        public UpdateErRouteMapResponse UpdateErRouteMapWithOptions(UpdateErRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapId))
            {
                body["ErRouteMapId"] = request.ErRouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateErRouteMap",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateErRouteMapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update some information about the routing policy, including the description and name of the routing policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErRouteMapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateErRouteMapResponse
        /// </returns>
        public async Task<UpdateErRouteMapResponse> UpdateErRouteMapWithOptionsAsync(UpdateErRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErId))
            {
                body["ErId"] = request.ErId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErRouteMapId))
            {
                body["ErRouteMapId"] = request.ErRouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateErRouteMap",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateErRouteMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update some information about the routing policy, including the description and name of the routing policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErRouteMapRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateErRouteMapResponse
        /// </returns>
        public UpdateErRouteMapResponse UpdateErRouteMap(UpdateErRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateErRouteMapWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update some information about the routing policy, including the description and name of the routing policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateErRouteMapRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateErRouteMapResponse
        /// </returns>
        public async Task<UpdateErRouteMapResponse> UpdateErRouteMapAsync(UpdateErRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateErRouteMapWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updated the description of the secondary private network assigned by the Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLeniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLeniPrivateIpAddressResponse
        /// </returns>
        public UpdateLeniPrivateIpAddressResponse UpdateLeniPrivateIpAddressWithOptions(UpdateLeniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLeniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLeniPrivateIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updated the description of the secondary private network assigned by the Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLeniPrivateIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLeniPrivateIpAddressResponse
        /// </returns>
        public async Task<UpdateLeniPrivateIpAddressResponse> UpdateLeniPrivateIpAddressWithOptionsAsync(UpdateLeniPrivateIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticNetworkInterfaceId))
            {
                body["ElasticNetworkInterfaceId"] = request.ElasticNetworkInterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpName))
            {
                body["IpName"] = request.IpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLeniPrivateIpAddress",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLeniPrivateIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updated the description of the secondary private network assigned by the Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLeniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLeniPrivateIpAddressResponse
        /// </returns>
        public UpdateLeniPrivateIpAddressResponse UpdateLeniPrivateIpAddress(UpdateLeniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLeniPrivateIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updated the description of the secondary private network assigned by the Lingjun Elastic Network Interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLeniPrivateIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLeniPrivateIpAddressResponse
        /// </returns>
        public async Task<UpdateLeniPrivateIpAddressResponse> UpdateLeniPrivateIpAddressAsync(UpdateLeniPrivateIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLeniPrivateIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates some information about a specified subnet instance, including the name of the subnet instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubnetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubnetResponse
        /// </returns>
        public UpdateSubnetResponse UpdateSubnetWithOptions(UpdateSubnetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetName))
            {
                body["SubnetName"] = request.SubnetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubnet",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubnetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates some information about a specified subnet instance, including the name of the subnet instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubnetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubnetResponse
        /// </returns>
        public async Task<UpdateSubnetResponse> UpdateSubnetWithOptionsAsync(UpdateSubnetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetId))
            {
                body["SubnetId"] = request.SubnetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubnetName))
            {
                body["SubnetName"] = request.SubnetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubnet",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubnetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates some information about a specified subnet instance, including the name of the subnet instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubnetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubnetResponse
        /// </returns>
        public UpdateSubnetResponse UpdateSubnet(UpdateSubnetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubnetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates some information about a specified subnet instance, including the name of the subnet instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubnetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubnetResponse
        /// </returns>
        public async Task<UpdateSubnetResponse> UpdateSubnetAsync(UpdateSubnetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubnetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a Lingjun connection instance, including the peak bandwidth and name of the Lingjun connection instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVccResponse
        /// </returns>
        public UpdateVccResponse UpdateVccWithOptions(UpdateVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccName))
            {
                body["VccName"] = request.VccName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVccResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a Lingjun connection instance, including the peak bandwidth and name of the Lingjun connection instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVccRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVccResponse
        /// </returns>
        public async Task<UpdateVccResponse> UpdateVccWithOptionsAsync(UpdateVccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccId))
            {
                body["VccId"] = request.VccId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VccName))
            {
                body["VccName"] = request.VccName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVcc",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVccResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a Lingjun connection instance, including the peak bandwidth and name of the Lingjun connection instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVccRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVccResponse
        /// </returns>
        public UpdateVccResponse UpdateVcc(UpdateVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVccWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a Lingjun connection instance, including the peak bandwidth and name of the Lingjun connection instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVccRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVccResponse
        /// </returns>
        public async Task<UpdateVccResponse> UpdateVccAsync(UpdateVccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVccWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about the Lingjun CIDR block, including the name of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVpdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpdResponse
        /// </returns>
        public UpdateVpdResponse UpdateVpdWithOptions(UpdateVpdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdName))
            {
                body["VpdName"] = request.VpdName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about the Lingjun CIDR block, including the name of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVpdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpdResponse
        /// </returns>
        public async Task<UpdateVpdResponse> UpdateVpdWithOptionsAsync(UpdateVpdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdId))
            {
                body["VpdId"] = request.VpdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpdName))
            {
                body["VpdName"] = request.VpdName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpd",
                Version = "2022-05-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about the Lingjun CIDR block, including the name of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVpdRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpdResponse
        /// </returns>
        public UpdateVpdResponse UpdateVpd(UpdateVpdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVpdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about the Lingjun CIDR block, including the name of the Lingjun CIDR block.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVpdRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpdResponse
        /// </returns>
        public async Task<UpdateVpdResponse> UpdateVpdAsync(UpdateVpdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVpdWithOptionsAsync(request, runtime);
        }

    }
}
