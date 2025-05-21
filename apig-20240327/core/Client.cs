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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConfig))
            {
                body["ingressConfig"] = request.IngressConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConfig))
            {
                body["ingressConfig"] = request.IngressConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
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
        /// <para>创建API</para>
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
        /// <para>创建API</para>
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
        /// <para>创建API</para>
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
        /// <para>创建API</para>
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
        /// <para>删除挂载规则API</para>
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
        /// <para>删除挂载规则API</para>
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
        /// <para>删除挂载规则API</para>
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
        /// <para>删除挂载规则API</para>
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
        /// <para>Get a gateway.</para>
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
        /// <para>Get a gateway.</para>
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
        /// <para>Get a gateway.</para>
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
        /// <para>Get a gateway.</para>
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
        /// <para>GetPluginAttachment。</para>
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
        /// <para>GetPluginAttachment。</para>
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
        /// <para>GetPluginAttachment。</para>
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
        /// <para>GetPluginAttachment。</para>
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
        /// <para>ListPlugins</para>
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
        /// <para>ListPlugins</para>
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
        /// <para>ListPlugins</para>
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
        /// <para>ListPlugins</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachResourceType))
            {
                query["attachResourceType"] = request.AttachResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
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
        /// <para>取消部署HttpApi</para>
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
        /// <para>取消部署HttpApi</para>
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
        /// <para>取消部署HttpApi</para>
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
        /// <para>取消部署HttpApi</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConfig))
            {
                body["ingressConfig"] = request.IngressConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressConfig))
            {
                body["ingressConfig"] = request.IngressConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
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
        /// <para>更新挂载规则API</para>
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
        /// <para>更新挂载规则API</para>
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
        /// <para>更新挂载规则API</para>
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
        /// <para>更新挂载规则API</para>
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
