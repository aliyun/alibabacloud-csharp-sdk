// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Starrocks20221019.Models;

namespace AlibabaCloud.SDK.Starrocks20221019
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("starrocks", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>新增备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddBackupPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBackupPolicyResponse
        /// </returns>
        public AddBackupPolicyResponse AddBackupPolicyWithOptions(AddBackupPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDays))
            {
                body["ExpireDays"] = request.ExpireDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hour))
            {
                body["Hour"] = request.Hour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minute))
            {
                body["Minute"] = request.Minute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceType))
            {
                body["RecurrenceType"] = request.RecurrenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceValues))
            {
                body["RecurrenceValues"] = request.RecurrenceValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutSeconds))
            {
                body["TimeoutSeconds"] = request.TimeoutSeconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBackupPolicy",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backupRestore/policy/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddBackupPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBackupPolicyResponse
        /// </returns>
        public async Task<AddBackupPolicyResponse> AddBackupPolicyWithOptionsAsync(AddBackupPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDays))
            {
                body["ExpireDays"] = request.ExpireDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hour))
            {
                body["Hour"] = request.Hour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minute))
            {
                body["Minute"] = request.Minute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceType))
            {
                body["RecurrenceType"] = request.RecurrenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceValues))
            {
                body["RecurrenceValues"] = request.RecurrenceValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutSeconds))
            {
                body["TimeoutSeconds"] = request.TimeoutSeconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBackupPolicy",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backupRestore/policy/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBackupPolicyResponse
        /// </returns>
        public AddBackupPolicyResponse AddBackupPolicy(AddBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddBackupPolicyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBackupPolicyResponse
        /// </returns>
        public async Task<AddBackupPolicyResponse> AddBackupPolicyAsync(AddBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddBackupPolicyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddGatewayResponse
        /// </returns>
        public AddGatewayResponse AddGatewayWithOptions(AddGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeNodeNumber))
            {
                query["FeNodeNumber"] = request.FeNodeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                query["GatewayName"] = request.GatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGateway",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddGatewayResponse
        /// </returns>
        public async Task<AddGatewayResponse> AddGatewayWithOptionsAsync(AddGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeNodeNumber))
            {
                query["FeNodeNumber"] = request.FeNodeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                query["GatewayName"] = request.GatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGateway",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// AddGatewayResponse
        /// </returns>
        public AddGatewayResponse AddGateway(AddGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddGatewayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// AddGatewayResponse
        /// </returns>
        public async Task<AddGatewayResponse> AddGatewayAsync(AddGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddGatewayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to modify the resource group of a Serverless StarRocks instance.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceGroup/change",
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
        /// <para>This interface is used to modify the resource group of a Serverless StarRocks instance.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceGroup/change",
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
        /// <para>This interface is used to modify the resource group of a Serverless StarRocks instance.</para>
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
        /// <para>This interface is used to modify the resource group of a Serverless StarRocks instance.</para>
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
        /// <para>校验ABM的资源库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckInventoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckInventoryResponse
        /// </returns>
        public CheckInventoryResponse CheckInventoryWithOptions(CheckInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterInfo))
            {
                query["ClusterInfo"] = request.ClusterInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInventory",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/check/inventory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInventoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验ABM的资源库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckInventoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckInventoryResponse
        /// </returns>
        public async Task<CheckInventoryResponse> CheckInventoryWithOptionsAsync(CheckInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterInfo))
            {
                query["ClusterInfo"] = request.ClusterInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInventory",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/check/inventory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInventoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验ABM的资源库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckInventoryResponse
        /// </returns>
        public CheckInventoryResponse CheckInventory(CheckInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInventoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验ABM的资源库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckInventoryResponse
        /// </returns>
        public async Task<CheckInventoryResponse> CheckInventoryAsync(CheckInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInventoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Agent资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResourceResponse
        /// </returns>
        public CreateAgentResourceResponse CreateAgentResourceWithOptions(CreateAgentResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cu))
            {
                query["Cu"] = request.Cu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentResource",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/lifecycle/createAgentNodeGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Agent资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResourceResponse
        /// </returns>
        public async Task<CreateAgentResourceResponse> CreateAgentResourceWithOptionsAsync(CreateAgentResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cu))
            {
                query["Cu"] = request.Cu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentResource",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/lifecycle/createAgentNodeGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Agent资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResourceResponse
        /// </returns>
        public CreateAgentResourceResponse CreateAgentResource(CreateAgentResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAgentResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Agent资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResourceResponse
        /// </returns>
        public async Task<CreateAgentResourceResponse> CreateAgentResourceAsync(CreateAgentResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAgentResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建StarRocks集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceV1Request
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceV1Response
        /// </returns>
        public CreateInstanceV1Response CreateInstanceV1WithOptions(CreateInstanceV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminPassword))
            {
                body["AdminPassword"] = request.AdminPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentNodeGroup))
            {
                body["AgentNodeGroup"] = request.AgentNodeGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendNodeGroups))
            {
                body["BackendNodeGroups"] = request.BackendNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlfCatalogName))
            {
                body["DlfCatalogName"] = request.DlfCatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlfCatalogType))
            {
                body["DlfCatalogType"] = request.DlfCatalogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encrypted))
            {
                body["Encrypted"] = request.Encrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendNodeGroups))
            {
                body["FrontendNodeGroups"] = request.FrontendNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                body["KmsKeyId"] = request.KmsKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkedRamUserName))
            {
                body["LinkedRamUserName"] = request.LinkedRamUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObserverNodeGroups))
            {
                body["ObserverNodeGroups"] = request.ObserverNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAccessingRoleName))
            {
                body["OssAccessingRoleName"] = request.OssAccessingRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                body["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                body["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                body["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUserId))
            {
                body["RamUserId"] = request.RamUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                body["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
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
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceV1",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/cluster/createV1",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceV1Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建StarRocks集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceV1Request
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceV1Response
        /// </returns>
        public async Task<CreateInstanceV1Response> CreateInstanceV1WithOptionsAsync(CreateInstanceV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminPassword))
            {
                body["AdminPassword"] = request.AdminPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentNodeGroup))
            {
                body["AgentNodeGroup"] = request.AgentNodeGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendNodeGroups))
            {
                body["BackendNodeGroups"] = request.BackendNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlfCatalogName))
            {
                body["DlfCatalogName"] = request.DlfCatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlfCatalogType))
            {
                body["DlfCatalogType"] = request.DlfCatalogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encrypted))
            {
                body["Encrypted"] = request.Encrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendNodeGroups))
            {
                body["FrontendNodeGroups"] = request.FrontendNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                body["KmsKeyId"] = request.KmsKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkedRamUserName))
            {
                body["LinkedRamUserName"] = request.LinkedRamUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObserverNodeGroups))
            {
                body["ObserverNodeGroups"] = request.ObserverNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAccessingRoleName))
            {
                body["OssAccessingRoleName"] = request.OssAccessingRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                body["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                body["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                body["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUserId))
            {
                body["RamUserId"] = request.RamUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                body["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
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
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceV1",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/cluster/createV1",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceV1Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建StarRocks集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceV1Request
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceV1Response
        /// </returns>
        public CreateInstanceV1Response CreateInstanceV1(CreateInstanceV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceV1WithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建StarRocks集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceV1Request
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceV1Response
        /// </returns>
        public async Task<CreateInstanceV1Response> CreateInstanceV1Async(CreateInstanceV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceV1WithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一条弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScalingRuleResponse
        /// </returns>
        public CreateScalingRuleResponse CreateScalingRuleWithOptions(CreateScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingRule",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/scalingRule/createScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一条弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScalingRuleResponse
        /// </returns>
        public async Task<CreateScalingRuleResponse> CreateScalingRuleWithOptionsAsync(CreateScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingRule",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/scalingRule/createScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一条弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScalingRuleResponse
        /// </returns>
        public CreateScalingRuleResponse CreateScalingRule(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateScalingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一条弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScalingRuleResponse
        /// </returns>
        public async Task<CreateScalingRuleResponse> CreateScalingRuleAsync(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to create the AliyunServiceRoleForEMRStarRocks role for users.</para>
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
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRole",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/user/create_default_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to create the AliyunServiceRoleForEMRStarRocks role for users.</para>
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
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRole",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/user/create_default_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to create the AliyunServiceRoleForEMRStarRocks role for users.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceLinkedRoleWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to create the AliyunServiceRoleForEMRStarRocks role for users.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceLinkedRoleWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据备份</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupResponse
        /// </returns>
        public DeleteBackupResponse DeleteBackupWithOptions(DeleteBackupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTaskId))
            {
                query["BackupTaskId"] = request.BackupTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
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
                Action = "DeleteBackup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backup/manage/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据备份</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupResponse
        /// </returns>
        public async Task<DeleteBackupResponse> DeleteBackupWithOptionsAsync(DeleteBackupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTaskId))
            {
                query["BackupTaskId"] = request.BackupTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
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
                Action = "DeleteBackup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backup/manage/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据备份</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupResponse
        /// </returns>
        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBackupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据备份</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupResponse
        /// </returns>
        public async Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBackupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupPolicyResponse
        /// </returns>
        public DeleteBackupPolicyResponse DeleteBackupPolicyWithOptions(DeleteBackupPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupPolicy",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backupRestore/policy/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupPolicyResponse
        /// </returns>
        public async Task<DeleteBackupPolicyResponse> DeleteBackupPolicyWithOptionsAsync(DeleteBackupPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupPolicy",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backupRestore/policy/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupPolicyResponse
        /// </returns>
        public DeleteBackupPolicyResponse DeleteBackupPolicy(DeleteBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBackupPolicyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupPolicyResponse
        /// </returns>
        public async Task<DeleteBackupPolicyResponse> DeleteBackupPolicyAsync(DeleteBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBackupPolicyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public DeleteGatewayResponse DeleteGatewayWithOptions(DeleteGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public async Task<DeleteGatewayResponse> DeleteGatewayWithOptionsAsync(DeleteGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public async Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除白名单分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInnerIpWhitelistGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInnerIpWhitelistGroupResponse
        /// </returns>
        public DeleteInnerIpWhitelistGroupResponse DeleteInnerIpWhitelistGroupWithOptions(DeleteInnerIpWhitelistGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerIpWhitelistGroupId))
            {
                body["InnerIpWhitelistGroupId"] = request.InnerIpWhitelistGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInnerIpWhitelistGroup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/securityGroup/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInnerIpWhitelistGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除白名单分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInnerIpWhitelistGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInnerIpWhitelistGroupResponse
        /// </returns>
        public async Task<DeleteInnerIpWhitelistGroupResponse> DeleteInnerIpWhitelistGroupWithOptionsAsync(DeleteInnerIpWhitelistGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerIpWhitelistGroupId))
            {
                body["InnerIpWhitelistGroupId"] = request.InnerIpWhitelistGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInnerIpWhitelistGroup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/securityGroup/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInnerIpWhitelistGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除白名单分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInnerIpWhitelistGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInnerIpWhitelistGroupResponse
        /// </returns>
        public DeleteInnerIpWhitelistGroupResponse DeleteInnerIpWhitelistGroup(DeleteInnerIpWhitelistGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInnerIpWhitelistGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除白名单分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInnerIpWhitelistGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInnerIpWhitelistGroupResponse
        /// </returns>
        public async Task<DeleteInnerIpWhitelistGroupResponse> DeleteInnerIpWhitelistGroupAsync(DeleteInnerIpWhitelistGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInnerIpWhitelistGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一条弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScalingRuleResponse
        /// </returns>
        public DeleteScalingRuleResponse DeleteScalingRuleWithOptions(DeleteScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingRule",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/scalingRule/deleteScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一条弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScalingRuleResponse
        /// </returns>
        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleWithOptionsAsync(DeleteScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingRule",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/scalingRule/deleteScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一条弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScalingRuleResponse
        /// </returns>
        public DeleteScalingRuleResponse DeleteScalingRule(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteScalingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一条弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScalingRuleResponse
        /// </returns>
        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleAsync(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeAvailableZonesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableZonesResponse
        /// </returns>
        public DescribeAvailableZonesResponse DescribeAvailableZonesWithOptions(DescribeAvailableZonesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeAvailableZones",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/zone/describeZones",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeAvailableZonesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableZonesResponse
        /// </returns>
        public async Task<DescribeAvailableZonesResponse> DescribeAvailableZonesWithOptionsAsync(DescribeAvailableZonesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeAvailableZones",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/zone/describeZones",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeAvailableZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableZonesResponse
        /// </returns>
        public DescribeAvailableZonesResponse DescribeAvailableZones(DescribeAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAvailableZonesWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeAvailableZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableZonesResponse
        /// </returns>
        public async Task<DescribeAvailableZonesResponse> DescribeAvailableZonesAsync(DescribeAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAvailableZonesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPoliciesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPoliciesResponse
        /// </returns>
        public DescribeBackupPoliciesResponse DescribeBackupPoliciesWithOptions(DescribeBackupPoliciesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
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
                Action = "DescribeBackupPolicies",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backupRestore/policy/describe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPoliciesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPoliciesResponse
        /// </returns>
        public async Task<DescribeBackupPoliciesResponse> DescribeBackupPoliciesWithOptionsAsync(DescribeBackupPoliciesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
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
                Action = "DescribeBackupPolicies",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backupRestore/policy/describe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPoliciesResponse
        /// </returns>
        public DescribeBackupPoliciesResponse DescribeBackupPolicies(DescribeBackupPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBackupPoliciesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPoliciesResponse
        /// </returns>
        public async Task<DescribeBackupPoliciesResponse> DescribeBackupPoliciesAsync(DescribeBackupPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBackupPoliciesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupsResponse
        /// </returns>
        public DescribeBackupsResponse DescribeBackupsWithOptions(DescribeBackupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTaskId))
            {
                query["BackupTaskId"] = request.BackupTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                query["Statuses"] = request.Statuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePeriodEndTime))
            {
                query["TimePeriodEndTime"] = request.TimePeriodEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePeriodStartTime))
            {
                query["TimePeriodStartTime"] = request.TimePeriodStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackups",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backup/manage/describe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupsResponse
        /// </returns>
        public async Task<DescribeBackupsResponse> DescribeBackupsWithOptionsAsync(DescribeBackupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTaskId))
            {
                query["BackupTaskId"] = request.BackupTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                query["Statuses"] = request.Statuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePeriodEndTime))
            {
                query["TimePeriodEndTime"] = request.TimePeriodEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePeriodStartTime))
            {
                query["TimePeriodStartTime"] = request.TimePeriodStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackups",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backup/manage/describe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupsResponse
        /// </returns>
        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBackupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取备份详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupsResponse
        /// </returns>
        public async Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBackupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例配置历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigHistoryResponse
        /// </returns>
        public DescribeConfigHistoryResponse DescribeConfigHistoryWithOptions(DescribeConfigHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectStatuses))
            {
                query["EffectStatuses"] = request.EffectStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotal))
            {
                query["NeedTotal"] = request.NeedTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigHistory",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/describeConfigHistory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例配置历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigHistoryResponse
        /// </returns>
        public async Task<DescribeConfigHistoryResponse> DescribeConfigHistoryWithOptionsAsync(DescribeConfigHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectStatuses))
            {
                query["EffectStatuses"] = request.EffectStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotal))
            {
                query["NeedTotal"] = request.NeedTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigHistory",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/describeConfigHistory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例配置历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigHistoryResponse
        /// </returns>
        public DescribeConfigHistoryResponse DescribeConfigHistory(DescribeConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例配置历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigHistoryResponse
        /// </returns>
        public async Task<DescribeConfigHistoryResponse> DescribeConfigHistoryAsync(DescribeConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群事件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventNamesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventNamesResponse
        /// </returns>
        public DescribeEventNamesResponse DescribeEventNamesWithOptions(DescribeEventNamesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventNames",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/event/describeEventNames",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventNamesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群事件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventNamesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventNamesResponse
        /// </returns>
        public async Task<DescribeEventNamesResponse> DescribeEventNamesWithOptionsAsync(DescribeEventNamesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventNames",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/event/describeEventNames",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群事件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventNamesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventNamesResponse
        /// </returns>
        public DescribeEventNamesResponse DescribeEventNames(DescribeEventNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEventNamesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群事件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventNamesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventNamesResponse
        /// </returns>
        public async Task<DescribeEventNamesResponse> DescribeEventNamesAsync(DescribeEventNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEventNamesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询白名单分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInnerIpWhitelistGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInnerIpWhitelistGroupsResponse
        /// </returns>
        public DescribeInnerIpWhitelistGroupsResponse DescribeInnerIpWhitelistGroupsWithOptions(DescribeInnerIpWhitelistGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInnerIpWhitelistGroups",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/securityGroup/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInnerIpWhitelistGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询白名单分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInnerIpWhitelistGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInnerIpWhitelistGroupsResponse
        /// </returns>
        public async Task<DescribeInnerIpWhitelistGroupsResponse> DescribeInnerIpWhitelistGroupsWithOptionsAsync(DescribeInnerIpWhitelistGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInnerIpWhitelistGroups",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/securityGroup/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInnerIpWhitelistGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询白名单分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInnerIpWhitelistGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInnerIpWhitelistGroupsResponse
        /// </returns>
        public DescribeInnerIpWhitelistGroupsResponse DescribeInnerIpWhitelistGroups(DescribeInnerIpWhitelistGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInnerIpWhitelistGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询白名单分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInnerIpWhitelistGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInnerIpWhitelistGroupsResponse
        /// </returns>
        public async Task<DescribeInnerIpWhitelistGroupsResponse> DescribeInnerIpWhitelistGroupsAsync(DescribeInnerIpWhitelistGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInnerIpWhitelistGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceConfigsResponse
        /// </returns>
        public DescribeInstanceConfigsResponse DescribeInstanceConfigsWithOptions(DescribeInstanceConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowModify))
            {
                query["AllowModify"] = request.AllowModify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotal))
            {
                query["NeedTotal"] = request.NeedTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceConfigs",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/describeInstanceConfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceConfigsResponse
        /// </returns>
        public async Task<DescribeInstanceConfigsResponse> DescribeInstanceConfigsWithOptionsAsync(DescribeInstanceConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowModify))
            {
                query["AllowModify"] = request.AllowModify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotal))
            {
                query["NeedTotal"] = request.NeedTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceConfigs",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/describeInstanceConfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceConfigsResponse
        /// </returns>
        public DescribeInstanceConfigsResponse DescribeInstanceConfigs(DescribeInstanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceConfigsResponse
        /// </returns>
        public async Task<DescribeInstanceConfigsResponse> DescribeInstanceConfigsAsync(DescribeInstanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例的健康诊断结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceDiagnosisResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDiagnosisResultResponse
        /// </returns>
        public DescribeInstanceDiagnosisResultResponse DescribeInstanceDiagnosisResultWithOptions(DescribeInstanceDiagnosisResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportDate))
            {
                query["ReportDate"] = request.ReportDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                query["Statuses"] = request.Statuses;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDiagnosisResult",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/diagnosis/describe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDiagnosisResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例的健康诊断结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceDiagnosisResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDiagnosisResultResponse
        /// </returns>
        public async Task<DescribeInstanceDiagnosisResultResponse> DescribeInstanceDiagnosisResultWithOptionsAsync(DescribeInstanceDiagnosisResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportDate))
            {
                query["ReportDate"] = request.ReportDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                query["Statuses"] = request.Statuses;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDiagnosisResult",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/diagnosis/describe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDiagnosisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例的健康诊断结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceDiagnosisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDiagnosisResultResponse
        /// </returns>
        public DescribeInstanceDiagnosisResultResponse DescribeInstanceDiagnosisResult(DescribeInstanceDiagnosisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceDiagnosisResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例的健康诊断结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceDiagnosisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDiagnosisResultResponse
        /// </returns>
        public async Task<DescribeInstanceDiagnosisResultResponse> DescribeInstanceDiagnosisResultAsync(DescribeInstanceDiagnosisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceDiagnosisResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 StarRocks 实例的 Meta Token。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceMetaTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceMetaTokenResponse
        /// </returns>
        public DescribeInstanceMetaTokenResponse DescribeInstanceMetaTokenWithOptions(DescribeInstanceMetaTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceMetaToken",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/migration/getMetaToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceMetaTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 StarRocks 实例的 Meta Token。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceMetaTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceMetaTokenResponse
        /// </returns>
        public async Task<DescribeInstanceMetaTokenResponse> DescribeInstanceMetaTokenWithOptionsAsync(DescribeInstanceMetaTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceMetaToken",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/migration/getMetaToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceMetaTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 StarRocks 实例的 Meta Token。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceMetaTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceMetaTokenResponse
        /// </returns>
        public DescribeInstanceMetaTokenResponse DescribeInstanceMetaToken(DescribeInstanceMetaTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceMetaTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 StarRocks 实例的 Meta Token。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceMetaTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceMetaTokenResponse
        /// </returns>
        public async Task<DescribeInstanceMetaTokenResponse> DescribeInstanceMetaTokenAsync(DescribeInstanceMetaTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceMetaTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is used to query Serverless StarRocks instances, supporting filtering based on instance name or tags and other information.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeInstancesShrinkRequest request = new DescribeInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/describeInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is used to query Serverless StarRocks instances, supporting filtering based on instance name or tags and other information.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeInstancesShrinkRequest request = new DescribeInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/describeInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is used to query Serverless StarRocks instances, supporting filtering based on instance name or tags and other information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is used to query Serverless StarRocks instances, supporting filtering based on instance name or tags and other information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节点组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeGroupsResponse
        /// </returns>
        public DescribeNodeGroupsResponse DescribeNodeGroupsWithOptions(DescribeNodeGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                body["componentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupIds))
            {
                body["nodeGroupIds"] = request.NodeGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupName))
            {
                body["nodeGroupName"] = request.NodeGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeGroups",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/nodegroup/describeNodeGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节点组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeGroupsResponse
        /// </returns>
        public async Task<DescribeNodeGroupsResponse> DescribeNodeGroupsWithOptionsAsync(DescribeNodeGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                body["componentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupIds))
            {
                body["nodeGroupIds"] = request.NodeGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupName))
            {
                body["nodeGroupName"] = request.NodeGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeGroups",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/nodegroup/describeNodeGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节点组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeGroupsResponse
        /// </returns>
        public DescribeNodeGroupsResponse DescribeNodeGroups(DescribeNodeGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNodeGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节点组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeGroupsResponse
        /// </returns>
        public async Task<DescribeNodeGroupsResponse> DescribeNodeGroupsAsync(DescribeNodeGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNodeGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/region/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/region/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(headers, runtime);
        }

        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>描述Starrocks的资源配置约束</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceConstraintsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceConstraintsResponse
        /// </returns>
        public DescribeResourceConstraintsResponse DescribeResourceConstraintsWithOptions(DescribeResourceConstraintsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Architecture))
            {
                query["Architecture"] = request.Architecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceConstraints",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/describeResourceConstraints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceConstraintsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>描述Starrocks的资源配置约束</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceConstraintsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceConstraintsResponse
        /// </returns>
        public async Task<DescribeResourceConstraintsResponse> DescribeResourceConstraintsWithOptionsAsync(DescribeResourceConstraintsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Architecture))
            {
                query["Architecture"] = request.Architecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceConstraints",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/describeResourceConstraints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceConstraintsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>描述Starrocks的资源配置约束</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceConstraintsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceConstraintsResponse
        /// </returns>
        public DescribeResourceConstraintsResponse DescribeResourceConstraints(DescribeResourceConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceConstraintsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>描述Starrocks的资源配置约束</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceConstraintsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceConstraintsResponse
        /// </returns>
        public async Task<DescribeResourceConstraintsResponse> DescribeResourceConstraintsAsync(DescribeResourceConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceConstraintsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 starrocks 实例的系统时区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemTimezoneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemTimezoneResponse
        /// </returns>
        public DescribeSystemTimezoneResponse DescribeSystemTimezoneWithOptions(DescribeSystemTimezoneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSystemTimezone",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/timezone/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemTimezoneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 starrocks 实例的系统时区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemTimezoneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemTimezoneResponse
        /// </returns>
        public async Task<DescribeSystemTimezoneResponse> DescribeSystemTimezoneWithOptionsAsync(DescribeSystemTimezoneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSystemTimezone",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/timezone/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemTimezoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 starrocks 实例的系统时区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemTimezoneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemTimezoneResponse
        /// </returns>
        public DescribeSystemTimezoneResponse DescribeSystemTimezone(DescribeSystemTimezoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSystemTimezoneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 starrocks 实例的系统时区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemTimezoneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemTimezoneResponse
        /// </returns>
        public async Task<DescribeSystemTimezoneResponse> DescribeSystemTimezoneAsync(DescribeSystemTimezoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSystemTimezoneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取时间触发规则信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTimeTriggerScalingRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTimeTriggerScalingRulesResponse
        /// </returns>
        public DescribeTimeTriggerScalingRulesResponse DescribeTimeTriggerScalingRulesWithOptions(DescribeTimeTriggerScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTimeTriggerScalingRules",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/scalingRule/describeTimeTriggerScalingRules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTimeTriggerScalingRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取时间触发规则信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTimeTriggerScalingRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTimeTriggerScalingRulesResponse
        /// </returns>
        public async Task<DescribeTimeTriggerScalingRulesResponse> DescribeTimeTriggerScalingRulesWithOptionsAsync(DescribeTimeTriggerScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTimeTriggerScalingRules",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/scalingRule/describeTimeTriggerScalingRules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTimeTriggerScalingRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取时间触发规则信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTimeTriggerScalingRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTimeTriggerScalingRulesResponse
        /// </returns>
        public DescribeTimeTriggerScalingRulesResponse DescribeTimeTriggerScalingRules(DescribeTimeTriggerScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTimeTriggerScalingRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取时间触发规则信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTimeTriggerScalingRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTimeTriggerScalingRulesResponse
        /// </returns>
        public async Task<DescribeTimeTriggerScalingRulesResponse> DescribeTimeTriggerScalingRulesAsync(DescribeTimeTriggerScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTimeTriggerScalingRulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks关闭SSL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSSLConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableSSLConnectionResponse
        /// </returns>
        public DisableSSLConnectionResponse DisableSSLConnectionWithOptions(DisableSSLConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSSLConnection",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/disableSSLConnection",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSSLConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks关闭SSL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSSLConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableSSLConnectionResponse
        /// </returns>
        public async Task<DisableSSLConnectionResponse> DisableSSLConnectionWithOptionsAsync(DisableSSLConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSSLConnection",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/disableSSLConnection",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSSLConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks关闭SSL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSSLConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableSSLConnectionResponse
        /// </returns>
        public DisableSSLConnectionResponse DisableSSLConnection(DisableSSLConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableSSLConnectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks关闭SSL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSSLConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableSSLConnectionResponse
        /// </returns>
        public async Task<DisableSSLConnectionResponse> DisableSSLConnectionAsync(DisableSSLConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableSSLConnectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>默认网关开启内网SLB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableInternalSlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableInternalSlbResponse
        /// </returns>
        public EnableInternalSlbResponse EnableInternalSlbWithOptions(EnableInternalSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInternalSlb",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/enableInternalSlb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInternalSlbResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>默认网关开启内网SLB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableInternalSlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableInternalSlbResponse
        /// </returns>
        public async Task<EnableInternalSlbResponse> EnableInternalSlbWithOptionsAsync(EnableInternalSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInternalSlb",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/enableInternalSlb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInternalSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>默认网关开启内网SLB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableInternalSlbRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableInternalSlbResponse
        /// </returns>
        public EnableInternalSlbResponse EnableInternalSlb(EnableInternalSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableInternalSlbWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>默认网关开启内网SLB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableInternalSlbRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableInternalSlbResponse
        /// </returns>
        public async Task<EnableInternalSlbResponse> EnableInternalSlbAsync(EnableInternalSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableInternalSlbWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启Multi AZ</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableMultiAzRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableMultiAzResponse
        /// </returns>
        public EnableMultiAzResponse EnableMultiAzWithOptions(EnableMultiAzRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Observers))
            {
                body["observers"] = request.Observers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                body["promotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMultiAz",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/lifecycle/enableMultiAz",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableMultiAzResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启Multi AZ</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableMultiAzRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableMultiAzResponse
        /// </returns>
        public async Task<EnableMultiAzResponse> EnableMultiAzWithOptionsAsync(EnableMultiAzRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Observers))
            {
                body["observers"] = request.Observers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                body["promotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMultiAz",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/lifecycle/enableMultiAz",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableMultiAzResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启Multi AZ</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableMultiAzRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableMultiAzResponse
        /// </returns>
        public EnableMultiAzResponse EnableMultiAz(EnableMultiAzRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableMultiAzWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启Multi AZ</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableMultiAzRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableMultiAzResponse
        /// </returns>
        public async Task<EnableMultiAzResponse> EnableMultiAzAsync(EnableMultiAzRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableMultiAzWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks开启SSL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableSSLConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableSSLConnectionResponse
        /// </returns>
        public EnableSSLConnectionResponse EnableSSLConnectionWithOptions(EnableSSLConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSSLCertificate))
            {
                body["CustomSSLCertificate"] = request.CustomSSLCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCustom))
            {
                body["EnableCustom"] = request.EnableCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Renewal))
            {
                body["Renewal"] = request.Renewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SslKeyPassword))
            {
                body["SslKeyPassword"] = request.SslKeyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SslKeystorePassword))
            {
                body["SslKeystorePassword"] = request.SslKeystorePassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSSLConnection",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/enableSSLConnection",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSSLConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks开启SSL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableSSLConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableSSLConnectionResponse
        /// </returns>
        public async Task<EnableSSLConnectionResponse> EnableSSLConnectionWithOptionsAsync(EnableSSLConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSSLCertificate))
            {
                body["CustomSSLCertificate"] = request.CustomSSLCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCustom))
            {
                body["EnableCustom"] = request.EnableCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Renewal))
            {
                body["Renewal"] = request.Renewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SslKeyPassword))
            {
                body["SslKeyPassword"] = request.SslKeyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SslKeystorePassword))
            {
                body["SslKeystorePassword"] = request.SslKeystorePassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSSLConnection",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/enableSSLConnection",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSSLConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks开启SSL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableSSLConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableSSLConnectionResponse
        /// </returns>
        public EnableSSLConnectionResponse EnableSSLConnection(EnableSSLConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableSSLConnectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks开启SSL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableSSLConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableSSLConnectionResponse
        /// </returns>
        public async Task<EnableSSLConnectionResponse> EnableSSLConnectionAsync(EnableSSLConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableSSLConnectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取StarRocks集群实例的特性开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceFeatureGateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceFeatureGateResponse
        /// </returns>
        public GetInstanceFeatureGateResponse GetInstanceFeatureGateWithOptions(GetInstanceFeatureGateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceFeatureGate",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/features/featureGate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceFeatureGateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取StarRocks集群实例的特性开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceFeatureGateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceFeatureGateResponse
        /// </returns>
        public async Task<GetInstanceFeatureGateResponse> GetInstanceFeatureGateWithOptionsAsync(GetInstanceFeatureGateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceFeatureGate",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/features/featureGate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceFeatureGateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取StarRocks集群实例的特性开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceFeatureGateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceFeatureGateResponse
        /// </returns>
        public GetInstanceFeatureGateResponse GetInstanceFeatureGate(GetInstanceFeatureGateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceFeatureGateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取StarRocks集群实例的特性开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceFeatureGateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceFeatureGateResponse
        /// </returns>
        public async Task<GetInstanceFeatureGateResponse> GetInstanceFeatureGateAsync(GetInstanceFeatureGateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceFeatureGateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取StarRocks 计算组实例的特性开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeGroupFeatureGateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeGroupFeatureGateResponse
        /// </returns>
        public GetNodeGroupFeatureGateResponse GetNodeGroupFeatureGateWithOptions(GetNodeGroupFeatureGateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeGroupFeatureGate",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/features/nodeGroupFeatureGate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeGroupFeatureGateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取StarRocks 计算组实例的特性开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeGroupFeatureGateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeGroupFeatureGateResponse
        /// </returns>
        public async Task<GetNodeGroupFeatureGateResponse> GetNodeGroupFeatureGateWithOptionsAsync(GetNodeGroupFeatureGateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeGroupFeatureGate",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/features/nodeGroupFeatureGate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeGroupFeatureGateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取StarRocks 计算组实例的特性开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeGroupFeatureGateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeGroupFeatureGateResponse
        /// </returns>
        public GetNodeGroupFeatureGateResponse GetNodeGroupFeatureGate(GetNodeGroupFeatureGateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNodeGroupFeatureGateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取StarRocks 计算组实例的特性开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeGroupFeatureGateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeGroupFeatureGateResponse
        /// </returns>
        public async Task<GetNodeGroupFeatureGateResponse> GetNodeGroupFeatureGateAsync(GetNodeGroupFeatureGateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNodeGroupFeatureGateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>默认网关开启内网SLB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsolateLeaderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IsolateLeaderResponse
        /// </returns>
        public IsolateLeaderResponse IsolateLeaderWithOptions(IsolateLeaderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolateLeader))
            {
                query["IsolateLeader"] = request.IsolateLeader;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsolateLeader",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/isolateLeader",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsolateLeaderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>默认网关开启内网SLB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsolateLeaderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IsolateLeaderResponse
        /// </returns>
        public async Task<IsolateLeaderResponse> IsolateLeaderWithOptionsAsync(IsolateLeaderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolateLeader))
            {
                query["IsolateLeader"] = request.IsolateLeader;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsolateLeader",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/isolateLeader",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsolateLeaderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>默认网关开启内网SLB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsolateLeaderRequest
        /// </param>
        /// 
        /// <returns>
        /// IsolateLeaderResponse
        /// </returns>
        public IsolateLeaderResponse IsolateLeader(IsolateLeaderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return IsolateLeaderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>默认网关开启内网SLB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsolateLeaderRequest
        /// </param>
        /// 
        /// <returns>
        /// IsolateLeaderResponse
        /// </returns>
        public async Task<IsolateLeaderResponse> IsolateLeaderAsync(IsolateLeaderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await IsolateLeaderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayResponse
        /// </returns>
        public ListGatewayResponse ListGatewayWithOptions(ListGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGateway",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayResponse
        /// </returns>
        public async Task<ListGatewayResponse> ListGatewayWithOptionsAsync(ListGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGateway",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayResponse
        /// </returns>
        public ListGatewayResponse ListGateway(ListGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayResponse
        /// </returns>
        public async Task<ListGatewayResponse> ListGatewayAsync(ListGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取操作的详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationActivityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOperationActivityResponse
        /// </returns>
        public ListOperationActivityResponse ListOperationActivityWithOptions(ListOperationActivityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOperationActivity",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/operation/listOperationActivity",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationActivityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取操作的详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationActivityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOperationActivityResponse
        /// </returns>
        public async Task<ListOperationActivityResponse> ListOperationActivityWithOptionsAsync(ListOperationActivityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOperationActivity",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/operation/listOperationActivity",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取操作的详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationActivityRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOperationActivityResponse
        /// </returns>
        public ListOperationActivityResponse ListOperationActivity(ListOperationActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOperationActivityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取操作的详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationActivityRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOperationActivityResponse
        /// </returns>
        public async Task<ListOperationActivityResponse> ListOperationActivityAsync(ListOperationActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOperationActivityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群的操作历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOperationHistoryResponse
        /// </returns>
        public ListOperationHistoryResponse ListOperationHistoryWithOptions(ListOperationHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                query["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOperationHistory",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/operation/listOperationHistory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群的操作历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOperationHistoryResponse
        /// </returns>
        public async Task<ListOperationHistoryResponse> ListOperationHistoryWithOptionsAsync(ListOperationHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                query["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOperationHistory",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/operation/listOperationHistory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群的操作历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOperationHistoryResponse
        /// </returns>
        public ListOperationHistoryResponse ListOperationHistory(ListOperationHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOperationHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群的操作历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOperationHistoryResponse
        /// </returns>
        public async Task<ListOperationHistoryResponse> ListOperationHistoryAsync(ListOperationHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOperationHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例的付费类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyChargeTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyChargeTypeResponse
        /// </returns>
        public ModifyChargeTypeResponse ModifyChargeTypeWithOptions(ModifyChargeTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["BillingInstanceIds"] = request.BillingInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyChargeType",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/cluster/modifyChargeType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyChargeTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例的付费类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyChargeTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyChargeTypeResponse
        /// </returns>
        public async Task<ModifyChargeTypeResponse> ModifyChargeTypeWithOptionsAsync(ModifyChargeTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["BillingInstanceIds"] = request.BillingInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyChargeType",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/cluster/modifyChargeType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyChargeTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例的付费类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyChargeTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyChargeTypeResponse
        /// </returns>
        public ModifyChargeTypeResponse ModifyChargeType(ModifyChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyChargeTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例的付费类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyChargeTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyChargeTypeResponse
        /// </returns>
        public async Task<ModifyChargeTypeResponse> ModifyChargeTypeAsync(ModifyChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyChargeTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the number of CUs for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the number of CUs for a warehouse of only StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can increase the number of disks only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you modify the number of CUs for a warehouse, the billing of CUs has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged based on the number of CUs.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of CUs before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyCuRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCuResponse
        /// </returns>
        public ModifyCuResponse ModifyCuWithOptions(ModifyCuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCu",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyCu",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCuResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the number of CUs for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the number of CUs for a warehouse of only StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can increase the number of disks only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you modify the number of CUs for a warehouse, the billing of CUs has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged based on the number of CUs.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of CUs before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyCuRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCuResponse
        /// </returns>
        public async Task<ModifyCuResponse> ModifyCuWithOptionsAsync(ModifyCuRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCu",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyCu",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCuResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the number of CUs for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the number of CUs for a warehouse of only StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can increase the number of disks only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you modify the number of CUs for a warehouse, the billing of CUs has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged based on the number of CUs.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of CUs before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyCuRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCuResponse
        /// </returns>
        public ModifyCuResponse ModifyCu(ModifyCuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyCuWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the number of CUs for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the number of CUs for a warehouse of only StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can increase the number of disks only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you modify the number of CUs for a warehouse, the billing of CUs has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged based on the number of CUs.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of CUs before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyCuRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCuResponse
        /// </returns>
        public async Task<ModifyCuResponse> ModifyCuAsync(ModifyCuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyCuWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a precheck before you modify the number of CUs for a warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCuPreCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCuPreCheckResponse
        /// </returns>
        public ModifyCuPreCheckResponse ModifyCuPreCheckWithOptions(ModifyCuPreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCuPreCheck",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyCuPreCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCuPreCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a precheck before you modify the number of CUs for a warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCuPreCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCuPreCheckResponse
        /// </returns>
        public async Task<ModifyCuPreCheckResponse> ModifyCuPreCheckWithOptionsAsync(ModifyCuPreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCuPreCheck",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyCuPreCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCuPreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a precheck before you modify the number of CUs for a warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCuPreCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCuPreCheckResponse
        /// </returns>
        public ModifyCuPreCheckResponse ModifyCuPreCheck(ModifyCuPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyCuPreCheckWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a precheck before you modify the number of CUs for a warehouse.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCuPreCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCuPreCheckResponse
        /// </returns>
        public async Task<ModifyCuPreCheckResponse> ModifyCuPreCheckAsync(ModifyCuPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyCuPreCheckWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Increases the number of disks for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can increase the number of disks only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can increase the number of disks only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you increase the number of disks for a warehouse, the billing of disks has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk type.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of disks before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskNumberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskNumberResponse
        /// </returns>
        public ModifyDiskNumberResponse ModifyDiskNumberWithOptions(ModifyDiskNumberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskNumber",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyDiskNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Increases the number of disks for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can increase the number of disks only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can increase the number of disks only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you increase the number of disks for a warehouse, the billing of disks has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk type.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of disks before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskNumberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskNumberResponse
        /// </returns>
        public async Task<ModifyDiskNumberResponse> ModifyDiskNumberWithOptionsAsync(ModifyDiskNumberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskNumber",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyDiskNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Increases the number of disks for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can increase the number of disks only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can increase the number of disks only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you increase the number of disks for a warehouse, the billing of disks has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk type.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of disks before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskNumberResponse
        /// </returns>
        public ModifyDiskNumberResponse ModifyDiskNumber(ModifyDiskNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDiskNumberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Increases the number of disks for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can increase the number of disks only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can increase the number of disks only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you increase the number of disks for a warehouse, the billing of disks has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk type.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of disks before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskNumberResponse
        /// </returns>
        public async Task<ModifyDiskNumberResponse> ModifyDiskNumberAsync(ModifyDiskNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDiskNumberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the disk performance level for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/en/product/ecs?_p_lc=1&spm=openapi-amp.newDocPublishment.0.0.47c9281fkIZGiB#pricing">pricing</a> of EMR Serverless StarRocks instances.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the disk performance level only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can modify the disk performance level only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.</description></item>
        /// <item><description>You cannot downgrade the performance level to PL0.</description></item>
        /// <item><description>The performance level of an Enterprise SSD (ESSD) is limited by the ESSD disk size. If you cannot upgrade the performance level of an ESSD, expand the ESSD and try again. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.
        /// After the disk performance level is changed, the billing of the disk has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk type.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the disk performance level before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskPerformanceLevelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskPerformanceLevelResponse
        /// </returns>
        public ModifyDiskPerformanceLevelResponse ModifyDiskPerformanceLevelWithOptions(ModifyDiskPerformanceLevelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskPerformanceLevel",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyDiskPerformanceLevel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskPerformanceLevelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the disk performance level for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/en/product/ecs?_p_lc=1&spm=openapi-amp.newDocPublishment.0.0.47c9281fkIZGiB#pricing">pricing</a> of EMR Serverless StarRocks instances.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the disk performance level only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can modify the disk performance level only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.</description></item>
        /// <item><description>You cannot downgrade the performance level to PL0.</description></item>
        /// <item><description>The performance level of an Enterprise SSD (ESSD) is limited by the ESSD disk size. If you cannot upgrade the performance level of an ESSD, expand the ESSD and try again. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.
        /// After the disk performance level is changed, the billing of the disk has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk type.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the disk performance level before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskPerformanceLevelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskPerformanceLevelResponse
        /// </returns>
        public async Task<ModifyDiskPerformanceLevelResponse> ModifyDiskPerformanceLevelWithOptionsAsync(ModifyDiskPerformanceLevelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskPerformanceLevel",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyDiskPerformanceLevel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskPerformanceLevelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the disk performance level for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/en/product/ecs?_p_lc=1&spm=openapi-amp.newDocPublishment.0.0.47c9281fkIZGiB#pricing">pricing</a> of EMR Serverless StarRocks instances.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the disk performance level only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can modify the disk performance level only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.</description></item>
        /// <item><description>You cannot downgrade the performance level to PL0.</description></item>
        /// <item><description>The performance level of an Enterprise SSD (ESSD) is limited by the ESSD disk size. If you cannot upgrade the performance level of an ESSD, expand the ESSD and try again. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.
        /// After the disk performance level is changed, the billing of the disk has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk type.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the disk performance level before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskPerformanceLevelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskPerformanceLevelResponse
        /// </returns>
        public ModifyDiskPerformanceLevelResponse ModifyDiskPerformanceLevel(ModifyDiskPerformanceLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDiskPerformanceLevelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the disk performance level for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/en/product/ecs?_p_lc=1&spm=openapi-amp.newDocPublishment.0.0.47c9281fkIZGiB#pricing">pricing</a> of EMR Serverless StarRocks instances.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the disk performance level only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can modify the disk performance level only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.</description></item>
        /// <item><description>You cannot downgrade the performance level to PL0.</description></item>
        /// <item><description>The performance level of an Enterprise SSD (ESSD) is limited by the ESSD disk size. If you cannot upgrade the performance level of an ESSD, expand the ESSD and try again. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.
        /// After the disk performance level is changed, the billing of the disk has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk type.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the disk performance level before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskPerformanceLevelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskPerformanceLevelResponse
        /// </returns>
        public async Task<ModifyDiskPerformanceLevelResponse> ModifyDiskPerformanceLevelAsync(ModifyDiskPerformanceLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDiskPerformanceLevelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Expands the disk size for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can expand the disk size only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can expand the disk size only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you expand the disk size, the billing of disks has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk size.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the disk size before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskSizeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskSizeResponse
        /// </returns>
        public ModifyDiskSizeResponse ModifyDiskSizeWithOptions(ModifyDiskSizeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskSize",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyDiskSize",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskSizeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Expands the disk size for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can expand the disk size only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can expand the disk size only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you expand the disk size, the billing of disks has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk size.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the disk size before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskSizeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskSizeResponse
        /// </returns>
        public async Task<ModifyDiskSizeResponse> ModifyDiskSizeWithOptionsAsync(ModifyDiskSizeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskSize",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyDiskSize",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskSizeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Expands the disk size for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can expand the disk size only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can expand the disk size only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you expand the disk size, the billing of disks has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk size.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the disk size before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskSizeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskSizeResponse
        /// </returns>
        public ModifyDiskSizeResponse ModifyDiskSize(ModifyDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDiskSizeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Expands the disk size for a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can expand the disk size only for StarRocks instances of Standard Edition.</description></item>
        /// <item><description>You can expand the disk size only for warehouses of the standard specifications.</description></item>
        /// <item><description>The instance must be in the Running state.
        /// After you expand the disk size, the billing of disks has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged for the disk based on the new disk size.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the disk size before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskSizeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskSizeResponse
        /// </returns>
        public async Task<ModifyDiskSizeResponse> ModifyDiskSizeAsync(ModifyDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDiskSizeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组的节点磁盘类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDiskTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskTypeResponse
        /// </returns>
        public ModifyDiskTypeResponse ModifyDiskTypeWithOptions(ModifyDiskTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDiskType))
            {
                query["TargetDiskType"] = request.TargetDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPerformanceLevel))
            {
                query["TargetPerformanceLevel"] = request.TargetPerformanceLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskType",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyDiskType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组的节点磁盘类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDiskTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskTypeResponse
        /// </returns>
        public async Task<ModifyDiskTypeResponse> ModifyDiskTypeWithOptionsAsync(ModifyDiskTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDiskType))
            {
                query["TargetDiskType"] = request.TargetDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPerformanceLevel))
            {
                query["TargetPerformanceLevel"] = request.TargetPerformanceLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskType",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyDiskType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组的节点磁盘类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDiskTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskTypeResponse
        /// </returns>
        public ModifyDiskTypeResponse ModifyDiskType(ModifyDiskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDiskTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组的节点磁盘类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDiskTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskTypeResponse
        /// </returns>
        public async Task<ModifyDiskTypeResponse> ModifyDiskTypeAsync(ModifyDiskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDiskTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改/etc/hosts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyHostAliasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyHostAliasResponse
        /// </returns>
        public ModifyHostAliasResponse ModifyHostAliasWithOptions(ModifyHostAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAliases))
            {
                body["hostAliases"] = request.HostAliases;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHostAlias",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/network/modifyHostAlias",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHostAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改/etc/hosts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyHostAliasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyHostAliasResponse
        /// </returns>
        public async Task<ModifyHostAliasResponse> ModifyHostAliasWithOptionsAsync(ModifyHostAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAliases))
            {
                body["hostAliases"] = request.HostAliases;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHostAlias",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/network/modifyHostAlias",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHostAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改/etc/hosts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyHostAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyHostAliasResponse
        /// </returns>
        public ModifyHostAliasResponse ModifyHostAlias(ModifyHostAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyHostAliasWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改/etc/hosts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyHostAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyHostAliasResponse
        /// </returns>
        public async Task<ModifyHostAliasResponse> ModifyHostAliasAsync(ModifyHostAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyHostAliasWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigResponse
        /// </returns>
        public ModifyInstanceConfigResponse ModifyInstanceConfigWithOptions(ModifyInstanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConfigList))
            {
                query["AddConfigList"] = request.AddConfigList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigList))
            {
                query["ConfigList"] = request.ConfigList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteConfigList))
            {
                query["DeleteConfigList"] = request.DeleteConfigList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToAdd))
            {
                body["configsToAdd"] = request.ConfigsToAdd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToDelete))
            {
                body["configsToDelete"] = request.ConfigsToDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToUpdate))
            {
                body["configsToUpdate"] = request.ConfigsToUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                body["fastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Restart))
            {
                body["restart"] = request.Restart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceConfig",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/modifyInstanceConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigResponse
        /// </returns>
        public async Task<ModifyInstanceConfigResponse> ModifyInstanceConfigWithOptionsAsync(ModifyInstanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddConfigList))
            {
                query["AddConfigList"] = request.AddConfigList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigList))
            {
                query["ConfigList"] = request.ConfigList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteConfigList))
            {
                query["DeleteConfigList"] = request.DeleteConfigList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToAdd))
            {
                body["configsToAdd"] = request.ConfigsToAdd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToDelete))
            {
                body["configsToDelete"] = request.ConfigsToDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToUpdate))
            {
                body["configsToUpdate"] = request.ConfigsToUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                body["fastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Restart))
            {
                body["restart"] = request.Restart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceConfig",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/modifyInstanceConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigResponse
        /// </returns>
        public ModifyInstanceConfigResponse ModifyInstanceConfig(ModifyInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyInstanceConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigResponse
        /// </returns>
        public async Task<ModifyInstanceConfigResponse> ModifyInstanceConfigAsync(ModifyInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyInstanceConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置变更预检查，返回此次变更需要重启的计算组ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigPreCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigPreCheckResponse
        /// </returns>
        public ModifyInstanceConfigPreCheckResponse ModifyInstanceConfigPreCheckWithOptions(ModifyInstanceConfigPreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToAdd))
            {
                body["configsToAdd"] = request.ConfigsToAdd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToDelete))
            {
                body["configsToDelete"] = request.ConfigsToDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToUpdate))
            {
                body["configsToUpdate"] = request.ConfigsToUpdate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceConfigPreCheck",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/modifyInstanceConfigPreCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceConfigPreCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置变更预检查，返回此次变更需要重启的计算组ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigPreCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigPreCheckResponse
        /// </returns>
        public async Task<ModifyInstanceConfigPreCheckResponse> ModifyInstanceConfigPreCheckWithOptionsAsync(ModifyInstanceConfigPreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToAdd))
            {
                body["configsToAdd"] = request.ConfigsToAdd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToDelete))
            {
                body["configsToDelete"] = request.ConfigsToDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsToUpdate))
            {
                body["configsToUpdate"] = request.ConfigsToUpdate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceConfigPreCheck",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/modifyInstanceConfigPreCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceConfigPreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置变更预检查，返回此次变更需要重启的计算组ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigPreCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigPreCheckResponse
        /// </returns>
        public ModifyInstanceConfigPreCheckResponse ModifyInstanceConfigPreCheck(ModifyInstanceConfigPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyInstanceConfigPreCheckWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置变更预检查，返回此次变更需要重启的计算组ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigPreCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigPreCheckResponse
        /// </returns>
        public async Task<ModifyInstanceConfigPreCheckResponse> ModifyInstanceConfigPreCheckAsync(ModifyInstanceConfigPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyInstanceConfigPreCheckWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Starrocks实例的可维护时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMaintainableTimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMaintainableTimeResponse
        /// </returns>
        public ModifyMaintainableTimeResponse ModifyMaintainableTimeWithOptions(ModifyMaintainableTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainableTimePeriod))
            {
                query["MaintainableTimePeriod"] = request.MaintainableTimePeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMaintainableTime",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/modifyMaintainableTime",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMaintainableTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Starrocks实例的可维护时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMaintainableTimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMaintainableTimeResponse
        /// </returns>
        public async Task<ModifyMaintainableTimeResponse> ModifyMaintainableTimeWithOptionsAsync(ModifyMaintainableTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainableTimePeriod))
            {
                query["MaintainableTimePeriod"] = request.MaintainableTimePeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMaintainableTime",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/modifyMaintainableTime",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMaintainableTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Starrocks实例的可维护时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMaintainableTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMaintainableTimeResponse
        /// </returns>
        public ModifyMaintainableTimeResponse ModifyMaintainableTime(ModifyMaintainableTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyMaintainableTimeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Starrocks实例的可维护时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMaintainableTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMaintainableTimeResponse
        /// </returns>
        public async Task<ModifyMaintainableTimeResponse> ModifyMaintainableTimeAsync(ModifyMaintainableTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyMaintainableTimeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the number of nodes in a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the number of nodes in a warehouse of only StarRocks instances of Standard Edition.</description></item>
        /// <item><description>The instance must be in the Running state.</description></item>
        /// <item><description>The number of frontend nodes (FEs) cannot be an even number, and you cannot reduce the number of FE nodes.
        /// After you modify the number of nodes in a warehouse, the billing of nodes has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged based on the number of nodes.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of nodes before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodeNumberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeNumberResponse
        /// </returns>
        public ModifyNodeNumberResponse ModifyNodeNumberWithOptions(ModifyNodeNumberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeNumber",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyNodeNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the number of nodes in a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the number of nodes in a warehouse of only StarRocks instances of Standard Edition.</description></item>
        /// <item><description>The instance must be in the Running state.</description></item>
        /// <item><description>The number of frontend nodes (FEs) cannot be an even number, and you cannot reduce the number of FE nodes.
        /// After you modify the number of nodes in a warehouse, the billing of nodes has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged based on the number of nodes.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of nodes before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodeNumberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeNumberResponse
        /// </returns>
        public async Task<ModifyNodeNumberResponse> ModifyNodeNumberWithOptionsAsync(ModifyNodeNumberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeNumber",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyNodeNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the number of nodes in a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the number of nodes in a warehouse of only StarRocks instances of Standard Edition.</description></item>
        /// <item><description>The instance must be in the Running state.</description></item>
        /// <item><description>The number of frontend nodes (FEs) cannot be an even number, and you cannot reduce the number of FE nodes.
        /// After you modify the number of nodes in a warehouse, the billing of nodes has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged based on the number of nodes.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of nodes before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodeNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeNumberResponse
        /// </returns>
        public ModifyNodeNumberResponse ModifyNodeNumber(ModifyNodeNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyNodeNumberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the number of nodes in a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and <a href="https://www.alibabacloud.com/help/en/emr/emr-serverless-starrocks/product-overview/billable-items?spm=a2c63.p38356.help-menu-28066.d_0_1_0.3aaf4b0b69jN1P">billable items</a> of EMR Serverless StarRocks instances. Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can modify the number of nodes in a warehouse of only StarRocks instances of Standard Edition.</description></item>
        /// <item><description>The instance must be in the Running state.</description></item>
        /// <item><description>The number of frontend nodes (FEs) cannot be an even number, and you cannot reduce the number of FE nodes.
        /// After you modify the number of nodes in a warehouse, the billing of nodes has the following changes:</description></item>
        /// <item><description>Pay-as-you-go StarRocks instances: You are charged based on the number of nodes.</description></item>
        /// <item><description>Subscription StarRocks instances: You are charged additionally based on the price difference between the number of nodes before and after the change and the remaining days of the billing cycle. The billing cycle starts from 00:00 the next day until the end of the subscription period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodeNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeNumberResponse
        /// </returns>
        public async Task<ModifyNodeNumberResponse> ModifyNodeNumberAsync(ModifyNodeNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyNodeNumberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a precheck before you modify the number of nodes in a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNodeNumberPreCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeNumberPreCheckResponse
        /// </returns>
        public ModifyNodeNumberPreCheckResponse ModifyNodeNumberPreCheckWithOptions(ModifyNodeNumberPreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeNumberPreCheck",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyNodeNumberPreCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeNumberPreCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a precheck before you modify the number of nodes in a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNodeNumberPreCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeNumberPreCheckResponse
        /// </returns>
        public async Task<ModifyNodeNumberPreCheckResponse> ModifyNodeNumberPreCheckWithOptionsAsync(ModifyNodeNumberPreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeNumberPreCheck",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifyNodeNumberPreCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeNumberPreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a precheck before you modify the number of nodes in a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNodeNumberPreCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeNumberPreCheckResponse
        /// </returns>
        public ModifyNodeNumberPreCheckResponse ModifyNodeNumberPreCheck(ModifyNodeNumberPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyNodeNumberPreCheckWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a precheck before you modify the number of nodes in a warehouse of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNodeNumberPreCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeNumberPreCheckResponse
        /// </returns>
        public async Task<ModifyNodeNumberPreCheckResponse> ModifyNodeNumberPreCheckAsync(ModifyNodeNumberPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyNodeNumberPreCheckWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改弹性伸缩规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScalingRuleResponse
        /// </returns>
        public ModifyScalingRuleResponse ModifyScalingRuleWithOptions(ModifyScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewTriggerType))
            {
                query["NewTriggerType"] = request.NewTriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldTriggerType))
            {
                query["OldTriggerType"] = request.OldTriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/scalingRule/modifyScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改弹性伸缩规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScalingRuleResponse
        /// </returns>
        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleWithOptionsAsync(ModifyScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewTriggerType))
            {
                query["NewTriggerType"] = request.NewTriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldTriggerType))
            {
                query["OldTriggerType"] = request.OldTriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/scalingRule/modifyScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改弹性伸缩规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScalingRuleResponse
        /// </returns>
        public ModifyScalingRuleResponse ModifyScalingRule(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyScalingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改弹性伸缩规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScalingRuleResponse
        /// </returns>
        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleAsync(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组的节点规格类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySpecTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySpecTypeResponse
        /// </returns>
        public ModifySpecTypeResponse ModifySpecTypeWithOptions(ModifySpecTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpecType))
            {
                query["TargetSpecType"] = request.TargetSpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySpecType",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifySpecType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySpecTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组的节点规格类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySpecTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySpecTypeResponse
        /// </returns>
        public async Task<ModifySpecTypeResponse> ModifySpecTypeWithOptionsAsync(ModifySpecTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpecType))
            {
                query["TargetSpecType"] = request.TargetSpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySpecType",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifySpecType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySpecTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组的节点规格类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySpecTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySpecTypeResponse
        /// </returns>
        public ModifySpecTypeResponse ModifySpecType(ModifySpecTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifySpecTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组的节点规格类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySpecTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySpecTypeResponse
        /// </returns>
        public async Task<ModifySpecTypeResponse> ModifySpecTypeAsync(ModifySpecTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifySpecTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组中节点规格类型预检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySpecTypePreCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySpecTypePreCheckResponse
        /// </returns>
        public ModifySpecTypePreCheckResponse ModifySpecTypePreCheckWithOptions(ModifySpecTypePreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpecType))
            {
                query["TargetSpecType"] = request.TargetSpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySpecTypePreCheck",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifySpecTypePreCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySpecTypePreCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组中节点规格类型预检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySpecTypePreCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySpecTypePreCheckResponse
        /// </returns>
        public async Task<ModifySpecTypePreCheckResponse> ModifySpecTypePreCheckWithOptionsAsync(ModifySpecTypePreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpecType))
            {
                query["TargetSpecType"] = request.TargetSpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySpecTypePreCheck",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/resourceChange/modifySpecTypePreCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySpecTypePreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组中节点规格类型预检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySpecTypePreCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySpecTypePreCheckResponse
        /// </returns>
        public ModifySpecTypePreCheckResponse ModifySpecTypePreCheck(ModifySpecTypePreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifySpecTypePreCheckWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组中节点规格类型预检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySpecTypePreCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySpecTypePreCheckResponse
        /// </returns>
        public async Task<ModifySpecTypePreCheckResponse> ModifySpecTypePreCheckAsync(ModifySpecTypePreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifySpecTypePreCheckWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改 starrocks 用户的密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserPasswordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserPasswordResponse
        /// </returns>
        public ModifyUserPasswordResponse ModifyUserPasswordWithOptions(ModifyUserPasswordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUserPassword",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/password/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改 starrocks 用户的密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserPasswordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserPasswordResponse
        /// </returns>
        public async Task<ModifyUserPasswordResponse> ModifyUserPasswordWithOptionsAsync(ModifyUserPasswordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUserPassword",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/password/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改 starrocks 用户的密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserPasswordResponse
        /// </returns>
        public ModifyUserPasswordResponse ModifyUserPassword(ModifyUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyUserPasswordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改 starrocks 用户的密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserPasswordResponse
        /// </returns>
        public async Task<ModifyUserPasswordResponse> ModifyUserPasswordAsync(ModifyUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyUserPasswordWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开启Multi AZ的价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnableMultiAzPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnableMultiAzPriceResponse
        /// </returns>
        public QueryEnableMultiAzPriceResponse QueryEnableMultiAzPriceWithOptions(QueryEnableMultiAzPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Observers))
            {
                body["observers"] = request.Observers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                body["promotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEnableMultiAzPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/enableMultiAz",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnableMultiAzPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开启Multi AZ的价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnableMultiAzPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnableMultiAzPriceResponse
        /// </returns>
        public async Task<QueryEnableMultiAzPriceResponse> QueryEnableMultiAzPriceWithOptionsAsync(QueryEnableMultiAzPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Observers))
            {
                body["observers"] = request.Observers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                body["promotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEnableMultiAzPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/enableMultiAz",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnableMultiAzPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开启Multi AZ的价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnableMultiAzPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnableMultiAzPriceResponse
        /// </returns>
        public QueryEnableMultiAzPriceResponse QueryEnableMultiAzPrice(QueryEnableMultiAzPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryEnableMultiAzPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开启Multi AZ的价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnableMultiAzPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnableMultiAzPriceResponse
        /// </returns>
        public async Task<QueryEnableMultiAzPriceResponse> QueryEnableMultiAzPriceAsync(QueryEnableMultiAzPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryEnableMultiAzPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小版本号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinorVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinorVersionResponse
        /// </returns>
        public QueryMinorVersionResponse QueryMinorVersionWithOptions(QueryMinorVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinorVersion",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/queryAppDefineVersion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinorVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小版本号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinorVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMinorVersionResponse
        /// </returns>
        public async Task<QueryMinorVersionResponse> QueryMinorVersionWithOptionsAsync(QueryMinorVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMinorVersion",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/queryAppDefineVersion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMinorVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小版本号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinorVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinorVersionResponse
        /// </returns>
        public QueryMinorVersionResponse QueryMinorVersion(QueryMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryMinorVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小版本号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMinorVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMinorVersionResponse
        /// </returns>
        public async Task<QueryMinorVersionResponse> QueryMinorVersionAsync(QueryMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryMinorVersionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks新购询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyChargeTypePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyChargeTypePriceResponse
        /// </returns>
        public QueryModifyChargeTypePriceResponse QueryModifyChargeTypePriceWithOptions(QueryModifyChargeTypePriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["BillingInstanceIds"] = request.BillingInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyChargeTypePrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/buy/query_modify_charge_type_price",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyChargeTypePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks新购询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyChargeTypePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyChargeTypePriceResponse
        /// </returns>
        public async Task<QueryModifyChargeTypePriceResponse> QueryModifyChargeTypePriceWithOptionsAsync(QueryModifyChargeTypePriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["BillingInstanceIds"] = request.BillingInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyChargeTypePrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/buy/query_modify_charge_type_price",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyChargeTypePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks新购询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyChargeTypePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyChargeTypePriceResponse
        /// </returns>
        public QueryModifyChargeTypePriceResponse QueryModifyChargeTypePrice(QueryModifyChargeTypePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryModifyChargeTypePriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks新购询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyChargeTypePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyChargeTypePriceResponse
        /// </returns>
        public async Task<QueryModifyChargeTypePriceResponse> QueryModifyChargeTypePriceAsync(QueryModifyChargeTypePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryModifyChargeTypePriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组节点Cu询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyCuPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyCuPriceResponse
        /// </returns>
        public QueryModifyCuPriceResponse QueryModifyCuPriceWithOptions(QueryModifyCuPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyCuPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyCu",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyCuPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组节点Cu询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyCuPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyCuPriceResponse
        /// </returns>
        public async Task<QueryModifyCuPriceResponse> QueryModifyCuPriceWithOptionsAsync(QueryModifyCuPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyCuPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyCu",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyCuPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组节点Cu询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyCuPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyCuPriceResponse
        /// </returns>
        public QueryModifyCuPriceResponse QueryModifyCuPrice(QueryModifyCuPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryModifyCuPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组节点Cu询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyCuPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyCuPriceResponse
        /// </returns>
        public async Task<QueryModifyCuPriceResponse> QueryModifyCuPriceAsync(QueryModifyCuPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryModifyCuPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘数量询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskNumberPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskNumberPriceResponse
        /// </returns>
        public QueryModifyDiskNumberPriceResponse QueryModifyDiskNumberPriceWithOptions(QueryModifyDiskNumberPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyDiskNumberPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyDiskNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyDiskNumberPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘数量询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskNumberPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskNumberPriceResponse
        /// </returns>
        public async Task<QueryModifyDiskNumberPriceResponse> QueryModifyDiskNumberPriceWithOptionsAsync(QueryModifyDiskNumberPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyDiskNumberPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyDiskNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyDiskNumberPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘数量询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskNumberPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskNumberPriceResponse
        /// </returns>
        public QueryModifyDiskNumberPriceResponse QueryModifyDiskNumberPrice(QueryModifyDiskNumberPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryModifyDiskNumberPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘数量询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskNumberPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskNumberPriceResponse
        /// </returns>
        public async Task<QueryModifyDiskNumberPriceResponse> QueryModifyDiskNumberPriceAsync(QueryModifyDiskNumberPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryModifyDiskNumberPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘性能级别询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskPerformanceLevelPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskPerformanceLevelPriceResponse
        /// </returns>
        public QueryModifyDiskPerformanceLevelPriceResponse QueryModifyDiskPerformanceLevelPriceWithOptions(QueryModifyDiskPerformanceLevelPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyDiskPerformanceLevelPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyDiskPerformanceLevel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyDiskPerformanceLevelPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘性能级别询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskPerformanceLevelPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskPerformanceLevelPriceResponse
        /// </returns>
        public async Task<QueryModifyDiskPerformanceLevelPriceResponse> QueryModifyDiskPerformanceLevelPriceWithOptionsAsync(QueryModifyDiskPerformanceLevelPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyDiskPerformanceLevelPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyDiskPerformanceLevel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyDiskPerformanceLevelPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘性能级别询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskPerformanceLevelPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskPerformanceLevelPriceResponse
        /// </returns>
        public QueryModifyDiskPerformanceLevelPriceResponse QueryModifyDiskPerformanceLevelPrice(QueryModifyDiskPerformanceLevelPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryModifyDiskPerformanceLevelPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘性能级别询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskPerformanceLevelPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskPerformanceLevelPriceResponse
        /// </returns>
        public async Task<QueryModifyDiskPerformanceLevelPriceResponse> QueryModifyDiskPerformanceLevelPriceAsync(QueryModifyDiskPerformanceLevelPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryModifyDiskPerformanceLevelPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点单盘存储大小询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskSizePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskSizePriceResponse
        /// </returns>
        public QueryModifyDiskSizePriceResponse QueryModifyDiskSizePriceWithOptions(QueryModifyDiskSizePriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyDiskSizePrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyDiskSize",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyDiskSizePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点单盘存储大小询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskSizePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskSizePriceResponse
        /// </returns>
        public async Task<QueryModifyDiskSizePriceResponse> QueryModifyDiskSizePriceWithOptionsAsync(QueryModifyDiskSizePriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyDiskSizePrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyDiskSize",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyDiskSizePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点单盘存储大小询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskSizePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskSizePriceResponse
        /// </returns>
        public QueryModifyDiskSizePriceResponse QueryModifyDiskSizePrice(QueryModifyDiskSizePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryModifyDiskSizePriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点单盘存储大小询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskSizePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskSizePriceResponse
        /// </returns>
        public async Task<QueryModifyDiskSizePriceResponse> QueryModifyDiskSizePriceAsync(QueryModifyDiskSizePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryModifyDiskSizePriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘类型询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskTypePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskTypePriceResponse
        /// </returns>
        public QueryModifyDiskTypePriceResponse QueryModifyDiskTypePriceWithOptions(QueryModifyDiskTypePriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDiskType))
            {
                query["TargetDiskType"] = request.TargetDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPerformanceLevel))
            {
                query["TargetPerformanceLevel"] = request.TargetPerformanceLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyDiskTypePrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyDiskType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyDiskTypePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘类型询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskTypePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskTypePriceResponse
        /// </returns>
        public async Task<QueryModifyDiskTypePriceResponse> QueryModifyDiskTypePriceWithOptionsAsync(QueryModifyDiskTypePriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDiskType))
            {
                query["TargetDiskType"] = request.TargetDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPerformanceLevel))
            {
                query["TargetPerformanceLevel"] = request.TargetPerformanceLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyDiskTypePrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyDiskType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyDiskTypePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘类型询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskTypePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskTypePriceResponse
        /// </returns>
        public QueryModifyDiskTypePriceResponse QueryModifyDiskTypePrice(QueryModifyDiskTypePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryModifyDiskTypePriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改计算组节点磁盘类型询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyDiskTypePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyDiskTypePriceResponse
        /// </returns>
        public async Task<QueryModifyDiskTypePriceResponse> QueryModifyDiskTypePriceAsync(QueryModifyDiskTypePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryModifyDiskTypePriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组节点数量询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyNodeNumberPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyNodeNumberPriceResponse
        /// </returns>
        public QueryModifyNodeNumberPriceResponse QueryModifyNodeNumberPriceWithOptions(QueryModifyNodeNumberPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyNodeNumberPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyNodeNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyNodeNumberPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组节点数量询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyNodeNumberPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyNodeNumberPriceResponse
        /// </returns>
        public async Task<QueryModifyNodeNumberPriceResponse> QueryModifyNodeNumberPriceWithOptionsAsync(QueryModifyNodeNumberPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyNodeNumberPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifyNodeNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyNodeNumberPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组节点数量询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyNodeNumberPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyNodeNumberPriceResponse
        /// </returns>
        public QueryModifyNodeNumberPriceResponse QueryModifyNodeNumberPrice(QueryModifyNodeNumberPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryModifyNodeNumberPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组节点数量询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyNodeNumberPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyNodeNumberPriceResponse
        /// </returns>
        public async Task<QueryModifyNodeNumberPriceResponse> QueryModifyNodeNumberPriceAsync(QueryModifyNodeNumberPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryModifyNodeNumberPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组规格类型询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifySpecTypePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifySpecTypePriceResponse
        /// </returns>
        public QueryModifySpecTypePriceResponse QueryModifySpecTypePriceWithOptions(QueryModifySpecTypePriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpecType))
            {
                query["TargetSpecType"] = request.TargetSpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifySpecTypePrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifySpecType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifySpecTypePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组规格类型询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifySpecTypePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifySpecTypePriceResponse
        /// </returns>
        public async Task<QueryModifySpecTypePriceResponse> QueryModifySpecTypePriceWithOptionsAsync(QueryModifySpecTypePriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSpecType))
            {
                query["TargetSpecType"] = request.TargetSpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifySpecTypePrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/priceInquiry/modifySpecType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifySpecTypePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组规格类型询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifySpecTypePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifySpecTypePriceResponse
        /// </returns>
        public QueryModifySpecTypePriceResponse QueryModifySpecTypePrice(QueryModifySpecTypePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryModifySpecTypePriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改节点组规格类型询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifySpecTypePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifySpecTypePriceResponse
        /// </returns>
        public async Task<QueryModifySpecTypePriceResponse> QueryModifySpecTypePriceAsync(QueryModifySpecTypePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryModifySpecTypePriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks新购询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPriceV1Request
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPriceV1Response
        /// </returns>
        public QueryPriceV1Response QueryPriceV1WithOptions(QueryPriceV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentNodeGroup))
            {
                body["AgentNodeGroup"] = request.AgentNodeGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendNodeGroups))
            {
                body["BackendNodeGroups"] = request.BackendNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendNodeGroups))
            {
                body["FrontendNodeGroups"] = request.FrontendNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObserverNodeGroups))
            {
                body["ObserverNodeGroups"] = request.ObserverNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                body["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                body["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                body["RunMode"] = request.RunMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPriceV1",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/price/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPriceV1Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks新购询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPriceV1Request
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPriceV1Response
        /// </returns>
        public async Task<QueryPriceV1Response> QueryPriceV1WithOptionsAsync(QueryPriceV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentNodeGroup))
            {
                body["AgentNodeGroup"] = request.AgentNodeGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendNodeGroups))
            {
                body["BackendNodeGroups"] = request.BackendNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendNodeGroups))
            {
                body["FrontendNodeGroups"] = request.FrontendNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObserverNodeGroups))
            {
                body["ObserverNodeGroups"] = request.ObserverNodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                body["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                body["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                body["RunMode"] = request.RunMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPriceV1",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/price/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPriceV1Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks新购询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPriceV1Request
        /// </param>
        /// 
        /// <returns>
        /// QueryPriceV1Response
        /// </returns>
        public QueryPriceV1Response QueryPriceV1(QueryPriceV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryPriceV1WithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks新购询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPriceV1Request
        /// </param>
        /// 
        /// <returns>
        /// QueryPriceV1Response
        /// </returns>
        public async Task<QueryPriceV1Response> QueryPriceV1Async(QueryPriceV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryPriceV1WithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks退订包年包月计费实例询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRefundPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRefundPriceResponse
        /// </returns>
        public QueryRefundPriceResponse QueryRefundPriceWithOptions(QueryRefundPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["billingInstanceIds"] = request.BillingInstanceIds;
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
                Action = "QueryRefundPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/buy/queryRefundPrice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRefundPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks退订包年包月计费实例询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRefundPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRefundPriceResponse
        /// </returns>
        public async Task<QueryRefundPriceResponse> QueryRefundPriceWithOptionsAsync(QueryRefundPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["billingInstanceIds"] = request.BillingInstanceIds;
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
                Action = "QueryRefundPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/buy/queryRefundPrice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRefundPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks退订包年包月计费实例询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRefundPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRefundPriceResponse
        /// </returns>
        public QueryRefundPriceResponse QueryRefundPrice(QueryRefundPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryRefundPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StarRocks退订包年包月计费实例询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRefundPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRefundPriceResponse
        /// </returns>
        public async Task<QueryRefundPriceResponse> QueryRefundPriceAsync(QueryRefundPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryRefundPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 StarRocks 计费实例的续费价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewPriceResponse
        /// </returns>
        public QueryRenewPriceResponse QueryRenewPriceWithOptions(QueryRenewPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["BillingInstanceIds"] = request.BillingInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRenewPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/price/renew",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRenewPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 StarRocks 计费实例的续费价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewPriceResponse
        /// </returns>
        public async Task<QueryRenewPriceResponse> QueryRenewPriceWithOptionsAsync(QueryRenewPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["BillingInstanceIds"] = request.BillingInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRenewPrice",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/price/renew",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRenewPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 StarRocks 计费实例的续费价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewPriceResponse
        /// </returns>
        public QueryRenewPriceResponse QueryRenewPrice(QueryRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryRenewPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 StarRocks 计费实例的续费价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewPriceResponse
        /// </returns>
        public async Task<QueryRenewPriceResponse> QueryRenewPriceAsync(QueryRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryRenewPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询计算组/集群的未支付订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnpaidOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnpaidOrderResponse
        /// </returns>
        public QueryUnpaidOrderResponse QueryUnpaidOrderWithOptions(QueryUnpaidOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceId))
            {
                query["BillingInstanceId"] = request.BillingInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnpaidOrder",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/order/queryUnpaidOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnpaidOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询计算组/集群的未支付订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnpaidOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnpaidOrderResponse
        /// </returns>
        public async Task<QueryUnpaidOrderResponse> QueryUnpaidOrderWithOptionsAsync(QueryUnpaidOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceId))
            {
                query["BillingInstanceId"] = request.BillingInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnpaidOrder",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/order/queryUnpaidOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnpaidOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询计算组/集群的未支付订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnpaidOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnpaidOrderResponse
        /// </returns>
        public QueryUnpaidOrderResponse QueryUnpaidOrder(QueryUnpaidOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryUnpaidOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询计算组/集群的未支付订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnpaidOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnpaidOrderResponse
        /// </returns>
        public async Task<QueryUnpaidOrderResponse> QueryUnpaidOrderAsync(QueryUnpaidOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryUnpaidOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of an E-MapReduce (EMR) Serverless StarRocks instance that the versions that you can upgrade to. The versions of a StarRocks instance include the major version and minor version. You can view the major version and minor version of a StarRocks instance in the Version Information section of the Instance Details tab in the EMR console. You can call this operation to query the minor versions or major versions that the versions that you can upgrade to.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUpgradableVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUpgradableVersionsResponse
        /// </returns>
        public QueryUpgradableVersionsResponse QueryUpgradableVersionsWithOptions(QueryUpgradableVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minor))
            {
                query["Minor"] = request.Minor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUpgradableVersions",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/queryUpgradableVersions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUpgradableVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of an E-MapReduce (EMR) Serverless StarRocks instance that the versions that you can upgrade to. The versions of a StarRocks instance include the major version and minor version. You can view the major version and minor version of a StarRocks instance in the Version Information section of the Instance Details tab in the EMR console. You can call this operation to query the minor versions or major versions that the versions that you can upgrade to.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUpgradableVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUpgradableVersionsResponse
        /// </returns>
        public async Task<QueryUpgradableVersionsResponse> QueryUpgradableVersionsWithOptionsAsync(QueryUpgradableVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minor))
            {
                query["Minor"] = request.Minor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUpgradableVersions",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/queryUpgradableVersions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUpgradableVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of an E-MapReduce (EMR) Serverless StarRocks instance that the versions that you can upgrade to. The versions of a StarRocks instance include the major version and minor version. You can view the major version and minor version of a StarRocks instance in the Version Information section of the Instance Details tab in the EMR console. You can call this operation to query the minor versions or major versions that the versions that you can upgrade to.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUpgradableVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUpgradableVersionsResponse
        /// </returns>
        public QueryUpgradableVersionsResponse QueryUpgradableVersions(QueryUpgradableVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryUpgradableVersionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of an E-MapReduce (EMR) Serverless StarRocks instance that the versions that you can upgrade to. The versions of a StarRocks instance include the major version and minor version. You can view the major version and minor version of a StarRocks instance in the Version Information section of the Instance Details tab in the EMR console. You can call this operation to query the minor versions or major versions that the versions that you can upgrade to.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUpgradableVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUpgradableVersionsResponse
        /// </returns>
        public async Task<QueryUpgradableVersionsResponse> QueryUpgradableVersionsAsync(QueryUpgradableVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryUpgradableVersionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处理集群事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootECSRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootECSResponse
        /// </returns>
        public RebootECSResponse RebootECSWithOptions(RebootECSRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RebootTime))
            {
                query["RebootTime"] = request.RebootTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootECS",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/event/rebootEcs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootECSResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处理集群事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootECSRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootECSResponse
        /// </returns>
        public async Task<RebootECSResponse> RebootECSWithOptionsAsync(RebootECSRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RebootTime))
            {
                query["RebootTime"] = request.RebootTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootECS",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/event/rebootEcs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootECSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处理集群事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootECSRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootECSResponse
        /// </returns>
        public RebootECSResponse RebootECS(RebootECSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RebootECSWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处理集群事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootECSRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootECSResponse
        /// </returns>
        public async Task<RebootECSResponse> RebootECSAsync(RebootECSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RebootECSWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go E-MapReduce (EMR) Serverless StarRocks instance. To unsubscribe from a subscription instance, go to the Unsubscribe page of the Expenses and Costs console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning:</b> After an instance is released, all physical resources used by the instance are recycled. Relevant data is erased and cannot be restored.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/cluster/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go E-MapReduce (EMR) Serverless StarRocks instance. To unsubscribe from a subscription instance, go to the Unsubscribe page of the Expenses and Costs console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning:</b> After an instance is released, all physical resources used by the instance are recycled. Relevant data is erased and cannot be restored.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/cluster/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go E-MapReduce (EMR) Serverless StarRocks instance. To unsubscribe from a subscription instance, go to the Unsubscribe page of the Expenses and Costs console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning:</b> After an instance is released, all physical resources used by the instance are recycled. Relevant data is erased and cannot be restored.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReleaseInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go E-MapReduce (EMR) Serverless StarRocks instance. To unsubscribe from a subscription instance, go to the Unsubscribe page of the Expenses and Costs console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning:</b> After an instance is released, all physical resources used by the instance are recycled. Relevant data is erased and cannot be restored.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReleaseInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费实例</para>
        /// </summary>
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
        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["BillingInstanceIds"] = request.BillingInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/order/renew_instance",
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
        /// <para>续费实例</para>
        /// </summary>
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
        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingInstanceIds))
            {
                query["BillingInstanceIds"] = request.BillingInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionOptionNo))
            {
                query["PromotionOptionNo"] = request.PromotionOptionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/order/renew_instance",
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
        /// <para>续费实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenewInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenewInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is an asynchronous operation. After you call this operation to restart a StarRocks instance, the operation sets the status of the instance to Restarting and begins the restart process. When the status of the instance changes to Running, the instance is restarted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartInstanceRequest
        /// </param>
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
        public RestartInstanceResponse RestartInstanceWithOptions(RestartInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/restartCluster",
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
        /// <para>Restarts an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is an asynchronous operation. After you call this operation to restart a StarRocks instance, the operation sets the status of the instance to Restarting and begins the restart process. When the status of the instance changes to Running, the instance is restarted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartInstanceRequest
        /// </param>
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
        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(RestartInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/restartCluster",
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
        /// <para>Restarts an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is an asynchronous operation. After you call this operation to restart a StarRocks instance, the operation sets the status of the instance to Restarting and begins the restart process. When the status of the instance changes to Running, the instance is restarted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public RestartInstanceResponse RestartInstance(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is an asynchronous operation. After you call this operation to restart a StarRocks instance, the operation sets the status of the instance to Restarting and begins the restart process. When the status of the instance changes to Running, the instance is restarted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启指定的node group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartNodeGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartNodeGroupResponse
        /// </returns>
        public RestartNodeGroupResponse RestartNodeGroupWithOptions(RestartNodeGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartNodeGroup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/nodegroup/restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartNodeGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启指定的node group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartNodeGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartNodeGroupResponse
        /// </returns>
        public async Task<RestartNodeGroupResponse> RestartNodeGroupWithOptionsAsync(RestartNodeGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartNodeGroup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/nodegroup/restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartNodeGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启指定的node group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartNodeGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartNodeGroupResponse
        /// </returns>
        public RestartNodeGroupResponse RestartNodeGroup(RestartNodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartNodeGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启指定的node group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartNodeGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartNodeGroupResponse
        /// </returns>
        public async Task<RestartNodeGroupResponse> RestartNodeGroupAsync(RestartNodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartNodeGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启集群中的节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartNodesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartNodesResponse
        /// </returns>
        public RestartNodesResponse RestartNodesWithOptions(RestartNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartNodeGroups))
            {
                body["RestartNodeGroups"] = request.RestartNodeGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartNodes",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/restart/restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启集群中的节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartNodesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartNodesResponse
        /// </returns>
        public async Task<RestartNodesResponse> RestartNodesWithOptionsAsync(RestartNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartNodeGroups))
            {
                body["RestartNodeGroups"] = request.RestartNodeGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartNodes",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/restart/restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启集群中的节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartNodesResponse
        /// </returns>
        public RestartNodesResponse RestartNodes(RestartNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartNodesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启集群中的节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartNodesResponse
        /// </returns>
        public async Task<RestartNodesResponse> RestartNodesAsync(RestartNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartNodesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从备份中恢复实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreInstanceResponse
        /// </returns>
        public RestoreInstanceResponse RestoreInstanceWithOptions(RestoreInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminPassword))
            {
                body["AdminPassword"] = request.AdminPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTaskId))
            {
                body["BackupTaskId"] = request.BackupTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                body["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/restore/restoreInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从备份中恢复实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreInstanceResponse
        /// </returns>
        public async Task<RestoreInstanceResponse> RestoreInstanceWithOptionsAsync(RestoreInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminPassword))
            {
                body["AdminPassword"] = request.AdminPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTaskId))
            {
                body["BackupTaskId"] = request.BackupTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                body["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/restore/restoreInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从备份中恢复实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreInstanceResponse
        /// </returns>
        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestoreInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从备份中恢复实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreInstanceResponse
        /// </returns>
        public async Task<RestoreInstanceResponse> RestoreInstanceAsync(RestoreInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestoreInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于恢复来自openlake自动停机的实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeInstanceRequest
        /// </param>
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
        public ResumeInstanceResponse ResumeInstanceWithOptions(ResumeInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/lifecycle/resumeInstance",
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
        /// <para>该接口用于恢复来自openlake自动停机的实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeInstanceRequest
        /// </param>
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
        public async Task<ResumeInstanceResponse> ResumeInstanceWithOptionsAsync(ResumeInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeInstance",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/lifecycle/resumeInstance",
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
        /// <para>该接口用于恢复来自openlake自动停机的实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeInstanceResponse
        /// </returns>
        public ResumeInstanceResponse ResumeInstance(ResumeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于恢复来自openlake自动停机的实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeInstanceResponse
        /// </returns>
        public async Task<ResumeInstanceResponse> ResumeInstanceAsync(ResumeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚正在进行中的配置修改</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackConfigModificationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackConfigModificationResponse
        /// </returns>
        public RollbackConfigModificationResponse RollbackConfigModificationWithOptions(RollbackConfigModificationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigHistoryId))
            {
                query["ConfigHistoryId"] = request.ConfigHistoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Restart))
            {
                query["Restart"] = request.Restart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackConfigModification",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/rollbackConfigModification",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackConfigModificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚正在进行中的配置修改</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackConfigModificationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackConfigModificationResponse
        /// </returns>
        public async Task<RollbackConfigModificationResponse> RollbackConfigModificationWithOptionsAsync(RollbackConfigModificationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigHistoryId))
            {
                query["ConfigHistoryId"] = request.ConfigHistoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Restart))
            {
                query["Restart"] = request.Restart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackConfigModification",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/config/rollbackConfigModification",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackConfigModificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚正在进行中的配置修改</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackConfigModificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackConfigModificationResponse
        /// </returns>
        public RollbackConfigModificationResponse RollbackConfigModification(RollbackConfigModificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollbackConfigModificationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚正在进行中的配置修改</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackConfigModificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackConfigModificationResponse
        /// </returns>
        public async Task<RollbackConfigModificationResponse> RollbackConfigModificationAsync(RollbackConfigModificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollbackConfigModificationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>切换主备可用区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SwitchActiveStandbyZonesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SwitchActiveStandbyZonesResponse
        /// </returns>
        public SwitchActiveStandbyZonesResponse SwitchActiveStandbyZonesWithOptions(SwitchActiveStandbyZonesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetZoneId))
            {
                query["TargetZoneId"] = request.TargetZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchActiveStandbyZones",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/recovery/switchZones",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchActiveStandbyZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>切换主备可用区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SwitchActiveStandbyZonesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SwitchActiveStandbyZonesResponse
        /// </returns>
        public async Task<SwitchActiveStandbyZonesResponse> SwitchActiveStandbyZonesWithOptionsAsync(SwitchActiveStandbyZonesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetZoneId))
            {
                query["TargetZoneId"] = request.TargetZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchActiveStandbyZones",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/recovery/switchZones",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchActiveStandbyZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>切换主备可用区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SwitchActiveStandbyZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// SwitchActiveStandbyZonesResponse
        /// </returns>
        public SwitchActiveStandbyZonesResponse SwitchActiveStandbyZones(SwitchActiveStandbyZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SwitchActiveStandbyZonesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>切换主备可用区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SwitchActiveStandbyZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// SwitchActiveStandbyZonesResponse
        /// </returns>
        public async Task<SwitchActiveStandbyZonesResponse> SwitchActiveStandbyZonesAsync(SwitchActiveStandbyZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SwitchActiveStandbyZonesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a resource.</para>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a resource.</para>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启/关闭StarRocks实例的小版本自动更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ToggleAutoMinorVersionUpgradeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ToggleAutoMinorVersionUpgradeResponse
        /// </returns>
        public ToggleAutoMinorVersionUpgradeResponse ToggleAutoMinorVersionUpgradeWithOptions(ToggleAutoMinorVersionUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUpgrade))
            {
                query["AutoUpgrade"] = request.AutoUpgrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ToggleAutoMinorVersionUpgrade",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/toggleAutoMinorVersionUpgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ToggleAutoMinorVersionUpgradeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启/关闭StarRocks实例的小版本自动更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ToggleAutoMinorVersionUpgradeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ToggleAutoMinorVersionUpgradeResponse
        /// </returns>
        public async Task<ToggleAutoMinorVersionUpgradeResponse> ToggleAutoMinorVersionUpgradeWithOptionsAsync(ToggleAutoMinorVersionUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUpgrade))
            {
                query["AutoUpgrade"] = request.AutoUpgrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ToggleAutoMinorVersionUpgrade",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/toggleAutoMinorVersionUpgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ToggleAutoMinorVersionUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启/关闭StarRocks实例的小版本自动更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ToggleAutoMinorVersionUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ToggleAutoMinorVersionUpgradeResponse
        /// </returns>
        public ToggleAutoMinorVersionUpgradeResponse ToggleAutoMinorVersionUpgrade(ToggleAutoMinorVersionUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ToggleAutoMinorVersionUpgradeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启/关闭StarRocks实例的小版本自动更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ToggleAutoMinorVersionUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ToggleAutoMinorVersionUpgradeResponse
        /// </returns>
        public async Task<ToggleAutoMinorVersionUpgradeResponse> ToggleAutoMinorVersionUpgradeAsync(ToggleAutoMinorVersionUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ToggleAutoMinorVersionUpgradeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>公网SLB开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TogglePublicSlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TogglePublicSlbResponse
        /// </returns>
        public TogglePublicSlbResponse TogglePublicSlbWithOptions(TogglePublicSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublicSlb))
            {
                query["EnablePublicSlb"] = request.EnablePublicSlb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TogglePublicSlb",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/togglePublicSlb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TogglePublicSlbResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>公网SLB开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TogglePublicSlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TogglePublicSlbResponse
        /// </returns>
        public async Task<TogglePublicSlbResponse> TogglePublicSlbWithOptionsAsync(TogglePublicSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublicSlb))
            {
                query["EnablePublicSlb"] = request.EnablePublicSlb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TogglePublicSlb",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/togglePublicSlb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TogglePublicSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>公网SLB开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TogglePublicSlbRequest
        /// </param>
        /// 
        /// <returns>
        /// TogglePublicSlbResponse
        /// </returns>
        public TogglePublicSlbResponse TogglePublicSlb(TogglePublicSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TogglePublicSlbWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>公网SLB开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TogglePublicSlbRequest
        /// </param>
        /// 
        /// <returns>
        /// TogglePublicSlbResponse
        /// </returns>
        public async Task<TogglePublicSlbResponse> TogglePublicSlbAsync(TogglePublicSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TogglePublicSlbWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified resources.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UnTagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public UnTagResourcesResponse UnTagResourcesWithOptions(UnTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnTagResourcesShrinkRequest request = new UnTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "ResourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "TagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["ResourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["TagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnTagResources",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified resources.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UnTagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public async Task<UnTagResourcesResponse> UnTagResourcesWithOptionsAsync(UnTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnTagResourcesShrinkRequest request = new UnTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "ResourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "TagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["ResourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["TagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnTagResources",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public UnTagResourcesResponse UnTagResources(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnTagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public async Task<UnTagResourcesResponse> UnTagResourcesAsync(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新备份任务描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupResponse
        /// </returns>
        public UpdateBackupResponse UpdateBackupWithOptions(UpdateBackupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTaskId))
            {
                body["backupTaskId"] = request.BackupTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBackup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backup/manage/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBackupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新备份任务描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupResponse
        /// </returns>
        public async Task<UpdateBackupResponse> UpdateBackupWithOptionsAsync(UpdateBackupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTaskId))
            {
                body["backupTaskId"] = request.BackupTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBackup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backup/manage/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新备份任务描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupResponse
        /// </returns>
        public UpdateBackupResponse UpdateBackup(UpdateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateBackupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新备份任务描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupResponse
        /// </returns>
        public async Task<UpdateBackupResponse> UpdateBackupAsync(UpdateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateBackupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupPolicyResponse
        /// </returns>
        public UpdateBackupPolicyResponse UpdateBackupPolicyWithOptions(UpdateBackupPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDays))
            {
                body["ExpireDays"] = request.ExpireDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hour))
            {
                body["Hour"] = request.Hour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minute))
            {
                body["Minute"] = request.Minute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceValues))
            {
                body["RecurrenceValues"] = request.RecurrenceValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutSeconds))
            {
                body["TimeoutSeconds"] = request.TimeoutSeconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBackupPolicy",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backupRestore/policy/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupPolicyResponse
        /// </returns>
        public async Task<UpdateBackupPolicyResponse> UpdateBackupPolicyWithOptionsAsync(UpdateBackupPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDays))
            {
                body["ExpireDays"] = request.ExpireDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hour))
            {
                body["Hour"] = request.Hour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minute))
            {
                body["Minute"] = request.Minute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceValues))
            {
                body["RecurrenceValues"] = request.RecurrenceValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutSeconds))
            {
                body["TimeoutSeconds"] = request.TimeoutSeconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBackupPolicy",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/backupRestore/policy/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupPolicyResponse
        /// </returns>
        public UpdateBackupPolicyResponse UpdateBackupPolicy(UpdateBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateBackupPolicyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新备份策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupPolicyResponse
        /// </returns>
        public async Task<UpdateBackupPolicyResponse> UpdateBackupPolicyAsync(UpdateBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateBackupPolicyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayResponse
        /// </returns>
        public UpdateGatewayResponse UpdateGatewayWithOptions(UpdateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeNodeNumber))
            {
                query["FeNodeNumber"] = request.FeNodeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                query["GatewayName"] = request.GatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGateway",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayResponse
        /// </returns>
        public async Task<UpdateGatewayResponse> UpdateGatewayWithOptionsAsync(UpdateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeNodeNumber))
            {
                query["FeNodeNumber"] = request.FeNodeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                query["GatewayName"] = request.GatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGateway",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/gateway/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayResponse
        /// </returns>
        public UpdateGatewayResponse UpdateGateway(UpdateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGatewayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayResponse
        /// </returns>
        public async Task<UpdateGatewayResponse> UpdateGatewayAsync(UpdateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGatewayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新白名单分组中的CIDR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInnerIpWhitelistGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInnerIpWhitelistGroupResponse
        /// </returns>
        public UpdateInnerIpWhitelistGroupResponse UpdateInnerIpWhitelistGroupWithOptions(UpdateInnerIpWhitelistGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CidrIpList))
            {
                body["CidrIpList"] = request.CidrIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerIpWhitelistGroupId))
            {
                body["InnerIpWhitelistGroupId"] = request.InnerIpWhitelistGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInnerIpWhitelistGroup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/securityGroup/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInnerIpWhitelistGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新白名单分组中的CIDR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInnerIpWhitelistGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInnerIpWhitelistGroupResponse
        /// </returns>
        public async Task<UpdateInnerIpWhitelistGroupResponse> UpdateInnerIpWhitelistGroupWithOptionsAsync(UpdateInnerIpWhitelistGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CidrIpList))
            {
                body["CidrIpList"] = request.CidrIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerIpWhitelistGroupId))
            {
                body["InnerIpWhitelistGroupId"] = request.InnerIpWhitelistGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInnerIpWhitelistGroup",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/securityGroup/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInnerIpWhitelistGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新白名单分组中的CIDR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInnerIpWhitelistGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInnerIpWhitelistGroupResponse
        /// </returns>
        public UpdateInnerIpWhitelistGroupResponse UpdateInnerIpWhitelistGroup(UpdateInnerIpWhitelistGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInnerIpWhitelistGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新白名单分组中的CIDR</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInnerIpWhitelistGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInnerIpWhitelistGroupResponse
        /// </returns>
        public async Task<UpdateInnerIpWhitelistGroupResponse> UpdateInnerIpWhitelistGroupAsync(UpdateInnerIpWhitelistGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInnerIpWhitelistGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
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
        public UpdateInstanceNameResponse UpdateInstanceNameWithOptions(UpdateInstanceNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceName",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/cluster/update_name",
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
        /// <para>Modifies the name of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
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
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameWithOptionsAsync(UpdateInstanceNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceName",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/cluster/update_name",
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
        /// <para>Modifies the name of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
        public UpdateInstanceNameResponse UpdateInstanceName(UpdateInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceNameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name of an E-MapReduce (EMR) Serverless StarRocks instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceNameWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新节点组描述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNodeGroupDescriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNodeGroupDescriptionResponse
        /// </returns>
        public UpdateNodeGroupDescriptionResponse UpdateNodeGroupDescriptionWithOptions(UpdateNodeGroupDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XAcsRamAuthContext))
            {
                query["X-Acs-Ram-Auth-Context"] = request.XAcsRamAuthContext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNodeGroupDescription",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/nodegroup/updateDescription",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNodeGroupDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新节点组描述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNodeGroupDescriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNodeGroupDescriptionResponse
        /// </returns>
        public async Task<UpdateNodeGroupDescriptionResponse> UpdateNodeGroupDescriptionWithOptionsAsync(UpdateNodeGroupDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XAcsRamAuthContext))
            {
                query["X-Acs-Ram-Auth-Context"] = request.XAcsRamAuthContext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNodeGroupDescription",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/nodegroup/updateDescription",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNodeGroupDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新节点组描述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNodeGroupDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNodeGroupDescriptionResponse
        /// </returns>
        public UpdateNodeGroupDescriptionResponse UpdateNodeGroupDescription(UpdateNodeGroupDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNodeGroupDescriptionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新节点组描述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNodeGroupDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNodeGroupDescriptionResponse
        /// </returns>
        public async Task<UpdateNodeGroupDescriptionResponse> UpdateNodeGroupDescriptionAsync(UpdateNodeGroupDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNodeGroupDescriptionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于开通/关闭 FE/BE的公网SLB。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePublicNetworkStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePublicNetworkStatusResponse
        /// </returns>
        public UpdatePublicNetworkStatusResponse UpdatePublicNetworkStatusWithOptions(UpdatePublicNetworkStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                query["ComponentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicNetworkEnabled))
            {
                query["PublicNetworkEnabled"] = request.PublicNetworkEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePublicNetworkStatus",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/network/updatePublicNetworkStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePublicNetworkStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于开通/关闭 FE/BE的公网SLB。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePublicNetworkStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePublicNetworkStatusResponse
        /// </returns>
        public async Task<UpdatePublicNetworkStatusResponse> UpdatePublicNetworkStatusWithOptionsAsync(UpdatePublicNetworkStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                query["ComponentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicNetworkEnabled))
            {
                query["PublicNetworkEnabled"] = request.PublicNetworkEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePublicNetworkStatus",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/network/updatePublicNetworkStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePublicNetworkStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于开通/关闭 FE/BE的公网SLB。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePublicNetworkStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePublicNetworkStatusResponse
        /// </returns>
        public UpdatePublicNetworkStatusResponse UpdatePublicNetworkStatus(UpdatePublicNetworkStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePublicNetworkStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于开通/关闭 FE/BE的公网SLB。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePublicNetworkStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePublicNetworkStatusResponse
        /// </returns>
        public async Task<UpdatePublicNetworkStatusResponse> UpdatePublicNetworkStatusAsync(UpdatePublicNetworkStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePublicNetworkStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the version of an E-MapReduce (EMR) Serverless StarRocks instance. The versions of a StarRocks instance include the major version and minor version. You can view the major version and minor version of a StarRocks instance in the Version Information section of the Instance Details tab in the EMR console. This operation can be used to upgrade the minor version or major version of a StarRocks instance. You can call the QueryUpgradableVersions operation to query the versions that you can upgrade to.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance must be in the Running state when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeVersionResponse
        /// </returns>
        public UpgradeVersionResponse UpgradeVersionWithOptions(UpgradeVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minor))
            {
                query["Minor"] = request.Minor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                query["TargetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeVersion",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/upgradeVersion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the version of an E-MapReduce (EMR) Serverless StarRocks instance. The versions of a StarRocks instance include the major version and minor version. You can view the major version and minor version of a StarRocks instance in the Version Information section of the Instance Details tab in the EMR console. This operation can be used to upgrade the minor version or major version of a StarRocks instance. You can call the QueryUpgradableVersions operation to query the versions that you can upgrade to.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance must be in the Running state when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeVersionResponse
        /// </returns>
        public async Task<UpgradeVersionResponse> UpgradeVersionWithOptionsAsync(UpgradeVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FastMode))
            {
                query["FastMode"] = request.FastMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minor))
            {
                query["Minor"] = request.Minor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                query["TargetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeVersion",
                Version = "2022-10-19",
                Protocol = "HTTPS",
                Pathname = "/webapi/starrocks/upgradeVersion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the version of an E-MapReduce (EMR) Serverless StarRocks instance. The versions of a StarRocks instance include the major version and minor version. You can view the major version and minor version of a StarRocks instance in the Version Information section of the Instance Details tab in the EMR console. This operation can be used to upgrade the minor version or major version of a StarRocks instance. You can call the QueryUpgradableVersions operation to query the versions that you can upgrade to.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance must be in the Running state when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeVersionResponse
        /// </returns>
        public UpgradeVersionResponse UpgradeVersion(UpgradeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the version of an E-MapReduce (EMR) Serverless StarRocks instance. The versions of a StarRocks instance include the major version and minor version. You can view the major version and minor version of a StarRocks instance in the Version Information section of the Instance Details tab in the EMR console. This operation can be used to upgrade the minor version or major version of a StarRocks instance. You can call the QueryUpgradableVersions operation to query the versions that you can upgrade to.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance must be in the Running state when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeVersionResponse
        /// </returns>
        public async Task<UpgradeVersionResponse> UpgradeVersionAsync(UpgradeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeVersionWithOptionsAsync(request, headers, runtime);
        }

    }
}
