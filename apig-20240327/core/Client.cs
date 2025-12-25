// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.APIG20240327.Models;

namespace AlibabaCloud.SDK.APIG20240327
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("apig", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Authorize the security group for gateway to access services</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGatewaySecurityGroupRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddGatewaySecurityGroupRuleResponse
        /// </returns>
        public AddGatewaySecurityGroupRuleResponse AddGatewaySecurityGroupRuleWithOptions(string gatewayId, AddGatewaySecurityGroupRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRanges))
            {
                body["portRanges"] = request.PortRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["securityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGatewaySecurityGroupRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/security-group-rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGatewaySecurityGroupRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorize the security group for gateway to access services</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGatewaySecurityGroupRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddGatewaySecurityGroupRuleResponse
        /// </returns>
        public async Task<AddGatewaySecurityGroupRuleResponse> AddGatewaySecurityGroupRuleWithOptionsAsync(string gatewayId, AddGatewaySecurityGroupRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRanges))
            {
                body["portRanges"] = request.PortRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["securityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGatewaySecurityGroupRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/security-group-rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGatewaySecurityGroupRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorize the security group for gateway to access services</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGatewaySecurityGroupRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// AddGatewaySecurityGroupRuleResponse
        /// </returns>
        public AddGatewaySecurityGroupRuleResponse AddGatewaySecurityGroupRule(string gatewayId, AddGatewaySecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddGatewaySecurityGroupRuleWithOptions(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorize the security group for gateway to access services</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGatewaySecurityGroupRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// AddGatewaySecurityGroupRuleResponse
        /// </returns>
        public async Task<AddGatewaySecurityGroupRuleResponse> AddGatewaySecurityGroupRuleAsync(string gatewayId, AddGatewaySecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddGatewaySecurityGroupRuleWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes consumer authentication rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteConsumerAuthorizationRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteConsumerAuthorizationRuleResponse
        /// </returns>
        public BatchDeleteConsumerAuthorizationRuleResponse BatchDeleteConsumerAuthorizationRuleWithOptions(BatchDeleteConsumerAuthorizationRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAuthorizationRuleIds))
            {
                query["consumerAuthorizationRuleIds"] = request.ConsumerAuthorizationRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/authorization-rules",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteConsumerAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes consumer authentication rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteConsumerAuthorizationRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<BatchDeleteConsumerAuthorizationRuleResponse> BatchDeleteConsumerAuthorizationRuleWithOptionsAsync(BatchDeleteConsumerAuthorizationRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAuthorizationRuleIds))
            {
                query["consumerAuthorizationRuleIds"] = request.ConsumerAuthorizationRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/authorization-rules",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteConsumerAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes consumer authentication rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteConsumerAuthorizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteConsumerAuthorizationRuleResponse
        /// </returns>
        public BatchDeleteConsumerAuthorizationRuleResponse BatchDeleteConsumerAuthorizationRule(BatchDeleteConsumerAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchDeleteConsumerAuthorizationRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes consumer authentication rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteConsumerAuthorizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<BatchDeleteConsumerAuthorizationRuleResponse> BatchDeleteConsumerAuthorizationRuleAsync(BatchDeleteConsumerAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchDeleteConsumerAuthorizationRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resource Group Transfer</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/move-resource-group",
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
        /// <para>Resource Group Transfer</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/move-resource-group",
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
        /// <para>Resource Group Transfer</para>
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
        /// <para>Resource Group Transfer</para>
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
        /// <para>Creates and associates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndAttachPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndAttachPolicyResponse
        /// </returns>
        public CreateAndAttachPolicyResponse CreateAndAttachPolicyWithOptions(CreateAndAttachPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceIds))
            {
                body["attachResourceIds"] = request.AttachResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                body["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                body["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
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
                Action = "CreateAndAttachPolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndAttachPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and associates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndAttachPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndAttachPolicyResponse
        /// </returns>
        public async Task<CreateAndAttachPolicyResponse> CreateAndAttachPolicyWithOptionsAsync(CreateAndAttachPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceIds))
            {
                body["attachResourceIds"] = request.AttachResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                body["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                body["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
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
                Action = "CreateAndAttachPolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndAttachPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and associates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndAttachPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndAttachPolicyResponse
        /// </returns>
        public CreateAndAttachPolicyResponse CreateAndAttachPolicy(CreateAndAttachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAndAttachPolicyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and associates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndAttachPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndAttachPolicyResponse
        /// </returns>
        public async Task<CreateAndAttachPolicyResponse> CreateAndAttachPolicyAsync(CreateAndAttachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAndAttachPolicyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerResponse
        /// </returns>
        public CreateConsumerResponse CreateConsumerWithOptions(CreateConsumerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkSkIdentityConfigs))
            {
                body["akSkIdentityConfigs"] = request.AkSkIdentityConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApikeyIdentityConfig))
            {
                body["apikeyIdentityConfig"] = request.ApikeyIdentityConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtIdentityConfig))
            {
                body["jwtIdentityConfig"] = request.JwtIdentityConfig;
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
                Action = "CreateConsumer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerResponse
        /// </returns>
        public async Task<CreateConsumerResponse> CreateConsumerWithOptionsAsync(CreateConsumerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkSkIdentityConfigs))
            {
                body["akSkIdentityConfigs"] = request.AkSkIdentityConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApikeyIdentityConfig))
            {
                body["apikeyIdentityConfig"] = request.ApikeyIdentityConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtIdentityConfig))
            {
                body["jwtIdentityConfig"] = request.JwtIdentityConfig;
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
                Action = "CreateConsumer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerResponse
        /// </returns>
        public CreateConsumerResponse CreateConsumer(CreateConsumerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConsumerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerResponse
        /// </returns>
        public async Task<CreateConsumerResponse> CreateConsumerAsync(CreateConsumerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConsumerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerAuthorizationRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerAuthorizationRuleResponse
        /// </returns>
        public CreateConsumerAuthorizationRuleResponse CreateConsumerAuthorizationRuleWithOptions(string consumerId, CreateConsumerAuthorizationRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationResourceInfos))
            {
                body["authorizationResourceInfos"] = request.AuthorizationResourceInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMode))
            {
                body["expireMode"] = request.ExpireMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimestamp))
            {
                body["expireTimestamp"] = request.ExpireTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentResourceType))
            {
                body["parentResourceType"] = request.ParentResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId) + "/authorization-rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerAuthorizationRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<CreateConsumerAuthorizationRuleResponse> CreateConsumerAuthorizationRuleWithOptionsAsync(string consumerId, CreateConsumerAuthorizationRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationResourceInfos))
            {
                body["authorizationResourceInfos"] = request.AuthorizationResourceInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMode))
            {
                body["expireMode"] = request.ExpireMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimestamp))
            {
                body["expireTimestamp"] = request.ExpireTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentResourceType))
            {
                body["parentResourceType"] = request.ParentResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId) + "/authorization-rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerAuthorizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerAuthorizationRuleResponse
        /// </returns>
        public CreateConsumerAuthorizationRuleResponse CreateConsumerAuthorizationRule(string consumerId, CreateConsumerAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConsumerAuthorizationRuleWithOptions(consumerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerAuthorizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<CreateConsumerAuthorizationRuleResponse> CreateConsumerAuthorizationRuleAsync(string consumerId, CreateConsumerAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConsumerAuthorizationRuleWithOptionsAsync(consumerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer authentication rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerAuthorizationRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerAuthorizationRulesResponse
        /// </returns>
        public CreateConsumerAuthorizationRulesResponse CreateConsumerAuthorizationRulesWithOptions(CreateConsumerAuthorizationRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRules))
            {
                body["authorizationRules"] = request.AuthorizationRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerAuthorizationRules",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/authorization-rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerAuthorizationRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer authentication rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerAuthorizationRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerAuthorizationRulesResponse
        /// </returns>
        public async Task<CreateConsumerAuthorizationRulesResponse> CreateConsumerAuthorizationRulesWithOptionsAsync(CreateConsumerAuthorizationRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRules))
            {
                body["authorizationRules"] = request.AuthorizationRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerAuthorizationRules",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/authorization-rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerAuthorizationRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer authentication rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerAuthorizationRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerAuthorizationRulesResponse
        /// </returns>
        public CreateConsumerAuthorizationRulesResponse CreateConsumerAuthorizationRules(CreateConsumerAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConsumerAuthorizationRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a consumer authentication rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerAuthorizationRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerAuthorizationRulesResponse
        /// </returns>
        public async Task<CreateConsumerAuthorizationRulesResponse> CreateConsumerAuthorizationRulesAsync(CreateConsumerAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConsumerAuthorizationRulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create Domain.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDomainResponse
        /// </returns>
        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertIdentifier))
            {
                body["caCertIdentifier"] = request.CaCertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                body["certIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientCACert))
            {
                body["clientCACert"] = request.ClientCACert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["forceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Option))
            {
                body["http2Option"] = request.Http2Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MTLSEnabled))
            {
                body["mTLSEnabled"] = request.MTLSEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsCipherSuitesConfig))
            {
                body["tlsCipherSuitesConfig"] = request.TlsCipherSuitesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMax))
            {
                body["tlsMax"] = request.TlsMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMin))
            {
                body["tlsMin"] = request.TlsMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create Domain.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDomainResponse
        /// </returns>
        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertIdentifier))
            {
                body["caCertIdentifier"] = request.CaCertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                body["certIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientCACert))
            {
                body["clientCACert"] = request.ClientCACert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["forceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Option))
            {
                body["http2Option"] = request.Http2Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MTLSEnabled))
            {
                body["mTLSEnabled"] = request.MTLSEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsCipherSuitesConfig))
            {
                body["tlsCipherSuitesConfig"] = request.TlsCipherSuitesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMax))
            {
                body["tlsMax"] = request.TlsMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMin))
            {
                body["tlsMin"] = request.TlsMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create Domain.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDomainResponse
        /// </returns>
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDomainWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create Domain.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDomainResponse
        /// </returns>
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDomainWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateEnvironment</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI CreateEnvironment is deprecated")]
        // Deprecated
        public CreateEnvironmentResponse CreateEnvironmentWithOptions(CreateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateEnvironment</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI CreateEnvironment is deprecated")]
        // Deprecated
        public async Task<CreateEnvironmentResponse> CreateEnvironmentWithOptionsAsync(CreateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateEnvironment</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI CreateEnvironment is deprecated")]
        // Deprecated
        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEnvironmentWithOptions(request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateEnvironment</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI CreateEnvironment is deprecated")]
        // Deprecated
        public async Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEnvironmentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud-native gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayResponse
        /// </returns>
        public CreateGatewayResponse CreateGatewayWithOptions(CreateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayEdition))
            {
                body["gatewayEdition"] = request.GatewayEdition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessConfig))
            {
                body["networkAccessConfig"] = request.NetworkAccessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["spec"] = request.Spec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneConfig))
            {
                body["zoneConfig"] = request.ZoneConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud-native gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayResponse
        /// </returns>
        public async Task<CreateGatewayResponse> CreateGatewayWithOptionsAsync(CreateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayEdition))
            {
                body["gatewayEdition"] = request.GatewayEdition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessConfig))
            {
                body["networkAccessConfig"] = request.NetworkAccessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["spec"] = request.Spec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneConfig))
            {
                body["zoneConfig"] = request.ZoneConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud-native gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayResponse
        /// </returns>
        public CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud-native gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayResponse
        /// </returns>
        public async Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiResponse
        /// </returns>
        public CreateHttpApiResponse CreateHttpApiWithOptions(CreateHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProtocols))
            {
                body["agentProtocols"] = request.AgentProtocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiProtocols))
            {
                body["aiProtocols"] = request.AiProtocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                body["authConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasePath))
            {
                body["basePath"] = request.BasePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuth))
            {
                body["enableAuth"] = request.EnableAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstByteTimeout))
            {
                body["firstByteTimeout"] = request.FirstByteTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConfig))
            {
                body["ingressConfig"] = request.IngressConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCategory))
            {
                body["modelCategory"] = request.ModelCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveBasePathOnForward))
            {
                body["removeBasePathOnForward"] = request.RemoveBasePathOnForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiResponse
        /// </returns>
        public async Task<CreateHttpApiResponse> CreateHttpApiWithOptionsAsync(CreateHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProtocols))
            {
                body["agentProtocols"] = request.AgentProtocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiProtocols))
            {
                body["aiProtocols"] = request.AiProtocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                body["authConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasePath))
            {
                body["basePath"] = request.BasePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuth))
            {
                body["enableAuth"] = request.EnableAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstByteTimeout))
            {
                body["firstByteTimeout"] = request.FirstByteTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConfig))
            {
                body["ingressConfig"] = request.IngressConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCategory))
            {
                body["modelCategory"] = request.ModelCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveBasePathOnForward))
            {
                body["removeBasePathOnForward"] = request.RemoveBasePathOnForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiResponse
        /// </returns>
        public CreateHttpApiResponse CreateHttpApi(CreateHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateHttpApiWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiResponse
        /// </returns>
        public async Task<CreateHttpApiResponse> CreateHttpApiAsync(CreateHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateHttpApiWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an Operation for HTTP API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiOperationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiOperationResponse
        /// </returns>
        public CreateHttpApiOperationResponse CreateHttpApiOperationWithOptions(string httpApiId, CreateHttpApiOperationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operations))
            {
                body["operations"] = request.Operations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiOperationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an Operation for HTTP API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiOperationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiOperationResponse
        /// </returns>
        public async Task<CreateHttpApiOperationResponse> CreateHttpApiOperationWithOptionsAsync(string httpApiId, CreateHttpApiOperationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operations))
            {
                body["operations"] = request.Operations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an Operation for HTTP API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiOperationResponse
        /// </returns>
        public CreateHttpApiOperationResponse CreateHttpApiOperation(string httpApiId, CreateHttpApiOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateHttpApiOperationWithOptions(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an Operation for HTTP API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiOperationResponse
        /// </returns>
        public async Task<CreateHttpApiOperationResponse> CreateHttpApiOperationAsync(string httpApiId, CreateHttpApiOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateHttpApiOperationWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a route for an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiRouteResponse
        /// </returns>
        public CreateHttpApiRouteResponse CreateHttpApiRouteWithOptions(string httpApiId, CreateHttpApiRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpRouteConfig))
            {
                body["mcpRouteConfig"] = request.McpRouteConfig;
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
                Action = "CreateHttpApiRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a route for an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiRouteResponse
        /// </returns>
        public async Task<CreateHttpApiRouteResponse> CreateHttpApiRouteWithOptionsAsync(string httpApiId, CreateHttpApiRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpRouteConfig))
            {
                body["mcpRouteConfig"] = request.McpRouteConfig;
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
                Action = "CreateHttpApiRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a route for an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiRouteResponse
        /// </returns>
        public CreateHttpApiRouteResponse CreateHttpApiRoute(string httpApiId, CreateHttpApiRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateHttpApiRouteWithOptions(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a route for an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHttpApiRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHttpApiRouteResponse
        /// </returns>
        public async Task<CreateHttpApiRouteResponse> CreateHttpApiRouteAsync(string httpApiId, CreateHttpApiRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateHttpApiRouteWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an MCP server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpServerResponse
        /// </returns>
        public CreateMcpServerResponse CreateMcpServerWithOptions(CreateMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssembledSources))
            {
                body["assembledSources"] = request.AssembledSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromType))
            {
                body["createFromType"] = request.CreateFromType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExposedUriPath))
            {
                body["exposedUriPath"] = request.ExposedUriPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayMcpServerConfigs))
            {
                body["grayMcpServerConfigs"] = request.GrayMcpServerConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpStatisticsEnable))
            {
                body["mcpStatisticsEnable"] = request.McpStatisticsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an MCP server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpServerResponse
        /// </returns>
        public async Task<CreateMcpServerResponse> CreateMcpServerWithOptionsAsync(CreateMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssembledSources))
            {
                body["assembledSources"] = request.AssembledSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromType))
            {
                body["createFromType"] = request.CreateFromType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExposedUriPath))
            {
                body["exposedUriPath"] = request.ExposedUriPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayMcpServerConfigs))
            {
                body["grayMcpServerConfigs"] = request.GrayMcpServerConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpStatisticsEnable))
            {
                body["mcpStatisticsEnable"] = request.McpStatisticsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an MCP server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpServerResponse
        /// </returns>
        public CreateMcpServerResponse CreateMcpServer(CreateMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMcpServerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an MCP server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpServerResponse
        /// </returns>
        public async Task<CreateMcpServerResponse> CreateMcpServerAsync(CreateMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMcpServerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches a plug-in.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePluginAttachmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePluginAttachmentResponse
        /// </returns>
        public CreatePluginAttachmentResponse CreatePluginAttachmentWithOptions(CreatePluginAttachmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceIds))
            {
                body["attachResourceIds"] = request.AttachResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                body["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginConfig))
            {
                body["pluginConfig"] = request.PluginConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                body["pluginId"] = request.PluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePluginAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePluginAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches a plug-in.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePluginAttachmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePluginAttachmentResponse
        /// </returns>
        public async Task<CreatePluginAttachmentResponse> CreatePluginAttachmentWithOptionsAsync(CreatePluginAttachmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceIds))
            {
                body["attachResourceIds"] = request.AttachResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                body["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginConfig))
            {
                body["pluginConfig"] = request.PluginConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                body["pluginId"] = request.PluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePluginAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePluginAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches a plug-in.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePluginAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePluginAttachmentResponse
        /// </returns>
        public CreatePluginAttachmentResponse CreatePluginAttachment(CreatePluginAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePluginAttachmentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches a plug-in.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePluginAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePluginAttachmentResponse
        /// </returns>
        public async Task<CreatePluginAttachmentResponse> CreatePluginAttachmentAsync(CreatePluginAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePluginAttachmentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public CreatePolicyResponse CreatePolicyWithOptions(CreatePolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                body["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
                Action = "CreatePolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v2/policies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public async Task<CreatePolicyResponse> CreatePolicyWithOptionsAsync(CreatePolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                body["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
                Action = "CreatePolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v2/policies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePolicyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePolicyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create policy resource mount</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyAttachmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyAttachmentResponse
        /// </returns>
        public CreatePolicyAttachmentResponse CreatePolicyAttachmentWithOptions(CreatePolicyAttachmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                body["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                body["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["policyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policy-attachments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create policy resource mount</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyAttachmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyAttachmentResponse
        /// </returns>
        public async Task<CreatePolicyAttachmentResponse> CreatePolicyAttachmentWithOptionsAsync(CreatePolicyAttachmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                body["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                body["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["policyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policy-attachments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create policy resource mount</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyAttachmentResponse
        /// </returns>
        public CreatePolicyAttachmentResponse CreatePolicyAttachment(CreatePolicyAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePolicyAttachmentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create policy resource mount</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyAttachmentResponse
        /// </returns>
        public async Task<CreatePolicyAttachmentResponse> CreatePolicyAttachmentAsync(CreatePolicyAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePolicyAttachmentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceConfigs))
            {
                body["serviceConfigs"] = request.ServiceConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceConfigs))
            {
                body["serviceConfigs"] = request.ServiceConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceVersionResponse
        /// </returns>
        public CreateServiceVersionResponse CreateServiceVersionWithOptions(string serviceId, CreateServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
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
                Action = "CreateServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceVersionResponse
        /// </returns>
        public async Task<CreateServiceVersionResponse> CreateServiceVersionWithOptionsAsync(string serviceId, CreateServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
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
                Action = "CreateServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceVersionResponse
        /// </returns>
        public CreateServiceVersionResponse CreateServiceVersion(string serviceId, CreateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceVersionWithOptions(serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceVersionResponse
        /// </returns>
        public async Task<CreateServiceVersionResponse> CreateServiceVersionAsync(string serviceId, CreateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceVersionWithOptionsAsync(serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建服务来源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSourceResponse
        /// </returns>
        public CreateSourceResponse CreateSourceWithOptions(CreateSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sSourceConfig))
            {
                body["k8sSourceConfig"] = request.K8sSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosSourceConfig))
            {
                body["nacosSourceConfig"] = request.NacosSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建服务来源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSourceResponse
        /// </returns>
        public async Task<CreateSourceResponse> CreateSourceWithOptionsAsync(CreateSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sSourceConfig))
            {
                body["k8sSourceConfig"] = request.K8sSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosSourceConfig))
            {
                body["nacosSourceConfig"] = request.NacosSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建服务来源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSourceResponse
        /// </returns>
        public CreateSourceResponse CreateSource(CreateSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建服务来源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSourceResponse
        /// </returns>
        public async Task<CreateSourceResponse> CreateSourceAsync(CreateSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer.</para>
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
        /// DeleteConsumerResponse
        /// </returns>
        public DeleteConsumerResponse DeleteConsumerWithOptions(string consumerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer.</para>
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
        /// DeleteConsumerResponse
        /// </returns>
        public async Task<DeleteConsumerResponse> DeleteConsumerWithOptionsAsync(string consumerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteConsumerResponse
        /// </returns>
        public DeleteConsumerResponse DeleteConsumer(string consumerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConsumerWithOptions(consumerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteConsumerResponse
        /// </returns>
        public async Task<DeleteConsumerResponse> DeleteConsumerAsync(string consumerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConsumerWithOptionsAsync(consumerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer authorization rule.</para>
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
        /// DeleteConsumerAuthorizationRuleResponse
        /// </returns>
        public DeleteConsumerAuthorizationRuleResponse DeleteConsumerAuthorizationRuleWithOptions(string consumerAuthorizationRuleId, string consumerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId) + "/authorization-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerAuthorizationRuleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer authorization rule.</para>
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
        /// DeleteConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<DeleteConsumerAuthorizationRuleResponse> DeleteConsumerAuthorizationRuleWithOptionsAsync(string consumerAuthorizationRuleId, string consumerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId) + "/authorization-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerAuthorizationRuleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteConsumerAuthorizationRuleResponse
        /// </returns>
        public DeleteConsumerAuthorizationRuleResponse DeleteConsumerAuthorizationRule(string consumerAuthorizationRuleId, string consumerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConsumerAuthorizationRuleWithOptions(consumerAuthorizationRuleId, consumerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<DeleteConsumerAuthorizationRuleResponse> DeleteConsumerAuthorizationRuleAsync(string consumerAuthorizationRuleId, string consumerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConsumerAuthorizationRuleWithOptionsAsync(consumerAuthorizationRuleId, consumerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteDomain</para>
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
        /// DeleteDomainResponse
        /// </returns>
        public DeleteDomainResponse DeleteDomainWithOptions(string domainId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteDomain</para>
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
        /// DeleteDomainResponse
        /// </returns>
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(string domainId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteDomain</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDomainResponse
        /// </returns>
        public DeleteDomainResponse DeleteDomain(string domainId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDomainWithOptions(domainId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteDomain</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDomainResponse
        /// </returns>
        public async Task<DeleteDomainResponse> DeleteDomainAsync(string domainId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDomainWithOptionsAsync(domainId, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteEnvironment</para>
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
        /// DeleteEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteEnvironment is deprecated")]
        // Deprecated
        public DeleteEnvironmentResponse DeleteEnvironmentWithOptions(string environmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteEnvironment</para>
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
        /// DeleteEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteEnvironment is deprecated")]
        // Deprecated
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentWithOptionsAsync(string environmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteEnvironment</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteEnvironment is deprecated")]
        // Deprecated
        public DeleteEnvironmentResponse DeleteEnvironment(string environmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEnvironmentWithOptions(environmentId, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteEnvironment</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteEnvironment is deprecated")]
        // Deprecated
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(string environmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEnvironmentWithOptionsAsync(environmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Gateway</para>
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
        /// DeleteGatewayResponse
        /// </returns>
        public DeleteGatewayResponse DeleteGatewayWithOptions(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Gateway</para>
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
        /// DeleteGatewayResponse
        /// </returns>
        public async Task<DeleteGatewayResponse> DeleteGatewayWithOptionsAsync(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Gateway</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public DeleteGatewayResponse DeleteGateway(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayWithOptions(gatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Gateway</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public async Task<DeleteGatewayResponse> DeleteGatewayAsync(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayWithOptionsAsync(gatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the security group rule of a gateway</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewaySecurityGroupRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewaySecurityGroupRuleResponse
        /// </returns>
        public DeleteGatewaySecurityGroupRuleResponse DeleteGatewaySecurityGroupRuleWithOptions(string gatewayId, string securityGroupRuleId, DeleteGatewaySecurityGroupRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CascadingDelete))
            {
                query["cascadingDelete"] = request.CascadingDelete;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewaySecurityGroupRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/security-group-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(securityGroupRuleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewaySecurityGroupRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the security group rule of a gateway</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewaySecurityGroupRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewaySecurityGroupRuleResponse
        /// </returns>
        public async Task<DeleteGatewaySecurityGroupRuleResponse> DeleteGatewaySecurityGroupRuleWithOptionsAsync(string gatewayId, string securityGroupRuleId, DeleteGatewaySecurityGroupRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CascadingDelete))
            {
                query["cascadingDelete"] = request.CascadingDelete;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewaySecurityGroupRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/security-group-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(securityGroupRuleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewaySecurityGroupRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the security group rule of a gateway</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewaySecurityGroupRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewaySecurityGroupRuleResponse
        /// </returns>
        public DeleteGatewaySecurityGroupRuleResponse DeleteGatewaySecurityGroupRule(string gatewayId, string securityGroupRuleId, DeleteGatewaySecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewaySecurityGroupRuleWithOptions(gatewayId, securityGroupRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the security group rule of a gateway</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewaySecurityGroupRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewaySecurityGroupRuleResponse
        /// </returns>
        public async Task<DeleteGatewaySecurityGroupRuleResponse> DeleteGatewaySecurityGroupRuleAsync(string gatewayId, string securityGroupRuleId, DeleteGatewaySecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewaySecurityGroupRuleWithOptionsAsync(gatewayId, securityGroupRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an HTTP API.</para>
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
        /// DeleteHttpApiResponse
        /// </returns>
        public DeleteHttpApiResponse DeleteHttpApiWithOptions(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an HTTP API.</para>
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
        /// DeleteHttpApiResponse
        /// </returns>
        public async Task<DeleteHttpApiResponse> DeleteHttpApiWithOptionsAsync(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an HTTP API.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteHttpApiResponse
        /// </returns>
        public DeleteHttpApiResponse DeleteHttpApi(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHttpApiWithOptions(httpApiId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an HTTP API.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteHttpApiResponse
        /// </returns>
        public async Task<DeleteHttpApiResponse> DeleteHttpApiAsync(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHttpApiWithOptionsAsync(httpApiId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Operation</para>
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
        /// DeleteHttpApiOperationResponse
        /// </returns>
        public DeleteHttpApiOperationResponse DeleteHttpApiOperationWithOptions(string httpApiId, string operationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiOperationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Operation</para>
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
        /// DeleteHttpApiOperationResponse
        /// </returns>
        public async Task<DeleteHttpApiOperationResponse> DeleteHttpApiOperationWithOptionsAsync(string httpApiId, string operationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Operation</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteHttpApiOperationResponse
        /// </returns>
        public DeleteHttpApiOperationResponse DeleteHttpApiOperation(string httpApiId, string operationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHttpApiOperationWithOptions(httpApiId, operationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Operation</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteHttpApiOperationResponse
        /// </returns>
        public async Task<DeleteHttpApiOperationResponse> DeleteHttpApiOperationAsync(string httpApiId, string operationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHttpApiOperationWithOptionsAsync(httpApiId, operationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the route of an HttpApi</para>
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
        /// DeleteHttpApiRouteResponse
        /// </returns>
        public DeleteHttpApiRouteResponse DeleteHttpApiRouteWithOptions(string httpApiId, string routeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApiRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(routeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the route of an HttpApi</para>
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
        /// DeleteHttpApiRouteResponse
        /// </returns>
        public async Task<DeleteHttpApiRouteResponse> DeleteHttpApiRouteWithOptionsAsync(string httpApiId, string routeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApiRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(routeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the route of an HttpApi</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteHttpApiRouteResponse
        /// </returns>
        public DeleteHttpApiRouteResponse DeleteHttpApiRoute(string httpApiId, string routeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHttpApiRouteWithOptions(httpApiId, routeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete the route of an HttpApi</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteHttpApiRouteResponse
        /// </returns>
        public async Task<DeleteHttpApiRouteResponse> DeleteHttpApiRouteAsync(string httpApiId, string routeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHttpApiRouteWithOptionsAsync(httpApiId, routeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除MCP server</para>
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
        /// DeleteMcpServerResponse
        /// </returns>
        public DeleteMcpServerResponse DeleteMcpServerWithOptions(string mcpServerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除MCP server</para>
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
        /// DeleteMcpServerResponse
        /// </returns>
        public async Task<DeleteMcpServerResponse> DeleteMcpServerWithOptionsAsync(string mcpServerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除MCP server</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMcpServerResponse
        /// </returns>
        public DeleteMcpServerResponse DeleteMcpServer(string mcpServerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMcpServerWithOptions(mcpServerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除MCP server</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMcpServerResponse
        /// </returns>
        public async Task<DeleteMcpServerResponse> DeleteMcpServerAsync(string mcpServerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMcpServerWithOptionsAsync(mcpServerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a plug-in attachment.</para>
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
        /// DeletePluginAttachmentResponse
        /// </returns>
        public DeletePluginAttachmentResponse DeletePluginAttachmentWithOptions(string pluginAttachmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePluginAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginAttachmentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePluginAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a plug-in attachment.</para>
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
        /// DeletePluginAttachmentResponse
        /// </returns>
        public async Task<DeletePluginAttachmentResponse> DeletePluginAttachmentWithOptionsAsync(string pluginAttachmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePluginAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginAttachmentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePluginAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a plug-in attachment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePluginAttachmentResponse
        /// </returns>
        public DeletePluginAttachmentResponse DeletePluginAttachment(string pluginAttachmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePluginAttachmentWithOptions(pluginAttachmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a plug-in attachment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePluginAttachmentResponse
        /// </returns>
        public async Task<DeletePluginAttachmentResponse> DeletePluginAttachmentAsync(string pluginAttachmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePluginAttachmentWithOptionsAsync(pluginAttachmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Policy</para>
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
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicyWithOptions(string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v2/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Policy</para>
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
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyWithOptionsAsync(string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v2/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Policy</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicy(string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePolicyWithOptions(policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Policy</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePolicyWithOptionsAsync(policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete policy resource attachment</para>
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
        /// DeletePolicyAttachmentResponse
        /// </returns>
        public DeletePolicyAttachmentResponse DeletePolicyAttachmentWithOptions(string policyAttachmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policy-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyAttachmentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete policy resource attachment</para>
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
        /// DeletePolicyAttachmentResponse
        /// </returns>
        public async Task<DeletePolicyAttachmentResponse> DeletePolicyAttachmentWithOptionsAsync(string policyAttachmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policy-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyAttachmentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete policy resource attachment</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePolicyAttachmentResponse
        /// </returns>
        public DeletePolicyAttachmentResponse DeletePolicyAttachment(string policyAttachmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePolicyAttachmentWithOptions(policyAttachmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete policy resource attachment</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePolicyAttachmentResponse
        /// </returns>
        public async Task<DeletePolicyAttachmentResponse> DeletePolicyAttachmentAsync(string policyAttachmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePolicyAttachmentWithOptionsAsync(policyAttachmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service.</para>
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
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteServiceWithOptions(string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service.</para>
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
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteService(string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceAsync(string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service version.</para>
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
        /// DeleteServiceVersionResponse
        /// </returns>
        public DeleteServiceVersionResponse DeleteServiceVersionWithOptions(string serviceId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service version.</para>
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
        /// DeleteServiceVersionResponse
        /// </returns>
        public async Task<DeleteServiceVersionResponse> DeleteServiceVersionWithOptionsAsync(string serviceId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service version.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceVersionResponse
        /// </returns>
        public DeleteServiceVersionResponse DeleteServiceVersion(string serviceId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceVersionWithOptions(serviceId, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service version.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceVersionResponse
        /// </returns>
        public async Task<DeleteServiceVersionResponse> DeleteServiceVersionAsync(string serviceId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceVersionWithOptionsAsync(serviceId, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除服务来源</para>
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
        /// DeleteSourceResponse
        /// </returns>
        public DeleteSourceResponse DeleteSourceWithOptions(string sourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除服务来源</para>
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
        /// DeleteSourceResponse
        /// </returns>
        public async Task<DeleteSourceResponse> DeleteSourceWithOptionsAsync(string sourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除服务来源</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSourceResponse
        /// </returns>
        public DeleteSourceResponse DeleteSource(string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSourceWithOptions(sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除服务来源</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSourceResponse
        /// </returns>
        public async Task<DeleteSourceResponse> DeleteSourceAsync(string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSourceWithOptionsAsync(sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploy HttpApi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployHttpApiResponse
        /// </returns>
        public DeployHttpApiResponse DeployHttpApiWithOptions(string httpApiId, DeployHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiConfig))
            {
                body["httpApiConfig"] = request.HttpApiConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestApiConfig))
            {
                body["restApiConfig"] = request.RestApiConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteId))
            {
                body["routeId"] = request.RouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploy HttpApi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployHttpApiResponse
        /// </returns>
        public async Task<DeployHttpApiResponse> DeployHttpApiWithOptionsAsync(string httpApiId, DeployHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiConfig))
            {
                body["httpApiConfig"] = request.HttpApiConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestApiConfig))
            {
                body["restApiConfig"] = request.RestApiConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteId))
            {
                body["routeId"] = request.RouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploy HttpApi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployHttpApiResponse
        /// </returns>
        public DeployHttpApiResponse DeployHttpApi(string httpApiId, DeployHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployHttpApiWithOptions(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploy HttpApi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployHttpApiResponse
        /// </returns>
        public async Task<DeployHttpApiResponse> DeployHttpApiAsync(string httpApiId, DeployHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployHttpApiWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an MCP server.</para>
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
        /// DeployMcpServerResponse
        /// </returns>
        public DeployMcpServerResponse DeployMcpServerWithOptions(string mcpServerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId) + "/deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an MCP server.</para>
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
        /// DeployMcpServerResponse
        /// </returns>
        public async Task<DeployMcpServerResponse> DeployMcpServerWithOptionsAsync(string mcpServerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId) + "/deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an MCP server.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeployMcpServerResponse
        /// </returns>
        public DeployMcpServerResponse DeployMcpServer(string mcpServerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployMcpServerWithOptions(mcpServerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an MCP server.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeployMcpServerResponse
        /// </returns>
        public async Task<DeployMcpServerResponse> DeployMcpServerAsync(string mcpServerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployMcpServerWithOptionsAsync(mcpServerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Export HTTP API</para>
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
        /// ExportHttpApiResponse
        /// </returns>
        public ExportHttpApiResponse ExportHttpApiWithOptions(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Export HTTP API</para>
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
        /// ExportHttpApiResponse
        /// </returns>
        public async Task<ExportHttpApiResponse> ExportHttpApiWithOptionsAsync(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Export HTTP API</para>
        /// </summary>
        /// 
        /// <returns>
        /// ExportHttpApiResponse
        /// </returns>
        public ExportHttpApiResponse ExportHttpApi(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExportHttpApiWithOptions(httpApiId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Export HTTP API</para>
        /// </summary>
        /// 
        /// <returns>
        /// ExportHttpApiResponse
        /// </returns>
        public async Task<ExportHttpApiResponse> ExportHttpApiAsync(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExportHttpApiWithOptionsAsync(httpApiId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information of a consumer.</para>
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
        /// GetConsumerResponse
        /// </returns>
        public GetConsumerResponse GetConsumerWithOptions(string consumerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information of a consumer.</para>
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
        /// GetConsumerResponse
        /// </returns>
        public async Task<GetConsumerResponse> GetConsumerWithOptionsAsync(string consumerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information of a consumer.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetConsumerResponse
        /// </returns>
        public GetConsumerResponse GetConsumer(string consumerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConsumerWithOptions(consumerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information of a consumer.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetConsumerResponse
        /// </returns>
        public async Task<GetConsumerResponse> GetConsumerAsync(string consumerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConsumerWithOptionsAsync(consumerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a consumer authentication rule.</para>
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
        /// GetConsumerAuthorizationRuleResponse
        /// </returns>
        public GetConsumerAuthorizationRuleResponse GetConsumerAuthorizationRuleWithOptions(string consumerAuthorizationRuleId, string consumerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId) + "/authorization-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerAuthorizationRuleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a consumer authentication rule.</para>
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
        /// GetConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<GetConsumerAuthorizationRuleResponse> GetConsumerAuthorizationRuleWithOptionsAsync(string consumerAuthorizationRuleId, string consumerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId) + "/authorization-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerAuthorizationRuleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a consumer authentication rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetConsumerAuthorizationRuleResponse
        /// </returns>
        public GetConsumerAuthorizationRuleResponse GetConsumerAuthorizationRule(string consumerAuthorizationRuleId, string consumerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConsumerAuthorizationRuleWithOptions(consumerAuthorizationRuleId, consumerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a consumer authentication rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<GetConsumerAuthorizationRuleResponse> GetConsumerAuthorizationRuleAsync(string consumerAuthorizationRuleId, string consumerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConsumerAuthorizationRuleWithOptionsAsync(consumerAuthorizationRuleId, consumerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains data from dashboards.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDashboardRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDashboardResponse
        /// </returns>
        public GetDashboardResponse GetDashboardWithOptions(string gatewayId, GetDashboardRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDashboardShrinkRequest request = new GetDashboardShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["apiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginClassId))
            {
                query["pluginClassId"] = request.PluginClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteId))
            {
                query["routeId"] = request.RouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpstreamCluster))
            {
                query["upstreamCluster"] = request.UpstreamCluster;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDashboard",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/dashboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDashboardResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains data from dashboards.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDashboardRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDashboardResponse
        /// </returns>
        public async Task<GetDashboardResponse> GetDashboardWithOptionsAsync(string gatewayId, GetDashboardRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDashboardShrinkRequest request = new GetDashboardShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["apiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginClassId))
            {
                query["pluginClassId"] = request.PluginClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteId))
            {
                query["routeId"] = request.RouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpstreamCluster))
            {
                query["upstreamCluster"] = request.UpstreamCluster;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDashboard",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/dashboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDashboardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains data from dashboards.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDashboardRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDashboardResponse
        /// </returns>
        public GetDashboardResponse GetDashboard(string gatewayId, GetDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDashboardWithOptions(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains data from dashboards.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDashboardRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDashboardResponse
        /// </returns>
        public async Task<GetDashboardResponse> GetDashboardAsync(string gatewayId, GetDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDashboardWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDomainResponse
        /// </returns>
        public GetDomainResponse GetDomainWithOptions(string domainId, GetDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatistics))
            {
                query["withStatistics"] = request.WithStatistics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDomainResponse
        /// </returns>
        public async Task<GetDomainResponse> GetDomainWithOptionsAsync(string domainId, GetDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatistics))
            {
                query["withStatistics"] = request.WithStatistics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDomainResponse
        /// </returns>
        public GetDomainResponse GetDomain(string domainId, GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDomainWithOptions(domainId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDomainResponse
        /// </returns>
        public async Task<GetDomainResponse> GetDomainAsync(string domainId, GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDomainWithOptionsAsync(domainId, request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetEnvironment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI GetEnvironment is deprecated")]
        // Deprecated
        public GetEnvironmentResponse GetEnvironmentWithOptions(string environmentId, GetEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatistics))
            {
                query["withStatistics"] = request.WithStatistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithVpcInfo))
            {
                query["withVpcInfo"] = request.WithVpcInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetEnvironment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI GetEnvironment is deprecated")]
        // Deprecated
        public async Task<GetEnvironmentResponse> GetEnvironmentWithOptionsAsync(string environmentId, GetEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatistics))
            {
                query["withStatistics"] = request.WithStatistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithVpcInfo))
            {
                query["withVpcInfo"] = request.WithVpcInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetEnvironment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI GetEnvironment is deprecated")]
        // Deprecated
        public GetEnvironmentResponse GetEnvironment(string environmentId, GetEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentWithOptions(environmentId, request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetEnvironment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI GetEnvironment is deprecated")]
        // Deprecated
        public async Task<GetEnvironmentResponse> GetEnvironmentAsync(string environmentId, GetEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentWithOptionsAsync(environmentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about an instance, such as the virtual private cloud (VPC) and vSwitch to which the instance belongs and its ingress.</para>
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
        /// GetGatewayResponse
        /// </returns>
        public GetGatewayResponse GetGatewayWithOptions(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about an instance, such as the virtual private cloud (VPC) and vSwitch to which the instance belongs and its ingress.</para>
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
        /// GetGatewayResponse
        /// </returns>
        public async Task<GetGatewayResponse> GetGatewayWithOptionsAsync(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about an instance, such as the virtual private cloud (VPC) and vSwitch to which the instance belongs and its ingress.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGatewayResponse
        /// </returns>
        public GetGatewayResponse GetGateway(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGatewayWithOptions(gatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about an instance, such as the virtual private cloud (VPC) and vSwitch to which the instance belongs and its ingress.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGatewayResponse
        /// </returns>
        public async Task<GetGatewayResponse> GetGatewayAsync(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGatewayWithOptionsAsync(gatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Read HttpApi</para>
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
        /// GetHttpApiResponse
        /// </returns>
        public GetHttpApiResponse GetHttpApiWithOptions(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Read HttpApi</para>
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
        /// GetHttpApiResponse
        /// </returns>
        public async Task<GetHttpApiResponse> GetHttpApiWithOptionsAsync(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Read HttpApi</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetHttpApiResponse
        /// </returns>
        public GetHttpApiResponse GetHttpApi(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHttpApiWithOptions(httpApiId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Read HttpApi</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetHttpApiResponse
        /// </returns>
        public async Task<GetHttpApiResponse> GetHttpApiAsync(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHttpApiWithOptionsAsync(httpApiId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Operation</para>
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
        /// GetHttpApiOperationResponse
        /// </returns>
        public GetHttpApiOperationResponse GetHttpApiOperationWithOptions(string httpApiId, string operationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiOperationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Operation</para>
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
        /// GetHttpApiOperationResponse
        /// </returns>
        public async Task<GetHttpApiOperationResponse> GetHttpApiOperationWithOptionsAsync(string httpApiId, string operationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Operation</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetHttpApiOperationResponse
        /// </returns>
        public GetHttpApiOperationResponse GetHttpApiOperation(string httpApiId, string operationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHttpApiOperationWithOptions(httpApiId, operationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Operation</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetHttpApiOperationResponse
        /// </returns>
        public async Task<GetHttpApiOperationResponse> GetHttpApiOperationAsync(string httpApiId, string operationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHttpApiOperationWithOptionsAsync(httpApiId, operationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a route of an HTTP API.</para>
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
        /// GetHttpApiRouteResponse
        /// </returns>
        public GetHttpApiRouteResponse GetHttpApiRouteWithOptions(string httpApiId, string routeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApiRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(routeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a route of an HTTP API.</para>
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
        /// GetHttpApiRouteResponse
        /// </returns>
        public async Task<GetHttpApiRouteResponse> GetHttpApiRouteWithOptionsAsync(string httpApiId, string routeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApiRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(routeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a route of an HTTP API.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetHttpApiRouteResponse
        /// </returns>
        public GetHttpApiRouteResponse GetHttpApiRoute(string httpApiId, string routeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHttpApiRouteWithOptions(httpApiId, routeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a route of an HTTP API.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetHttpApiRouteResponse
        /// </returns>
        public async Task<GetHttpApiRouteResponse> GetHttpApiRouteAsync(string httpApiId, string routeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHttpApiRouteWithOptionsAsync(httpApiId, routeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information of an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcpServerResponse
        /// </returns>
        public GetMcpServerResponse GetMcpServerWithOptions(string mcpServerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information of an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcpServerResponse
        /// </returns>
        public async Task<GetMcpServerResponse> GetMcpServerWithOptionsAsync(string mcpServerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information of an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetMcpServerResponse
        /// </returns>
        public GetMcpServerResponse GetMcpServer(string mcpServerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMcpServerWithOptions(mcpServerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information of an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetMcpServerResponse
        /// </returns>
        public async Task<GetMcpServerResponse> GetMcpServerAsync(string mcpServerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMcpServerWithOptionsAsync(mcpServerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a plug-in attachment.</para>
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
        /// GetPluginAttachmentResponse
        /// </returns>
        public GetPluginAttachmentResponse GetPluginAttachmentWithOptions(string pluginAttachmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPluginAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginAttachmentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPluginAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a plug-in attachment.</para>
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
        /// GetPluginAttachmentResponse
        /// </returns>
        public async Task<GetPluginAttachmentResponse> GetPluginAttachmentWithOptionsAsync(string pluginAttachmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPluginAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginAttachmentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPluginAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a plug-in attachment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPluginAttachmentResponse
        /// </returns>
        public GetPluginAttachmentResponse GetPluginAttachment(string pluginAttachmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPluginAttachmentWithOptions(pluginAttachmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a plug-in attachment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPluginAttachmentResponse
        /// </returns>
        public async Task<GetPluginAttachmentResponse> GetPluginAttachmentAsync(string pluginAttachmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPluginAttachmentWithOptionsAsync(pluginAttachmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a policy.</para>
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
        /// GetPolicyResponse
        /// </returns>
        public GetPolicyResponse GetPolicyWithOptions(string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v2/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a policy.</para>
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
        /// GetPolicyResponse
        /// </returns>
        public async Task<GetPolicyResponse> GetPolicyWithOptionsAsync(string policyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v2/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a policy.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public GetPolicyResponse GetPolicy(string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPolicyWithOptions(policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a policy.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public async Task<GetPolicyResponse> GetPolicyAsync(string policyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPolicyWithOptionsAsync(policyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Policy Resource Attachment</para>
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
        /// GetPolicyAttachmentResponse
        /// </returns>
        public GetPolicyAttachmentResponse GetPolicyAttachmentWithOptions(string policyAttachmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicyAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policy-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyAttachmentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Policy Resource Attachment</para>
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
        /// GetPolicyAttachmentResponse
        /// </returns>
        public async Task<GetPolicyAttachmentResponse> GetPolicyAttachmentWithOptionsAsync(string policyAttachmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicyAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policy-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyAttachmentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Policy Resource Attachment</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPolicyAttachmentResponse
        /// </returns>
        public GetPolicyAttachmentResponse GetPolicyAttachment(string policyAttachmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPolicyAttachmentWithOptions(policyAttachmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Policy Resource Attachment</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPolicyAttachmentResponse
        /// </returns>
        public async Task<GetPolicyAttachmentResponse> GetPolicyAttachmentAsync(string policyAttachmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPolicyAttachmentWithOptionsAsync(policyAttachmentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get resource overview information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceOverviewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceOverviewResponse
        /// </returns>
        public GetResourceOverviewResponse GetResourceOverviewWithOptions(GetResourceOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceOverview",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/overview/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceOverviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get resource overview information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceOverviewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceOverviewResponse
        /// </returns>
        public async Task<GetResourceOverviewResponse> GetResourceOverviewWithOptionsAsync(GetResourceOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceOverview",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/overview/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get resource overview information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceOverviewResponse
        /// </returns>
        public GetResourceOverviewResponse GetResourceOverview(GetResourceOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceOverviewWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get resource overview information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceOverviewResponse
        /// </returns>
        public async Task<GetResourceOverviewResponse> GetResourceOverviewAsync(GetResourceOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceOverviewWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a service.</para>
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
        /// GetServiceResponse
        /// </returns>
        public GetServiceResponse GetServiceWithOptions(string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a service.</para>
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
        /// GetServiceResponse
        /// </returns>
        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public GetServiceResponse GetService(string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceWithOptions(serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public async Task<GetServiceResponse> GetServiceAsync(string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceWithOptionsAsync(serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a service source.</para>
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
        /// GetSourceResponse
        /// </returns>
        public GetSourceResponse GetSourceWithOptions(string sourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a service source.</para>
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
        /// GetSourceResponse
        /// </returns>
        public async Task<GetSourceResponse> GetSourceWithOptionsAsync(string sourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a service source.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSourceResponse
        /// </returns>
        public GetSourceResponse GetSource(string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSourceWithOptions(sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a service source.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSourceResponse
        /// </returns>
        public async Task<GetSourceResponse> GetSourceAsync(string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSourceWithOptionsAsync(sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve Tracing Configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTraceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTraceConfigResponse
        /// </returns>
        public GetTraceConfigResponse GetTraceConfigWithOptions(string gatewayId, GetTraceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTraceConfig",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/trace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTraceConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve Tracing Configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTraceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTraceConfigResponse
        /// </returns>
        public async Task<GetTraceConfigResponse> GetTraceConfigWithOptionsAsync(string gatewayId, GetTraceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTraceConfig",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/trace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTraceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve Tracing Configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTraceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTraceConfigResponse
        /// </returns>
        public GetTraceConfigResponse GetTraceConfig(string gatewayId, GetTraceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTraceConfigWithOptions(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve Tracing Configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTraceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTraceConfigResponse
        /// </returns>
        public async Task<GetTraceConfigResponse> GetTraceConfigAsync(string gatewayId, GetTraceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTraceConfigWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports HTTP APIs. You can call this operation to import OpenAPI 2.0 and OpenAPI 3.0.x definition files to create REST APIs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportHttpApiResponse
        /// </returns>
        public ImportHttpApiResponse ImportHttpApiWithOptions(ImportHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpRouteId))
            {
                body["mcpRouteId"] = request.McpRouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecContentBase64))
            {
                body["specContentBase64"] = request.SpecContentBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecFileUrl))
            {
                body["specFileUrl"] = request.SpecFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecOssConfig))
            {
                body["specOssConfig"] = request.SpecOssConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHttpApiId))
            {
                body["targetHttpApiId"] = request.TargetHttpApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports HTTP APIs. You can call this operation to import OpenAPI 2.0 and OpenAPI 3.0.x definition files to create REST APIs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportHttpApiResponse
        /// </returns>
        public async Task<ImportHttpApiResponse> ImportHttpApiWithOptionsAsync(ImportHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpRouteId))
            {
                body["mcpRouteId"] = request.McpRouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecContentBase64))
            {
                body["specContentBase64"] = request.SpecContentBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecFileUrl))
            {
                body["specFileUrl"] = request.SpecFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecOssConfig))
            {
                body["specOssConfig"] = request.SpecOssConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHttpApiId))
            {
                body["targetHttpApiId"] = request.TargetHttpApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports HTTP APIs. You can call this operation to import OpenAPI 2.0 and OpenAPI 3.0.x definition files to create REST APIs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportHttpApiResponse
        /// </returns>
        public ImportHttpApiResponse ImportHttpApi(ImportHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImportHttpApiWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports HTTP APIs. You can call this operation to import OpenAPI 2.0 and OpenAPI 3.0.x definition files to create REST APIs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportHttpApiResponse
        /// </returns>
        public async Task<ImportHttpApiResponse> ImportHttpApiAsync(ImportHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImportHttpApiWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a plug-in.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallPluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallPluginResponse
        /// </returns>
        public InstallPluginResponse InstallPluginWithOptions(InstallPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayIds))
            {
                body["gatewayIds"] = request.GatewayIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginClassId))
            {
                body["pluginClassId"] = request.PluginClassId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallPlugin",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugins/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallPluginResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a plug-in.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallPluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallPluginResponse
        /// </returns>
        public async Task<InstallPluginResponse> InstallPluginWithOptionsAsync(InstallPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayIds))
            {
                body["gatewayIds"] = request.GatewayIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginClassId))
            {
                body["pluginClassId"] = request.PluginClassId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallPlugin",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugins/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallPluginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a plug-in.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallPluginResponse
        /// </returns>
        public InstallPluginResponse InstallPlugin(InstallPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a plug-in.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallPluginResponse
        /// </returns>
        public async Task<InstallPluginResponse> InstallPluginAsync(InstallPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallPluginWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of consumers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConsumersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConsumersResponse
        /// </returns>
        public ListConsumersResponse ListConsumersWithOptions(ListConsumersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumers",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of consumers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConsumersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConsumersResponse
        /// </returns>
        public async Task<ListConsumersResponse> ListConsumersWithOptionsAsync(ListConsumersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumers",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of consumers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConsumersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConsumersResponse
        /// </returns>
        public ListConsumersResponse ListConsumers(ListConsumersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of consumers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConsumersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConsumersResponse
        /// </returns>
        public async Task<ListConsumersResponse> ListConsumersAsync(ListConsumersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of domain names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDomainsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDomainsResponse
        /// </returns>
        public ListDomainsResponse ListDomainsWithOptions(ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of domain names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDomainsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDomainsResponse
        /// </returns>
        public async Task<ListDomainsResponse> ListDomainsWithOptionsAsync(ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of domain names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDomainsResponse
        /// </returns>
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDomainsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of domain names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDomainsResponse
        /// </returns>
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDomainsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListEnvironments is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListEnvironments</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvironmentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnvironmentsResponse
        /// </returns>
        [Obsolete("OpenAPI ListEnvironments is deprecated")]
        // Deprecated
        public ListEnvironmentsResponse ListEnvironmentsWithOptions(ListEnvironmentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasLike))
            {
                query["aliasLike"] = request.AliasLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayNameLike))
            {
                query["gatewayNameLike"] = request.GatewayNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListEnvironments is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListEnvironments</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvironmentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnvironmentsResponse
        /// </returns>
        [Obsolete("OpenAPI ListEnvironments is deprecated")]
        // Deprecated
        public async Task<ListEnvironmentsResponse> ListEnvironmentsWithOptionsAsync(ListEnvironmentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasLike))
            {
                query["aliasLike"] = request.AliasLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayNameLike))
            {
                query["gatewayNameLike"] = request.GatewayNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListEnvironments is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListEnvironments</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvironmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnvironmentsResponse
        /// </returns>
        [Obsolete("OpenAPI ListEnvironments is deprecated")]
        // Deprecated
        public ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnvironmentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListEnvironments is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListEnvironments</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvironmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnvironmentsResponse
        /// </returns>
        [Obsolete("OpenAPI ListEnvironments is deprecated")]
        // Deprecated
        public async Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnvironmentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the feature parameter configurations of an instance.</para>
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
        /// ListGatewayFeaturesResponse
        /// </returns>
        public ListGatewayFeaturesResponse ListGatewayFeaturesWithOptions(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayFeatures",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-features",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayFeaturesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the feature parameter configurations of an instance.</para>
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
        /// ListGatewayFeaturesResponse
        /// </returns>
        public async Task<ListGatewayFeaturesResponse> ListGatewayFeaturesWithOptionsAsync(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayFeatures",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-features",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayFeaturesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the feature parameter configurations of an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListGatewayFeaturesResponse
        /// </returns>
        public ListGatewayFeaturesResponse ListGatewayFeatures(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayFeaturesWithOptions(gatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the feature parameter configurations of an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListGatewayFeaturesResponse
        /// </returns>
        public async Task<ListGatewayFeaturesResponse> ListGatewayFeaturesAsync(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayFeaturesWithOptionsAsync(gatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListGatewaysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewaysResponse
        /// </returns>
        public ListGatewaysResponse ListGatewaysWithOptions(ListGatewaysRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListGatewaysShrinkRequest request = new ListGatewaysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGateways",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewaysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListGatewaysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewaysResponse
        /// </returns>
        public async Task<ListGatewaysResponse> ListGatewaysWithOptionsAsync(ListGatewaysRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListGatewaysShrinkRequest request = new ListGatewaysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGateways",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewaysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewaysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGatewaysResponse
        /// </returns>
        public ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewaysWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewaysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGatewaysResponse
        /// </returns>
        public async Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewaysWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Operations</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApiOperationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApiOperationsResponse
        /// </returns>
        public ListHttpApiOperationsResponse ListHttpApiOperationsWithOptions(string httpApiId, ListHttpApiOperationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAuthorizationRuleId))
            {
                query["consumerAuthorizationRuleId"] = request.ConsumerAuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuth))
            {
                query["enableAuth"] = request.EnableAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForDeploy))
            {
                query["forDeploy"] = request.ForDeploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathLike))
            {
                query["pathLike"] = request.PathLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConsumerInEnvironmentId))
            {
                query["withConsumerInEnvironmentId"] = request.WithConsumerInEnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConsumerInfoById))
            {
                query["withConsumerInfoById"] = request.WithConsumerInfoById;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPluginAttachmentByPluginId))
            {
                query["withPluginAttachmentByPluginId"] = request.WithPluginAttachmentByPluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApiOperations",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApiOperationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Operations</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApiOperationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApiOperationsResponse
        /// </returns>
        public async Task<ListHttpApiOperationsResponse> ListHttpApiOperationsWithOptionsAsync(string httpApiId, ListHttpApiOperationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAuthorizationRuleId))
            {
                query["consumerAuthorizationRuleId"] = request.ConsumerAuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuth))
            {
                query["enableAuth"] = request.EnableAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForDeploy))
            {
                query["forDeploy"] = request.ForDeploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathLike))
            {
                query["pathLike"] = request.PathLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConsumerInEnvironmentId))
            {
                query["withConsumerInEnvironmentId"] = request.WithConsumerInEnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConsumerInfoById))
            {
                query["withConsumerInfoById"] = request.WithConsumerInfoById;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPluginAttachmentByPluginId))
            {
                query["withPluginAttachmentByPluginId"] = request.WithPluginAttachmentByPluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApiOperations",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApiOperationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Operations</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApiOperationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApiOperationsResponse
        /// </returns>
        public ListHttpApiOperationsResponse ListHttpApiOperations(string httpApiId, ListHttpApiOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHttpApiOperationsWithOptions(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Operations</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApiOperationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApiOperationsResponse
        /// </returns>
        public async Task<ListHttpApiOperationsResponse> ListHttpApiOperationsAsync(string httpApiId, ListHttpApiOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHttpApiOperationsWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the routes of an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApiRoutesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApiRoutesResponse
        /// </returns>
        public ListHttpApiRoutesResponse ListHttpApiRoutesWithOptions(string httpApiId, ListHttpApiRoutesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAuthorizationRuleId))
            {
                query["consumerAuthorizationRuleId"] = request.ConsumerAuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployStatuses))
            {
                query["deployStatuses"] = request.DeployStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["domainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForDeploy))
            {
                query["forDeploy"] = request.ForDeploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathLike))
            {
                query["pathLike"] = request.PathLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAuthPolicyInfo))
            {
                query["withAuthPolicyInfo"] = request.WithAuthPolicyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConsumerInfoById))
            {
                query["withConsumerInfoById"] = request.WithConsumerInfoById;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPluginAttachmentByPluginId))
            {
                query["withPluginAttachmentByPluginId"] = request.WithPluginAttachmentByPluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApiRoutes",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApiRoutesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the routes of an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApiRoutesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApiRoutesResponse
        /// </returns>
        public async Task<ListHttpApiRoutesResponse> ListHttpApiRoutesWithOptionsAsync(string httpApiId, ListHttpApiRoutesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerAuthorizationRuleId))
            {
                query["consumerAuthorizationRuleId"] = request.ConsumerAuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployStatuses))
            {
                query["deployStatuses"] = request.DeployStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["domainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForDeploy))
            {
                query["forDeploy"] = request.ForDeploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathLike))
            {
                query["pathLike"] = request.PathLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAuthPolicyInfo))
            {
                query["withAuthPolicyInfo"] = request.WithAuthPolicyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConsumerInfoById))
            {
                query["withConsumerInfoById"] = request.WithConsumerInfoById;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPluginAttachmentByPluginId))
            {
                query["withPluginAttachmentByPluginId"] = request.WithPluginAttachmentByPluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApiRoutes",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApiRoutesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the routes of an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApiRoutesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApiRoutesResponse
        /// </returns>
        public ListHttpApiRoutesResponse ListHttpApiRoutes(string httpApiId, ListHttpApiRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHttpApiRoutesWithOptions(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the routes of an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApiRoutesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApiRoutesResponse
        /// </returns>
        public async Task<ListHttpApiRoutesResponse> ListHttpApiRoutesAsync(string httpApiId, ListHttpApiRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHttpApiRoutesWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of HTTP APIs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApisResponse
        /// </returns>
        public ListHttpApisResponse ListHttpApisWithOptions(ListHttpApisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAPIsPublishedToEnvironment))
            {
                query["withAPIsPublishedToEnvironment"] = request.WithAPIsPublishedToEnvironment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAuthPolicyInEnvironmentId))
            {
                query["withAuthPolicyInEnvironmentId"] = request.WithAuthPolicyInEnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAuthPolicyList))
            {
                query["withAuthPolicyList"] = request.WithAuthPolicyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConsumerInfoById))
            {
                query["withConsumerInfoById"] = request.WithConsumerInfoById;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEnvironmentInfo))
            {
                query["withEnvironmentInfo"] = request.WithEnvironmentInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEnvironmentInfoById))
            {
                query["withEnvironmentInfoById"] = request.WithEnvironmentInfoById;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithIngressInfo))
            {
                query["withIngressInfo"] = request.WithIngressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPluginAttachmentByPluginId))
            {
                query["withPluginAttachmentByPluginId"] = request.WithPluginAttachmentByPluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPolicyConfigs))
            {
                query["withPolicyConfigs"] = request.WithPolicyConfigs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApis",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of HTTP APIs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApisResponse
        /// </returns>
        public async Task<ListHttpApisResponse> ListHttpApisWithOptionsAsync(ListHttpApisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAPIsPublishedToEnvironment))
            {
                query["withAPIsPublishedToEnvironment"] = request.WithAPIsPublishedToEnvironment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAuthPolicyInEnvironmentId))
            {
                query["withAuthPolicyInEnvironmentId"] = request.WithAuthPolicyInEnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAuthPolicyList))
            {
                query["withAuthPolicyList"] = request.WithAuthPolicyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConsumerInfoById))
            {
                query["withConsumerInfoById"] = request.WithConsumerInfoById;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEnvironmentInfo))
            {
                query["withEnvironmentInfo"] = request.WithEnvironmentInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEnvironmentInfoById))
            {
                query["withEnvironmentInfoById"] = request.WithEnvironmentInfoById;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithIngressInfo))
            {
                query["withIngressInfo"] = request.WithIngressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPluginAttachmentByPluginId))
            {
                query["withPluginAttachmentByPluginId"] = request.WithPluginAttachmentByPluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPolicyConfigs))
            {
                query["withPolicyConfigs"] = request.WithPolicyConfigs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApis",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of HTTP APIs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApisRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApisResponse
        /// </returns>
        public ListHttpApisResponse ListHttpApis(ListHttpApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHttpApisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of HTTP APIs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHttpApisRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHttpApisResponse
        /// </returns>
        public async Task<ListHttpApisResponse> ListHttpApisAsync(ListHttpApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHttpApisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of MCP servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpServersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpServersResponse
        /// </returns>
        public ListMcpServersResponse ListMcpServersWithOptions(ListMcpServersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTypes))
            {
                query["createFromTypes"] = request.CreateFromTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployStatuses))
            {
                query["deployStatuses"] = request.DeployStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcpServers",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of MCP servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpServersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpServersResponse
        /// </returns>
        public async Task<ListMcpServersResponse> ListMcpServersWithOptionsAsync(ListMcpServersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTypes))
            {
                query["createFromTypes"] = request.CreateFromTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployStatuses))
            {
                query["deployStatuses"] = request.DeployStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcpServers",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of MCP servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpServersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpServersResponse
        /// </returns>
        public ListMcpServersResponse ListMcpServers(ListMcpServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMcpServersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of MCP servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create multiple services at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpServersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpServersResponse
        /// </returns>
        public async Task<ListMcpServersResponse> ListMcpServersAsync(ListMcpServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMcpServersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of plug-in attachments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPluginAttachmentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPluginAttachmentsResponse
        /// </returns>
        public ListPluginAttachmentsResponse ListPluginAttachmentsWithOptions(ListPluginAttachmentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                query["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceTypes))
            {
                query["attachResourceTypes"] = request.AttachResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithParentResource))
            {
                query["withParentResource"] = request.WithParentResource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPluginAttachments",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPluginAttachmentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of plug-in attachments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPluginAttachmentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPluginAttachmentsResponse
        /// </returns>
        public async Task<ListPluginAttachmentsResponse> ListPluginAttachmentsWithOptionsAsync(ListPluginAttachmentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                query["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceTypes))
            {
                query["attachResourceTypes"] = request.AttachResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithParentResource))
            {
                query["withParentResource"] = request.WithParentResource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPluginAttachments",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPluginAttachmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of plug-in attachments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPluginAttachmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPluginAttachmentsResponse
        /// </returns>
        public ListPluginAttachmentsResponse ListPluginAttachments(ListPluginAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPluginAttachmentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of plug-in attachments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPluginAttachmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPluginAttachmentsResponse
        /// </returns>
        public async Task<ListPluginAttachmentsResponse> ListPluginAttachmentsAsync(ListPluginAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPluginAttachmentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries plug-ins.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPluginsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPluginsResponse
        /// </returns>
        public ListPluginsResponse ListPluginsWithOptions(ListPluginsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                query["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeBuiltinAiGateway))
            {
                query["includeBuiltinAiGateway"] = request.IncludeBuiltinAiGateway;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginClassId))
            {
                query["pluginClassId"] = request.PluginClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginClassName))
            {
                query["pluginClassName"] = request.PluginClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAttachmentInfo))
            {
                query["withAttachmentInfo"] = request.WithAttachmentInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPlugins",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPluginsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries plug-ins.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPluginsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPluginsResponse
        /// </returns>
        public async Task<ListPluginsResponse> ListPluginsWithOptionsAsync(ListPluginsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                query["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["gatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeBuiltinAiGateway))
            {
                query["includeBuiltinAiGateway"] = request.IncludeBuiltinAiGateway;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginClassId))
            {
                query["pluginClassId"] = request.PluginClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginClassName))
            {
                query["pluginClassName"] = request.PluginClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAttachmentInfo))
            {
                query["withAttachmentInfo"] = request.WithAttachmentInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPlugins",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPluginsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries plug-ins.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPluginsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPluginsResponse
        /// </returns>
        public ListPluginsResponse ListPlugins(ListPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPluginsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries plug-ins.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPluginsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPluginsResponse
        /// </returns>
        public async Task<ListPluginsResponse> ListPluginsAsync(ListPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPluginsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public ListPoliciesResponse ListPoliciesWithOptions(ListPoliciesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                query["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAttachments))
            {
                query["withAttachments"] = request.WithAttachments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithSystemPolicy))
            {
                query["withSystemPolicy"] = request.WithSystemPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public async Task<ListPoliciesResponse> ListPoliciesWithOptionsAsync(ListPoliciesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                query["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAttachments))
            {
                query["withAttachments"] = request.WithAttachments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithSystemPolicy))
            {
                query["withSystemPolicy"] = request.WithSystemPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPoliciesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPoliciesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListPolicyClasses</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyClassesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyClassesResponse
        /// </returns>
        public ListPolicyClassesResponse ListPolicyClassesWithOptions(ListPolicyClassesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                query["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicyClasses",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policy-classes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyClassesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListPolicyClasses</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyClassesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyClassesResponse
        /// </returns>
        public async Task<ListPolicyClassesResponse> ListPolicyClassesWithOptionsAsync(ListPolicyClassesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceId))
            {
                query["attachResourceId"] = request.AttachResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicyClasses",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policy-classes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyClassesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListPolicyClasses</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyClassesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyClassesResponse
        /// </returns>
        public ListPolicyClassesResponse ListPolicyClasses(ListPolicyClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPolicyClassesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListPolicyClasses</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyClassesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyClassesResponse
        /// </returns>
        public async Task<ListPolicyClassesResponse> ListPolicyClassesAsync(ListPolicyClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPolicyClassesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                query["sourceTypes"] = request.SourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                query["sourceTypes"] = request.SourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListSslCerts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSslCertsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSslCertsResponse
        /// </returns>
        public ListSslCertsResponse ListSslCertsWithOptions(ListSslCertsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNameLike))
            {
                query["certNameLike"] = request.CertNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSslCerts",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/ssl/certs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSslCertsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListSslCerts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSslCertsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSslCertsResponse
        /// </returns>
        public async Task<ListSslCertsResponse> ListSslCertsWithOptionsAsync(ListSslCertsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNameLike))
            {
                query["certNameLike"] = request.CertNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSslCerts",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/ssl/certs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSslCertsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListSslCerts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSslCertsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSslCertsResponse
        /// </returns>
        public ListSslCertsResponse ListSslCerts(ListSslCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSslCertsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListSslCerts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSslCertsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSslCertsResponse
        /// </returns>
        public async Task<ListSslCertsResponse> ListSslCertsAsync(ListSslCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSslCertsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the availability zones under a cloud-native API gateway region</para>
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
        /// ListZonesResponse
        /// </returns>
        public ListZonesResponse ListZonesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListZones",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/zones",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the availability zones under a cloud-native API gateway region</para>
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
        /// ListZonesResponse
        /// </returns>
        public async Task<ListZonesResponse> ListZonesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListZones",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/zones",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the availability zones under a cloud-native API gateway region</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListZonesResponse
        /// </returns>
        public ListZonesResponse ListZones()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListZonesWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the availability zones under a cloud-native API gateway region</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListZonesResponse
        /// </returns>
        public async Task<ListZonesResponse> ListZonesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListZonesWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of consumer authentication rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConsumerAuthorizationRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConsumerAuthorizationRulesResponse
        /// </returns>
        public QueryConsumerAuthorizationRulesResponse QueryConsumerAuthorizationRulesWithOptions(QueryConsumerAuthorizationRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiNameLike))
            {
                query["apiNameLike"] = request.ApiNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["consumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerNameLike))
            {
                query["consumerNameLike"] = request.ConsumerNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByApi))
            {
                query["groupByApi"] = request.GroupByApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentResourceId))
            {
                query["parentResourceId"] = request.ParentResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["resourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConsumerAuthorizationRules",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/authorization-rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConsumerAuthorizationRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of consumer authentication rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConsumerAuthorizationRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConsumerAuthorizationRulesResponse
        /// </returns>
        public async Task<QueryConsumerAuthorizationRulesResponse> QueryConsumerAuthorizationRulesWithOptionsAsync(QueryConsumerAuthorizationRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiNameLike))
            {
                query["apiNameLike"] = request.ApiNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["consumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerNameLike))
            {
                query["consumerNameLike"] = request.ConsumerNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByApi))
            {
                query["groupByApi"] = request.GroupByApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentResourceId))
            {
                query["parentResourceId"] = request.ParentResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["resourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConsumerAuthorizationRules",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/authorization-rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConsumerAuthorizationRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of consumer authentication rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConsumerAuthorizationRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConsumerAuthorizationRulesResponse
        /// </returns>
        public QueryConsumerAuthorizationRulesResponse QueryConsumerAuthorizationRules(QueryConsumerAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryConsumerAuthorizationRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of consumer authentication rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConsumerAuthorizationRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConsumerAuthorizationRulesResponse
        /// </returns>
        public async Task<QueryConsumerAuthorizationRulesResponse> QueryConsumerAuthorizationRulesAsync(QueryConsumerAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryConsumerAuthorizationRulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer authorization rule.</para>
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
        /// RemoveConsumerAuthorizationRuleResponse
        /// </returns>
        public RemoveConsumerAuthorizationRuleResponse RemoveConsumerAuthorizationRuleWithOptions(string consumerAuthorizationRuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/authorization-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerAuthorizationRuleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveConsumerAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer authorization rule.</para>
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
        /// RemoveConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<RemoveConsumerAuthorizationRuleResponse> RemoveConsumerAuthorizationRuleWithOptionsAsync(string consumerAuthorizationRuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/authorization-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerAuthorizationRuleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveConsumerAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveConsumerAuthorizationRuleResponse
        /// </returns>
        public RemoveConsumerAuthorizationRuleResponse RemoveConsumerAuthorizationRule(string consumerAuthorizationRuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveConsumerAuthorizationRuleWithOptions(consumerAuthorizationRuleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<RemoveConsumerAuthorizationRuleResponse> RemoveConsumerAuthorizationRuleAsync(string consumerAuthorizationRuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveConsumerAuthorizationRuleWithOptionsAsync(consumerAuthorizationRuleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gateway Restart</para>
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
        /// RestartGatewayResponse
        /// </returns>
        public RestartGatewayResponse RestartGatewayWithOptions(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gateway Restart</para>
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
        /// RestartGatewayResponse
        /// </returns>
        public async Task<RestartGatewayResponse> RestartGatewayWithOptionsAsync(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/restart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gateway Restart</para>
        /// </summary>
        /// 
        /// <returns>
        /// RestartGatewayResponse
        /// </returns>
        public RestartGatewayResponse RestartGateway(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartGatewayWithOptions(gatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gateway Restart</para>
        /// </summary>
        /// 
        /// <returns>
        /// RestartGatewayResponse
        /// </returns>
        public async Task<RestartGatewayResponse> RestartGatewayAsync(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartGatewayWithOptionsAsync(gatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步外部MCP server</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncMCPServersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncMCPServersResponse
        /// </returns>
        public SyncMCPServersResponse SyncMCPServersWithOptions(SyncMCPServersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosMcpServers))
            {
                body["nacosMcpServers"] = request.NacosMcpServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncMCPServers",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/sync-mcp-server",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncMCPServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步外部MCP server</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncMCPServersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncMCPServersResponse
        /// </returns>
        public async Task<SyncMCPServersResponse> SyncMCPServersWithOptionsAsync(SyncMCPServersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosMcpServers))
            {
                body["nacosMcpServers"] = request.NacosMcpServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncMCPServers",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/sync-mcp-server",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncMCPServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步外部MCP server</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncMCPServersRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncMCPServersResponse
        /// </returns>
        public SyncMCPServersResponse SyncMCPServers(SyncMCPServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncMCPServersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步外部MCP server</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncMCPServersRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncMCPServersResponse
        /// </returns>
        public async Task<SyncMCPServersResponse> SyncMCPServersAsync(SyncMCPServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncMCPServersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Undeploys an MCP server.</para>
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
        /// UnDeployMcpServerResponse
        /// </returns>
        public UnDeployMcpServerResponse UnDeployMcpServerWithOptions(string mcpServerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnDeployMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId) + "/undeploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnDeployMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Undeploys an MCP server.</para>
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
        /// UnDeployMcpServerResponse
        /// </returns>
        public async Task<UnDeployMcpServerResponse> UnDeployMcpServerWithOptionsAsync(string mcpServerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnDeployMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId) + "/undeploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnDeployMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Undeploys an MCP server.</para>
        /// </summary>
        /// 
        /// <returns>
        /// UnDeployMcpServerResponse
        /// </returns>
        public UnDeployMcpServerResponse UnDeployMcpServer(string mcpServerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnDeployMcpServerWithOptions(mcpServerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Undeploys an MCP server.</para>
        /// </summary>
        /// 
        /// <returns>
        /// UnDeployMcpServerResponse
        /// </returns>
        public async Task<UnDeployMcpServerResponse> UnDeployMcpServerAsync(string mcpServerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnDeployMcpServerWithOptionsAsync(mcpServerId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unpublishes an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UndeployHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UndeployHttpApiResponse
        /// </returns>
        public UndeployHttpApiResponse UndeployHttpApiWithOptions(string httpApiId, UndeployHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                body["operationId"] = request.OperationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteId))
            {
                body["routeId"] = request.RouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UndeployHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/undeploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UndeployHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unpublishes an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UndeployHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UndeployHttpApiResponse
        /// </returns>
        public async Task<UndeployHttpApiResponse> UndeployHttpApiWithOptionsAsync(string httpApiId, UndeployHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                body["operationId"] = request.OperationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteId))
            {
                body["routeId"] = request.RouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UndeployHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/undeploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UndeployHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unpublishes an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UndeployHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// UndeployHttpApiResponse
        /// </returns>
        public UndeployHttpApiResponse UndeployHttpApi(string httpApiId, UndeployHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UndeployHttpApiWithOptions(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unpublishes an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UndeployHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// UndeployHttpApiResponse
        /// </returns>
        public async Task<UndeployHttpApiResponse> UndeployHttpApiAsync(string httpApiId, UndeployHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UndeployHttpApiWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a plug-in.</para>
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
        /// UninstallPluginResponse
        /// </returns>
        public UninstallPluginResponse UninstallPluginWithOptions(string pluginId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallPlugin",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugins/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallPluginResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a plug-in.</para>
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
        /// UninstallPluginResponse
        /// </returns>
        public async Task<UninstallPluginResponse> UninstallPluginWithOptionsAsync(string pluginId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallPlugin",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugins/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallPluginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a plug-in.</para>
        /// </summary>
        /// 
        /// <returns>
        /// UninstallPluginResponse
        /// </returns>
        public UninstallPluginResponse UninstallPlugin(string pluginId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UninstallPluginWithOptions(pluginId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a plug-in.</para>
        /// </summary>
        /// 
        /// <returns>
        /// UninstallPluginResponse
        /// </returns>
        public async Task<UninstallPluginResponse> UninstallPluginAsync(string pluginId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UninstallPluginWithOptionsAsync(pluginId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates and associates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAndAttachPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndAttachPolicyResponse
        /// </returns>
        public UpdateAndAttachPolicyResponse UpdateAndAttachPolicyWithOptions(string policyId, UpdateAndAttachPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceIds))
            {
                body["attachResourceIds"] = request.AttachResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                body["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
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
                Action = "UpdateAndAttachPolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAndAttachPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates and associates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAndAttachPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndAttachPolicyResponse
        /// </returns>
        public async Task<UpdateAndAttachPolicyResponse> UpdateAndAttachPolicyWithOptionsAsync(string policyId, UpdateAndAttachPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceIds))
            {
                body["attachResourceIds"] = request.AttachResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                body["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
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
                Action = "UpdateAndAttachPolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAndAttachPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates and associates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAndAttachPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndAttachPolicyResponse
        /// </returns>
        public UpdateAndAttachPolicyResponse UpdateAndAttachPolicy(string policyId, UpdateAndAttachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAndAttachPolicyWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates and associates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAndAttachPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndAttachPolicyResponse
        /// </returns>
        public async Task<UpdateAndAttachPolicyResponse> UpdateAndAttachPolicyAsync(string policyId, UpdateAndAttachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAndAttachPolicyWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a consumer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConsumerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerResponse
        /// </returns>
        public UpdateConsumerResponse UpdateConsumerWithOptions(string consumerId, UpdateConsumerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkSkIdentityConfigs))
            {
                body["akSkIdentityConfigs"] = request.AkSkIdentityConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApikeyIdentityConfig))
            {
                body["apikeyIdentityConfig"] = request.ApikeyIdentityConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtIdentityConfig))
            {
                body["jwtIdentityConfig"] = request.JwtIdentityConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a consumer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConsumerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerResponse
        /// </returns>
        public async Task<UpdateConsumerResponse> UpdateConsumerWithOptionsAsync(string consumerId, UpdateConsumerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkSkIdentityConfigs))
            {
                body["akSkIdentityConfigs"] = request.AkSkIdentityConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApikeyIdentityConfig))
            {
                body["apikeyIdentityConfig"] = request.ApikeyIdentityConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtIdentityConfig))
            {
                body["jwtIdentityConfig"] = request.JwtIdentityConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a consumer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConsumerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerResponse
        /// </returns>
        public UpdateConsumerResponse UpdateConsumer(string consumerId, UpdateConsumerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConsumerWithOptions(consumerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a consumer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConsumerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerResponse
        /// </returns>
        public async Task<UpdateConsumerResponse> UpdateConsumerAsync(string consumerId, UpdateConsumerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConsumerWithOptionsAsync(consumerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConsumerAuthorizationRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerAuthorizationRuleResponse
        /// </returns>
        public UpdateConsumerAuthorizationRuleResponse UpdateConsumerAuthorizationRuleWithOptions(string consumerId, string consumerAuthorizationRuleId, UpdateConsumerAuthorizationRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationResourceInfos))
            {
                body["authorizationResourceInfos"] = request.AuthorizationResourceInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMode))
            {
                body["expireMode"] = request.ExpireMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimestamp))
            {
                body["expireTimestamp"] = request.ExpireTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId) + "/authorization-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerAuthorizationRuleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConsumerAuthorizationRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<UpdateConsumerAuthorizationRuleResponse> UpdateConsumerAuthorizationRuleWithOptionsAsync(string consumerId, string consumerAuthorizationRuleId, UpdateConsumerAuthorizationRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationResourceInfos))
            {
                body["authorizationResourceInfos"] = request.AuthorizationResourceInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMode))
            {
                body["expireMode"] = request.ExpireMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimestamp))
            {
                body["expireTimestamp"] = request.ExpireTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerAuthorizationRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/consumers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerId) + "/authorization-rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerAuthorizationRuleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConsumerAuthorizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerAuthorizationRuleResponse
        /// </returns>
        public UpdateConsumerAuthorizationRuleResponse UpdateConsumerAuthorizationRule(string consumerId, string consumerAuthorizationRuleId, UpdateConsumerAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConsumerAuthorizationRuleWithOptions(consumerId, consumerAuthorizationRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a consumer authorization rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConsumerAuthorizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerAuthorizationRuleResponse
        /// </returns>
        public async Task<UpdateConsumerAuthorizationRuleResponse> UpdateConsumerAuthorizationRuleAsync(string consumerId, string consumerAuthorizationRuleId, UpdateConsumerAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConsumerAuthorizationRuleWithOptionsAsync(consumerId, consumerAuthorizationRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDomainResponse
        /// </returns>
        public UpdateDomainResponse UpdateDomainWithOptions(string domainId, UpdateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertIdentifier))
            {
                body["caCertIdentifier"] = request.CaCertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                body["certIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientCACert))
            {
                body["clientCACert"] = request.ClientCACert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["forceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Option))
            {
                body["http2Option"] = request.Http2Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MTLSEnabled))
            {
                body["mTLSEnabled"] = request.MTLSEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsCipherSuitesConfig))
            {
                body["tlsCipherSuitesConfig"] = request.TlsCipherSuitesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMax))
            {
                body["tlsMax"] = request.TlsMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMin))
            {
                body["tlsMin"] = request.TlsMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDomainResponse
        /// </returns>
        public async Task<UpdateDomainResponse> UpdateDomainWithOptionsAsync(string domainId, UpdateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertIdentifier))
            {
                body["caCertIdentifier"] = request.CaCertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                body["certIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientCACert))
            {
                body["clientCACert"] = request.ClientCACert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["forceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Option))
            {
                body["http2Option"] = request.Http2Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MTLSEnabled))
            {
                body["mTLSEnabled"] = request.MTLSEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsCipherSuitesConfig))
            {
                body["tlsCipherSuitesConfig"] = request.TlsCipherSuitesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMax))
            {
                body["tlsMax"] = request.TlsMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMin))
            {
                body["tlsMin"] = request.TlsMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDomainResponse
        /// </returns>
        public UpdateDomainResponse UpdateDomain(string domainId, UpdateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDomainWithOptions(domainId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDomainResponse
        /// </returns>
        public async Task<UpdateDomainResponse> UpdateDomainAsync(string domainId, UpdateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDomainWithOptionsAsync(domainId, request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateEnvironment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateEnvironment is deprecated")]
        // Deprecated
        public UpdateEnvironmentResponse UpdateEnvironmentWithOptions(string environmentId, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateEnvironment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateEnvironment is deprecated")]
        // Deprecated
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentWithOptionsAsync(string environmentId, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateEnvironment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateEnvironment is deprecated")]
        // Deprecated
        public UpdateEnvironmentResponse UpdateEnvironment(string environmentId, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEnvironmentWithOptions(environmentId, request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateEnvironment is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateEnvironment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnvironmentResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateEnvironment is deprecated")]
        // Deprecated
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(string environmentId, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEnvironmentWithOptionsAsync(environmentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the feature configuration of the gateway</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayFeatureRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayFeatureResponse
        /// </returns>
        public UpdateGatewayFeatureResponse UpdateGatewayFeatureWithOptions(string gatewayId, string name, UpdateGatewayFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayFeature",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-features/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayFeatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the feature configuration of the gateway</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayFeatureRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayFeatureResponse
        /// </returns>
        public async Task<UpdateGatewayFeatureResponse> UpdateGatewayFeatureWithOptionsAsync(string gatewayId, string name, UpdateGatewayFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayFeature",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-features/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the feature configuration of the gateway</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayFeatureRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayFeatureResponse
        /// </returns>
        public UpdateGatewayFeatureResponse UpdateGatewayFeature(string gatewayId, string name, UpdateGatewayFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGatewayFeatureWithOptions(gatewayId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the feature configuration of the gateway</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayFeatureRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayFeatureResponse
        /// </returns>
        public async Task<UpdateGatewayFeatureResponse> UpdateGatewayFeatureAsync(string gatewayId, string name, UpdateGatewayFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGatewayFeatureWithOptionsAsync(gatewayId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Change the name of a gateway instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayNameResponse
        /// </returns>
        public UpdateGatewayNameResponse UpdateGatewayNameWithOptions(string gatewayId, UpdateGatewayNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayName",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/name",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Change the name of a gateway instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayNameResponse
        /// </returns>
        public async Task<UpdateGatewayNameResponse> UpdateGatewayNameWithOptionsAsync(string gatewayId, UpdateGatewayNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayName",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/name",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Change the name of a gateway instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayNameResponse
        /// </returns>
        public UpdateGatewayNameResponse UpdateGatewayName(string gatewayId, UpdateGatewayNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGatewayNameWithOptions(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Change the name of a gateway instance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayNameResponse
        /// </returns>
        public async Task<UpdateGatewayNameResponse> UpdateGatewayNameAsync(string gatewayId, UpdateGatewayNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGatewayNameWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiResponse
        /// </returns>
        public UpdateHttpApiResponse UpdateHttpApiWithOptions(string httpApiId, UpdateHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProtocols))
            {
                body["agentProtocols"] = request.AgentProtocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiProtocols))
            {
                body["aiProtocols"] = request.AiProtocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                body["authConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasePath))
            {
                body["basePath"] = request.BasePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuth))
            {
                body["enableAuth"] = request.EnableAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstByteTimeout))
            {
                body["firstByteTimeout"] = request.FirstByteTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConfig))
            {
                body["ingressConfig"] = request.IngressConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyChangeConfig))
            {
                body["onlyChangeConfig"] = request.OnlyChangeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveBasePathOnForward))
            {
                body["removeBasePathOnForward"] = request.RemoveBasePathOnForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiResponse
        /// </returns>
        public async Task<UpdateHttpApiResponse> UpdateHttpApiWithOptionsAsync(string httpApiId, UpdateHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProtocols))
            {
                body["agentProtocols"] = request.AgentProtocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiProtocols))
            {
                body["aiProtocols"] = request.AiProtocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                body["authConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasePath))
            {
                body["basePath"] = request.BasePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuth))
            {
                body["enableAuth"] = request.EnableAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstByteTimeout))
            {
                body["firstByteTimeout"] = request.FirstByteTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConfig))
            {
                body["ingressConfig"] = request.IngressConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyChangeConfig))
            {
                body["onlyChangeConfig"] = request.OnlyChangeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveBasePathOnForward))
            {
                body["removeBasePathOnForward"] = request.RemoveBasePathOnForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiResponse
        /// </returns>
        public UpdateHttpApiResponse UpdateHttpApi(string httpApiId, UpdateHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHttpApiWithOptions(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiResponse
        /// </returns>
        public async Task<UpdateHttpApiResponse> UpdateHttpApiAsync(string httpApiId, UpdateHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHttpApiWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Operation</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiOperationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiOperationResponse
        /// </returns>
        public UpdateHttpApiOperationResponse UpdateHttpApiOperationWithOptions(string httpApiId, string operationId, UpdateHttpApiOperationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["operation"] = request.Operation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiOperationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Operation</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiOperationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiOperationResponse
        /// </returns>
        public async Task<UpdateHttpApiOperationResponse> UpdateHttpApiOperationWithOptionsAsync(string httpApiId, string operationId, UpdateHttpApiOperationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["operation"] = request.Operation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Operation</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiOperationResponse
        /// </returns>
        public UpdateHttpApiOperationResponse UpdateHttpApiOperation(string httpApiId, string operationId, UpdateHttpApiOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHttpApiOperationWithOptions(httpApiId, operationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Operation</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiOperationResponse
        /// </returns>
        public async Task<UpdateHttpApiOperationResponse> UpdateHttpApiOperationAsync(string httpApiId, string operationId, UpdateHttpApiOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHttpApiOperationWithOptionsAsync(httpApiId, operationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the route of an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiRouteResponse
        /// </returns>
        public UpdateHttpApiRouteResponse UpdateHttpApiRouteWithOptions(string httpApiId, string routeId, UpdateHttpApiRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpRouteConfig))
            {
                body["mcpRouteConfig"] = request.McpRouteConfig;
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
                Action = "UpdateHttpApiRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(routeId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the route of an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiRouteResponse
        /// </returns>
        public async Task<UpdateHttpApiRouteResponse> UpdateHttpApiRouteWithOptionsAsync(string httpApiId, string routeId, UpdateHttpApiRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployConfigs))
            {
                body["deployConfigs"] = request.DeployConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpRouteConfig))
            {
                body["mcpRouteConfig"] = request.McpRouteConfig;
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
                Action = "UpdateHttpApiRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(routeId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the route of an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiRouteResponse
        /// </returns>
        public UpdateHttpApiRouteResponse UpdateHttpApiRoute(string httpApiId, string routeId, UpdateHttpApiRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHttpApiRouteWithOptions(httpApiId, routeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the route of an HTTP API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHttpApiRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHttpApiRouteResponse
        /// </returns>
        public async Task<UpdateHttpApiRouteResponse> UpdateHttpApiRouteAsync(string httpApiId, string routeId, UpdateHttpApiRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHttpApiRouteWithOptionsAsync(httpApiId, routeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can only update the listening Ingress configuration for sources of the <b>ACK</b> type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpServerResponse
        /// </returns>
        public UpdateMcpServerResponse UpdateMcpServerWithOptions(string mcpServerId, UpdateMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssembledSources))
            {
                body["assembledSources"] = request.AssembledSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromType))
            {
                body["createFromType"] = request.CreateFromType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExposedUriPath))
            {
                body["exposedUriPath"] = request.ExposedUriPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayMcpServerConfigs))
            {
                body["grayMcpServerConfigs"] = request.GrayMcpServerConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpStatisticsEnable))
            {
                body["mcpStatisticsEnable"] = request.McpStatisticsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can only update the listening Ingress configuration for sources of the <b>ACK</b> type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpServerResponse
        /// </returns>
        public async Task<UpdateMcpServerResponse> UpdateMcpServerWithOptionsAsync(string mcpServerId, UpdateMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssembledSources))
            {
                body["assembledSources"] = request.AssembledSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromType))
            {
                body["createFromType"] = request.CreateFromType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainIds))
            {
                body["domainIds"] = request.DomainIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExposedUriPath))
            {
                body["exposedUriPath"] = request.ExposedUriPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayMcpServerConfigs))
            {
                body["grayMcpServerConfigs"] = request.GrayMcpServerConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpStatisticsEnable))
            {
                body["mcpStatisticsEnable"] = request.McpStatisticsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcpServer",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can only update the listening Ingress configuration for sources of the <b>ACK</b> type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpServerResponse
        /// </returns>
        public UpdateMcpServerResponse UpdateMcpServer(string mcpServerId, UpdateMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMcpServerWithOptions(mcpServerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can only update the listening Ingress configuration for sources of the <b>ACK</b> type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpServerResponse
        /// </returns>
        public async Task<UpdateMcpServerResponse> UpdateMcpServerAsync(string mcpServerId, UpdateMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMcpServerWithOptionsAsync(mcpServerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a plug-in attachment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePluginAttachmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePluginAttachmentResponse
        /// </returns>
        public UpdatePluginAttachmentResponse UpdatePluginAttachmentWithOptions(string pluginAttachmentId, UpdatePluginAttachmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceIds))
            {
                body["attachResourceIds"] = request.AttachResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginConfig))
            {
                body["pluginConfig"] = request.PluginConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePluginAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginAttachmentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePluginAttachmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a plug-in attachment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePluginAttachmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePluginAttachmentResponse
        /// </returns>
        public async Task<UpdatePluginAttachmentResponse> UpdatePluginAttachmentWithOptionsAsync(string pluginAttachmentId, UpdatePluginAttachmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceIds))
            {
                body["attachResourceIds"] = request.AttachResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginConfig))
            {
                body["pluginConfig"] = request.PluginConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePluginAttachment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/plugin-attachments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginAttachmentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePluginAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a plug-in attachment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePluginAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePluginAttachmentResponse
        /// </returns>
        public UpdatePluginAttachmentResponse UpdatePluginAttachment(string pluginAttachmentId, UpdatePluginAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePluginAttachmentWithOptions(pluginAttachmentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a plug-in attachment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePluginAttachmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePluginAttachmentResponse
        /// </returns>
        public async Task<UpdatePluginAttachmentResponse> UpdatePluginAttachmentAsync(string pluginAttachmentId, UpdatePluginAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePluginAttachmentWithOptionsAsync(pluginAttachmentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public UpdatePolicyResponse UpdatePolicyWithOptions(string policyId, UpdatePolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
                Action = "UpdatePolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v2/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public async Task<UpdatePolicyResponse> UpdatePolicyWithOptionsAsync(string policyId, UpdatePolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
                Action = "UpdatePolicy",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v2/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public UpdatePolicyResponse UpdatePolicy(string policyId, UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePolicyWithOptions(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(string policyId, UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePolicyWithOptionsAsync(policyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public UpdateServiceResponse UpdateServiceWithOptions(string serviceId, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addresses))
            {
                body["addresses"] = request.Addresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentServiceConfig))
            {
                body["agentServiceConfig"] = request.AgentServiceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiServiceConfig))
            {
                body["aiServiceConfig"] = request.AiServiceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsServers))
            {
                body["dnsServers"] = request.DnsServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                body["healthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyPanicThreshold))
            {
                body["healthyPanicThreshold"] = request.HealthyPanicThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutlierDetectionConfig))
            {
                body["outlierDetectionConfig"] = request.OutlierDetectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ports))
            {
                body["ports"] = request.Ports;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(string serviceId, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addresses))
            {
                body["addresses"] = request.Addresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentServiceConfig))
            {
                body["agentServiceConfig"] = request.AgentServiceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiServiceConfig))
            {
                body["aiServiceConfig"] = request.AiServiceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsServers))
            {
                body["dnsServers"] = request.DnsServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                body["healthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyPanicThreshold))
            {
                body["healthyPanicThreshold"] = request.HealthyPanicThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutlierDetectionConfig))
            {
                body["outlierDetectionConfig"] = request.OutlierDetectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ports))
            {
                body["ports"] = request.Ports;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public UpdateServiceResponse UpdateService(string serviceId, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceWithOptions(serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public async Task<UpdateServiceResponse> UpdateServiceAsync(string serviceId, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceWithOptionsAsync(serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a service version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceVersionResponse
        /// </returns>
        public UpdateServiceVersionResponse UpdateServiceVersionWithOptions(string serviceId, string name, UpdateServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a service version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceVersionResponse
        /// </returns>
        public async Task<UpdateServiceVersionResponse> UpdateServiceVersionWithOptionsAsync(string serviceId, string name, UpdateServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a service version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceVersionResponse
        /// </returns>
        public UpdateServiceVersionResponse UpdateServiceVersion(string serviceId, string name, UpdateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceVersionWithOptions(serviceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a service version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceVersionResponse
        /// </returns>
        public async Task<UpdateServiceVersionResponse> UpdateServiceVersionAsync(string serviceId, string name, UpdateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceVersionWithOptionsAsync(serviceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrade the gateway version</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeGatewayResponse
        /// </returns>
        public UpgradeGatewayResponse UpgradeGatewayWithOptions(string gatewayId, UpgradeGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrade the gateway version</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeGatewayResponse
        /// </returns>
        public async Task<UpgradeGatewayResponse> UpgradeGatewayWithOptionsAsync(string gatewayId, UpgradeGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrade the gateway version</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeGatewayResponse
        /// </returns>
        public UpgradeGatewayResponse UpgradeGateway(string gatewayId, UpgradeGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeGatewayWithOptions(gatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrade the gateway version</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeGatewayResponse
        /// </returns>
        public async Task<UpgradeGatewayResponse> UpgradeGatewayAsync(string gatewayId, UpgradeGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeGatewayWithOptionsAsync(gatewayId, request, headers, runtime);
        }

    }
}
