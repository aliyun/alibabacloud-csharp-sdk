// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Hologram20220601.Models;

namespace AlibabaCloud.SDK.Hologram20220601
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("hologram", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Updates a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["newResourceGroupId"] = request.NewResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tag/changeResourceGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["newResourceGroupId"] = request.NewResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tag/changeResourceGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a resource group.</para>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a resource group.</para>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHoloWarehouseResponse
        /// </returns>
        public CreateHoloWarehouseResponse CreateHoloWarehouseWithOptions(string instanceId, CreateHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/createHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHoloWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHoloWarehouseResponse
        /// </returns>
        public async Task<CreateHoloWarehouseResponse> CreateHoloWarehouseWithOptionsAsync(string instanceId, CreateHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/createHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHoloWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHoloWarehouseResponse
        /// </returns>
        public CreateHoloWarehouseResponse CreateHoloWarehouse(string instanceId, CreateHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateHoloWarehouseWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHoloWarehouseResponse
        /// </returns>
        public async Task<CreateHoloWarehouseResponse> CreateHoloWarehouseAsync(string instanceId, CreateHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateHoloWarehouseWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the billing details of Hologres, see <a href="https://www.alibabacloud.com/help/en/hologres/developer-reference/api-hologram-2022-06-01-createinstance">Pricing</a>.</description></item>
        /// <item><description>When you purchase a Hologres instance, you must specify the region and zone in which the Hologres instance resides. A region may correspond to multiple zones. Example:<!---->
        /// cn-hangzhou: cn-hangzhou-h, cn-hangzhou-j
        ///    cn-shanghai: cn-shanghai-e, cn-shanghai-f
        ///    cn-beijing: cn-beijing-i, cn-beijing-g
        ///    cn-zhangjiakou: cn-zhangjiakou-b
        ///    cn-shenzhen: cn-shenzhen-e
        ///    cn-hongkong: cn-hongkong-b
        ///    cn-shanghai-finance-1: cn-shanghai-finance-1z
        ///    ap-northeast-1: ap-northeast-1a
        ///    ap-southeast-1: ap-southeast-1c
        ///    ap-southeast-3: ap-southeast-3b
        ///    ap-southeast-5: ap-southeast-5b
        ///    ap-south-1: ap-south-1b
        ///    eu-central-1: eu-central-1a
        ///    us-east-1: us-east-1a
        ///    us-west-1: us-west-1b</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["autoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["autoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                body["coldStorageSize"] = request.ColdStorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableServerlessComputing))
            {
                body["enableServerlessComputing"] = request.EnableServerlessComputing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayCount))
            {
                body["gatewayCount"] = request.GatewayCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialDatabases))
            {
                body["initialDatabases"] = request.InitialDatabases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaderInstanceId))
            {
                body["leaderInstanceId"] = request.LeaderInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["pricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSize))
            {
                body["storageSize"] = request.StorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["vSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["zoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the billing details of Hologres, see <a href="https://www.alibabacloud.com/help/en/hologres/developer-reference/api-hologram-2022-06-01-createinstance">Pricing</a>.</description></item>
        /// <item><description>When you purchase a Hologres instance, you must specify the region and zone in which the Hologres instance resides. A region may correspond to multiple zones. Example:<!---->
        /// cn-hangzhou: cn-hangzhou-h, cn-hangzhou-j
        ///    cn-shanghai: cn-shanghai-e, cn-shanghai-f
        ///    cn-beijing: cn-beijing-i, cn-beijing-g
        ///    cn-zhangjiakou: cn-zhangjiakou-b
        ///    cn-shenzhen: cn-shenzhen-e
        ///    cn-hongkong: cn-hongkong-b
        ///    cn-shanghai-finance-1: cn-shanghai-finance-1z
        ///    ap-northeast-1: ap-northeast-1a
        ///    ap-southeast-1: ap-southeast-1c
        ///    ap-southeast-3: ap-southeast-3b
        ///    ap-southeast-5: ap-southeast-5b
        ///    ap-south-1: ap-south-1b
        ///    eu-central-1: eu-central-1a
        ///    us-east-1: us-east-1a
        ///    us-west-1: us-west-1b</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["autoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["autoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                body["coldStorageSize"] = request.ColdStorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableServerlessComputing))
            {
                body["enableServerlessComputing"] = request.EnableServerlessComputing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayCount))
            {
                body["gatewayCount"] = request.GatewayCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialDatabases))
            {
                body["initialDatabases"] = request.InitialDatabases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaderInstanceId))
            {
                body["leaderInstanceId"] = request.LeaderInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["pricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSize))
            {
                body["storageSize"] = request.StorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["vSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["zoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the billing details of Hologres, see <a href="https://www.alibabacloud.com/help/en/hologres/developer-reference/api-hologram-2022-06-01-createinstance">Pricing</a>.</description></item>
        /// <item><description>When you purchase a Hologres instance, you must specify the region and zone in which the Hologres instance resides. A region may correspond to multiple zones. Example:<!---->
        /// cn-hangzhou: cn-hangzhou-h, cn-hangzhou-j
        ///    cn-shanghai: cn-shanghai-e, cn-shanghai-f
        ///    cn-beijing: cn-beijing-i, cn-beijing-g
        ///    cn-zhangjiakou: cn-zhangjiakou-b
        ///    cn-shenzhen: cn-shenzhen-e
        ///    cn-hongkong: cn-hongkong-b
        ///    cn-shanghai-finance-1: cn-shanghai-finance-1z
        ///    ap-northeast-1: ap-northeast-1a
        ///    ap-southeast-1: ap-southeast-1c
        ///    ap-southeast-3: ap-southeast-3b
        ///    ap-southeast-5: ap-southeast-5b
        ///    ap-south-1: ap-south-1b
        ///    eu-central-1: eu-central-1a
        ///    us-east-1: us-east-1a
        ///    us-west-1: us-west-1b</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the billing details of Hologres, see <a href="https://www.alibabacloud.com/help/en/hologres/developer-reference/api-hologram-2022-06-01-createinstance">Pricing</a>.</description></item>
        /// <item><description>When you purchase a Hologres instance, you must specify the region and zone in which the Hologres instance resides. A region may correspond to multiple zones. Example:<!---->
        /// cn-hangzhou: cn-hangzhou-h, cn-hangzhou-j
        ///    cn-shanghai: cn-shanghai-e, cn-shanghai-f
        ///    cn-beijing: cn-beijing-i, cn-beijing-g
        ///    cn-zhangjiakou: cn-zhangjiakou-b
        ///    cn-shenzhen: cn-shenzhen-e
        ///    cn-hongkong: cn-hongkong-b
        ///    cn-shanghai-finance-1: cn-shanghai-finance-1z
        ///    ap-northeast-1: ap-northeast-1a
        ///    ap-southeast-1: ap-southeast-1c
        ///    ap-southeast-3: ap-southeast-3b
        ///    ap-southeast-5: ap-southeast-5b
        ///    ap-south-1: ap-south-1b
        ///    eu-central-1: eu-central-1a
        ///    us-east-1: us-east-1a
        ///    us-west-1: us-west-1b</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHoloWarehouseResponse
        /// </returns>
        public DeleteHoloWarehouseResponse DeleteHoloWarehouseWithOptions(string instanceId, DeleteHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/deleteHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHoloWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHoloWarehouseResponse
        /// </returns>
        public async Task<DeleteHoloWarehouseResponse> DeleteHoloWarehouseWithOptionsAsync(string instanceId, DeleteHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/deleteHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHoloWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHoloWarehouseResponse
        /// </returns>
        public DeleteHoloWarehouseResponse DeleteHoloWarehouse(string instanceId, DeleteHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHoloWarehouseWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHoloWarehouseResponse
        /// </returns>
        public async Task<DeleteHoloWarehouseResponse> DeleteHoloWarehouseAsync(string instanceId, DeleteHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHoloWarehouseWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, read the documentation and make sure that you understand the prerequisites and impacts of this operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>After you delete a Hologres instance, data and objects in the instance cannot be restored. Proceed with caution. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/billing-overview#section-h6a-x58-jc0">Billing overview</a>.</description></item>
        /// <item><description>You can delete only pay-as-you-go instances.</description></item>
        /// <item><description>If you want to unsubscribe from a subscription instance, submit a ticket.<a href="https://help.aliyun.com/document_detail/150284.html#section-ogc-9vc-858"></a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstanceWithOptions(string instanceId, DeleteInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, read the documentation and make sure that you understand the prerequisites and impacts of this operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>After you delete a Hologres instance, data and objects in the instance cannot be restored. Proceed with caution. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/billing-overview#section-h6a-x58-jc0">Billing overview</a>.</description></item>
        /// <item><description>You can delete only pay-as-you-go instances.</description></item>
        /// <item><description>If you want to unsubscribe from a subscription instance, submit a ticket.<a href="https://help.aliyun.com/document_detail/150284.html#section-ogc-9vc-858"></a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(string instanceId, DeleteInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, read the documentation and make sure that you understand the prerequisites and impacts of this operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>After you delete a Hologres instance, data and objects in the instance cannot be restored. Proceed with caution. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/billing-overview#section-h6a-x58-jc0">Billing overview</a>.</description></item>
        /// <item><description>You can delete only pay-as-you-go instances.</description></item>
        /// <item><description>If you want to unsubscribe from a subscription instance, submit a ticket.<a href="https://help.aliyun.com/document_detail/150284.html#section-ogc-9vc-858"></a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstance(string instanceId, DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, read the documentation and make sure that you understand the prerequisites and impacts of this operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>After you delete a Hologres instance, data and objects in the instance cannot be restored. Proceed with caution. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/billing-overview#section-h6a-x58-jc0">Billing overview</a>.</description></item>
        /// <item><description>You can delete only pay-as-you-go instances.</description></item>
        /// <item><description>If you want to unsubscribe from a subscription instance, submit a ticket.<a href="https://help.aliyun.com/document_detail/150284.html#section-ogc-9vc-858"></a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(string instanceId, DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables data lake acceleration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableHiveAccessRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableHiveAccessResponse
        /// </returns>
        public DisableHiveAccessResponse DisableHiveAccessWithOptions(string instanceId, DisableHiveAccessRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableHiveAccess",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/disableHiveAccess",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableHiveAccessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables data lake acceleration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableHiveAccessRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableHiveAccessResponse
        /// </returns>
        public async Task<DisableHiveAccessResponse> DisableHiveAccessWithOptionsAsync(string instanceId, DisableHiveAccessRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableHiveAccess",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/disableHiveAccess",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableHiveAccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables data lake acceleration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableHiveAccessRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableHiveAccessResponse
        /// </returns>
        public DisableHiveAccessResponse DisableHiveAccess(string instanceId, DisableHiveAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableHiveAccessWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables data lake acceleration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableHiveAccessRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableHiveAccessResponse
        /// </returns>
        public async Task<DisableHiveAccessResponse> DisableHiveAccessAsync(string instanceId, DisableHiveAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableHiveAccessWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables data lake acceleration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableHiveAccessRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableHiveAccessResponse
        /// </returns>
        public EnableHiveAccessResponse EnableHiveAccessWithOptions(string instanceId, EnableHiveAccessRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableHiveAccess",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/enableHiveAccess",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHiveAccessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables data lake acceleration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableHiveAccessRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableHiveAccessResponse
        /// </returns>
        public async Task<EnableHiveAccessResponse> EnableHiveAccessWithOptionsAsync(string instanceId, EnableHiveAccessRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableHiveAccess",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/enableHiveAccess",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHiveAccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables data lake acceleration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableHiveAccessRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableHiveAccessResponse
        /// </returns>
        public EnableHiveAccessResponse EnableHiveAccess(string instanceId, EnableHiveAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableHiveAccessWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables data lake acceleration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableHiveAccessRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableHiveAccessResponse
        /// </returns>
        public async Task<EnableHiveAccessResponse> EnableHiveAccessAsync(string instanceId, EnableHiveAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableHiveAccessWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of a virtual warehouse instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWarehouseDetailResponse
        /// </returns>
        public GetWarehouseDetailResponse GetWarehouseDetailWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWarehouseDetail",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/getWarehouseDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWarehouseDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of a virtual warehouse instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWarehouseDetailResponse
        /// </returns>
        public async Task<GetWarehouseDetailResponse> GetWarehouseDetailWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWarehouseDetail",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/getWarehouseDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWarehouseDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of a virtual warehouse instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWarehouseDetailResponse
        /// </returns>
        public GetWarehouseDetailResponse GetWarehouseDetail(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWarehouseDetailWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of a virtual warehouse instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWarehouseDetailResponse
        /// </returns>
        public async Task<GetWarehouseDetailResponse> GetWarehouseDetailAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWarehouseDetailWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBackupDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBackupDataResponse
        /// </returns>
        public ListBackupDataResponse ListBackupDataWithOptions(ListBackupDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["backupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBackupData",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/backups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBackupDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBackupDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBackupDataResponse
        /// </returns>
        public async Task<ListBackupDataResponse> ListBackupDataWithOptionsAsync(ListBackupDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["backupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBackupData",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/backups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBackupDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBackupDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBackupDataResponse
        /// </returns>
        public ListBackupDataResponse ListBackupData(ListBackupDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBackupDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBackupDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBackupDataResponse
        /// </returns>
        public async Task<ListBackupDataResponse> ListBackupDataAsync(ListBackupDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBackupDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmsInstanceType))
            {
                body["cmsInstanceType"] = request.CmsInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmsInstanceType))
            {
                body["cmsInstanceType"] = request.CmsInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of virtual warehouse instances.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWarehousesResponse
        /// </returns>
        public ListWarehousesResponse ListWarehousesWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWarehouses",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/listWarehouses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWarehousesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of virtual warehouse instances.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWarehousesResponse
        /// </returns>
        public async Task<ListWarehousesResponse> ListWarehousesWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWarehouses",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/listWarehouses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWarehousesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of virtual warehouse instances.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListWarehousesResponse
        /// </returns>
        public ListWarehousesResponse ListWarehouses(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWarehousesWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of virtual warehouse instances.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListWarehousesResponse
        /// </returns>
        public async Task<ListWarehousesResponse> ListWarehousesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWarehousesWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers shard rebalancing for a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebalanceHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebalanceHoloWarehouseResponse
        /// </returns>
        public RebalanceHoloWarehouseResponse RebalanceHoloWarehouseWithOptions(string instanceId, RebalanceHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebalanceHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rebalanceHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebalanceHoloWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers shard rebalancing for a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebalanceHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebalanceHoloWarehouseResponse
        /// </returns>
        public async Task<RebalanceHoloWarehouseResponse> RebalanceHoloWarehouseWithOptionsAsync(string instanceId, RebalanceHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebalanceHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rebalanceHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebalanceHoloWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers shard rebalancing for a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebalanceHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// RebalanceHoloWarehouseResponse
        /// </returns>
        public RebalanceHoloWarehouseResponse RebalanceHoloWarehouse(string instanceId, RebalanceHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RebalanceHoloWarehouseWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers shard rebalancing for a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebalanceHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// RebalanceHoloWarehouseResponse
        /// </returns>
        public async Task<RebalanceHoloWarehouseResponse> RebalanceHoloWarehouseAsync(string instanceId, RebalanceHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RebalanceHoloWarehouseWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameHoloWarehouseResponse
        /// </returns>
        public RenameHoloWarehouseResponse RenameHoloWarehouseWithOptions(string instanceId, RenameHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewWarehouseName))
            {
                body["newWarehouseName"] = request.NewWarehouseName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/renameHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameHoloWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameHoloWarehouseResponse
        /// </returns>
        public async Task<RenameHoloWarehouseResponse> RenameHoloWarehouseWithOptionsAsync(string instanceId, RenameHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewWarehouseName))
            {
                body["newWarehouseName"] = request.NewWarehouseName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/renameHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameHoloWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameHoloWarehouseResponse
        /// </returns>
        public RenameHoloWarehouseResponse RenameHoloWarehouse(string instanceId, RenameHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenameHoloWarehouseWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenameHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameHoloWarehouseResponse
        /// </returns>
        public async Task<RenameHoloWarehouseResponse> RenameHoloWarehouseAsync(string instanceId, RenameHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenameHoloWarehouseWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually renews a Hologres instance. You can enable monthly auto-renewal when you renew a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about billing details of Hologres, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/billing-overview">Pricing</a>.</description></item>
        /// <item><description>For more information about how to renew a Hologres instance, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/manage-renewals?spm=a2c63.p38356.0.0.73f27c8d1Q0FUi">Manage renewals</a>.</description></item>
        /// <item><description>You can renew only subscription instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public RenewInstanceResponse RenewInstanceWithOptions(string instanceId, RenewInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["autoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/renew",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually renews a Hologres instance. You can enable monthly auto-renewal when you renew a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about billing details of Hologres, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/billing-overview">Pricing</a>.</description></item>
        /// <item><description>For more information about how to renew a Hologres instance, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/manage-renewals?spm=a2c63.p38356.0.0.73f27c8d1Q0FUi">Manage renewals</a>.</description></item>
        /// <item><description>You can renew only subscription instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(string instanceId, RenewInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["autoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/renew",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually renews a Hologres instance. You can enable monthly auto-renewal when you renew a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about billing details of Hologres, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/billing-overview">Pricing</a>.</description></item>
        /// <item><description>For more information about how to renew a Hologres instance, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/manage-renewals?spm=a2c63.p38356.0.0.73f27c8d1Q0FUi">Manage renewals</a>.</description></item>
        /// <item><description>You can renew only subscription instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public RenewInstanceResponse RenewInstance(string instanceId, RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenewInstanceWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually renews a Hologres instance. You can enable monthly auto-renewal when you renew a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about billing details of Hologres, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/billing-overview">Pricing</a>.</description></item>
        /// <item><description>For more information about how to renew a Hologres instance, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/manage-renewals?spm=a2c63.p38356.0.0.73f27c8d1Q0FUi">Manage renewals</a>.</description></item>
        /// <item><description>You can renew only subscription instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public async Task<RenewInstanceResponse> RenewInstanceAsync(string instanceId, RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenewInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartHoloWarehouseResponse
        /// </returns>
        public RestartHoloWarehouseResponse RestartHoloWarehouseWithOptions(string instanceId, RestartHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/restartHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartHoloWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartHoloWarehouseResponse
        /// </returns>
        public async Task<RestartHoloWarehouseResponse> RestartHoloWarehouseWithOptionsAsync(string instanceId, RestartHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/restartHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartHoloWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartHoloWarehouseResponse
        /// </returns>
        public RestartHoloWarehouseResponse RestartHoloWarehouse(string instanceId, RestartHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartHoloWarehouseWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartHoloWarehouseResponse
        /// </returns>
        public async Task<RestartHoloWarehouseResponse> RestartHoloWarehouseAsync(string instanceId, RestartHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartHoloWarehouseWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public RestartInstanceResponse RestartInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public RestartInstanceResponse RestartInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public async Task<RestartInstanceResponse> RestartInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeHoloWarehouseResponse
        /// </returns>
        public ResumeHoloWarehouseResponse ResumeHoloWarehouseWithOptions(string instanceId, ResumeHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/resumeHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeHoloWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeHoloWarehouseResponse
        /// </returns>
        public async Task<ResumeHoloWarehouseResponse> ResumeHoloWarehouseWithOptionsAsync(string instanceId, ResumeHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/resumeHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeHoloWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeHoloWarehouseResponse
        /// </returns>
        public ResumeHoloWarehouseResponse ResumeHoloWarehouse(string instanceId, ResumeHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeHoloWarehouseWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeHoloWarehouseResponse
        /// </returns>
        public async Task<ResumeHoloWarehouseResponse> ResumeHoloWarehouseAsync(string instanceId, ResumeHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeHoloWarehouseWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a suspended instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeInstanceResponse
        /// </returns>
        public ResumeInstanceResponse ResumeInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a suspended instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeInstanceResponse
        /// </returns>
        public async Task<ResumeInstanceResponse> ResumeInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a suspended instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ResumeInstanceResponse
        /// </returns>
        public ResumeInstanceResponse ResumeInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a suspended instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ResumeInstanceResponse
        /// </returns>
        public async Task<ResumeInstanceResponse> ResumeInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales in or out a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScaleHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScaleHoloWarehouseResponse
        /// </returns>
        public ScaleHoloWarehouseResponse ScaleHoloWarehouseWithOptions(string instanceId, ScaleHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scaleHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleHoloWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales in or out a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScaleHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScaleHoloWarehouseResponse
        /// </returns>
        public async Task<ScaleHoloWarehouseResponse> ScaleHoloWarehouseWithOptionsAsync(string instanceId, ScaleHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scaleHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleHoloWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales in or out a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScaleHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// ScaleHoloWarehouseResponse
        /// </returns>
        public ScaleHoloWarehouseResponse ScaleHoloWarehouse(string instanceId, ScaleHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleHoloWarehouseWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales in or out a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScaleHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// ScaleHoloWarehouseResponse
        /// </returns>
        public async Task<ScaleHoloWarehouseResponse> ScaleHoloWarehouseAsync(string instanceId, ScaleHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleHoloWarehouseWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the specifications and storage space of a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the billing of Hologres, see <a href="https://www.alibabacloud.com/help/zh/hologres/product-overview/billing-overview">Billing overview</a>.</description></item>
        /// <item><description>During the change of computing resource specifications of a Hologres instance, the instance is unavailable. During the change of storage resource specifications of a Hologres instance, the instance can work normally. Do not frequently change instance specifications. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/upgrade-or-downgrade-instance-specifications">Upgrade or downgrade instance specifications</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ScaleInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScaleInstanceResponse
        /// </returns>
        public ScaleInstanceResponse ScaleInstanceWithOptions(string instanceId, ScaleInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                body["coldStorageSize"] = request.ColdStorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableServerlessComputing))
            {
                body["enableServerlessComputing"] = request.EnableServerlessComputing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayCount))
            {
                body["gatewayCount"] = request.GatewayCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                body["scaleType"] = request.ScaleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSize))
            {
                body["storageSize"] = request.StorageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scale",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the specifications and storage space of a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the billing of Hologres, see <a href="https://www.alibabacloud.com/help/zh/hologres/product-overview/billing-overview">Billing overview</a>.</description></item>
        /// <item><description>During the change of computing resource specifications of a Hologres instance, the instance is unavailable. During the change of storage resource specifications of a Hologres instance, the instance can work normally. Do not frequently change instance specifications. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/upgrade-or-downgrade-instance-specifications">Upgrade or downgrade instance specifications</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ScaleInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScaleInstanceResponse
        /// </returns>
        public async Task<ScaleInstanceResponse> ScaleInstanceWithOptionsAsync(string instanceId, ScaleInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                body["coldStorageSize"] = request.ColdStorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableServerlessComputing))
            {
                body["enableServerlessComputing"] = request.EnableServerlessComputing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayCount))
            {
                body["gatewayCount"] = request.GatewayCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                body["scaleType"] = request.ScaleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSize))
            {
                body["storageSize"] = request.StorageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scale",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the specifications and storage space of a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the billing of Hologres, see <a href="https://www.alibabacloud.com/help/zh/hologres/product-overview/billing-overview">Billing overview</a>.</description></item>
        /// <item><description>During the change of computing resource specifications of a Hologres instance, the instance is unavailable. During the change of storage resource specifications of a Hologres instance, the instance can work normally. Do not frequently change instance specifications. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/upgrade-or-downgrade-instance-specifications">Upgrade or downgrade instance specifications</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ScaleInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ScaleInstanceResponse
        /// </returns>
        public ScaleInstanceResponse ScaleInstance(string instanceId, ScaleInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleInstanceWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the specifications and storage space of a Hologres instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Hologres because this operation is charged.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the billing of Hologres, see <a href="https://www.alibabacloud.com/help/zh/hologres/product-overview/billing-overview">Billing overview</a>.</description></item>
        /// <item><description>During the change of computing resource specifications of a Hologres instance, the instance is unavailable. During the change of storage resource specifications of a Hologres instance, the instance can work normally. Do not frequently change instance specifications. For more information, see <a href="https://www.alibabacloud.com/help/en/hologres/product-overview/upgrade-or-downgrade-instance-specifications">Upgrade or downgrade instance specifications</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ScaleInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ScaleInstanceResponse
        /// </returns>
        public async Task<ScaleInstanceResponse> ScaleInstanceAsync(string instanceId, ScaleInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public StopInstanceResponse StopInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstance",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public StopInstanceResponse StopInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public async Task<StopInstanceResponse> StopInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Suspends a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendHoloWarehouseResponse
        /// </returns>
        public SuspendHoloWarehouseResponse SuspendHoloWarehouseWithOptions(string instanceId, SuspendHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/suspendHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendHoloWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Suspends a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendHoloWarehouseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendHoloWarehouseResponse
        /// </returns>
        public async Task<SuspendHoloWarehouseResponse> SuspendHoloWarehouseWithOptionsAsync(string instanceId, SuspendHoloWarehouseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendHoloWarehouse",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/suspendHoloWarehouse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendHoloWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Suspends a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendHoloWarehouseResponse
        /// </returns>
        public SuspendHoloWarehouseResponse SuspendHoloWarehouse(string instanceId, SuspendHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SuspendHoloWarehouseWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Suspends a virtual warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendHoloWarehouseRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendHoloWarehouseResponse
        /// </returns>
        public async Task<SuspendHoloWarehouseResponse> SuspendHoloWarehouseAsync(string instanceId, SuspendHoloWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SuspendHoloWarehouseWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
        public UpdateInstanceNameResponse UpdateInstanceNameWithOptions(string instanceId, UpdateInstanceNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceName",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/instanceName",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameWithOptionsAsync(string instanceId, UpdateInstanceNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceName",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/instanceName",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
        public UpdateInstanceNameResponse UpdateInstanceName(string instanceId, UpdateInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceNameWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(string instanceId, UpdateInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceNameWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network configuration of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNetworkTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNetworkTypeResponse
        /// </returns>
        public UpdateInstanceNetworkTypeResponse UpdateInstanceNetworkTypeWithOptions(string instanceId, UpdateInstanceNetworkTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnyTunnelToSingleTunnel))
            {
                body["anyTunnelToSingleTunnel"] = request.AnyTunnelToSingleTunnel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkTypes))
            {
                body["networkTypes"] = request.NetworkTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["vSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcOwnerId))
            {
                body["vpcOwnerId"] = request.VpcOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                body["vpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceNetworkType",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/network",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceNetworkTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network configuration of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNetworkTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNetworkTypeResponse
        /// </returns>
        public async Task<UpdateInstanceNetworkTypeResponse> UpdateInstanceNetworkTypeWithOptionsAsync(string instanceId, UpdateInstanceNetworkTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnyTunnelToSingleTunnel))
            {
                body["anyTunnelToSingleTunnel"] = request.AnyTunnelToSingleTunnel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkTypes))
            {
                body["networkTypes"] = request.NetworkTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["vSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcOwnerId))
            {
                body["vpcOwnerId"] = request.VpcOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                body["vpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceNetworkType",
                Version = "2022-06-01",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/network",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceNetworkTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network configuration of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNetworkTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNetworkTypeResponse
        /// </returns>
        public UpdateInstanceNetworkTypeResponse UpdateInstanceNetworkType(string instanceId, UpdateInstanceNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceNetworkTypeWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network configuration of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNetworkTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNetworkTypeResponse
        /// </returns>
        public async Task<UpdateInstanceNetworkTypeResponse> UpdateInstanceNetworkTypeAsync(string instanceId, UpdateInstanceNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceNetworkTypeWithOptionsAsync(instanceId, request, headers, runtime);
        }

    }
}
