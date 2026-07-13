// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AgentTeams20260605.Models;

namespace AlibabaCloud.SDK.AgentTeams20260605
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("agentteams", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>绑定上游身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindIdentityProviderResponse
        /// </returns>
        public BindIdentityProviderResponse BindIdentityProviderWithOptions(BindIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                query["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpMetadata))
            {
                query["IdpMetadata"] = request.IdpMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEnabled))
            {
                query["LoginEnabled"] = request.LoginEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncEnabled))
            {
                query["SyncEnabled"] = request.SyncEnabled;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindIdentityProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定上游身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindIdentityProviderResponse
        /// </returns>
        public async Task<BindIdentityProviderResponse> BindIdentityProviderWithOptionsAsync(BindIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                query["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpMetadata))
            {
                query["IdpMetadata"] = request.IdpMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEnabled))
            {
                query["LoginEnabled"] = request.LoginEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncEnabled))
            {
                query["SyncEnabled"] = request.SyncEnabled;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindIdentityProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定上游身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// BindIdentityProviderResponse
        /// </returns>
        public BindIdentityProviderResponse BindIdentityProvider(BindIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定上游身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// BindIdentityProviderResponse
        /// </returns>
        public async Task<BindIdentityProviderResponse> BindIdentityProviderAsync(BindIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定AgentTeams实例异步开通并配置阿里云公网NAT网关。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于为特定的AgentTeams实例创建公网NAT网关，并自动完成EIP申请、绑定以及SNAT规则的设置。</description></item>
        /// <item><description>接口调用后将返回一个异步任务ID，实际的NAT网关、EIP及SNAT资源ID会在异步任务完成后通过任务结果提供。</description></item>
        /// <item><description>NAT网关名称由系统自动生成，格式为<c>magic-create-for-vpc-{vpcId}</c>。</description></item>
        /// <item><description>支持GET和POST方法进行请求。</description></item>
        /// <item><description><c>eipBandwidth</c>参数指定了自动申请EIP时的带宽大小，默认值为5Mbps，范围在1-200Mbps之间。</description></item>
        /// <item><description>如果<c>instanceId</c>为空或无效，或者提供的<c>eipBandwidth</c>不在允许范围内，API将返回错误响应。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigureNatGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigureNatGatewayResponse
        /// </returns>
        public ConfigureNatGatewayResponse ConfigureNatGatewayWithOptions(ConfigureNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipAllocationId))
            {
                query["EipAllocationId"] = request.EipAllocationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipBandwidth))
            {
                query["EipBandwidth"] = request.EipBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayInstanceId))
            {
                query["NatGatewayInstanceId"] = request.NatGatewayInstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureNatGateway",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureNatGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定AgentTeams实例异步开通并配置阿里云公网NAT网关。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于为特定的AgentTeams实例创建公网NAT网关，并自动完成EIP申请、绑定以及SNAT规则的设置。</description></item>
        /// <item><description>接口调用后将返回一个异步任务ID，实际的NAT网关、EIP及SNAT资源ID会在异步任务完成后通过任务结果提供。</description></item>
        /// <item><description>NAT网关名称由系统自动生成，格式为<c>magic-create-for-vpc-{vpcId}</c>。</description></item>
        /// <item><description>支持GET和POST方法进行请求。</description></item>
        /// <item><description><c>eipBandwidth</c>参数指定了自动申请EIP时的带宽大小，默认值为5Mbps，范围在1-200Mbps之间。</description></item>
        /// <item><description>如果<c>instanceId</c>为空或无效，或者提供的<c>eipBandwidth</c>不在允许范围内，API将返回错误响应。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigureNatGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigureNatGatewayResponse
        /// </returns>
        public async Task<ConfigureNatGatewayResponse> ConfigureNatGatewayWithOptionsAsync(ConfigureNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipAllocationId))
            {
                query["EipAllocationId"] = request.EipAllocationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipBandwidth))
            {
                query["EipBandwidth"] = request.EipBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayInstanceId))
            {
                query["NatGatewayInstanceId"] = request.NatGatewayInstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureNatGateway",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureNatGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定AgentTeams实例异步开通并配置阿里云公网NAT网关。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于为特定的AgentTeams实例创建公网NAT网关，并自动完成EIP申请、绑定以及SNAT规则的设置。</description></item>
        /// <item><description>接口调用后将返回一个异步任务ID，实际的NAT网关、EIP及SNAT资源ID会在异步任务完成后通过任务结果提供。</description></item>
        /// <item><description>NAT网关名称由系统自动生成，格式为<c>magic-create-for-vpc-{vpcId}</c>。</description></item>
        /// <item><description>支持GET和POST方法进行请求。</description></item>
        /// <item><description><c>eipBandwidth</c>参数指定了自动申请EIP时的带宽大小，默认值为5Mbps，范围在1-200Mbps之间。</description></item>
        /// <item><description>如果<c>instanceId</c>为空或无效，或者提供的<c>eipBandwidth</c>不在允许范围内，API将返回错误响应。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigureNatGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigureNatGatewayResponse
        /// </returns>
        public ConfigureNatGatewayResponse ConfigureNatGateway(ConfigureNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureNatGatewayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定AgentTeams实例异步开通并配置阿里云公网NAT网关。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于为特定的AgentTeams实例创建公网NAT网关，并自动完成EIP申请、绑定以及SNAT规则的设置。</description></item>
        /// <item><description>接口调用后将返回一个异步任务ID，实际的NAT网关、EIP及SNAT资源ID会在异步任务完成后通过任务结果提供。</description></item>
        /// <item><description>NAT网关名称由系统自动生成，格式为<c>magic-create-for-vpc-{vpcId}</c>。</description></item>
        /// <item><description>支持GET和POST方法进行请求。</description></item>
        /// <item><description><c>eipBandwidth</c>参数指定了自动申请EIP时的带宽大小，默认值为5Mbps，范围在1-200Mbps之间。</description></item>
        /// <item><description>如果<c>instanceId</c>为空或无效，或者提供的<c>eipBandwidth</c>不在允许范围内，API将返回错误响应。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigureNatGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigureNatGatewayResponse
        /// </returns>
        public async Task<ConfigureNatGatewayResponse> ConfigureNatGatewayAsync(ConfigureNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureNatGatewayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public CreateCredentialResponse CreateCredentialWithOptions(CreateCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCredential",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public async Task<CreateCredentialResponse> CreateCredentialWithOptionsAsync(CreateCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCredential",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public CreateCredentialResponse CreateCredential(CreateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public async Task<CreateCredentialResponse> CreateCredentialAsync(CreateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建指定配置的集群实例。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过表单参数或 query 参数传递请求信息。</description></item>
        /// <item><description><c>instanceSpec</c> 和 <c>networkType</c> 等部分参数有默认值，若未指定则使用默认值。</description></item>
        /// <item><description>必须提供 <c>instanceName</c>, <c>regionId</c>, <c>vpcId</c>, 和 <c>vSwitchId</c> 参数。</description></item>
        /// <item><description><c>networkType</c> 支持三种选项：<c>PRIVATE_PUBNET</c>, <c>PRIVATE_NET</c>, <c>PUB_NET</c>，默认为 <c>PRIVATE_NET</c>。</description></item>
        /// <item><description>如果指定了 <c>zoneId</c>，则会尝试在该可用区创建实例；否则将根据系统策略选择合适的可用区。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateInstanceShrinkRequest request = new CreateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Zones))
            {
                request.ZonesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Zones, "Zones", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSpec))
            {
                query["InstanceSpec"] = request.InstanceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZonesShrink))
            {
                query["Zones"] = request.ZonesShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["PaymentType"] = request.PaymentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建指定配置的集群实例。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过表单参数或 query 参数传递请求信息。</description></item>
        /// <item><description><c>instanceSpec</c> 和 <c>networkType</c> 等部分参数有默认值，若未指定则使用默认值。</description></item>
        /// <item><description>必须提供 <c>instanceName</c>, <c>regionId</c>, <c>vpcId</c>, 和 <c>vSwitchId</c> 参数。</description></item>
        /// <item><description><c>networkType</c> 支持三种选项：<c>PRIVATE_PUBNET</c>, <c>PRIVATE_NET</c>, <c>PUB_NET</c>，默认为 <c>PRIVATE_NET</c>。</description></item>
        /// <item><description>如果指定了 <c>zoneId</c>，则会尝试在该可用区创建实例；否则将根据系统策略选择合适的可用区。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateInstanceShrinkRequest request = new CreateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Zones))
            {
                request.ZonesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Zones, "Zones", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSpec))
            {
                query["InstanceSpec"] = request.InstanceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZonesShrink))
            {
                query["Zones"] = request.ZonesShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["PaymentType"] = request.PaymentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建指定配置的集群实例。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过表单参数或 query 参数传递请求信息。</description></item>
        /// <item><description><c>instanceSpec</c> 和 <c>networkType</c> 等部分参数有默认值，若未指定则使用默认值。</description></item>
        /// <item><description>必须提供 <c>instanceName</c>, <c>regionId</c>, <c>vpcId</c>, 和 <c>vSwitchId</c> 参数。</description></item>
        /// <item><description><c>networkType</c> 支持三种选项：<c>PRIVATE_PUBNET</c>, <c>PRIVATE_NET</c>, <c>PUB_NET</c>，默认为 <c>PRIVATE_NET</c>。</description></item>
        /// <item><description>如果指定了 <c>zoneId</c>，则会尝试在该可用区创建实例；否则将根据系统策略选择合适的可用区。</description></item>
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
            return CreateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建指定配置的集群实例。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过表单参数或 query 参数传递请求信息。</description></item>
        /// <item><description><c>instanceSpec</c> 和 <c>networkType</c> 等部分参数有默认值，若未指定则使用默认值。</description></item>
        /// <item><description>必须提供 <c>instanceName</c>, <c>regionId</c>, <c>vpcId</c>, 和 <c>vSwitchId</c> 参数。</description></item>
        /// <item><description><c>networkType</c> 支持三种选项：<c>PRIVATE_PUBNET</c>, <c>PRIVATE_NET</c>, <c>PUB_NET</c>，默认为 <c>PRIVATE_NET</c>。</description></item>
        /// <item><description>如果指定了 <c>zoneId</c>，则会尝试在该可用区创建实例；否则将根据系统策略选择合适的可用区。</description></item>
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
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateMcpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpResponse
        /// </returns>
        public CreateMcpResponse CreateMcpWithOptions(CreateMcpRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMcpShrinkRequest request = new CreateMcpShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Addresses))
            {
                request.AddressesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Addresses, "Addresses", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressesShrink))
            {
                body["Addresses"] = request.AddressesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                body["AuthConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthEnabled))
            {
                body["AuthEnabled"] = request.AuthEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateType))
            {
                body["CreateType"] = request.CreateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwaggerConfig))
            {
                body["SwaggerConfig"] = request.SwaggerConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcp",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateMcpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpResponse
        /// </returns>
        public async Task<CreateMcpResponse> CreateMcpWithOptionsAsync(CreateMcpRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMcpShrinkRequest request = new CreateMcpShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Addresses))
            {
                request.AddressesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Addresses, "Addresses", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressesShrink))
            {
                body["Addresses"] = request.AddressesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                body["AuthConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthEnabled))
            {
                body["AuthEnabled"] = request.AuthEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateType))
            {
                body["CreateType"] = request.CreateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwaggerConfig))
            {
                body["SwaggerConfig"] = request.SwaggerConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcp",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpResponse
        /// </returns>
        public CreateMcpResponse CreateMcp(CreateMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpResponse
        /// </returns>
        public async Task<CreateMcpResponse> CreateMcpAsync(CreateMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public CreateModelResponse CreateModelWithOptions(CreateModelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelShrinkRequest request = new CreateModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Protocols))
            {
                request.ProtocolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Protocols, "Protocols", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolsShrink))
            {
                body["Protocols"] = request.ProtocolsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                body["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                body["ProviderName"] = request.ProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModel",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(CreateModelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelShrinkRequest request = new CreateModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Protocols))
            {
                request.ProtocolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Protocols, "Protocols", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolsShrink))
            {
                body["Protocols"] = request.ProtocolsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                body["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                body["ProviderName"] = request.ProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModel",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public CreateModelResponse CreateModel(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public async Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProviderResponse
        /// </returns>
        public CreateModelProviderResponse CreateModelProviderWithOptions(CreateModelProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelProviderShrinkRequest request = new CreateModelProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiKeys))
            {
                request.ApiKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiKeys, "ApiKeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Protocols))
            {
                request.ProtocolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Protocols, "Protocols", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeysShrink))
            {
                body["ApiKeys"] = request.ApiKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolsShrink))
            {
                body["Protocols"] = request.ProtocolsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                body["Provider"] = request.Provider;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProviderResponse
        /// </returns>
        public async Task<CreateModelProviderResponse> CreateModelProviderWithOptionsAsync(CreateModelProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelProviderShrinkRequest request = new CreateModelProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiKeys))
            {
                request.ApiKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiKeys, "ApiKeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Protocols))
            {
                request.ProtocolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Protocols, "Protocols", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeysShrink))
            {
                body["ApiKeys"] = request.ApiKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolsShrink))
            {
                body["Protocols"] = request.ProtocolsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                body["Provider"] = request.Provider;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProviderResponse
        /// </returns>
        public CreateModelProviderResponse CreateModelProvider(CreateModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateModelProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProviderResponse
        /// </returns>
        public async Task<CreateModelProviderResponse> CreateModelProviderAsync(CreateModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateModelProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建指定实例的Endpoint，支持多种组件和网关类型。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>当前controller使用的是普通参数绑定，不是<c>@RequestBody</c>，因此参数更适合按query/form方式传递。</description></item>
        /// <item><description><c>domain</c>字段会在服务端进行<c>trim + lowerCase</c>处理。</description></item>
        /// <item><description><c>query</c>和<c>headers</c>必须是JSON object字符串格式，不能为数组。</description></item>
        /// <item><description>创建操作仅将数据保存到数据库；只有在更新时，如果满足<c>ELEMENT/MATRIX + AI_GATEWAY + INTERNET</c>且域名或证书发生变化，才会触发AI Gateway域名同步逻辑。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceEndpointResponse
        /// </returns>
        public CreateServiceEndpointResponse CreateServiceEndpointWithOptions(CreateServiceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Component))
            {
                query["Component"] = request.Component;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceEndpoint",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建指定实例的Endpoint，支持多种组件和网关类型。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>当前controller使用的是普通参数绑定，不是<c>@RequestBody</c>，因此参数更适合按query/form方式传递。</description></item>
        /// <item><description><c>domain</c>字段会在服务端进行<c>trim + lowerCase</c>处理。</description></item>
        /// <item><description><c>query</c>和<c>headers</c>必须是JSON object字符串格式，不能为数组。</description></item>
        /// <item><description>创建操作仅将数据保存到数据库；只有在更新时，如果满足<c>ELEMENT/MATRIX + AI_GATEWAY + INTERNET</c>且域名或证书发生变化，才会触发AI Gateway域名同步逻辑。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceEndpointResponse
        /// </returns>
        public async Task<CreateServiceEndpointResponse> CreateServiceEndpointWithOptionsAsync(CreateServiceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Component))
            {
                query["Component"] = request.Component;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceEndpoint",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建指定实例的Endpoint，支持多种组件和网关类型。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>当前controller使用的是普通参数绑定，不是<c>@RequestBody</c>，因此参数更适合按query/form方式传递。</description></item>
        /// <item><description><c>domain</c>字段会在服务端进行<c>trim + lowerCase</c>处理。</description></item>
        /// <item><description><c>query</c>和<c>headers</c>必须是JSON object字符串格式，不能为数组。</description></item>
        /// <item><description>创建操作仅将数据保存到数据库；只有在更新时，如果满足<c>ELEMENT/MATRIX + AI_GATEWAY + INTERNET</c>且域名或证书发生变化，才会触发AI Gateway域名同步逻辑。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceEndpointResponse
        /// </returns>
        public CreateServiceEndpointResponse CreateServiceEndpoint(CreateServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建指定实例的Endpoint，支持多种组件和网关类型。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>当前controller使用的是普通参数绑定，不是<c>@RequestBody</c>，因此参数更适合按query/form方式传递。</description></item>
        /// <item><description><c>domain</c>字段会在服务端进行<c>trim + lowerCase</c>处理。</description></item>
        /// <item><description><c>query</c>和<c>headers</c>必须是JSON object字符串格式，不能为数组。</description></item>
        /// <item><description>创建操作仅将数据保存到数据库；只有在更新时，如果满足<c>ELEMENT/MATRIX + AI_GATEWAY + INTERNET</c>且域名或证书发生变化，才会触发AI Gateway域名同步逻辑。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceEndpointResponse
        /// </returns>
        public async Task<CreateServiceEndpointResponse> CreateServiceEndpointAsync(CreateServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建团队</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTeamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public CreateTeamResponse CreateTeamWithOptions(CreateTeamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTeamShrinkRequest request = new CreateTeamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TeamMembers))
            {
                request.TeamMembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TeamMembers, "TeamMembers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminName))
            {
                query["AdminName"] = request.AdminName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamMembersShrink))
            {
                query["TeamMembers"] = request.TeamMembersShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTeam",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTeamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建团队</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTeamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public async Task<CreateTeamResponse> CreateTeamWithOptionsAsync(CreateTeamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTeamShrinkRequest request = new CreateTeamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TeamMembers))
            {
                request.TeamMembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TeamMembers, "TeamMembers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminName))
            {
                query["AdminName"] = request.AdminName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamMembersShrink))
            {
                query["TeamMembers"] = request.TeamMembersShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTeam",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTeamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public CreateTeamResponse CreateTeam(CreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTeamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public async Task<CreateTeamResponse> CreateTeamAsync(CreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTeamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMethod))
            {
                query["AuthMethod"] = request.AuthMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMethod))
            {
                query["AuthMethod"] = request.AuthMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Worker</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWorkerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkerResponse
        /// </returns>
        public CreateWorkerResponse CreateWorkerWithOptions(CreateWorkerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkerShrinkRequest request = new CreateWorkerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Channels))
            {
                request.ChannelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Channels, "Channels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Credentials))
            {
                request.CredentialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Credentials, "Credentials", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Groups))
            {
                request.GroupsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Groups, "Groups", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LimitConfig))
            {
                request.LimitConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LimitConfig, "LimitConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.McpServers))
            {
                request.McpServersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.McpServers, "McpServers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Model))
            {
                request.ModelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Model, "Model", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Skills))
            {
                request.SkillsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Skills, "Skills", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Subagents))
            {
                request.SubagentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Subagents, "Subagents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Agents))
            {
                query["Agents"] = request.Agents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelsShrink))
            {
                query["Channels"] = request.ChannelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupsShrink))
            {
                query["Groups"] = request.GroupsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitConfigShrink))
            {
                query["LimitConfig"] = request.LimitConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServersShrink))
            {
                query["McpServers"] = request.McpServersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelShrink))
            {
                query["Model"] = request.ModelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillsShrink))
            {
                query["Skills"] = request.SkillsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Soul))
            {
                query["Soul"] = request.Soul;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubagentsShrink))
            {
                query["Subagents"] = request.SubagentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionCode))
            {
                query["VersionCode"] = request.VersionCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialsShrink))
            {
                body["Credentials"] = request.CredentialsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorker",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Worker</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWorkerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkerResponse
        /// </returns>
        public async Task<CreateWorkerResponse> CreateWorkerWithOptionsAsync(CreateWorkerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkerShrinkRequest request = new CreateWorkerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Channels))
            {
                request.ChannelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Channels, "Channels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Credentials))
            {
                request.CredentialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Credentials, "Credentials", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Groups))
            {
                request.GroupsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Groups, "Groups", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LimitConfig))
            {
                request.LimitConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LimitConfig, "LimitConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.McpServers))
            {
                request.McpServersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.McpServers, "McpServers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Model))
            {
                request.ModelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Model, "Model", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Skills))
            {
                request.SkillsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Skills, "Skills", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Subagents))
            {
                request.SubagentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Subagents, "Subagents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Agents))
            {
                query["Agents"] = request.Agents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelsShrink))
            {
                query["Channels"] = request.ChannelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupsShrink))
            {
                query["Groups"] = request.GroupsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitConfigShrink))
            {
                query["LimitConfig"] = request.LimitConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServersShrink))
            {
                query["McpServers"] = request.McpServersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelShrink))
            {
                query["Model"] = request.ModelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillsShrink))
            {
                query["Skills"] = request.SkillsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Soul))
            {
                query["Soul"] = request.Soul;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubagentsShrink))
            {
                query["Subagents"] = request.SubagentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionCode))
            {
                query["VersionCode"] = request.VersionCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialsShrink))
            {
                body["Credentials"] = request.CredentialsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorker",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Worker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkerResponse
        /// </returns>
        public CreateWorkerResponse CreateWorker(CreateWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Worker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkerResponse
        /// </returns>
        public async Task<CreateWorkerResponse> CreateWorkerAsync(CreateWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Worker本地纳管启动Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkerBootstrapTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkerBootstrapTokenResponse
        /// </returns>
        public CreateWorkerBootstrapTokenResponse CreateWorkerBootstrapTokenWithOptions(CreateWorkerBootstrapTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkerBootstrapToken",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkerBootstrapTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Worker本地纳管启动Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkerBootstrapTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkerBootstrapTokenResponse
        /// </returns>
        public async Task<CreateWorkerBootstrapTokenResponse> CreateWorkerBootstrapTokenWithOptionsAsync(CreateWorkerBootstrapTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkerBootstrapToken",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkerBootstrapTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Worker本地纳管启动Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkerBootstrapTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkerBootstrapTokenResponse
        /// </returns>
        public CreateWorkerBootstrapTokenResponse CreateWorkerBootstrapToken(CreateWorkerBootstrapTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkerBootstrapTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Worker本地纳管启动Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkerBootstrapTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkerBootstrapTokenResponse
        /// </returns>
        public async Task<CreateWorkerBootstrapTokenResponse> CreateWorkerBootstrapTokenAsync(CreateWorkerBootstrapTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkerBootstrapTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public DeleteCredentialResponse DeleteCredentialWithOptions(DeleteCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCredential",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public async Task<DeleteCredentialResponse> DeleteCredentialWithOptionsAsync(DeleteCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCredential",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public DeleteCredentialResponse DeleteCredential(DeleteCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public async Task<DeleteCredentialResponse> DeleteCredentialAsync(DeleteCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于释放指定的AgentTeams实例，并清理相关资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本API支持<c>GET</c>和<c>POST</c>方法，两者语义相同。</description></item>
        /// <item><description>使用<c>POST</c>方法时，参数通过<c>application/x-www-form-urlencoded</c>格式提交。</description></item>
        /// <item><description>当前实例状态为<c>CREATING</c>、<c>DELETING</c>或<c>DELETED</c>时，请求将被拒绝。</description></item>
        /// <item><description>成功调用后，实例状态将首先更改为<c>DELETING</c>，实际的资源清理过程由后台异步执行。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于释放指定的AgentTeams实例，并清理相关资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本API支持<c>GET</c>和<c>POST</c>方法，两者语义相同。</description></item>
        /// <item><description>使用<c>POST</c>方法时，参数通过<c>application/x-www-form-urlencoded</c>格式提交。</description></item>
        /// <item><description>当前实例状态为<c>CREATING</c>、<c>DELETING</c>或<c>DELETED</c>时，请求将被拒绝。</description></item>
        /// <item><description>成功调用后，实例状态将首先更改为<c>DELETING</c>，实际的资源清理过程由后台异步执行。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于释放指定的AgentTeams实例，并清理相关资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本API支持<c>GET</c>和<c>POST</c>方法，两者语义相同。</description></item>
        /// <item><description>使用<c>POST</c>方法时，参数通过<c>application/x-www-form-urlencoded</c>格式提交。</description></item>
        /// <item><description>当前实例状态为<c>CREATING</c>、<c>DELETING</c>或<c>DELETED</c>时，请求将被拒绝。</description></item>
        /// <item><description>成功调用后，实例状态将首先更改为<c>DELETING</c>，实际的资源清理过程由后台异步执行。</description></item>
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
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于释放指定的AgentTeams实例，并清理相关资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本API支持<c>GET</c>和<c>POST</c>方法，两者语义相同。</description></item>
        /// <item><description>使用<c>POST</c>方法时，参数通过<c>application/x-www-form-urlencoded</c>格式提交。</description></item>
        /// <item><description>当前实例状态为<c>CREATING</c>、<c>DELETING</c>或<c>DELETED</c>时，请求将被拒绝。</description></item>
        /// <item><description>成功调用后，实例状态将首先更改为<c>DELETING</c>，实际的资源清理过程由后台异步执行。</description></item>
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
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMcpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpResponse
        /// </returns>
        public DeleteMcpResponse DeleteMcpWithOptions(DeleteMcpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcp",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMcpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpResponse
        /// </returns>
        public async Task<DeleteMcpResponse> DeleteMcpWithOptionsAsync(DeleteMcpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcp",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpResponse
        /// </returns>
        public DeleteMcpResponse DeleteMcp(DeleteMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpResponse
        /// </returns>
        public async Task<DeleteMcpResponse> DeleteMcpAsync(DeleteMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModelWithOptions(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型供应商</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProviderResponse
        /// </returns>
        public DeleteModelProviderResponse DeleteModelProviderWithOptions(DeleteModelProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型供应商</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProviderResponse
        /// </returns>
        public async Task<DeleteModelProviderResponse> DeleteModelProviderWithOptionsAsync(DeleteModelProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型供应商</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProviderResponse
        /// </returns>
        public DeleteModelProviderResponse DeleteModelProvider(DeleteModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型供应商</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProviderResponse
        /// </returns>
        public async Task<DeleteModelProviderResponse> DeleteModelProviderAsync(DeleteModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于删除指定AgentTeams实例下的endpoint，并清理相关资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过GET或POST方法调用。</description></item>
        /// <item><description>如果目标endpoint是<c>WORKER</c>类型，系统将自动清理与之关联的APIG/AI Gateway云资源及KubeOne worker service配置。</description></item>
        /// <item><description>请求参数必须包含<c>instanceId</c>和<c>endpointId</c>，且不能为空。</description></item>
        /// <item><description>成功响应会返回HTTP状态码200以及成功标志；错误响应则根据具体情况返回相应的HTTP状态码（如400、404、409）及错误信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServiceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceEndpointResponse
        /// </returns>
        public DeleteServiceEndpointResponse DeleteServiceEndpointWithOptions(DeleteServiceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceEndpoint",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于删除指定AgentTeams实例下的endpoint，并清理相关资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过GET或POST方法调用。</description></item>
        /// <item><description>如果目标endpoint是<c>WORKER</c>类型，系统将自动清理与之关联的APIG/AI Gateway云资源及KubeOne worker service配置。</description></item>
        /// <item><description>请求参数必须包含<c>instanceId</c>和<c>endpointId</c>，且不能为空。</description></item>
        /// <item><description>成功响应会返回HTTP状态码200以及成功标志；错误响应则根据具体情况返回相应的HTTP状态码（如400、404、409）及错误信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServiceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceEndpointResponse
        /// </returns>
        public async Task<DeleteServiceEndpointResponse> DeleteServiceEndpointWithOptionsAsync(DeleteServiceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceEndpoint",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于删除指定AgentTeams实例下的endpoint，并清理相关资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过GET或POST方法调用。</description></item>
        /// <item><description>如果目标endpoint是<c>WORKER</c>类型，系统将自动清理与之关联的APIG/AI Gateway云资源及KubeOne worker service配置。</description></item>
        /// <item><description>请求参数必须包含<c>instanceId</c>和<c>endpointId</c>，且不能为空。</description></item>
        /// <item><description>成功响应会返回HTTP状态码200以及成功标志；错误响应则根据具体情况返回相应的HTTP状态码（如400、404、409）及错误信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceEndpointResponse
        /// </returns>
        public DeleteServiceEndpointResponse DeleteServiceEndpoint(DeleteServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于删除指定AgentTeams实例下的endpoint，并清理相关资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过GET或POST方法调用。</description></item>
        /// <item><description>如果目标endpoint是<c>WORKER</c>类型，系统将自动清理与之关联的APIG/AI Gateway云资源及KubeOne worker service配置。</description></item>
        /// <item><description>请求参数必须包含<c>instanceId</c>和<c>endpointId</c>，且不能为空。</description></item>
        /// <item><description>成功响应会返回HTTP状态码200以及成功标志；错误响应则根据具体情况返回相应的HTTP状态码（如400、404、409）及错误信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceEndpointResponse
        /// </returns>
        public async Task<DeleteServiceEndpointResponse> DeleteServiceEndpointAsync(DeleteServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public DeleteTeamResponse DeleteTeamWithOptions(DeleteTeamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteTeam",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTeamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public async Task<DeleteTeamResponse> DeleteTeamWithOptionsAsync(DeleteTeamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteTeam",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTeamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public DeleteTeamResponse DeleteTeam(DeleteTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTeamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public async Task<DeleteTeamResponse> DeleteTeamAsync(DeleteTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTeamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteUser",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteUser",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Worker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkerResponse
        /// </returns>
        public DeleteWorkerResponse DeleteWorkerWithOptions(DeleteWorkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteWorker",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Worker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkerResponse
        /// </returns>
        public async Task<DeleteWorkerResponse> DeleteWorkerWithOptionsAsync(DeleteWorkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteWorker",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Worker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkerResponse
        /// </returns>
        public DeleteWorkerResponse DeleteWorker(DeleteWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Worker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkerResponse
        /// </returns>
        public async Task<DeleteWorkerResponse> DeleteWorkerAsync(DeleteWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public GetCredentialResponse GetCredentialWithOptions(GetCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetCredential",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public async Task<GetCredentialResponse> GetCredentialWithOptionsAsync(GetCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetCredential",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public GetCredentialResponse GetCredential(GetCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public async Task<GetCredentialResponse> GetCredentialAsync(GetCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定类型的上游身份提供商详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityProviderResponse
        /// </returns>
        public GetIdentityProviderResponse GetIdentityProviderWithOptions(GetIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                query["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定类型的上游身份提供商详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityProviderResponse
        /// </returns>
        public async Task<GetIdentityProviderResponse> GetIdentityProviderWithOptionsAsync(GetIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                query["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定类型的上游身份提供商详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityProviderResponse
        /// </returns>
        public GetIdentityProviderResponse GetIdentityProvider(GetIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定类型的上游身份提供商详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityProviderResponse
        /// </returns>
        public async Task<GetIdentityProviderResponse> GetIdentityProviderAsync(GetIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例ID查询指定实例的详细信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持<c>GET</c>和<c>POST</c>方法。</description></item>
        /// <item><description>请求时必须在头部包含<c>X-User-Id</c>，用于校验实例归属。</description></item>
        /// <item><description><c>X-Acs-Request-Id</c>为可选项，如果提供，则响应中的<c>requestId</c>将优先使用此值。</description></item>
        /// <item><description>必须通过<c>instanceId</c>参数指定要查询的实例。</description></item>
        /// <item><description>成功响应会返回实例的详细配置信息及状态。</description></item>
        /// <item><description>如果请求失败，根据错误类型返回相应的HTTP状态码及错误消息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例ID查询指定实例的详细信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持<c>GET</c>和<c>POST</c>方法。</description></item>
        /// <item><description>请求时必须在头部包含<c>X-User-Id</c>，用于校验实例归属。</description></item>
        /// <item><description><c>X-Acs-Request-Id</c>为可选项，如果提供，则响应中的<c>requestId</c>将优先使用此值。</description></item>
        /// <item><description>必须通过<c>instanceId</c>参数指定要查询的实例。</description></item>
        /// <item><description>成功响应会返回实例的详细配置信息及状态。</description></item>
        /// <item><description>如果请求失败，根据错误类型返回相应的HTTP状态码及错误消息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例ID查询指定实例的详细信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持<c>GET</c>和<c>POST</c>方法。</description></item>
        /// <item><description>请求时必须在头部包含<c>X-User-Id</c>，用于校验实例归属。</description></item>
        /// <item><description><c>X-Acs-Request-Id</c>为可选项，如果提供，则响应中的<c>requestId</c>将优先使用此值。</description></item>
        /// <item><description>必须通过<c>instanceId</c>参数指定要查询的实例。</description></item>
        /// <item><description>成功响应会返回实例的详细配置信息及状态。</description></item>
        /// <item><description>如果请求失败，根据错误类型返回相应的HTTP状态码及错误消息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例ID查询指定实例的详细信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持<c>GET</c>和<c>POST</c>方法。</description></item>
        /// <item><description>请求时必须在头部包含<c>X-User-Id</c>，用于校验实例归属。</description></item>
        /// <item><description><c>X-Acs-Request-Id</c>为可选项，如果提供，则响应中的<c>requestId</c>将优先使用此值。</description></item>
        /// <item><description>必须通过<c>instanceId</c>参数指定要查询的实例。</description></item>
        /// <item><description>成功响应会返回实例的详细配置信息及状态。</description></item>
        /// <item><description>如果请求失败，根据错误类型返回相应的HTTP状态码及错误消息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定AgentTeams实例关联的异步任务状态，支持分页。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询特定AgentTeams实例下的异步任务执行状态。</description></item>
        /// <item><description>目前仅支持查询与实例生命周期相关的创建实例任务。</description></item>
        /// <item><description>可通过<c>taskCode</c>参数指定要查询的任务类型，默认为创建实例任务。</description></item>
        /// <item><description>支持使用<c>maxResults</c>和<c>nextToken</c>进行结果分页。</description></item>
        /// <item><description>当任务处于暂停(<c>PAUSED</c>)状态时，会返回用户需要采取行动的信息(<c>recoveryMessage</c>)。</description></item>
        /// <item><description>注意：当前不支持通过<c>taskId</c>直接查询任务状态。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceAsyncTaskResponse
        /// </returns>
        public GetInstanceAsyncTaskResponse GetInstanceAsyncTaskWithOptions(GetInstanceAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCode))
            {
                query["TaskCode"] = request.TaskCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceAsyncTask",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定AgentTeams实例关联的异步任务状态，支持分页。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询特定AgentTeams实例下的异步任务执行状态。</description></item>
        /// <item><description>目前仅支持查询与实例生命周期相关的创建实例任务。</description></item>
        /// <item><description>可通过<c>taskCode</c>参数指定要查询的任务类型，默认为创建实例任务。</description></item>
        /// <item><description>支持使用<c>maxResults</c>和<c>nextToken</c>进行结果分页。</description></item>
        /// <item><description>当任务处于暂停(<c>PAUSED</c>)状态时，会返回用户需要采取行动的信息(<c>recoveryMessage</c>)。</description></item>
        /// <item><description>注意：当前不支持通过<c>taskId</c>直接查询任务状态。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceAsyncTaskResponse
        /// </returns>
        public async Task<GetInstanceAsyncTaskResponse> GetInstanceAsyncTaskWithOptionsAsync(GetInstanceAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCode))
            {
                query["TaskCode"] = request.TaskCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceAsyncTask",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定AgentTeams实例关联的异步任务状态，支持分页。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询特定AgentTeams实例下的异步任务执行状态。</description></item>
        /// <item><description>目前仅支持查询与实例生命周期相关的创建实例任务。</description></item>
        /// <item><description>可通过<c>taskCode</c>参数指定要查询的任务类型，默认为创建实例任务。</description></item>
        /// <item><description>支持使用<c>maxResults</c>和<c>nextToken</c>进行结果分页。</description></item>
        /// <item><description>当任务处于暂停(<c>PAUSED</c>)状态时，会返回用户需要采取行动的信息(<c>recoveryMessage</c>)。</description></item>
        /// <item><description>注意：当前不支持通过<c>taskId</c>直接查询任务状态。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceAsyncTaskResponse
        /// </returns>
        public GetInstanceAsyncTaskResponse GetInstanceAsyncTask(GetInstanceAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceAsyncTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定AgentTeams实例关联的异步任务状态，支持分页。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询特定AgentTeams实例下的异步任务执行状态。</description></item>
        /// <item><description>目前仅支持查询与实例生命周期相关的创建实例任务。</description></item>
        /// <item><description>可通过<c>taskCode</c>参数指定要查询的任务类型，默认为创建实例任务。</description></item>
        /// <item><description>支持使用<c>maxResults</c>和<c>nextToken</c>进行结果分页。</description></item>
        /// <item><description>当任务处于暂停(<c>PAUSED</c>)状态时，会返回用户需要采取行动的信息(<c>recoveryMessage</c>)。</description></item>
        /// <item><description>注意：当前不支持通过<c>taskId</c>直接查询任务状态。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceAsyncTaskResponse
        /// </returns>
        public async Task<GetInstanceAsyncTaskResponse> GetInstanceAsyncTaskAsync(GetInstanceAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceAsyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例 OSS 挂载到 ACS 所需的 RAM 授权链接。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持<c>GET</c>和<c>POST</c>方法。</description></item>
        /// <item><description>请求时必须在头部包含<c>X-User-Id</c>，用于校验实例归属。</description></item>
        /// <item><description>必须通过<c>instanceId</c>参数指定实例，后端会根据实例信息生成授权链接。</description></item>
        /// <item><description>成功响应会返回 RAM 控制台授权链接，不会创建 RAM 角色或策略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceOssMountRamAuthorizeUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceOssMountRamAuthorizeUrlResponse
        /// </returns>
        public GetInstanceOssMountRamAuthorizeUrlResponse GetInstanceOssMountRamAuthorizeUrlWithOptions(GetInstanceOssMountRamAuthorizeUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceOssMountRamAuthorizeUrl",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceOssMountRamAuthorizeUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例 OSS 挂载到 ACS 所需的 RAM 授权链接。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持<c>GET</c>和<c>POST</c>方法。</description></item>
        /// <item><description>请求时必须在头部包含<c>X-User-Id</c>，用于校验实例归属。</description></item>
        /// <item><description>必须通过<c>instanceId</c>参数指定实例，后端会根据实例信息生成授权链接。</description></item>
        /// <item><description>成功响应会返回 RAM 控制台授权链接，不会创建 RAM 角色或策略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceOssMountRamAuthorizeUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceOssMountRamAuthorizeUrlResponse
        /// </returns>
        public async Task<GetInstanceOssMountRamAuthorizeUrlResponse> GetInstanceOssMountRamAuthorizeUrlWithOptionsAsync(GetInstanceOssMountRamAuthorizeUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceOssMountRamAuthorizeUrl",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceOssMountRamAuthorizeUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例 OSS 挂载到 ACS 所需的 RAM 授权链接。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持<c>GET</c>和<c>POST</c>方法。</description></item>
        /// <item><description>请求时必须在头部包含<c>X-User-Id</c>，用于校验实例归属。</description></item>
        /// <item><description>必须通过<c>instanceId</c>参数指定实例，后端会根据实例信息生成授权链接。</description></item>
        /// <item><description>成功响应会返回 RAM 控制台授权链接，不会创建 RAM 角色或策略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceOssMountRamAuthorizeUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceOssMountRamAuthorizeUrlResponse
        /// </returns>
        public GetInstanceOssMountRamAuthorizeUrlResponse GetInstanceOssMountRamAuthorizeUrl(GetInstanceOssMountRamAuthorizeUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceOssMountRamAuthorizeUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例 OSS 挂载到 ACS 所需的 RAM 授权链接。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持<c>GET</c>和<c>POST</c>方法。</description></item>
        /// <item><description>请求时必须在头部包含<c>X-User-Id</c>，用于校验实例归属。</description></item>
        /// <item><description>必须通过<c>instanceId</c>参数指定实例，后端会根据实例信息生成授权链接。</description></item>
        /// <item><description>成功响应会返回 RAM 控制台授权链接，不会创建 RAM 角色或策略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceOssMountRamAuthorizeUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceOssMountRamAuthorizeUrlResponse
        /// </returns>
        public async Task<GetInstanceOssMountRamAuthorizeUrlResponse> GetInstanceOssMountRamAuthorizeUrlAsync(GetInstanceOssMountRamAuthorizeUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceOssMountRamAuthorizeUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询MCP详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMcpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcpResponse
        /// </returns>
        public GetMcpResponse GetMcpWithOptions(GetMcpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcp",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询MCP详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMcpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcpResponse
        /// </returns>
        public async Task<GetMcpResponse> GetMcpWithOptionsAsync(GetMcpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcp",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询MCP详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcpResponse
        /// </returns>
        public GetMcpResponse GetMcp(GetMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询MCP详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcpResponse
        /// </returns>
        public async Task<GetMcpResponse> GetMcpAsync(GetMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型调用摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInvocationSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelInvocationSummaryResponse
        /// </returns>
        public GetModelInvocationSummaryResponse GetModelInvocationSummaryWithOptions(GetModelInvocationSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelInvocationSummary",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelInvocationSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型调用摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInvocationSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelInvocationSummaryResponse
        /// </returns>
        public async Task<GetModelInvocationSummaryResponse> GetModelInvocationSummaryWithOptionsAsync(GetModelInvocationSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelInvocationSummary",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelInvocationSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型调用摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInvocationSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelInvocationSummaryResponse
        /// </returns>
        public GetModelInvocationSummaryResponse GetModelInvocationSummary(GetModelInvocationSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelInvocationSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型调用摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInvocationSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelInvocationSummaryResponse
        /// </returns>
        public async Task<GetModelInvocationSummaryResponse> GetModelInvocationSummaryAsync(GetModelInvocationSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelInvocationSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型供应商详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelProviderResponse
        /// </returns>
        public GetModelProviderResponse GetModelProviderWithOptions(GetModelProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型供应商详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelProviderResponse
        /// </returns>
        public async Task<GetModelProviderResponse> GetModelProviderWithOptionsAsync(GetModelProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型供应商详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelProviderResponse
        /// </returns>
        public GetModelProviderResponse GetModelProvider(GetModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型供应商详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelProviderResponse
        /// </returns>
        public async Task<GetModelProviderResponse> GetModelProviderAsync(GetModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定实例的NAT网关及其SNAT规则的配置状态。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过此API，您可以获取特定实例关联的NAT网关配置详情及SNAT规则的状态。该接口支持GET或POST方法调用，并需要提供<c>instanceId</c>作为请求参数来指定要查询的实例。</para>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description>确保提供的<c>instanceId</c>是有效的且属于您的账户。</description></item>
        /// <item><description>根据返回的状态值（如<c>READY</c>, <c>NEED_CONFIGURE_NAT_GATEWAY</c>, <c>NEED_CONFIGURE_SNAT_RULE</c>），采取相应的操作以完成NAT网关或SNAT规则的配置。</description></item>
        /// <item><description>当状态为<c>NEED_CONFIGURE_NAT_GATEWAY</c>时，表示当前VPC下没有可用的NAT网关；而<c>NEED_CONFIGURE_SNAT_RULE</c>则意味着虽然存在NAT网关但某些子网CIDR未被SNAT规则覆盖。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNatGatewayStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNatGatewayStatusResponse
        /// </returns>
        public GetNatGatewayStatusResponse GetNatGatewayStatusWithOptions(GetNatGatewayStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNatGatewayStatus",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNatGatewayStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定实例的NAT网关及其SNAT规则的配置状态。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过此API，您可以获取特定实例关联的NAT网关配置详情及SNAT规则的状态。该接口支持GET或POST方法调用，并需要提供<c>instanceId</c>作为请求参数来指定要查询的实例。</para>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description>确保提供的<c>instanceId</c>是有效的且属于您的账户。</description></item>
        /// <item><description>根据返回的状态值（如<c>READY</c>, <c>NEED_CONFIGURE_NAT_GATEWAY</c>, <c>NEED_CONFIGURE_SNAT_RULE</c>），采取相应的操作以完成NAT网关或SNAT规则的配置。</description></item>
        /// <item><description>当状态为<c>NEED_CONFIGURE_NAT_GATEWAY</c>时，表示当前VPC下没有可用的NAT网关；而<c>NEED_CONFIGURE_SNAT_RULE</c>则意味着虽然存在NAT网关但某些子网CIDR未被SNAT规则覆盖。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNatGatewayStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNatGatewayStatusResponse
        /// </returns>
        public async Task<GetNatGatewayStatusResponse> GetNatGatewayStatusWithOptionsAsync(GetNatGatewayStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNatGatewayStatus",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNatGatewayStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定实例的NAT网关及其SNAT规则的配置状态。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过此API，您可以获取特定实例关联的NAT网关配置详情及SNAT规则的状态。该接口支持GET或POST方法调用，并需要提供<c>instanceId</c>作为请求参数来指定要查询的实例。</para>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description>确保提供的<c>instanceId</c>是有效的且属于您的账户。</description></item>
        /// <item><description>根据返回的状态值（如<c>READY</c>, <c>NEED_CONFIGURE_NAT_GATEWAY</c>, <c>NEED_CONFIGURE_SNAT_RULE</c>），采取相应的操作以完成NAT网关或SNAT规则的配置。</description></item>
        /// <item><description>当状态为<c>NEED_CONFIGURE_NAT_GATEWAY</c>时，表示当前VPC下没有可用的NAT网关；而<c>NEED_CONFIGURE_SNAT_RULE</c>则意味着虽然存在NAT网关但某些子网CIDR未被SNAT规则覆盖。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNatGatewayStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNatGatewayStatusResponse
        /// </returns>
        public GetNatGatewayStatusResponse GetNatGatewayStatus(GetNatGatewayStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNatGatewayStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定实例的NAT网关及其SNAT规则的配置状态。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过此API，您可以获取特定实例关联的NAT网关配置详情及SNAT规则的状态。该接口支持GET或POST方法调用，并需要提供<c>instanceId</c>作为请求参数来指定要查询的实例。</para>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description>确保提供的<c>instanceId</c>是有效的且属于您的账户。</description></item>
        /// <item><description>根据返回的状态值（如<c>READY</c>, <c>NEED_CONFIGURE_NAT_GATEWAY</c>, <c>NEED_CONFIGURE_SNAT_RULE</c>），采取相应的操作以完成NAT网关或SNAT规则的配置。</description></item>
        /// <item><description>当状态为<c>NEED_CONFIGURE_NAT_GATEWAY</c>时，表示当前VPC下没有可用的NAT网关；而<c>NEED_CONFIGURE_SNAT_RULE</c>则意味着虽然存在NAT网关但某些子网CIDR未被SNAT规则覆盖。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNatGatewayStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNatGatewayStatusResponse
        /// </returns>
        public async Task<GetNatGatewayStatusResponse> GetNatGatewayStatusAsync(GetNatGatewayStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNatGatewayStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定ID的Endpoint详细信息，支持通过实例ID进行校验。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于根据<c>endpointId</c>查询单个Endpoint的具体配置与状态信息。</description></item>
        /// <item><description>可选参数<c>instanceId</c>用于验证Endpoint是否属于特定实例。</description></item>
        /// <item><description>请求方式支持<c>GET</c>和<c>POST</c>，其中<c>GET</c>使用query string传递参数，而<c>POST</c>则可以通过form参数提交。</description></item>
        /// <item><description>如果<c>endpointId</c>缺失或为空，则会返回<c>InvalidParameter</c>错误。</description></item>
        /// <item><description>当请求的Endpoint不存在、不属于提供的实例或者不属于当前用户时，将收到相应的资源不存在类错误响应。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointResponse
        /// </returns>
        public GetServiceEndpointResponse GetServiceEndpointWithOptions(GetServiceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceEndpoint",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定ID的Endpoint详细信息，支持通过实例ID进行校验。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于根据<c>endpointId</c>查询单个Endpoint的具体配置与状态信息。</description></item>
        /// <item><description>可选参数<c>instanceId</c>用于验证Endpoint是否属于特定实例。</description></item>
        /// <item><description>请求方式支持<c>GET</c>和<c>POST</c>，其中<c>GET</c>使用query string传递参数，而<c>POST</c>则可以通过form参数提交。</description></item>
        /// <item><description>如果<c>endpointId</c>缺失或为空，则会返回<c>InvalidParameter</c>错误。</description></item>
        /// <item><description>当请求的Endpoint不存在、不属于提供的实例或者不属于当前用户时，将收到相应的资源不存在类错误响应。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointResponse
        /// </returns>
        public async Task<GetServiceEndpointResponse> GetServiceEndpointWithOptionsAsync(GetServiceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceEndpoint",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定ID的Endpoint详细信息，支持通过实例ID进行校验。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于根据<c>endpointId</c>查询单个Endpoint的具体配置与状态信息。</description></item>
        /// <item><description>可选参数<c>instanceId</c>用于验证Endpoint是否属于特定实例。</description></item>
        /// <item><description>请求方式支持<c>GET</c>和<c>POST</c>，其中<c>GET</c>使用query string传递参数，而<c>POST</c>则可以通过form参数提交。</description></item>
        /// <item><description>如果<c>endpointId</c>缺失或为空，则会返回<c>InvalidParameter</c>错误。</description></item>
        /// <item><description>当请求的Endpoint不存在、不属于提供的实例或者不属于当前用户时，将收到相应的资源不存在类错误响应。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointResponse
        /// </returns>
        public GetServiceEndpointResponse GetServiceEndpoint(GetServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定ID的Endpoint详细信息，支持通过实例ID进行校验。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于根据<c>endpointId</c>查询单个Endpoint的具体配置与状态信息。</description></item>
        /// <item><description>可选参数<c>instanceId</c>用于验证Endpoint是否属于特定实例。</description></item>
        /// <item><description>请求方式支持<c>GET</c>和<c>POST</c>，其中<c>GET</c>使用query string传递参数，而<c>POST</c>则可以通过form参数提交。</description></item>
        /// <item><description>如果<c>endpointId</c>缺失或为空，则会返回<c>InvalidParameter</c>错误。</description></item>
        /// <item><description>当请求的Endpoint不存在、不属于提供的实例或者不属于当前用户时，将收到相应的资源不存在类错误响应。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointResponse
        /// </returns>
        public async Task<GetServiceEndpointResponse> GetServiceEndpointAsync(GetServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务统计摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatsSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatsSummaryResponse
        /// </returns>
        public GetTaskStatsSummaryResponse GetTaskStatsSummaryWithOptions(GetTaskStatsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatsSummary",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务统计摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatsSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatsSummaryResponse
        /// </returns>
        public async Task<GetTaskStatsSummaryResponse> GetTaskStatsSummaryWithOptionsAsync(GetTaskStatsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatsSummary",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务统计摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatsSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatsSummaryResponse
        /// </returns>
        public GetTaskStatsSummaryResponse GetTaskStatsSummary(GetTaskStatsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskStatsSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务统计摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatsSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatsSummaryResponse
        /// </returns>
        public async Task<GetTaskStatsSummaryResponse> GetTaskStatsSummaryAsync(GetTaskStatsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskStatsSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public GetTeamResponse GetTeamWithOptions(GetTeamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetTeam",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTeamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public async Task<GetTeamResponse> GetTeamWithOptionsAsync(GetTeamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetTeam",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTeamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public GetTeamResponse GetTeam(GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTeamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public async Task<GetTeamResponse> GetTeamAsync(GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTeamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Token趋势统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenTrendResponse
        /// </returns>
        public GetTokenTrendResponse GetTokenTrendWithOptions(GetTokenTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenTrend",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenTrendResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Token趋势统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenTrendResponse
        /// </returns>
        public async Task<GetTokenTrendResponse> GetTokenTrendWithOptionsAsync(GetTokenTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenTrend",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Token趋势统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenTrendResponse
        /// </returns>
        public GetTokenTrendResponse GetTokenTrend(GetTokenTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTokenTrendWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Token趋势统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenTrendResponse
        /// </returns>
        public async Task<GetTokenTrendResponse> GetTokenTrendAsync(GetTokenTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTokenTrendWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工具调用分布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetToolCallDistributionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetToolCallDistributionResponse
        /// </returns>
        public GetToolCallDistributionResponse GetToolCallDistributionWithOptions(GetToolCallDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToolCallDistribution",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetToolCallDistributionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工具调用分布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetToolCallDistributionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetToolCallDistributionResponse
        /// </returns>
        public async Task<GetToolCallDistributionResponse> GetToolCallDistributionWithOptionsAsync(GetToolCallDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToolCallDistribution",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetToolCallDistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工具调用分布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetToolCallDistributionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetToolCallDistributionResponse
        /// </returns>
        public GetToolCallDistributionResponse GetToolCallDistribution(GetToolCallDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetToolCallDistributionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工具调用分布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetToolCallDistributionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetToolCallDistributionResponse
        /// </returns>
        public async Task<GetToolCallDistributionResponse> GetToolCallDistributionAsync(GetToolCallDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetToolCallDistributionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetUser",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetUser",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户初始密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserPasswordResponse
        /// </returns>
        public GetUserPasswordResponse GetUserPasswordWithOptions(GetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetUserPassword",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户初始密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserPasswordResponse
        /// </returns>
        public async Task<GetUserPasswordResponse> GetUserPasswordWithOptionsAsync(GetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetUserPassword",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户初始密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserPasswordResponse
        /// </returns>
        public GetUserPasswordResponse GetUserPassword(GetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户初始密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserPasswordResponse
        /// </returns>
        public async Task<GetUserPasswordResponse> GetUserPasswordAsync(GetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerResponse
        /// </returns>
        public GetWorkerResponse GetWorkerWithOptions(GetWorkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetWorker",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerResponse
        /// </returns>
        public async Task<GetWorkerResponse> GetWorkerWithOptionsAsync(GetWorkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetWorker",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerResponse
        /// </returns>
        public GetWorkerResponse GetWorker(GetWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerResponse
        /// </returns>
        public async Task<GetWorkerResponse> GetWorkerAsync(GetWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker本地纳管启动选项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerBootstrapOptionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerBootstrapOptionsResponse
        /// </returns>
        public GetWorkerBootstrapOptionsResponse GetWorkerBootstrapOptionsWithOptions(GetWorkerBootstrapOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetWorkerBootstrapOptions",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerBootstrapOptionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker本地纳管启动选项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerBootstrapOptionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerBootstrapOptionsResponse
        /// </returns>
        public async Task<GetWorkerBootstrapOptionsResponse> GetWorkerBootstrapOptionsWithOptionsAsync(GetWorkerBootstrapOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetWorkerBootstrapOptions",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerBootstrapOptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker本地纳管启动选项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerBootstrapOptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerBootstrapOptionsResponse
        /// </returns>
        public GetWorkerBootstrapOptionsResponse GetWorkerBootstrapOptions(GetWorkerBootstrapOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkerBootstrapOptionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker本地纳管启动选项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerBootstrapOptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerBootstrapOptionsResponse
        /// </returns>
        public async Task<GetWorkerBootstrapOptionsResponse> GetWorkerBootstrapOptionsAsync(GetWorkerBootstrapOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkerBootstrapOptionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker最大可升级版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerMaxVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerMaxVersionResponse
        /// </returns>
        public GetWorkerMaxVersionResponse GetWorkerMaxVersionWithOptions(GetWorkerMaxVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkerMaxVersion",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerMaxVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker最大可升级版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerMaxVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerMaxVersionResponse
        /// </returns>
        public async Task<GetWorkerMaxVersionResponse> GetWorkerMaxVersionWithOptionsAsync(GetWorkerMaxVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkerMaxVersion",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerMaxVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker最大可升级版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerMaxVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerMaxVersionResponse
        /// </returns>
        public GetWorkerMaxVersionResponse GetWorkerMaxVersion(GetWorkerMaxVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkerMaxVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker最大可升级版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerMaxVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerMaxVersionResponse
        /// </returns>
        public async Task<GetWorkerMaxVersionResponse> GetWorkerMaxVersionAsync(GetWorkerMaxVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkerMaxVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Worker统计摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerStatsSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerStatsSummaryResponse
        /// </returns>
        public GetWorkerStatsSummaryResponse GetWorkerStatsSummaryWithOptions(GetWorkerStatsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkerStatsSummary",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerStatsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Worker统计摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerStatsSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerStatsSummaryResponse
        /// </returns>
        public async Task<GetWorkerStatsSummaryResponse> GetWorkerStatsSummaryWithOptionsAsync(GetWorkerStatsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkerStatsSummary",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerStatsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Worker统计摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerStatsSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerStatsSummaryResponse
        /// </returns>
        public GetWorkerStatsSummaryResponse GetWorkerStatsSummary(GetWorkerStatsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkerStatsSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Worker统计摘要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkerStatsSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkerStatsSummaryResponse
        /// </returns>
        public async Task<GetWorkerStatsSummaryResponse> GetWorkerStatsSummaryAsync(GetWorkerStatsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkerStatsSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public ListCredentialsResponse ListCredentialsWithOptions(ListCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["NameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCredentials",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public async Task<ListCredentialsResponse> ListCredentialsWithOptionsAsync(ListCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["NameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCredentials",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public ListCredentialsResponse ListCredentials(ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCredentialsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public async Task<ListCredentialsResponse> ListCredentialsAsync(ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCredentialsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上游身份提供商绑定列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdentityProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdentityProvidersResponse
        /// </returns>
        public ListIdentityProvidersResponse ListIdentityProvidersWithOptions(ListIdentityProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentityProviders",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentityProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上游身份提供商绑定列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdentityProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdentityProvidersResponse
        /// </returns>
        public async Task<ListIdentityProvidersResponse> ListIdentityProvidersWithOptionsAsync(ListIdentityProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentityProviders",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentityProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上游身份提供商绑定列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdentityProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdentityProvidersResponse
        /// </returns>
        public ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIdentityProvidersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上游身份提供商绑定列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdentityProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdentityProvidersResponse
        /// </returns>
        public async Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIdentityProvidersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于查询符合条件的实例列表，并支持分页和模糊匹配。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>分页规则</b>：<list type="bullet">
        /// <item><description>如果传了 <c>NextToken</c>，优先按 <c>NextToken</c> 解析 offset。</description></item>
        /// <item><description>如果没传 <c>NextToken</c>，则使用 <c>skip</c>。</description></item>
        /// <item><description><c>MaxResults</c> 的取值范围为 1 到 100，非法值会返回 <c>400</c> 错误。</description></item>
        /// <item><description><c>NextToken</c> 必须是有效的整数，否则会返回 <c>400</c> 错误。</description></item>
        /// <item><description><c>skip</c> 的值不能小于 0，否则会返回 <c>400</c> 错误。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>排序规则</b>：列表按创建时间倒序返回。</description></item>
        /// <item><description><b>请求参数</b>：<list type="bullet">
        /// <item><description><c>instanceName</c>：实例名称，支持模糊匹配。</description></item>
        /// <item><description><c>status</c>：实例状态。</description></item>
        /// <item><description><c>MaxResults</c>：分页大小，默认值为 20。</description></item>
        /// <item><description><c>NextToken</c>：下一页游标。</description></item>
        /// <item><description><c>skip</c>：跳过的记录数，默认值为 0。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于查询符合条件的实例列表，并支持分页和模糊匹配。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>分页规则</b>：<list type="bullet">
        /// <item><description>如果传了 <c>NextToken</c>，优先按 <c>NextToken</c> 解析 offset。</description></item>
        /// <item><description>如果没传 <c>NextToken</c>，则使用 <c>skip</c>。</description></item>
        /// <item><description><c>MaxResults</c> 的取值范围为 1 到 100，非法值会返回 <c>400</c> 错误。</description></item>
        /// <item><description><c>NextToken</c> 必须是有效的整数，否则会返回 <c>400</c> 错误。</description></item>
        /// <item><description><c>skip</c> 的值不能小于 0，否则会返回 <c>400</c> 错误。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>排序规则</b>：列表按创建时间倒序返回。</description></item>
        /// <item><description><b>请求参数</b>：<list type="bullet">
        /// <item><description><c>instanceName</c>：实例名称，支持模糊匹配。</description></item>
        /// <item><description><c>status</c>：实例状态。</description></item>
        /// <item><description><c>MaxResults</c>：分页大小，默认值为 20。</description></item>
        /// <item><description><c>NextToken</c>：下一页游标。</description></item>
        /// <item><description><c>skip</c>：跳过的记录数，默认值为 0。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于查询符合条件的实例列表，并支持分页和模糊匹配。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>分页规则</b>：<list type="bullet">
        /// <item><description>如果传了 <c>NextToken</c>，优先按 <c>NextToken</c> 解析 offset。</description></item>
        /// <item><description>如果没传 <c>NextToken</c>，则使用 <c>skip</c>。</description></item>
        /// <item><description><c>MaxResults</c> 的取值范围为 1 到 100，非法值会返回 <c>400</c> 错误。</description></item>
        /// <item><description><c>NextToken</c> 必须是有效的整数，否则会返回 <c>400</c> 错误。</description></item>
        /// <item><description><c>skip</c> 的值不能小于 0，否则会返回 <c>400</c> 错误。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>排序规则</b>：列表按创建时间倒序返回。</description></item>
        /// <item><description><b>请求参数</b>：<list type="bullet">
        /// <item><description><c>instanceName</c>：实例名称，支持模糊匹配。</description></item>
        /// <item><description><c>status</c>：实例状态。</description></item>
        /// <item><description><c>MaxResults</c>：分页大小，默认值为 20。</description></item>
        /// <item><description><c>NextToken</c>：下一页游标。</description></item>
        /// <item><description><c>skip</c>：跳过的记录数，默认值为 0。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
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
            return ListInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于查询符合条件的实例列表，并支持分页和模糊匹配。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>分页规则</b>：<list type="bullet">
        /// <item><description>如果传了 <c>NextToken</c>，优先按 <c>NextToken</c> 解析 offset。</description></item>
        /// <item><description>如果没传 <c>NextToken</c>，则使用 <c>skip</c>。</description></item>
        /// <item><description><c>MaxResults</c> 的取值范围为 1 到 100，非法值会返回 <c>400</c> 错误。</description></item>
        /// <item><description><c>NextToken</c> 必须是有效的整数，否则会返回 <c>400</c> 错误。</description></item>
        /// <item><description><c>skip</c> 的值不能小于 0，否则会返回 <c>400</c> 错误。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>排序规则</b>：列表按创建时间倒序返回。</description></item>
        /// <item><description><b>请求参数</b>：<list type="bullet">
        /// <item><description><c>instanceName</c>：实例名称，支持模糊匹配。</description></item>
        /// <item><description><c>status</c>：实例状态。</description></item>
        /// <item><description><c>MaxResults</c>：分页大小，默认值为 20。</description></item>
        /// <item><description><c>NextToken</c>：下一页游标。</description></item>
        /// <item><description><c>skip</c>：跳过的记录数，默认值为 0。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
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
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试模型供应商和模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有Magic实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpToolsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpToolsResponse
        /// </returns>
        public ListMcpToolsResponse ListMcpToolsWithOptions(ListMcpToolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcpTools",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpToolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试模型供应商和模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有Magic实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpToolsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpToolsResponse
        /// </returns>
        public async Task<ListMcpToolsResponse> ListMcpToolsWithOptionsAsync(ListMcpToolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcpTools",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpToolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试模型供应商和模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有Magic实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpToolsResponse
        /// </returns>
        public ListMcpToolsResponse ListMcpTools(ListMcpToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcpToolsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试模型供应商和模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有Magic实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpToolsResponse
        /// </returns>
        public async Task<ListMcpToolsResponse> ListMcpToolsAsync(ListMcpToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcpToolsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询MCP列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpsResponse
        /// </returns>
        public ListMcpsResponse ListMcpsWithOptions(ListMcpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcps",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询MCP列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpsResponse
        /// </returns>
        public async Task<ListMcpsResponse> ListMcpsWithOptionsAsync(ListMcpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcps",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询MCP列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpsResponse
        /// </returns>
        public ListMcpsResponse ListMcps(ListMcpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcpsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询MCP列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpsResponse
        /// </returns>
        public async Task<ListMcpsResponse> ListMcpsAsync(ListMcpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcpsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型供应商列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProvidersResponse
        /// </returns>
        public ListModelProvidersResponse ListModelProvidersWithOptions(ListModelProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProviders",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型供应商列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProvidersResponse
        /// </returns>
        public async Task<ListModelProvidersResponse> ListModelProvidersWithOptionsAsync(ListModelProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProviders",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型供应商列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProvidersResponse
        /// </returns>
        public ListModelProvidersResponse ListModelProviders(ListModelProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelProvidersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型供应商列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProvidersResponse
        /// </returns>
        public async Task<ListModelProvidersResponse> ListModelProvidersAsync(ListModelProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelProvidersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModelsWithOptions(ListModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                query["ProviderName"] = request.ProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModels",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsWithOptionsAsync(ListModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                query["ProviderName"] = request.ProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModels",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModels(ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>此API用于查询指定实例下的AI网关端点列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> 是必填参数，用来指定 AgentTeams 实例 ID。</description></item>
        /// <item><description>可选参数包括 <c>component</c>, <c>serviceName</c>, <c>networkType</c>, 和 <c>domainType</c>，用于进一步筛选返回的端点列表。</description></item>
        /// <item><description>不支持通过 <c>status</c> 参数进行筛选。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListServiceEndpointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceEndpointsResponse
        /// </returns>
        public ListServiceEndpointsResponse ListServiceEndpointsWithOptions(ListServiceEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Component))
            {
                query["Component"] = request.Component;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["Skip"] = request.Skip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceEndpoints",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>此API用于查询指定实例下的AI网关端点列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> 是必填参数，用来指定 AgentTeams 实例 ID。</description></item>
        /// <item><description>可选参数包括 <c>component</c>, <c>serviceName</c>, <c>networkType</c>, 和 <c>domainType</c>，用于进一步筛选返回的端点列表。</description></item>
        /// <item><description>不支持通过 <c>status</c> 参数进行筛选。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListServiceEndpointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceEndpointsResponse
        /// </returns>
        public async Task<ListServiceEndpointsResponse> ListServiceEndpointsWithOptionsAsync(ListServiceEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Component))
            {
                query["Component"] = request.Component;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["Skip"] = request.Skip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceEndpoints",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>此API用于查询指定实例下的AI网关端点列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> 是必填参数，用来指定 AgentTeams 实例 ID。</description></item>
        /// <item><description>可选参数包括 <c>component</c>, <c>serviceName</c>, <c>networkType</c>, 和 <c>domainType</c>，用于进一步筛选返回的端点列表。</description></item>
        /// <item><description>不支持通过 <c>status</c> 参数进行筛选。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListServiceEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceEndpointsResponse
        /// </returns>
        public ListServiceEndpointsResponse ListServiceEndpoints(ListServiceEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceEndpointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>此API用于查询指定实例下的AI网关端点列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> 是必填参数，用来指定 AgentTeams 实例 ID。</description></item>
        /// <item><description>可选参数包括 <c>component</c>, <c>serviceName</c>, <c>networkType</c>, 和 <c>domainType</c>，用于进一步筛选返回的端点列表。</description></item>
        /// <item><description>不支持通过 <c>status</c> 参数进行筛选。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListServiceEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceEndpointsResponse
        /// </returns>
        public async Task<ListServiceEndpointsResponse> ListServiceEndpointsAsync(ListServiceEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceEndpointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户侧APIG可用的SSL证书列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取与指定AgentTeams实例相关的SSL证书列表。</description></item>
        /// <item><description>可通过<c>certNameLike</c>和<c>domainName</c>参数进行模糊搜索或精确匹配证书名称及绑定域名。</description></item>
        /// <item><description>分页参数<c>pageNumber</c>和<c>pageSize</c>允许客户端控制返回结果的数量和页码，默认每页显示10条记录。</description></item>
        /// <item><description>成功响应将包含请求ID、是否成功标志、错误代码（如果有的话）、HTTP状态码、本次请求的最大结果数、下一页标记（如果有更多数据的话）、总证书数量以及具体的证书详情列表。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSslCertsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSslCertsResponse
        /// </returns>
        public ListSslCertsResponse ListSslCertsWithOptions(ListSslCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSslCerts",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSslCertsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户侧APIG可用的SSL证书列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取与指定AgentTeams实例相关的SSL证书列表。</description></item>
        /// <item><description>可通过<c>certNameLike</c>和<c>domainName</c>参数进行模糊搜索或精确匹配证书名称及绑定域名。</description></item>
        /// <item><description>分页参数<c>pageNumber</c>和<c>pageSize</c>允许客户端控制返回结果的数量和页码，默认每页显示10条记录。</description></item>
        /// <item><description>成功响应将包含请求ID、是否成功标志、错误代码（如果有的话）、HTTP状态码、本次请求的最大结果数、下一页标记（如果有更多数据的话）、总证书数量以及具体的证书详情列表。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSslCertsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSslCertsResponse
        /// </returns>
        public async Task<ListSslCertsResponse> ListSslCertsWithOptionsAsync(ListSslCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSslCerts",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSslCertsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户侧APIG可用的SSL证书列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取与指定AgentTeams实例相关的SSL证书列表。</description></item>
        /// <item><description>可通过<c>certNameLike</c>和<c>domainName</c>参数进行模糊搜索或精确匹配证书名称及绑定域名。</description></item>
        /// <item><description>分页参数<c>pageNumber</c>和<c>pageSize</c>允许客户端控制返回结果的数量和页码，默认每页显示10条记录。</description></item>
        /// <item><description>成功响应将包含请求ID、是否成功标志、错误代码（如果有的话）、HTTP状态码、本次请求的最大结果数、下一页标记（如果有更多数据的话）、总证书数量以及具体的证书详情列表。</description></item>
        /// </list>
        /// </description>
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
            return ListSslCertsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户侧APIG可用的SSL证书列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取与指定AgentTeams实例相关的SSL证书列表。</description></item>
        /// <item><description>可通过<c>certNameLike</c>和<c>domainName</c>参数进行模糊搜索或精确匹配证书名称及绑定域名。</description></item>
        /// <item><description>分页参数<c>pageNumber</c>和<c>pageSize</c>允许客户端控制返回结果的数量和页码，默认每页显示10条记录。</description></item>
        /// <item><description>成功响应将包含请求ID、是否成功标志、错误代码（如果有的话）、HTTP状态码、本次请求的最大结果数、下一页标记（如果有更多数据的话）、总证书数量以及具体的证书详情列表。</description></item>
        /// </list>
        /// </description>
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
            return await ListSslCertsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>团队详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamDetailsResponse
        /// </returns>
        public ListTeamDetailsResponse ListTeamDetailsWithOptions(ListTeamDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTeamDetails",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>团队详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamDetailsResponse
        /// </returns>
        public async Task<ListTeamDetailsResponse> ListTeamDetailsWithOptionsAsync(ListTeamDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTeamDetails",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>团队详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamDetailsResponse
        /// </returns>
        public ListTeamDetailsResponse ListTeamDetails(ListTeamDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTeamDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>团队详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamDetailsResponse
        /// </returns>
        public async Task<ListTeamDetailsResponse> ListTeamDetailsAsync(ListTeamDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTeamDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Team任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamTasksResponse
        /// </returns>
        public ListTeamTasksResponse ListTeamTasksWithOptions(ListTeamTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Team))
            {
                query["Team"] = request.Team;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTeamTasks",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Team任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamTasksResponse
        /// </returns>
        public async Task<ListTeamTasksResponse> ListTeamTasksWithOptionsAsync(ListTeamTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Team))
            {
                query["Team"] = request.Team;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTeamTasks",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Team任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamTasksResponse
        /// </returns>
        public ListTeamTasksResponse ListTeamTasks(ListTeamTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTeamTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Team任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamTasksResponse
        /// </returns>
        public async Task<ListTeamTasksResponse> ListTeamTasksAsync(ListTeamTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTeamTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamsResponse
        /// </returns>
        public ListTeamsResponse ListTeamsWithOptions(ListTeamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["NameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTeams",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamsResponse
        /// </returns>
        public async Task<ListTeamsResponse> ListTeamsWithOptionsAsync(ListTeamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["NameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTeams",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamsResponse
        /// </returns>
        public ListTeamsResponse ListTeams(ListTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTeamsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamsResponse
        /// </returns>
        public async Task<ListTeamsResponse> ListTeamsAsync(ListTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTeamsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["NameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["NameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Worker统计详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkerStatsDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkerStatsDetailsResponse
        /// </returns>
        public ListWorkerStatsDetailsResponse ListWorkerStatsDetailsWithOptions(ListWorkerStatsDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkerStatsDetails",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkerStatsDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Worker统计详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkerStatsDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkerStatsDetailsResponse
        /// </returns>
        public async Task<ListWorkerStatsDetailsResponse> ListWorkerStatsDetailsWithOptionsAsync(ListWorkerStatsDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkerStatsDetails",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkerStatsDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Worker统计详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkerStatsDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkerStatsDetailsResponse
        /// </returns>
        public ListWorkerStatsDetailsResponse ListWorkerStatsDetails(ListWorkerStatsDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkerStatsDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Worker统计详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkerStatsDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkerStatsDetailsResponse
        /// </returns>
        public async Task<ListWorkerStatsDetailsResponse> ListWorkerStatsDetailsAsync(ListWorkerStatsDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkerStatsDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWorkersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkersResponse
        /// </returns>
        public ListWorkersResponse ListWorkersWithOptions(ListWorkersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkersShrinkRequest request = new ListWorkersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Group))
            {
                request.GroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Group, "Group", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                query["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupShrink))
            {
                query["Group"] = request.GroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mcp))
            {
                query["Mcp"] = request.Mcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelProvider))
            {
                query["ModelProvider"] = request.ModelProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["NameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionCode))
            {
                query["VersionCode"] = request.VersionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkers",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWorkersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkersResponse
        /// </returns>
        public async Task<ListWorkersResponse> ListWorkersWithOptionsAsync(ListWorkersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkersShrinkRequest request = new ListWorkersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Group))
            {
                request.GroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Group, "Group", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                query["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupShrink))
            {
                query["Group"] = request.GroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mcp))
            {
                query["Mcp"] = request.Mcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelProvider))
            {
                query["ModelProvider"] = request.ModelProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["NameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionCode))
            {
                query["VersionCode"] = request.VersionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkers",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkersResponse
        /// </returns>
        public ListWorkersResponse ListWorkers(ListWorkersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Worker列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkersResponse
        /// </returns>
        public async Task<ListWorkersResponse> ListWorkersAsync(ListWorkersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新CMS工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutCmsWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutCmsWorkspaceResponse
        /// </returns>
        public PutCmsWorkspaceResponse PutCmsWorkspaceWithOptions(PutCmsWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCmsWorkspace",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCmsWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新CMS工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutCmsWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutCmsWorkspaceResponse
        /// </returns>
        public async Task<PutCmsWorkspaceResponse> PutCmsWorkspaceWithOptionsAsync(PutCmsWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCmsWorkspace",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCmsWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新CMS工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutCmsWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PutCmsWorkspaceResponse
        /// </returns>
        public PutCmsWorkspaceResponse PutCmsWorkspace(PutCmsWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCmsWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新CMS工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutCmsWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PutCmsWorkspaceResponse
        /// </returns>
        public async Task<PutCmsWorkspaceResponse> PutCmsWorkspaceAsync(PutCmsWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCmsWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定实例、worker、团队或个人的功能特性状态。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询特定<c>instanceId</c>下的不同目标（如<c>INSTANCE</c>、<c>WORKER</c>、<c>TEAM</c>、<c>HUMAN</c>）的功能特性状态。</description></item>
        /// <item><description><c>targetScope</c>参数定义了查询的目标类型，根据不同的<c>targetScope</c>值，可能需要提供额外的<c>resourceName</c>参数来指定具体的资源名称。</description></item>
        /// <item><description>如果提供了<c>featureCodes</c>列表，则返回这些特定功能特性的状态；否则，将返回指定<c>targetScope</c>下所有功能特性的状态。</description></item>
        /// <item><description>当使用<c>WORKER</c>、<c>TEAM</c>或<c>HUMAN</c>作为<c>targetScope</c>时，请确保正确填写对应的<c>resourceName</c>。</description></item>
        /// <item><description>对于<c>INSTANCE</c>级别的查询，无需提供<c>resourceName</c>。</description></item>
        /// <item><description>特性支持情况受基础版本、工作器版本等因素影响，并通过<c>unsupportedReasonCode</c>和<c>unsupportedReason</c>字段给出不支持的具体原因。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryFeaturesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFeaturesResponse
        /// </returns>
        public QueryFeaturesResponse QueryFeaturesWithOptions(QueryFeaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetScope))
            {
                query["TargetScope"] = request.TargetScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFeatures",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFeaturesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定实例、worker、团队或个人的功能特性状态。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询特定<c>instanceId</c>下的不同目标（如<c>INSTANCE</c>、<c>WORKER</c>、<c>TEAM</c>、<c>HUMAN</c>）的功能特性状态。</description></item>
        /// <item><description><c>targetScope</c>参数定义了查询的目标类型，根据不同的<c>targetScope</c>值，可能需要提供额外的<c>resourceName</c>参数来指定具体的资源名称。</description></item>
        /// <item><description>如果提供了<c>featureCodes</c>列表，则返回这些特定功能特性的状态；否则，将返回指定<c>targetScope</c>下所有功能特性的状态。</description></item>
        /// <item><description>当使用<c>WORKER</c>、<c>TEAM</c>或<c>HUMAN</c>作为<c>targetScope</c>时，请确保正确填写对应的<c>resourceName</c>。</description></item>
        /// <item><description>对于<c>INSTANCE</c>级别的查询，无需提供<c>resourceName</c>。</description></item>
        /// <item><description>特性支持情况受基础版本、工作器版本等因素影响，并通过<c>unsupportedReasonCode</c>和<c>unsupportedReason</c>字段给出不支持的具体原因。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryFeaturesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFeaturesResponse
        /// </returns>
        public async Task<QueryFeaturesResponse> QueryFeaturesWithOptionsAsync(QueryFeaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetScope))
            {
                query["TargetScope"] = request.TargetScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFeatures",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFeaturesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定实例、worker、团队或个人的功能特性状态。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询特定<c>instanceId</c>下的不同目标（如<c>INSTANCE</c>、<c>WORKER</c>、<c>TEAM</c>、<c>HUMAN</c>）的功能特性状态。</description></item>
        /// <item><description><c>targetScope</c>参数定义了查询的目标类型，根据不同的<c>targetScope</c>值，可能需要提供额外的<c>resourceName</c>参数来指定具体的资源名称。</description></item>
        /// <item><description>如果提供了<c>featureCodes</c>列表，则返回这些特定功能特性的状态；否则，将返回指定<c>targetScope</c>下所有功能特性的状态。</description></item>
        /// <item><description>当使用<c>WORKER</c>、<c>TEAM</c>或<c>HUMAN</c>作为<c>targetScope</c>时，请确保正确填写对应的<c>resourceName</c>。</description></item>
        /// <item><description>对于<c>INSTANCE</c>级别的查询，无需提供<c>resourceName</c>。</description></item>
        /// <item><description>特性支持情况受基础版本、工作器版本等因素影响，并通过<c>unsupportedReasonCode</c>和<c>unsupportedReason</c>字段给出不支持的具体原因。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryFeaturesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFeaturesResponse
        /// </returns>
        public QueryFeaturesResponse QueryFeatures(QueryFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFeaturesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定实例、worker、团队或个人的功能特性状态。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询特定<c>instanceId</c>下的不同目标（如<c>INSTANCE</c>、<c>WORKER</c>、<c>TEAM</c>、<c>HUMAN</c>）的功能特性状态。</description></item>
        /// <item><description><c>targetScope</c>参数定义了查询的目标类型，根据不同的<c>targetScope</c>值，可能需要提供额外的<c>resourceName</c>参数来指定具体的资源名称。</description></item>
        /// <item><description>如果提供了<c>featureCodes</c>列表，则返回这些特定功能特性的状态；否则，将返回指定<c>targetScope</c>下所有功能特性的状态。</description></item>
        /// <item><description>当使用<c>WORKER</c>、<c>TEAM</c>或<c>HUMAN</c>作为<c>targetScope</c>时，请确保正确填写对应的<c>resourceName</c>。</description></item>
        /// <item><description>对于<c>INSTANCE</c>级别的查询，无需提供<c>resourceName</c>。</description></item>
        /// <item><description>特性支持情况受基础版本、工作器版本等因素影响，并通过<c>unsupportedReasonCode</c>和<c>unsupportedReason</c>字段给出不支持的具体原因。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryFeaturesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFeaturesResponse
        /// </returns>
        public async Task<QueryFeaturesResponse> QueryFeaturesAsync(QueryFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFeaturesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前AgentTeams Resource Pool配置支持的所有可用区ID。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySupportedZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySupportedZonesResponse
        /// </returns>
        public QuerySupportedZonesResponse QuerySupportedZonesWithOptions(QuerySupportedZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySupportedZones",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySupportedZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前AgentTeams Resource Pool配置支持的所有可用区ID。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySupportedZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySupportedZonesResponse
        /// </returns>
        public async Task<QuerySupportedZonesResponse> QuerySupportedZonesWithOptionsAsync(QuerySupportedZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySupportedZones",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySupportedZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前AgentTeams Resource Pool配置支持的所有可用区ID。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySupportedZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySupportedZonesResponse
        /// </returns>
        public QuerySupportedZonesResponse QuerySupportedZones(QuerySupportedZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySupportedZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前AgentTeams Resource Pool配置支持的所有可用区ID。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySupportedZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySupportedZonesResponse
        /// </returns>
        public async Task<QuerySupportedZonesResponse> QuerySupportedZonesAsync(QuerySupportedZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySupportedZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public ResetUserPasswordResponse ResetUserPasswordWithOptions(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserPassword",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public async Task<ResetUserPasswordResponse> ResetUserPasswordWithOptionsAsync(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserPassword",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetUserPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetUserPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试模型供应商和模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestModelProviderResponse
        /// </returns>
        public TestModelProviderResponse TestModelProviderWithOptions(TestModelProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                body["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                body["ProviderName"] = request.ProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestModelProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试模型供应商和模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestModelProviderResponse
        /// </returns>
        public async Task<TestModelProviderResponse> TestModelProviderWithOptionsAsync(TestModelProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                body["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                body["ProviderName"] = request.ProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestModelProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试模型供应商和模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// TestModelProviderResponse
        /// </returns>
        public TestModelProviderResponse TestModelProvider(TestModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestModelProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试模型供应商和模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// TestModelProviderResponse
        /// </returns>
        public async Task<TestModelProviderResponse> TestModelProviderAsync(TestModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestModelProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑上游身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindIdentityProviderResponse
        /// </returns>
        public UnbindIdentityProviderResponse UnbindIdentityProviderWithOptions(UnbindIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                query["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindIdentityProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑上游身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindIdentityProviderResponse
        /// </returns>
        public async Task<UnbindIdentityProviderResponse> UnbindIdentityProviderWithOptionsAsync(UnbindIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                query["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindIdentityProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑上游身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindIdentityProviderResponse
        /// </returns>
        public UnbindIdentityProviderResponse UnbindIdentityProvider(UnbindIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑上游身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindIdentityProviderResponse
        /// </returns>
        public async Task<UnbindIdentityProviderResponse> UnbindIdentityProviderAsync(UnbindIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证密钥</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于更新 AgentTeams 实例下已有 Credential 的密钥明文。</description></item>
        /// <item><description>仅更新 Agent Identity TokenVault 中同名 APIKeyCredentialProvider 的密钥值，不修改本地元数据（description、createTime、updateTime、status）。</description></item>
        /// <item><description>响应不包含 apiKey 明文；如需绑定 Worker 明细请调用 GetCredential。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public UpdateCredentialResponse UpdateCredentialWithOptions(UpdateCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredential",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证密钥</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于更新 AgentTeams 实例下已有 Credential 的密钥明文。</description></item>
        /// <item><description>仅更新 Agent Identity TokenVault 中同名 APIKeyCredentialProvider 的密钥值，不修改本地元数据（description、createTime、updateTime、status）。</description></item>
        /// <item><description>响应不包含 apiKey 明文；如需绑定 Worker 明细请调用 GetCredential。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public async Task<UpdateCredentialResponse> UpdateCredentialWithOptionsAsync(UpdateCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredential",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证密钥</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于更新 AgentTeams 实例下已有 Credential 的密钥明文。</description></item>
        /// <item><description>仅更新 Agent Identity TokenVault 中同名 APIKeyCredentialProvider 的密钥值，不修改本地元数据（description、createTime、updateTime、status）。</description></item>
        /// <item><description>响应不包含 apiKey 明文；如需绑定 Worker 明细请调用 GetCredential。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public UpdateCredentialResponse UpdateCredential(UpdateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证密钥</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于更新 AgentTeams 实例下已有 Credential 的密钥明文。</description></item>
        /// <item><description>仅更新 Agent Identity TokenVault 中同名 APIKeyCredentialProvider 的密钥值，不修改本地元数据（description、createTime、updateTime、status）。</description></item>
        /// <item><description>响应不包含 apiKey 明文；如需绑定 Worker 明细请调用 GetCredential。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public async Task<UpdateCredentialResponse> UpdateCredentialAsync(UpdateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新上游身份提供商绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public UpdateIdentityProviderResponse UpdateIdentityProviderWithOptions(UpdateIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                query["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpMetadata))
            {
                query["IdpMetadata"] = request.IdpMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEnabled))
            {
                query["LoginEnabled"] = request.LoginEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncEnabled))
            {
                query["SyncEnabled"] = request.SyncEnabled;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdentityProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新上游身份提供商绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public async Task<UpdateIdentityProviderResponse> UpdateIdentityProviderWithOptionsAsync(UpdateIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                query["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpMetadata))
            {
                query["IdpMetadata"] = request.IdpMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEnabled))
            {
                query["LoginEnabled"] = request.LoginEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncEnabled))
            {
                query["SyncEnabled"] = request.SyncEnabled;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdentityProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新上游身份提供商绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新上游身份提供商绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public async Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定AgentTeams实例的名称，支持通过GET或POST方法调用。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>推荐使用<c>POST</c>方法，并以表单形式提交参数。</description></item>
        /// <item><description>当前实现不支持JSON格式的请求体，请勿尝试使用<c>@RequestBody</c>方式调用。</description></item>
        /// <item><description>必须提供有效的<c>instanceId</c>和非空的<c>instanceName</c>作为参数。</description></item>
        /// <item><description>该接口仅允许修改实例名称(<c>instanceName</c>)，不允许通过此接口变更命名空间(<c>namespace</c>)。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstanceWithOptions(UpdateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateInstanceShrinkRequest request = new UpdateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Zones))
            {
                request.ZonesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Zones, "Zones", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZonesShrink))
            {
                query["Zones"] = request.ZonesShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定AgentTeams实例的名称，支持通过GET或POST方法调用。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>推荐使用<c>POST</c>方法，并以表单形式提交参数。</description></item>
        /// <item><description>当前实现不支持JSON格式的请求体，请勿尝试使用<c>@RequestBody</c>方式调用。</description></item>
        /// <item><description>必须提供有效的<c>instanceId</c>和非空的<c>instanceName</c>作为参数。</description></item>
        /// <item><description>该接口仅允许修改实例名称(<c>instanceName</c>)，不允许通过此接口变更命名空间(<c>namespace</c>)。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(UpdateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateInstanceShrinkRequest request = new UpdateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Zones))
            {
                request.ZonesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Zones, "Zones", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZonesShrink))
            {
                query["Zones"] = request.ZonesShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定AgentTeams实例的名称，支持通过GET或POST方法调用。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>推荐使用<c>POST</c>方法，并以表单形式提交参数。</description></item>
        /// <item><description>当前实现不支持JSON格式的请求体，请勿尝试使用<c>@RequestBody</c>方式调用。</description></item>
        /// <item><description>必须提供有效的<c>instanceId</c>和非空的<c>instanceName</c>作为参数。</description></item>
        /// <item><description>该接口仅允许修改实例名称(<c>instanceName</c>)，不允许通过此接口变更命名空间(<c>namespace</c>)。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定AgentTeams实例的名称，支持通过GET或POST方法调用。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>推荐使用<c>POST</c>方法，并以表单形式提交参数。</description></item>
        /// <item><description>当前实现不支持JSON格式的请求体，请勿尝试使用<c>@RequestBody</c>方式调用。</description></item>
        /// <item><description>必须提供有效的<c>instanceId</c>和非空的<c>instanceName</c>作为参数。</description></item>
        /// <item><description>该接口仅允许修改实例名称(<c>instanceName</c>)，不允许通过此接口变更命名空间(<c>namespace</c>)。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启暂停中的创建实例异步任务。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于重新启动一个处于暂停状态的创建实例任务。</description></item>
        /// <item><description>目前仅支持 <c>agentteams:pay-order:create</c> 类型的任务。</description></item>
        /// <item><description>确保提供的 <c>instanceId</c>、<c>taskCode</c> 和 <c>taskId</c> 参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果任务不是暂停状态（PAUSED），则不允许调用此接口进行更新。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAsyncTaskResponse
        /// </returns>
        public UpdateInstanceAsyncTaskResponse UpdateInstanceAsyncTaskWithOptions(UpdateInstanceAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResume))
            {
                query["IsResume"] = request.IsResume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCode))
            {
                query["TaskCode"] = request.TaskCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceAsyncTask",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启暂停中的创建实例异步任务。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于重新启动一个处于暂停状态的创建实例任务。</description></item>
        /// <item><description>目前仅支持 <c>agentteams:pay-order:create</c> 类型的任务。</description></item>
        /// <item><description>确保提供的 <c>instanceId</c>、<c>taskCode</c> 和 <c>taskId</c> 参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果任务不是暂停状态（PAUSED），则不允许调用此接口进行更新。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAsyncTaskResponse
        /// </returns>
        public async Task<UpdateInstanceAsyncTaskResponse> UpdateInstanceAsyncTaskWithOptionsAsync(UpdateInstanceAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResume))
            {
                query["IsResume"] = request.IsResume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCode))
            {
                query["TaskCode"] = request.TaskCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceAsyncTask",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启暂停中的创建实例异步任务。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于重新启动一个处于暂停状态的创建实例任务。</description></item>
        /// <item><description>目前仅支持 <c>agentteams:pay-order:create</c> 类型的任务。</description></item>
        /// <item><description>确保提供的 <c>instanceId</c>、<c>taskCode</c> 和 <c>taskId</c> 参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果任务不是暂停状态（PAUSED），则不允许调用此接口进行更新。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAsyncTaskResponse
        /// </returns>
        public UpdateInstanceAsyncTaskResponse UpdateInstanceAsyncTask(UpdateInstanceAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceAsyncTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启暂停中的创建实例异步任务。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于重新启动一个处于暂停状态的创建实例任务。</description></item>
        /// <item><description>目前仅支持 <c>agentteams:pay-order:create</c> 类型的任务。</description></item>
        /// <item><description>确保提供的 <c>instanceId</c>、<c>taskCode</c> 和 <c>taskId</c> 参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果任务不是暂停状态（PAUSED），则不允许调用此接口进行更新。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAsyncTaskResponse
        /// </returns>
        public async Task<UpdateInstanceAsyncTaskResponse> UpdateInstanceAsyncTaskAsync(UpdateInstanceAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceAsyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateMcpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpResponse
        /// </returns>
        public UpdateMcpResponse UpdateMcpWithOptions(UpdateMcpRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMcpShrinkRequest request = new UpdateMcpShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Addresses))
            {
                request.AddressesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Addresses, "Addresses", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressesShrink))
            {
                body["Addresses"] = request.AddressesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                body["AuthConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthEnabled))
            {
                body["AuthEnabled"] = request.AuthEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateType))
            {
                body["CreateType"] = request.CreateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwaggerConfig))
            {
                body["SwaggerConfig"] = request.SwaggerConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcp",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateMcpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpResponse
        /// </returns>
        public async Task<UpdateMcpResponse> UpdateMcpWithOptionsAsync(UpdateMcpRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMcpShrinkRequest request = new UpdateMcpShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Addresses))
            {
                request.AddressesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Addresses, "Addresses", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressesShrink))
            {
                body["Addresses"] = request.AddressesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                body["AuthConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthEnabled))
            {
                body["AuthEnabled"] = request.AuthEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateType))
            {
                body["CreateType"] = request.CreateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwaggerConfig))
            {
                body["SwaggerConfig"] = request.SwaggerConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcp",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpResponse
        /// </returns>
        public UpdateMcpResponse UpdateMcp(UpdateMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMcpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新MCP</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpResponse
        /// </returns>
        public async Task<UpdateMcpResponse> UpdateMcpAsync(UpdateMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMcpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public UpdateModelResponse UpdateModelWithOptions(UpdateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModel",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public async Task<UpdateModelResponse> UpdateModelWithOptionsAsync(UpdateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModel",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public async Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模型供应商</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProviderResponse
        /// </returns>
        public UpdateModelProviderResponse UpdateModelProviderWithOptions(UpdateModelProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateModelProviderShrinkRequest request = new UpdateModelProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiKeys))
            {
                request.ApiKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiKeys, "ApiKeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Protocols))
            {
                request.ProtocolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Protocols, "Protocols", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeysShrink))
            {
                body["ApiKeys"] = request.ApiKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolsShrink))
            {
                body["Protocols"] = request.ProtocolsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模型供应商</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateModelProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProviderResponse
        /// </returns>
        public async Task<UpdateModelProviderResponse> UpdateModelProviderWithOptionsAsync(UpdateModelProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateModelProviderShrinkRequest request = new UpdateModelProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiKeys))
            {
                request.ApiKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiKeys, "ApiKeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Protocols))
            {
                request.ProtocolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Protocols, "Protocols", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeysShrink))
            {
                body["ApiKeys"] = request.ApiKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolsShrink))
            {
                body["Protocols"] = request.ProtocolsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelProvider",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模型供应商</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProviderResponse
        /// </returns>
        public UpdateModelProviderResponse UpdateModelProvider(UpdateModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateModelProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模型供应商</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询当前登录用户所拥有的所有AgentTeams实例。</description></item>
        /// <item><description>用户身份通过请求头<c>X-User-Id</c>传递，服务端会根据此ID自动过滤只返回属于该用户的实例数据。</description></item>
        /// <item><description>支持使用<c>instanceName</c>进行模糊匹配以及通过<c>status</c>参数精确匹配实例状态来过滤查询结果。</description></item>
        /// <item><description>默认情况下，结果将按照创建时间倒序排列，并且可以通过设置<c>limit</c>和<c>offset</c>参数来进行分页控制，默认每页显示20条记录。</description></item>
        /// <item><description>如果请求中缺少<c>X-User-Id</c>或者其值为空，则会返回400错误；如果指定的实例不存在或不属于当前用户，则返回404错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProviderResponse
        /// </returns>
        public async Task<UpdateModelProviderResponse> UpdateModelProviderAsync(UpdateModelProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateModelProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新指定Endpoint的域名和SSL证书信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本API支持更新<c>ELEMENT</c>、<c>MATRIX</c>类型的Endpoint。</description></item>
        /// <item><description>如果尝试更新其他类型的Endpoint，将返回400错误。</description></item>
        /// <item><description>当<c>endpointId</c>不存在或不属于当前用户实例时，将返回404错误。</description></item>
        /// <item><description>更新域名时，系统会创建或复用新的HTTPS domain，并将其绑定到原endpoint route上，同时解绑旧domain，但不会删除旧domain。</description></item>
        /// <item><description>若不提供<c>domain</c>或<c>certIdentifier</c>参数，则保持原有设置不变。</description></item>
        /// <item><description>其他如<c>component</c>、<c>gatewayType</c>等字段即使传入也不会被更新。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServiceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceEndpointResponse
        /// </returns>
        public UpdateServiceEndpointResponse UpdateServiceEndpointWithOptions(UpdateServiceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceEndpoint",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新指定Endpoint的域名和SSL证书信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本API支持更新<c>ELEMENT</c>、<c>MATRIX</c>类型的Endpoint。</description></item>
        /// <item><description>如果尝试更新其他类型的Endpoint，将返回400错误。</description></item>
        /// <item><description>当<c>endpointId</c>不存在或不属于当前用户实例时，将返回404错误。</description></item>
        /// <item><description>更新域名时，系统会创建或复用新的HTTPS domain，并将其绑定到原endpoint route上，同时解绑旧domain，但不会删除旧domain。</description></item>
        /// <item><description>若不提供<c>domain</c>或<c>certIdentifier</c>参数，则保持原有设置不变。</description></item>
        /// <item><description>其他如<c>component</c>、<c>gatewayType</c>等字段即使传入也不会被更新。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServiceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceEndpointResponse
        /// </returns>
        public async Task<UpdateServiceEndpointResponse> UpdateServiceEndpointWithOptionsAsync(UpdateServiceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceEndpoint",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新指定Endpoint的域名和SSL证书信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本API支持更新<c>ELEMENT</c>、<c>MATRIX</c>类型的Endpoint。</description></item>
        /// <item><description>如果尝试更新其他类型的Endpoint，将返回400错误。</description></item>
        /// <item><description>当<c>endpointId</c>不存在或不属于当前用户实例时，将返回404错误。</description></item>
        /// <item><description>更新域名时，系统会创建或复用新的HTTPS domain，并将其绑定到原endpoint route上，同时解绑旧domain，但不会删除旧domain。</description></item>
        /// <item><description>若不提供<c>domain</c>或<c>certIdentifier</c>参数，则保持原有设置不变。</description></item>
        /// <item><description>其他如<c>component</c>、<c>gatewayType</c>等字段即使传入也不会被更新。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceEndpointResponse
        /// </returns>
        public UpdateServiceEndpointResponse UpdateServiceEndpoint(UpdateServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新指定Endpoint的域名和SSL证书信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本API支持更新<c>ELEMENT</c>、<c>MATRIX</c>类型的Endpoint。</description></item>
        /// <item><description>如果尝试更新其他类型的Endpoint，将返回400错误。</description></item>
        /// <item><description>当<c>endpointId</c>不存在或不属于当前用户实例时，将返回404错误。</description></item>
        /// <item><description>更新域名时，系统会创建或复用新的HTTPS domain，并将其绑定到原endpoint route上，同时解绑旧domain，但不会删除旧domain。</description></item>
        /// <item><description>若不提供<c>domain</c>或<c>certIdentifier</c>参数，则保持原有设置不变。</description></item>
        /// <item><description>其他如<c>component</c>、<c>gatewayType</c>等字段即使传入也不会被更新。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceEndpointResponse
        /// </returns>
        public async Task<UpdateServiceEndpointResponse> UpdateServiceEndpointAsync(UpdateServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新团队</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTeamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public UpdateTeamResponse UpdateTeamWithOptions(UpdateTeamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTeamShrinkRequest request = new UpdateTeamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TeamMembers))
            {
                request.TeamMembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TeamMembers, "TeamMembers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamMembersShrink))
            {
                query["TeamMembers"] = request.TeamMembersShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTeam",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTeamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新团队</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTeamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public async Task<UpdateTeamResponse> UpdateTeamWithOptionsAsync(UpdateTeamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTeamShrinkRequest request = new UpdateTeamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TeamMembers))
            {
                request.TeamMembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TeamMembers, "TeamMembers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamMembersShrink))
            {
                query["TeamMembers"] = request.TeamMembersShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTeam",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTeamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public UpdateTeamResponse UpdateTeam(UpdateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTeamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public async Task<UpdateTeamResponse> UpdateTeamAsync(UpdateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTeamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMethod))
            {
                query["AuthMethod"] = request.AuthMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMethod))
            {
                query["AuthMethod"] = request.AuthMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Worker</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWorkerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkerResponse
        /// </returns>
        public UpdateWorkerResponse UpdateWorkerWithOptions(UpdateWorkerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkerShrinkRequest request = new UpdateWorkerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Channels))
            {
                request.ChannelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Channels, "Channels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Credentials))
            {
                request.CredentialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Credentials, "Credentials", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LimitConfig))
            {
                request.LimitConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LimitConfig, "LimitConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.McpServers))
            {
                request.McpServersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.McpServers, "McpServers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Model))
            {
                request.ModelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Model, "Model", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Skills))
            {
                request.SkillsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Skills, "Skills", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Agents))
            {
                query["Agents"] = request.Agents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelsShrink))
            {
                query["Channels"] = request.ChannelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialsShrink))
            {
                query["Credentials"] = request.CredentialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitConfigShrink))
            {
                query["LimitConfig"] = request.LimitConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServersShrink))
            {
                query["McpServers"] = request.McpServersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelShrink))
            {
                query["Model"] = request.ModelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillsShrink))
            {
                query["Skills"] = request.SkillsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Soul))
            {
                query["Soul"] = request.Soul;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionCode))
            {
                query["VersionCode"] = request.VersionCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorker",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Worker</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWorkerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkerResponse
        /// </returns>
        public async Task<UpdateWorkerResponse> UpdateWorkerWithOptionsAsync(UpdateWorkerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkerShrinkRequest request = new UpdateWorkerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Channels))
            {
                request.ChannelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Channels, "Channels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Credentials))
            {
                request.CredentialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Credentials, "Credentials", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LimitConfig))
            {
                request.LimitConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LimitConfig, "LimitConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.McpServers))
            {
                request.McpServersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.McpServers, "McpServers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Model))
            {
                request.ModelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Model, "Model", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Skills))
            {
                request.SkillsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Skills, "Skills", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Agents))
            {
                query["Agents"] = request.Agents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelsShrink))
            {
                query["Channels"] = request.ChannelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialsShrink))
            {
                query["Credentials"] = request.CredentialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitConfigShrink))
            {
                query["LimitConfig"] = request.LimitConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServersShrink))
            {
                query["McpServers"] = request.McpServersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelShrink))
            {
                query["Model"] = request.ModelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillsShrink))
            {
                query["Skills"] = request.SkillsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Soul))
            {
                query["Soul"] = request.Soul;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionCode))
            {
                query["VersionCode"] = request.VersionCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorker",
                Version = "2026-06-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Worker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkerResponse
        /// </returns>
        public UpdateWorkerResponse UpdateWorker(UpdateWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Worker</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkerResponse
        /// </returns>
        public async Task<UpdateWorkerResponse> UpdateWorkerAsync(UpdateWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkerWithOptionsAsync(request, runtime);
        }

    }
}
